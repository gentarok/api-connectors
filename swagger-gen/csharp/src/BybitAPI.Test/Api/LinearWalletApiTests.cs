using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing LinearWalletApi
    /// </summary>
    [TestFixture]
    public class LinearWalletApiTests
    {
        private static LinearWalletApi Create()
        {
            var instance = new LinearWalletApi();

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
        /// Test an instance of LinearWalletApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<LinearWalletApi>(instance, "instance is a LinearWalletApi");
        }

        private static readonly string linearWallletGetRiskLimitJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        {
            ""id"": 1,
            ""symbol"": ""BTCUSDT"",
            ""limit"": 1000000,
            ""maintain_margin"": 0.005,
            ""starting_margin"": 0.01,
            ""section"": [
                ""1"",
                ""2"",
                ""3"",
                ""5"",
                ""10"",
                ""25"",
                ""50"",
                ""100""
            ],
            ""is_lowest_risk"": 1,
            ""created_at"": ""2020-01-06T09:45:28.000Z"",
            ""updated_at"": ""2020-01-06T09:45:28.000Z""
        },
        {
            ""id"": 2,
            ""symbol"": ""BTCUSDT"",
            ""limit"": 1500000,
            ""maintain_margin"": 0.01,
            ""starting_margin"": 0.015,
            ""section"": [
                ""1"",
                ""2"",
                ""3"",
                ""5"",
                ""10"",
                ""25"",
                ""50"",
                ""66""
            ],
            ""is_lowest_risk"": 0,
            ""created_at"": ""2020-01-06T09:45:28.000Z"",
            ""updated_at"": ""2020-01-06T09:45:28.000Z""
        },
        {
            ""id"": 3,
            ""symbol"": ""BTCUSDT"",
            ""limit"": 2000000,
            ""maintain_margin"": 0.015,
            ""starting_margin"": 0.02,
            ""section"": [
                ""1"",
                ""2"",
                ""3"",
                ""5"",
                ""10"",
                ""25"",
                ""33"",
                ""50""
            ],
            ""is_lowest_risk"": 0,
            ""created_at"": ""2020-01-06T09:45:28.000Z"",
            ""updated_at"": ""2020-01-06T09:45:28.000Z""
        },
        {
            ""id"": 4,
            ""symbol"": ""BTCUSDT"",
            ""limit"": 2500000,
            ""maintain_margin"": 0.02,
            ""starting_margin"": 0.025,
            ""section"": [
                ""1"",
                ""2"",
                ""3"",
                ""5"",
                ""10"",
                ""25"",
                ""33"",
                ""40""
            ],
            ""is_lowest_risk"": 0,
            ""created_at"": ""2020-01-06T09:45:28.000Z"",
            ""updated_at"": ""2020-01-06T09:45:28.000Z""
        },
        {
            ""id"": 5,
            ""symbol"": ""BTCUSDT"",
            ""limit"": 3000000,
            ""maintain_margin"": 0.025,
            ""starting_margin"": 0.03,
            ""section"": [
                ""1"",
                ""2"",
                ""3"",
                ""5"",
                ""10"",
                ""15"",
                ""25"",
                ""33""
            ],
            ""is_lowest_risk"": 0,
            ""created_at"": ""2020-01-06T09:45:28.000Z"",
            ""updated_at"": ""2020-01-06T09:45:28.000Z""
        },
        {
            ""id"": 6,
            ""symbol"": ""BTCUSDT"",
            ""limit"": 3500000,
            ""maintain_margin"": 0.03,
            ""starting_margin"": 0.035,
            ""section"": [
                ""1"",
                ""2"",
                ""3"",
                ""5"",
                ""10"",
                ""15"",
                ""20"",
                ""28""
            ],
            ""is_lowest_risk"": 0,
            ""created_at"": ""2020-01-06T09:45:28.000Z"",
            ""updated_at"": ""2020-01-06T09:45:28.000Z""
        },
        {
            ""id"": 7,
            ""symbol"": ""BTCUSDT"",
            ""limit"": 4000000,
            ""maintain_margin"": 0.035,
            ""starting_margin"": 0.04,
            ""section"": [
                ""1"",
                ""2"",
                ""3"",
                ""5"",
                ""10"",
                ""15"",
                ""20"",
                ""25""
            ],
            ""is_lowest_risk"": 0,
            ""created_at"": ""2020-01-06T09:45:28.000Z"",
            ""updated_at"": ""2020-01-06T09:45:28.000Z""
        },
        {
            ""id"": 8,
            ""symbol"": ""BTCUSDT"",
            ""limit"": 4500000,
            ""maintain_margin"": 0.04,
            ""starting_margin"": 0.045,
            ""section"": [
                ""1"",
                ""2"",
                ""3"",
                ""5"",
                ""10"",
                ""15"",
                ""20"",
                ""22""
            ],
            ""is_lowest_risk"": 0,
            ""created_at"": ""2020-01-06T09:45:28.000Z"",
            ""updated_at"": ""2020-01-06T09:45:28.000Z""
        },
        {
            ""id"": 9,
            ""symbol"": ""BTCUSDT"",
            ""limit"": 5000000,
            ""maintain_margin"": 0.045,
            ""starting_margin"": 0.05,
            ""section"": [
                ""1"",
                ""2"",
                ""3"",
                ""4"",
                ""5"",
                ""10"",
                ""15"",
                ""20""
            ],
            ""is_lowest_risk"": 0,
            ""created_at"": ""2020-01-06T09:45:28.000Z"",
            ""updated_at"": ""2020-01-06T09:45:28.000Z""
        },
        {
            ""id"": 10,
            ""symbol"": ""BTCUSDT"",
            ""limit"": 5500000,
            ""maintain_margin"": 0.05,
            ""starting_margin"": 0.055,
            ""section"": [
                ""1"",
                ""2"",
                ""3"",
                ""4"",
                ""5"",
                ""10"",
                ""15"",
                ""18""
            ],
            ""is_lowest_risk"": 0,
            ""created_at"": ""2020-01-06T09:45:29.000Z"",
            ""updated_at"": ""2020-01-06T09:45:29.000Z""
        }
    ],
    ""time_now"": ""1586780586.850288""
}
";

        [Test]
        public void LinearWalletGetRiskLimit_ParametersAreValid_ShouldReturnLinearWalletGetRiskLimitBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearWallletGetRiskLimitJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var response = instance.LinearWalletGetRiskLimit(symbol);

            // Assert
            Assert.IsInstanceOf<LinearWalletGetRiskLimitBase>(response, "response is LinearWalletGetRiskLimitBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearWalletGetRiskLimitWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearWalletGetRiskLimitBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearWallletGetRiskLimitJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var response = instance.LinearWalletGetRiskLimitWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearWalletGetRiskLimitBase>>(response, "response is ApiResponse<LinearWalletGetRiskLimitBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearWalletGetRiskLimitAsync_ParametersAreValid_ShouldReturnLinearWalletGetRiskLimitBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearWallletGetRiskLimitJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var response = await instance.LinearWalletGetRiskLimitAsync(symbol);

            // Assert
            Assert.IsInstanceOf<LinearWalletGetRiskLimitBase>(response, "response is LinearWalletGetRiskLimitBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearWalletGetRiskLimitAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearWalletGetRiskLimitBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearWallletGetRiskLimitJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var response = await instance.LinearWalletGetRiskLimitAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearWalletGetRiskLimitBase>>(response, "response is ApiResponse<LinearWalletGetRiskLimitBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }
    }
}