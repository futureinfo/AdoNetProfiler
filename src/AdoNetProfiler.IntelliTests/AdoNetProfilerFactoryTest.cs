using System;
using AdoNetProfiler;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;

namespace AdoNetProfiler.IntelliTests
{
    /// <summary>このクラスには、AdoNetProfilerFactory に対するパラメーター化された単体テストが含まれています</summary>
    [PexClass(typeof(AdoNetProfilerFactory))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AdoNetProfilerFactoryTest
    {

        /// <summary>GetProfiler() のテスト スタブ </summary>
        [PexMethod]
        internal IAdoNetProfiler GetProfilerTest()
        {
            IAdoNetProfiler result = AdoNetProfilerFactory.GetProfiler();
            return result;
            // TODO: アサーションを メソッド AdoNetProfilerFactoryTest.GetProfilerTest() に追加します
        }

        /// <summary>Initialize(Type) のテスト スタブ </summary>
        [PexMethod]
        public void InitializeTest(Type profilerType)
        {
            AdoNetProfilerFactory.Initialize(profilerType);
            // TODO: アサーションを メソッド AdoNetProfilerFactoryTest.InitializeTest(Type) に追加します
        }
    }
}
