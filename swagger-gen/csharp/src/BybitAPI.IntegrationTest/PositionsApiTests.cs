using BybitAPI.Api;
using BybitAPI.Client;
using BybitAPI.IntegrationTest.Util;
using NUnit.Framework;

namespace BybitAPI.IntegrationTest
{
    [TestFixture]
    public class PositionsApiTests
    {
        private static PositionsApi Create()
        {
            // Prepeare configurations to test.
            var configuration = new Configuration
            {
                BasePath = TestUtil.TESTNET_URI
            };
            configuration.ApiKey.Add("api_key", TestUtil.GetTestApiKey());
            configuration.ApiKey.Add("api_secret", TestUtil.GetTestApiSecret());
            return new PositionsApi(configuration);
        }

        [Test]
        public void Test()
        {
            // Arragne
            var instance = Create();

            // Act
            //var response = instance.PositionsChangeMargin(Symbol.BTCUSD, 0.0012630m);

            //{"ret_code":0,"ret_msg":"OK","ext_code":"","ext_info":"","result":0.00125924,"time_now":"1610304386.607695","rate_limit_status":74,"rate_limit_reset_ms":1610304386605,"rate_limit":75}

            //var response = instance.PositionsClosePnlRecords(Symbol.BTCUSD);

            //var response1 = instance.PositionsMyPosition(Symbol.BTCUSD);
            //var response2 = instance.PositionsMyPosition();

            // Assert
            //Assert.Fail();
        }
    }
}