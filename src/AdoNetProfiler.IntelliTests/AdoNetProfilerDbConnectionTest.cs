using System.Data;
using System.Data.Common;
using System;
using AdoNetProfiler;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;

namespace AdoNetProfiler.IntelliTests
{
    /// <summary>このクラスには、AdoNetProfilerDbConnection に対するパラメーター化された単体テストが含まれています</summary>
    [PexClass(typeof(AdoNetProfilerDbConnection))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AdoNetProfilerDbConnectionTest
    {

        /// <summary>.ctor(DbConnection) のテスト スタブ </summary>
        [PexMethod]
        public AdoNetProfilerDbConnection ConstructorTest(DbConnection connection)
        {
            AdoNetProfilerDbConnection target = new AdoNetProfilerDbConnection(connection);
            return target;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.ConstructorTest(DbConnection) に追加します
        }

        /// <summary>.ctor(DbConnection, IAdoNetProfiler) のテスト スタブ </summary>
        [PexMethod]
        public AdoNetProfilerDbConnection ConstructorTest01(DbConnection connection, IAdoNetProfiler profiler)
        {
            AdoNetProfilerDbConnection target = new AdoNetProfilerDbConnection(connection, profiler);
            return target;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.ConstructorTest01(DbConnection, IAdoNetProfiler) に追加します
        }

        /// <summary>ChangeDatabase(String) のテスト スタブ </summary>
        [PexMethod]
        public void ChangeDatabaseTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target, string databaseName)
        {
            target.ChangeDatabase(databaseName);
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.ChangeDatabaseTest(AdoNetProfilerDbConnection, String) に追加します
        }

        /// <summary>Close() のテスト スタブ </summary>
        [PexMethod]
        public void CloseTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target)
        {
            target.Close();
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.CloseTest(AdoNetProfilerDbConnection) に追加します
        }

        /// <summary>GetSchema() のテスト スタブ </summary>
        [PexMethod]
        public DataTable GetSchemaTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target)
        {
            DataTable result = target.GetSchema();
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.GetSchemaTest(AdoNetProfilerDbConnection) に追加します
        }

        /// <summary>GetSchema(String) のテスト スタブ </summary>
        [PexMethod]
        public DataTable GetSchemaTest01([PexAssumeUnderTest]AdoNetProfilerDbConnection target, string collectionName)
        {
            DataTable result = target.GetSchema(collectionName);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.GetSchemaTest01(AdoNetProfilerDbConnection, String) に追加します
        }

        /// <summary>GetSchema(String, String[]) のテスト スタブ </summary>
        [PexMethod]
        public DataTable GetSchemaTest02(
            [PexAssumeUnderTest]AdoNetProfilerDbConnection target,
            string collectionName,
            string[] restrictionValues
        )
        {
            DataTable result = target.GetSchema(collectionName, restrictionValues);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.GetSchemaTest02(AdoNetProfilerDbConnection, String, String[]) に追加します
        }

        /// <summary>Open() のテスト スタブ </summary>
        [PexMethod]
        public void OpenTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target)
        {
            target.Open();
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.OpenTest(AdoNetProfilerDbConnection) に追加します
        }

        /// <summary>get_ConnectionString() のテスト スタブ </summary>
        [PexMethod]
        public string ConnectionStringGetTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target)
        {
            string result = target.ConnectionString;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.ConnectionStringGetTest(AdoNetProfilerDbConnection) に追加します
        }

        /// <summary>get_ConnectionTimeout() のテスト スタブ </summary>
        [PexMethod]
        public int ConnectionTimeoutGetTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target)
        {
            int result = target.ConnectionTimeout;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.ConnectionTimeoutGetTest(AdoNetProfilerDbConnection) に追加します
        }

        /// <summary>get_DataSource() のテスト スタブ </summary>
        [PexMethod]
        public string DataSourceGetTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target)
        {
            string result = target.DataSource;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.DataSourceGetTest(AdoNetProfilerDbConnection) に追加します
        }

        /// <summary>get_Database() のテスト スタブ </summary>
        [PexMethod]
        public string DatabaseGetTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target)
        {
            string result = target.Database;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.DatabaseGetTest(AdoNetProfilerDbConnection) に追加します
        }

        /// <summary>get_ServerVersion() のテスト スタブ </summary>
        [PexMethod]
        public string ServerVersionGetTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target)
        {
            string result = target.ServerVersion;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.ServerVersionGetTest(AdoNetProfilerDbConnection) に追加します
        }

        /// <summary>get_State() のテスト スタブ </summary>
        [PexMethod]
        public ConnectionState StateGetTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target)
        {
            ConnectionState result = target.State;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.StateGetTest(AdoNetProfilerDbConnection) に追加します
        }

        /// <summary>get_WrappedConnection() のテスト スタブ </summary>
        [PexMethod]
        public DbConnection WrappedConnectionGetTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target)
        {
            DbConnection result = target.WrappedConnection;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.WrappedConnectionGetTest(AdoNetProfilerDbConnection) に追加します
        }

        /// <summary>set_ConnectionString(String) のテスト スタブ </summary>
        [PexMethod]
        public void ConnectionStringSetTest([PexAssumeUnderTest]AdoNetProfilerDbConnection target, string value)
        {
            target.ConnectionString = value;
            // TODO: アサーションを メソッド AdoNetProfilerDbConnectionTest.ConnectionStringSetTest(AdoNetProfilerDbConnection, String) に追加します
        }
    }
}
