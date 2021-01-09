using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing APIkeyApi
    /// </summary>
    [TestFixture]
    public class APIkeyApiTests
    {
        private static APIkeyApi Create()
        {
            var instance = new APIkeyApi();

            // Prepeare configurations to test.
            instance.Configuration.AddApiKey("api_key", "");
            instance.Configuration.AddApiKey("api_secret", "");
            return instance;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<APIkeyApi>(instance, "instance is a APIkeyApi");
        }

        private readonly string apiKeyInfoJson = @"{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": [
        {
            ""api_key"": ""7GkMBBLTbGRfa0Nuh1"",
            ""type"": ""personal"",
            ""user_id"": 1,
            ""inviter_id"": 3,
            ""ips"": [
                ""*""
            ],
            ""note"": ""scalping_bot"",
            ""permissions"": [
                ""Order"",
                ""Position""
            ],
            ""created_at"": ""2019-10-28T13:22:39.000Z"",
            ""expired_at"": ""2020-01-28T13:22:39.000Z"",
            ""read_only"": false
        }
    ],
    ""ext_info"": null,
    ""time_now"": ""1577445138.790150"",
    ""rate_limit_status"": 99,
    ""rate_limit_reset_ms"": 1577445138812,
    ""rate_limit"": 100
}";

        [Test]
        public void APIkeyInfo_NoConditions_ShouldReturnAPIKeyInfoBase()
        {
            // Arrange
            var instance = Create();
            instance.Configuration.ApiClient.RestClient = MockRestClientFactory.Create(HttpStatusCode.OK, apiKeyInfoJson);

            // Act
            var response = instance.APIkeyInfo();

            // Assert
            Assert.IsInstanceOf<APIKeyInfoBase>(response, "response is APIKeyInfoBase");
            Assert.That(response.RetCode, Is.EqualTo(0));
            Assert.That(response.RetMsg, Is.EqualTo("ok"));
            Assert.That(response.ExtCode, Is.EqualTo(""));
            Assert.That(response.ExtInfo, Is.Null);
            Assert.That(response.TimeNow, Is.EqualTo("1577445138.790150"));
            Assert.That(response.Result.Count, Is.EqualTo(1));
            Assert.That(response.Result[0].ApiKey, Is.EqualTo("7GkMBBLTbGRfa0Nuh1"));
            // TODO: and more...
        }

        [Test]
        public void APIkeyInfoWithHttpInfo_NoConditions_ShouldReturnApiResponseOfAPIKeyInfoBase()
        {
            // Arrange
            var instance = Create();
            instance.Configuration.ApiClient.RestClient = MockRestClientFactory.Create(HttpStatusCode.OK, apiKeyInfoJson);

            // Act
            var response = instance.APIkeyInfoWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<APIKeyInfoBase>>(response, "response is ApiResponse<APIKeyInfoBase>");
        }

        [Test()]
        public async Task APIkeyInfoAsyncTest_NoConditions_ShouldReturnAPIKeyInfoBase()
        {
            // Arrange
            var instance = Create();
            instance.Configuration.ApiClient.RestClient = MockRestClientFactory.Create(HttpStatusCode.OK, apiKeyInfoJson);

            // Act
            var response = await instance.APIkeyInfoAsync();

            // Assert
            Assert.IsInstanceOf<APIKeyInfoBase>(response, "response is APIKeyInfoBase");
        }

        [Test()]
        public async Task APIkeyInfoAsyncWithHttpInfo_NoConditions_ShouldReturnApiResponseOfAPIKeyInfoBase()
        {
            // Arrange
            var instance = Create();
            instance.Configuration.ApiClient.RestClient = MockRestClientFactory.Create(HttpStatusCode.OK, apiKeyInfoJson);

            // Act
            var response = await instance.APIkeyInfoAsyncWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<APIKeyInfoBase>>(response, "response is ApiResponse<APIKeyInfoBase>");
        }
    }
}