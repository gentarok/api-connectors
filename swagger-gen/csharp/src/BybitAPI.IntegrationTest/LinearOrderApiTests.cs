using BybitAPI.Api;
using BybitAPI.Client;
using BybitAPI.IntegrationTest.Util;
using NUnit.Framework;

namespace BybitAPI.IntegrationTest
{
    [TestFixture]
    public class LinearOrderApiTests
    {
        private static LinearOrderApi Create()
        {
            // Prepeare configurations to test.
            var configuration = new Configuration
            {
                BasePath = TestUtil.TESTNET_URI
            };
            configuration.ApiKey.Add("api_key", TestUtil.GetTestApiKey());
            configuration.ApiKey.Add("api_secret", TestUtil.GetTestApiSecret());
            return new LinearOrderApi(configuration);
        }

        [Test]
        public void Test()
        {
            // Arragne
            var instance = Create();

            // Act
            var response1 = instance.LinearOrderQuery(Model.LinearSymbol.BTCUSDT, "8314d636-2a58-440b-a310-8e4f5498ec27");

            // Assert
            Assert.Fail();
        }
    }
}