using System.Data;
using System.Data.Common;
using System;
using AdoNetProfiler;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;

namespace AdoNetProfiler.IntelliTests
{
    /// <summary>このクラスには、AdoNetProfilerDbTransaction に対するパラメーター化された単体テストが含まれています</summary>
    [PexClass(typeof(AdoNetProfilerDbTransaction))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AdoNetProfilerDbTransactionTest
    {

        /// <summary>.ctor(DbTransaction, DbConnection, IAdoNetProfiler) のテスト スタブ </summary>
        [PexMethod]
        internal AdoNetProfilerDbTransaction ConstructorTest(
            DbTransaction transaction,
            DbConnection connection,
            IAdoNetProfiler profiler
        )
        {
            AdoNetProfilerDbTransaction target
               = new AdoNetProfilerDbTransaction(transaction, connection, profiler);
            return target;
            // TODO: アサーションを メソッド AdoNetProfilerDbTransactionTest.ConstructorTest(DbTransaction, DbConnection, IAdoNetProfiler) に追加します
        }

        /// <summary>Commit() のテスト スタブ </summary>
        [PexMethod]
        internal void CommitTest([PexAssumeUnderTest]AdoNetProfilerDbTransaction target)
        {
            target.Commit();
            // TODO: アサーションを メソッド AdoNetProfilerDbTransactionTest.CommitTest(AdoNetProfilerDbTransaction) に追加します
        }

        /// <summary>Rollback() のテスト スタブ </summary>
        [PexMethod]
        internal void RollbackTest([PexAssumeUnderTest]AdoNetProfilerDbTransaction target)
        {
            target.Rollback();
            // TODO: アサーションを メソッド AdoNetProfilerDbTransactionTest.RollbackTest(AdoNetProfilerDbTransaction) に追加します
        }

        /// <summary>get_IsolationLevel() のテスト スタブ </summary>
        [PexMethod]
        internal IsolationLevel IsolationLevelGetTest([PexAssumeUnderTest]AdoNetProfilerDbTransaction target)
        {
            IsolationLevel result = target.IsolationLevel;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbTransactionTest.IsolationLevelGetTest(AdoNetProfilerDbTransaction) に追加します
        }

        /// <summary>get_WrappedTransaction() のテスト スタブ </summary>
        [PexMethod]
        internal DbTransaction WrappedTransactionGetTest([PexAssumeUnderTest]AdoNetProfilerDbTransaction target)
        {
            DbTransaction result = target.WrappedTransaction;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbTransactionTest.WrappedTransactionGetTest(AdoNetProfilerDbTransaction) に追加します
        }
    }
}
