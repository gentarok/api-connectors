using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing FundingApi
    /// </summary>
    [TestFixture]
    public class FundingApiTests
    {
        private static FundingApi Create()
        {
            var instance = new FundingApi();

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
            Assert.IsInstanceOf<FundingApi>(instance, "instance is a FundingApi");
        }

        private static readonly string fundingMyLastFeeJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
        ""symbol"": ""BTCUSD"",
        ""side"": ""Buy"",
        ""size"": 1,
        ""funding_rate"": 0.0001,
        ""exec_fee"": 0.00000002,
        ""exec_timestamp"": 1575907200
    },
    ""ext_info"": null,
    ""time_now"": ""1577446900.717204"",
    ""rate_limit_status"": 119,
    ""rate_limit_reset_ms"": 1577446900724,
    ""rate_limit"": 120
}
";

        [Test]
        public void FundingMyLastFee_ParametersAreValid_ShouldReturnFundingMyLastFeeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingMyLastFeeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.FundingMyLastFee(symbol);

            // Assert
            Assert.IsInstanceOf<FundingMyLastFeeBase>(response, "response is FundingMyLastFeeBase");
            Assert.NotNull(response.Result);
        }

        [Test]
        public void FundingMyLastFeeWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseFundingMyLastFeeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingMyLastFeeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.FundingMyLastFeeWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<FundingMyLastFeeBase>>(response, "response is ApiResponse<FundingMyLastFeeBase>");
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.Result);
        }

        [Test]
        public async Task FundingMyLastFeeAsync_ParametersAreValid_ShouldReturnFundingMyLastFeeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingMyLastFeeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.FundingMyLastFeeAsync(symbol);

            // Assert
            Assert.IsInstanceOf<FundingMyLastFeeBase>(response, "response is FundingMyLastFeeBase");
            Assert.NotNull(response.Result);
        }

        [Test]
        public async Task FundingMyLastFeeAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseFundingMyLastFeeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingMyLastFeeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.FundingMyLastFeeAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<FundingMyLastFeeBase>>(response, "response is ApiResponse<FundingMyLastFeeBase>");
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.Result);
        }

        private static readonly string fundingPredictedJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
        ""predicted_funding_rate"": 0.0001,
        ""predicted_funding_fee"": 0
    },
    ""ext_info"": null,
    ""time_now"": ""1577447415.583259"",
    ""rate_limit_status"": 118,
    ""rate_limit_reset_ms"": 1577447415590,
    ""rate_limit"": 120
}
";

        [Test]
        public void FundingPredicted_ParametersAreValid_ShouldReturnFundingPredictedBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingPredictedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.FundingPredicted(symbol);

            // Assert
            Assert.IsInstanceOf<FundingPredictedBase>(response, "response is FundingPredictedBase");
            Assert.NotNull(response.Result);
        }

        [Test]
        public void FundingPredictedWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfFundingPredictedBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingPredictedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.FundingPredictedWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<FundingPredictedBase>>(response, "response is ApiResponse<FundingPredictedBase>");
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.Result);
        }

        [Test]
        public async Task FundingPredictedAsync_ParametersAreValid_ShouldReturnFundingPredictedBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingPredictedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.FundingPredictedAsync(symbol);

            // Assert
            Assert.IsInstanceOf<FundingPredictedBase>(response, "response is FundingPredictedBase");
            Assert.NotNull(response.Result);
        }

        [Test]
        public async Task FundingPredictedAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfFundingPredictedBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingPredictedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.FundingPredictedAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<FundingPredictedBase>>(response, "response is ApiResponse<FundingPredictedBase>");
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.Result);
        }

        private static readonly string fundingPrevRateJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
        ""symbol"": ""BTCUSD"",
        ""funding_rate"": ""0.00010000"",
        ""funding_rate_timestamp"": 1577433600
    },
    ""ext_info"": null,
    ""time_now"": ""1577445586.446797"",
    ""rate_limit_status"": 119,
    ""rate_limit_reset_ms"": 1577445586454,
    ""rate_limit"": 120
}
";

        [Test]
        public void FundingPrevRate_ParametersAreValid_ShouldReturnFundingPrevRateBase()
        {
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingPrevRateJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.FundingPrevRate(symbol);

            // Assert
            Assert.IsInstanceOf<FundingPrevRateBase>(response, "response is FundingPrevRateBase");
            Assert.NotNull(response.Result);
        }

        [Test]
        public void FundingPrevRateWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfFundingPrevRateBase()
        {
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingPrevRateJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.FundingPrevRateWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<FundingPrevRateBase>>(response, "response is ApiResponse<FundingPrevRateBase>");
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.Result);
        }

        [Test]
        public async Task FundingPrevRateAsync_ParametersAreValid_ShouldReturnFundingPrevRateBase()
        {
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingPrevRateJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.FundingPrevRateAsync(symbol);

            // Assert
            Assert.IsInstanceOf<FundingPrevRateBase>(response, "response is FundingPrevRateBase");
            Assert.NotNull(response.Result);
        }

        [Test]
        public async Task FundingPrevRateAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfFundingPrevRateBase()
        {
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, fundingPrevRateJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.FundingPrevRateAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<FundingPrevRateBase>>(response, "response is ApiResponse<FundingPrevRateBase>");
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.Result);
        }

        //[Test]
        //public void Test()
        //{
        //    var asm = Assembly.GetAssembly(typeof(FundingApi));
        //    var policyType = asm?.GetType("BybitAPI.Api.Util.SnakeCaseNamingPolicy");
        //    var utilType = asm?.GetType("BybitAPI.Api.Util.ApiUtil");
        //    var mi = utilType.GetMethod("GetJsonConverters", BindingFlags.Static | BindingFlags.NonPublic);

        //    var options = new JsonSerializerOptions
        //    {
        //        PropertyNamingPolicy = (JsonNamingPolicy)Activator.CreateInstance(policyType),
        //        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        //        PropertyNameCaseInsensitive = true,
        //    };
        //    foreach (var converter in (IEnumerable<JsonConverter>)mi.Invoke(null, null))
        //    {
        //        options.Converters.Add(converter);
        //    }
        //    var obj = JsonSerializer.Deserialize<FundingPrevRateBase>(fundingPrevRateJson, options);

        //    Assert.IsInstanceOf<FundingPrevRateBase>(obj);
        //}
    }
}