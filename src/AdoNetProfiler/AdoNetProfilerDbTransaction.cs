﻿using System;
using System.Data;
using System.Data.Common;

namespace AdoNetProfiler
{
    internal class AdoNetProfilerDbTransaction : DbTransaction
    {
        private DbConnection _connection;
        private DbTransaction _transaction;
        private readonly IAdoNetProfiler _profiler;

        protected override DbConnection DbConnection => _connection;

        public override IsolationLevel IsolationLevel => _transaction.IsolationLevel;

        public DbTransaction WrappedTransaction => _transaction;

        internal AdoNetProfilerDbTransaction(DbTransaction transaction, DbConnection connection, IAdoNetProfiler profiler)
        {
            if (transaction == null)
            {
                throw new ArgumentNullException(nameof(transaction));
            }

            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }

            _transaction = transaction;
            _connection  = connection;
            _profiler    = profiler;
        }

        public override void Commit()
        {
            if (_profiler == null || !_profiler.IsEnabled)
            {
                _transaction.Commit();
                _transaction.Dispose();
                _transaction = null;
                return;
            }
            
            _profiler.OnCommitting(this);

            _transaction.Commit();
            _transaction.Dispose();
            _transaction = null;

            _profiler.OnCommitted(_connection);
        }

        public override void Rollback()
        {
            if (_profiler == null || !_profiler.IsEnabled)
            {
                _transaction.Rollback();
                _transaction.Dispose();
                _transaction = null;
                return;
            }
            
            _profiler.OnRollbacking(this);

            _transaction.Rollback();
            _transaction.Dispose();
            _transaction = null;

            _profiler.OnRollbacked(_connection);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_transaction != null)
                {
                    Rollback();
                }
            }

            _transaction = null;
            _connection  = null;

            base.Dispose(disposing);
        }
    }
}