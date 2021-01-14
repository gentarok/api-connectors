using BybitAPI.Api;
using BybitAPI.Client;
using BybitAPI.IntegrationTest.Util;
using NUnit.Framework;
using System;

namespace BybitAPI.IntegrationTest
{
    [TestFixture]
    public class LinearKlineApiTests
    {
        private static LinearKlineApi Create()
        {
            // Prepeare configurations to test.
            var configuration = new Configuration
            {
                BasePath = TestUtil.TESTNET_URI
            };
            configuration.ApiKey.Add("api_key", TestUtil.GetTestApiKey());
            configuration.ApiKey.Add("api_secret", TestUtil.GetTestApiSecret());
            return new LinearKlineApi(configuration);
        }

        [Test]
        public void Test()
        {
            // Arragne
            var instance = Create();

            // Act
            //var response1 = instance.WalletGetRecords(new System.DateTimeOffset(2021, 1, 1, 0, 0, 0, System.TimeSpan.FromHours(9)));
            var response1 = instance.LinearKlineGet(Model.LinearSymbol.BCHUSDT, "D", DateTimeOffset.Now.AddDays(-10).ToUnixTimeSeconds());

            // Assert
            Assert.Fail();
        }
    }
}