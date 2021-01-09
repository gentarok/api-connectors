using BybitAPI.Api;
using BybitAPI.Client;
using BybitAPI.IntegrationTest.Util;
using BybitAPI.Model;
using NUnit.Framework;

namespace BybitAPI.IntegrationTest
{
    public class CommonApiTests
    {
        private static CommonApi Create()
        {
            // Prepeare configurations to test.
            var configuration = new Configuration
            {
                BasePath = TestUtil.TESTNET_URI
            };
            configuration.ApiKey.Add("api_key", TestUtil.GetTestApiKey());
            configuration.ApiKey.Add("api_secret", TestUtil.GetTestApiSecret());
            return new CommonApi(configuration);
        }

        [Test]
        public void CommonAnnouncements_ShouldReturnAnnouncementBase()
        {
            // Arrange
            var instance = Create();

            // Act
            var response = instance.CommonAnnouncements();

            // Assert
            Assert.IsInstanceOf<AnnouncementBase>(response, "response is AnnouncementBase");
            Assert.That(response.RetCode, Is.EqualTo(0), $"API error has occered: {response.RetMsg}");
        }

        [Test]
        public void CommonGetLcp_ParametersAreValid_ShouldReturnLCPInfoBase()
        {
            // Arrange
            var instance = Create();

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.CommonGetLcp(symbol);

            // Assert
            Assert.IsInstanceOf<LCPInfoBase>(response, "response is LCPInfoBase");
            Assert.That(response.RetCode, Is.EqualTo(0), $"API error has occered: {response.RetMsg}");
        }

        [Test]
        public void CommonGetTime_ShouldReturnServerTimeRes()
        {
            // Arrange
            var instance = Create();

            // Act
            var response = instance.CommonGetTime();

            // Assert
            Assert.IsInstanceOf<ServerTimeRes>(response, "response is ServerTimeRes");
            Assert.That(response.RetCode, Is.EqualTo(0), $"API error has occered: {response.RetMsg}");
        }
    }
}