using System.Data;
using System.Collections;
using System.Data.Common;
using System;
using AdoNetProfiler;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;

namespace AdoNetProfiler.IntelliTests
{
    /// <summary>このクラスには、AdoNetProfilerDbDataReader に対するパラメーター化された単体テストが含まれています</summary>
    [PexClass(typeof(AdoNetProfilerDbDataReader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AdoNetProfilerDbDataReaderTest
    {

        /// <summary>.ctor(DbDataReader, IAdoNetProfiler) のテスト スタブ </summary>
        [PexMethod]
        internal AdoNetProfilerDbDataReader ConstructorTest(DbDataReader reader, IAdoNetProfiler profiler)
        {
            AdoNetProfilerDbDataReader target = new AdoNetProfilerDbDataReader(reader, profiler);
            return target;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.ConstructorTest(DbDataReader, IAdoNetProfiler) に追加します
        }

        /// <summary>Close() のテスト スタブ </summary>
        [PexMethod]
        internal void CloseTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target)
        {
            target.Close();
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.CloseTest(AdoNetProfilerDbDataReader) に追加します
        }

        /// <summary>GetBoolean(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal bool GetBooleanTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            bool result = target.GetBoolean(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetBooleanTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetByte(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal byte GetByteTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            byte result = target.GetByte(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetByteTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetBytes(Int32, Int64, Byte[], Int32, Int32) のテスト スタブ </summary>
        [PexMethod]
        internal long GetBytesTest(
            [PexAssumeUnderTest]AdoNetProfilerDbDataReader target,
            int ordinal,
            long dataOffset,
            byte[] buffer,
            int bufferOffset,
            int length
        )
        {
            long result = target.GetBytes(ordinal, dataOffset, buffer, bufferOffset, length);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetBytesTest(AdoNetProfilerDbDataReader, Int32, Int64, Byte[], Int32, Int32) に追加します
        }

        /// <summary>GetChar(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal char GetCharTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            char result = target.GetChar(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetCharTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetChars(Int32, Int64, Char[], Int32, Int32) のテスト スタブ </summary>
        [PexMethod]
        internal long GetCharsTest(
            [PexAssumeUnderTest]AdoNetProfilerDbDataReader target,
            int ordinal,
            long dataOffset,
            char[] buffer,
            int bufferOffset,
            int length
        )
        {
            long result = target.GetChars(ordinal, dataOffset, buffer, bufferOffset, length);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetCharsTest(AdoNetProfilerDbDataReader, Int32, Int64, Char[], Int32, Int32) に追加します
        }

        /// <summary>GetDataTypeName(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal string GetDataTypeNameTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            string result = target.GetDataTypeName(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetDataTypeNameTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetDateTime(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal DateTime GetDateTimeTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            DateTime result = target.GetDateTime(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetDateTimeTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetDecimal(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal decimal GetDecimalTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            decimal result = target.GetDecimal(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetDecimalTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetDouble(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal double GetDoubleTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            double result = target.GetDouble(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetDoubleTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetEnumerator() のテスト スタブ </summary>
        [PexMethod]
        internal IEnumerator GetEnumeratorTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target)
        {
            IEnumerator result = target.GetEnumerator();
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetEnumeratorTest(AdoNetProfilerDbDataReader) に追加します
        }

        /// <summary>GetFieldType(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal Type GetFieldTypeTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            Type result = target.GetFieldType(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetFieldTypeTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetFloat(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal float GetFloatTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            float result = target.GetFloat(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetFloatTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetGuid(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal Guid GetGuidTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            Guid result = target.GetGuid(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetGuidTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetInt16(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal short GetInt16Test([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            short result = target.GetInt16(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetInt16Test(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetInt32(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal int GetInt32Test([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            int result = target.GetInt32(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetInt32Test(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetInt64(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal long GetInt64Test([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            long result = target.GetInt64(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetInt64Test(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetName(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal string GetNameTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            string result = target.GetName(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetNameTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetOrdinal(String) のテスト スタブ </summary>
        [PexMethod]
        internal int GetOrdinalTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, string name)
        {
            int result = target.GetOrdinal(name);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetOrdinalTest(AdoNetProfilerDbDataReader, String) に追加します
        }

        /// <summary>GetSchemaTable() のテスト スタブ </summary>
        [PexMethod]
        internal DataTable GetSchemaTableTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target)
        {
            DataTable result = target.GetSchemaTable();
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetSchemaTableTest(AdoNetProfilerDbDataReader) に追加します
        }

        /// <summary>GetString(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal string GetStringTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            string result = target.GetString(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetStringTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetValue(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal object GetValueTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            object result = target.GetValue(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetValueTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>GetValues(Object[]) のテスト スタブ </summary>
        [PexMethod]
        internal int GetValuesTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, object[] values)
        {
            int result = target.GetValues(values);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.GetValuesTest(AdoNetProfilerDbDataReader, Object[]) に追加します
        }

        /// <summary>IsDBNull(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal bool IsDBNullTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            bool result = target.IsDBNull(ordinal);
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.IsDBNullTest(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>NextResult() のテスト スタブ </summary>
        [PexMethod]
        internal bool NextResultTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target)
        {
            bool result = target.NextResult();
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.NextResultTest(AdoNetProfilerDbDataReader) に追加します
        }

        /// <summary>Read() のテスト スタブ </summary>
        [PexMethod]
        internal bool ReadTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target)
        {
            bool result = target.Read();
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.ReadTest(AdoNetProfilerDbDataReader) に追加します
        }

        /// <summary>get_Depth() のテスト スタブ </summary>
        [PexMethod]
        internal int DepthGetTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target)
        {
            int result = target.Depth;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.DepthGetTest(AdoNetProfilerDbDataReader) に追加します
        }

        /// <summary>get_FieldCount() のテスト スタブ </summary>
        [PexMethod]
        internal int FieldCountGetTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target)
        {
            int result = target.FieldCount;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.FieldCountGetTest(AdoNetProfilerDbDataReader) に追加します
        }

        /// <summary>get_HasRows() のテスト スタブ </summary>
        [PexMethod]
        internal bool HasRowsGetTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target)
        {
            bool result = target.HasRows;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.HasRowsGetTest(AdoNetProfilerDbDataReader) に追加します
        }

        /// <summary>get_IsClosed() のテスト スタブ </summary>
        [PexMethod]
        internal bool IsClosedGetTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target)
        {
            bool result = target.IsClosed;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.IsClosedGetTest(AdoNetProfilerDbDataReader) に追加します
        }

        /// <summary>get_Item(String) のテスト スタブ </summary>
        [PexMethod]
        internal object ItemGetTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, string name)
        {
            object result = target[name];
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.ItemGetTest(AdoNetProfilerDbDataReader, String) に追加します
        }

        /// <summary>get_Item(Int32) のテスト スタブ </summary>
        [PexMethod]
        internal object ItemGetTest01([PexAssumeUnderTest]AdoNetProfilerDbDataReader target, int ordinal)
        {
            object result = target[ordinal];
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.ItemGetTest01(AdoNetProfilerDbDataReader, Int32) に追加します
        }

        /// <summary>get_RecordsAffected() のテスト スタブ </summary>
        [PexMethod]
        internal int RecordsAffectedGetTest([PexAssumeUnderTest]AdoNetProfilerDbDataReader target)
        {
            int result = target.RecordsAffected;
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerDbDataReaderTest.RecordsAffectedGetTest(AdoNetProfilerDbDataReader) に追加します
        }
    }
}
