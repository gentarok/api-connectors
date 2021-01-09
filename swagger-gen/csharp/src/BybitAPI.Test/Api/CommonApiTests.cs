using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing CommonApi
    /// </summary>
    [TestFixture]
    public class CommonApiTests
    {
        private static CommonApi Create()
        {
            var instance = new CommonApi();

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

        /// <summary>
        /// Test an instance of CommonApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<CommonApi>(instance, "instance is a CommonApi");
        }

        private readonly string announcementsjson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        {
            ""id"": 2,
            ""title"": ""2019-12-02 RELEASE"",
            ""link"": ""https://github.com/bybit-exchange/bybit-official-api-docs/blob/master/en/CHANGELOG.md"",
            ""summary"": ""<p>New `cancel all` endpoint is here now!</p><p>Additionally, we strongly recommend that you use the new released place and cancel active V2 endpoints, which are more stable and efficient.The old ones are deprecated (although still working for the time be"",
            ""created_at"": ""2019-12-02T11:33:42Z""
        }
    ],
    ""time_now"": ""1577444818.227082""
}
";

        [Test]
        public void CommonAnnouncements_NoConditions_ShouldReturnAnnouncementBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, announcementsjson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = instance.CommonAnnouncements();

            // Assert
            Assert.IsInstanceOf<AnnouncementBase>(response, "response is AnnouncementBase");
        }

        [Test()]
        public void CommonAnnouncementsWithHttpInfo_NoConditions_ShouldReturnApiResponseOfAnnouncementBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, announcementsjson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = instance.CommonAnnouncementsWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<AnnouncementBase>>(response, "response is ApiResponse<AnnouncementBase>");
        }

        [Test()]
        public async Task CommonAnnouncementsAsync_NoConditions_ShouldReturnAnnouncementBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, announcementsjson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = await instance.CommonAnnouncementsAsync();

            // Assert
            Assert.IsInstanceOf<AnnouncementBase>(response, "response is AnnouncementBase");
        }

        [Test()]
        public async Task CommonAnnouncementsAsyncWithHttpInfo_NoConditions_ShouldReturnApiResponseOfAnnouncementBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, announcementsjson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = await instance.CommonAnnouncementsAsyncWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<AnnouncementBase>>(response, "response is ApiResponse<AnnouncementBase>");
        }

        //Fixed: The documentation is wrong, so we will test it according to the actual format of the returned JSON.

        //        private readonly string commonGetLcpjson = @"
        //{
        //    ""ret_code"": 0,
        //    ""ret_msg"": ""ok"",
        //    ""ext_code"": """",
        //    ""result"": [
        //        {
        //            ""date"": ""2020-04-27"",
        //            ""self_ratio"": 1.1251,
        //            ""platform_ratio"": 0.001254,
        //            ""score"": 0.1459
        //        },
        //        {
        //            ""date"": ""2020-04-26"",
        //            ""self_ratio"": 1.1251,
        //            ""platform_ratio"": 0.001254,
        //            ""score"": 0.1459
        //        }
        //    ],
        //    ""ext_info"": null,
        //    ""time_now"": ""1577445138.790150"",
        //    ""rate_limit_status"": 99,
        //    ""rate_limit_reset_ms"": 1577445138812,
        //    ""rate_limit"": 100
        //}
        //";
        private readonly string commonGetLcpjson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": { ""lcp_list"": [
        {
            ""date"": ""2020-04-27"",
            ""self_ratio"": 1.1251,
            ""platform_ratio"": 0.001254,
            ""score"": 0.1459
        },
        {
            ""date"": ""2020-04-26"",
            ""self_ratio"": 1.1251,
            ""platform_ratio"": 0.001254,
            ""score"": 0.1459
        }
    ]},
    ""ext_info"": null,
    ""time_now"": ""1577445138.790150""
}
";

        [Test]
        public void CommonGetLcp_ParametersAreValid_ShouldReturnLCPInfoBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, commonGetLcpjson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.CommonGetLcp(symbol);

            // Assert
            Assert.IsInstanceOf<LCPInfoBase>(response, "response is LCPInfoBase");
        }

        [Test()]
        public void CommonGetLcpWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLCPInfoBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, commonGetLcpjson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.CommonGetLcpWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LCPInfoBase>>(response, "response is ApiResponse<LCPInfoBase>");
        }

        [Test()]
        public async Task CommonGetLcpAsync_ParametersAreValid_ShouldReturnLCPInfoBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, commonGetLcpjson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.CommonGetLcpAsync(symbol);

            // Assert
            Assert.IsInstanceOf<LCPInfoBase>(response, "response is LCPInfoBase");
        }

        [Test()]
        public async Task CommonGetLcpAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLCPInfoBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, commonGetLcpjson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.CommonGetLcpAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LCPInfoBase>>(response, "response is ApiResponse<LCPInfoBase>");
        }

        private readonly string servertimejson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {},
    ""time_now"": ""1577444332.192859""
}
";

        [Test]
        public void CommonGetTime_NoCondition_ShouldReturnServerTimeRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, servertimejson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = instance.CommonGetTime();

            // Assert
            Assert.IsInstanceOf<ServerTimeRes>(response, "response is ServerTimeRes");
            Assert.That(response.RetCode, Is.EqualTo(0));
            Assert.That(response.RetMsg, Is.EqualTo("OK"));
            Assert.That(response.ExtCode, Is.EqualTo(""));
            Assert.That(response.Result, Is.InstanceOf<object>());
            Assert.That(response.TimeNow, Is.EqualTo("1577444332.192859"));
        }

        [Test()]
        public void CommonGetTimeWithHttpInfo_NoCondition_ShouldReturnApiResponceOfServerTimeRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, servertimejson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = instance.CommonGetTimeWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<ServerTimeRes>>(response, "response is ApiResponse<ServerTimeRes>");
        }

        [Test()]
        public async Task CommonGetTimeAsync_NoCondition_ShouldReturnServerTimeRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, servertimejson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = await instance.CommonGetTimeAsync();

            // Assert
            Assert.IsInstanceOf<ServerTimeRes>(response, "response is ServerTimeRes");
        }

        [Test()]
        public async Task CommonGetTimeAsyncWithHttpInfo_NoCondition_ShouldReturnApiResponceOfServerTimeRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, servertimejson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = await instance.CommonGetTimeAsyncWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<ServerTimeRes>>(response, "response is ApiResponse<ServerTimeRes>");
        }
    }
}