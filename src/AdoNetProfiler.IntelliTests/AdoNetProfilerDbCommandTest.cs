// <copyright file="AdoNetProfilerDbCommandTest.cs">Copyright ©  2015</copyright>
using System;
using System.Data;
using System.Data.Common;
using AdoNetProfiler;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;

namespace AdoNetProfiler.IntelliTests
{
    /// <summary>このクラスには、AdoNetProfilerDbCommand に対するパラメーター化された単体テストが含まれています</summary>
    [PexClass(typeof(AdoNetProfilerDbCommand))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    public partial class AdoNetProfilerDbCommandTest
    {
        /// <summary>Cancel() のテスト スタブ </summary>
        [PexMethod]
        internal void CancelTest([PexAssumeUnderTest]AdoNetProfilerDbCommand target)
        {
            target.Cancel();
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.CancelTest(AdoNetProfilerDbCommand) に追加します
        }

        /// <summary>get_CommandText() のテスト スタブ </summary>
        [PexMethod]
        internal string CommandTextGetTest([PexAssumeUnderTest]AdoNetProfilerDbCommand target)
        {
            string result = target.CommandText;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.CommandTextGetTest(AdoNetProfilerDbCommand) に追加します
        }

        /// <summary>set_CommandText(String) のテスト スタブ </summary>
        [PexMethod]
        internal void CommandTextSetTest(
            [PexAssumeUnderTest]AdoNetProfilerDbCommand target,
            string value
        )
        {
            target.CommandText = value;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.CommandTextSetTest(AdoNetProfilerDbCommand, String) に追加します
        }

        /// <summary>get_CommandTimeout() のテスト スタブ </summary>
        [PexMethod]
        internal int CommandTimeoutGetTest([PexAssumeUnderTest]AdoNetProfilerDbCommand target)
        {
            int result = target.CommandTimeout;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.CommandTimeoutGetTest(AdoNetProfilerDbCommand) に追加します
        }

        /// <summary>set_CommandTimeout(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal void CommandTimeoutSetTest([PexAssumeUnderTest]AdoNetProfilerDbCommand target, int value)
        {
            target.CommandTimeout = value;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.CommandTimeoutSetTest(AdoNetProfilerDbCommand, Int32) に追加します
        }

        /// <summary>get_CommandType() のテスト スタブ </summary>
        [PexMethod]
        internal CommandType CommandTypeGetTest([PexAssumeUnderTest]AdoNetProfilerDbCommand target)
        {
            CommandType result = target.CommandType;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.CommandTypeGetTest(AdoNetProfilerDbCommand) に追加します
        }

        /// <summary>set_CommandType(CommandType) のテスト スタブ </summary>
        [PexMethod]
        internal void CommandTypeSetTest(
            [PexAssumeUnderTest]AdoNetProfilerDbCommand target,
            CommandType value
        )
        {
            target.CommandType = value;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.CommandTypeSetTest(AdoNetProfilerDbCommand, CommandType) に追加します
        }

        /// <summary>.ctor(DbCommand, DbConnection, IAdoNetProfiler) のテスト スタブ </summary>
        [PexMethod]
        internal AdoNetProfilerDbCommand ConstructorTest(
            DbCommand command,
            DbConnection connection,
            IAdoNetProfiler profiler
        )
        {
            AdoNetProfilerDbCommand target
               = new AdoNetProfilerDbCommand(command, connection, profiler);
            return target;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.ConstructorTest(DbCommand, DbConnection, IAdoNetProfiler) に追加します
        }

        /// <summary>get_DesignTimeVisible() のテスト スタブ </summary>
        [PexMethod]
        internal bool DesignTimeVisibleGetTest([PexAssumeUnderTest]AdoNetProfilerDbCommand target)
        {
            bool result = target.DesignTimeVisible;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.DesignTimeVisibleGetTest(AdoNetProfilerDbCommand) に追加します
        }

        /// <summary>set_DesignTimeVisible(Boolean) のテスト スタブ </summary>
        [PexMethod]
        internal void DesignTimeVisibleSetTest(
            [PexAssumeUnderTest]AdoNetProfilerDbCommand target,
            bool value
        )
        {
            target.DesignTimeVisible = value;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.DesignTimeVisibleSetTest(AdoNetProfilerDbCommand, Boolean) に追加します
        }

        /// <summary>ExecuteNonQuery() のテスト スタブ </summary>
        [PexMethod]
        internal int ExecuteNonQueryTest([PexAssumeUnderTest]AdoNetProfilerDbCommand target)
        {
            int result = target.ExecuteNonQuery();
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.ExecuteNonQueryTest(AdoNetProfilerDbCommand) に追加します
        }

        /// <summary>ExecuteScalar() のテスト スタブ </summary>
        [PexMethod]
        internal object ExecuteScalarTest([PexAssumeUnderTest]AdoNetProfilerDbCommand target)
        {
            object result = target.ExecuteScalar();
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.ExecuteScalarTest(AdoNetProfilerDbCommand) に追加します
        }

        /// <summary>Prepare() のテスト スタブ </summary>
        [PexMethod]
        internal void PrepareTest([PexAssumeUnderTest]AdoNetProfilerDbCommand target)
        {
            target.Prepare();
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.PrepareTest(AdoNetProfilerDbCommand) に追加します
        }

        /// <summary>get_UpdatedRowSource() のテスト スタブ </summary>
        [PexMethod]
        internal UpdateRowSource UpdatedRowSourceGetTest([PexAssumeUnderTest]AdoNetProfilerDbCommand target)
        {
            UpdateRowSource result = target.UpdatedRowSource;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.UpdatedRowSourceGetTest(AdoNetProfilerDbCommand) に追加します
        }

        /// <summary>set_UpdatedRowSource(UpdateRowSource) のテスト スタブ </summary>
        [PexMethod]
        internal void UpdatedRowSourceSetTest(
            [PexAssumeUnderTest]AdoNetProfilerDbCommand target,
            UpdateRowSource value
        )
        {
            target.UpdatedRowSource = value;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.UpdatedRowSourceSetTest(AdoNetProfilerDbCommand, UpdateRowSource) に追加します
        }

        /// <summary>get_WrappedCommand() のテスト スタブ </summary>
        [PexMethod]
        internal DbCommand WrappedCommandGetTest([PexAssumeUnderTest]AdoNetProfilerDbCommand target)
        {
            DbCommand result = target.WrappedCommand;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbCommandTest.WrappedCommandGetTest(AdoNetProfilerDbCommand) に追加します
        }
    }
}
