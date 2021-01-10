using BybitAPI.Api;
using BybitAPI.Client;
using BybitAPI.IntegrationTest.Util;
using BybitAPI.Model;
using NUnit.Framework;

namespace BybitAPI.IntegrationTest
{
    [TestFixture]
    public class APIkeyApiTests
    {
        private static APIkeyApi Create()
        {
            // Prepeare configurations to test.
            var configuration = new Configuration
            {
                BasePath = TestUtil.TESTNET_URI
            };
            configuration.ApiKey.Add("api_key", TestUtil.GetTestApiKey());
            configuration.ApiKey.Add("api_secret", TestUtil.GetTestApiSecret());
            return new APIkeyApi(configuration);
        }

        [Test]
        public void APIkeyInfo_NoConditions_ShouldReturnAPIKeyInfoBase()
        {
            // Arrange
            var instance = Create();

            // Act
            var response = instance.APIkeyInfo();

            // Assert
            Assert.IsInstanceOf<APIKeyInfoBase>(response, "response is APIKeyInfoBase");
            Assert.That(response.RetCode, Is.EqualTo(0));
            Assert.That(response.Result, Has.Exactly(1).Matches<APIKeyInfoRes>(x => x.ApiKey == TestUtil.GetTestApiKey()));
        }

        [Test]
        public void APIkeyInfoWithHttpInfo_NoConditions_ShouldReturnApiRespenseOfAPIKeyInfoBase()
        {
            // Arrange
            var instance = Create();

            // Act
            var response = instance.APIkeyInfoWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<APIKeyInfoBase>>(response, "response is ApiResponce<APIKeyInfoBase>");
            Assert.That(response.Data.RetCode, Is.EqualTo(0));
            Assert.That(response.Data.Result, Has.Exactly(1).Matches<APIKeyInfoRes>(x => x.ApiKey == TestUtil.GetTestApiKey()));
        }
    }
}