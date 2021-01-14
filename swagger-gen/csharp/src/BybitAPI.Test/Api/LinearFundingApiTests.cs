using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing LinearFundingApi
    /// </summary>
    [TestFixture]
    public class LinearFundingApiTests
    {
        private static LinearFundingApi Create()
        {
            var instance = new LinearFundingApi();

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
        /// Test an instance of LinearFundingApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<LinearFundingApi>(instance, "instance is a LinearFundingApi");
        }

        private static readonly string linearFundingMyLastFeeJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""symbol"": ""BTCUSDT"",
        ""side"": ""Buy"",
        ""size"": 3.13,
        ""funding_rate"": 0.0001,
        ""exec_fee"": 1.868923,
        ""exec_time"": ""2020-04-13T08:00:00.000Z""
    },
    ""time_now"": ""1586780352.867171"",
    ""rate_limit_status"": 119,
    ""rate_limit_reset_ms"": 1586780352864,
    ""rate_limit"": 120
}
";

        [Test]
        public void LinearFundingMyLastFee_ParametersAreValid_ShouldReturnLinearFundingMyLastFeeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingMyLastFeeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearFundingMyLastFee(symbol);

            // Assert
            Assert.IsInstanceOf<LinearFundingMyLastFeeBase>(response, "response is LinearFundingMyLastFeeBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearFundingMyLastFee_ParametersAreValid_ShouldReturnApiResponseOfLinearFundingMyLastFeeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingMyLastFeeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearFundingMyLastFeeWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearFundingMyLastFeeBase>>(response, "response is ApiResponse<LinearFundingMyLastFeeBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearFundingMyLastFeeAsync_ParametersAreValid_ShouldReturnLinearFundingMyLastFeeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingMyLastFeeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearFundingMyLastFeeAsync(symbol);

            // Assert
            Assert.IsInstanceOf<LinearFundingMyLastFeeBase>(response, "response is LinearFundingMyLastFeeBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearFundingMyLastFeeAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearFundingMyLastFeeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingMyLastFeeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearFundingMyLastFeeAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearFundingMyLastFeeBase>>(response, "response is ApiResponse<LinearFundingMyLastFeeBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string linearFundingPredictedJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""predicted_funding_rate"": -0.00375,
        ""predicted_funding_fee"": 0.13081256
    },
    ""time_now"": ""1587035697.424492"",
    ""rate_limit_status"": 119,
    ""rate_limit_reset_ms"": 1587035697422,
    ""rate_limit"": 120
}
";

        [Test]
        public void LinearFundingPredicted_ParametersAreValid_ShouldReturnLinearFundingPredictedBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingPredictedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearFundingPredicted(symbol);

            // Assert
            Assert.IsInstanceOf<LinearFundingPredictedBase>(response, "response is LinearFundingPredictedBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearFundingPredictedWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearFundingPredictedBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingPredictedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearFundingPredictedWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearFundingPredictedBase>>(response, "response is ApiResponse<LinearFundingPredictedBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearFundingPredictedAsync_ParametersAreValid_ShouldReturnLinearFundingPredictedBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingPredictedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearFundingPredictedAsync(symbol);

            // Assert
            Assert.IsInstanceOf<LinearFundingPredictedBase>(response, "response is LinearFundingPredictedBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearFundingPredictedAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearFundingPredictedBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingPredictedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearFundingPredictedAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearFundingPredictedBase>>(response, "response is ApiResponse<LinearFundingPredictedBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string linearFundingPrevRateJson = @"
{
    ""ret_code"":0,
    ""ret_msg"":""OK"",
    ""ext_code"":"""",
    ""ext_info"":"""",
    ""result"":{
        ""symbol"":""BTCUSDT"",
        ""funding_rate"":-0.00005965,
        ""funding_rate_timestamp"":""2020-04-07T08:00:00.000Z""
    },
    ""time_now"":""1586251109.454281""
}
";

        [Test]
        public void LinearFundingPrevRate_ParametersAreValid_ShouldReturnLinearFundingPrevRateBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingPrevRateJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearFundingPrevRate(symbol);

            Assert.IsInstanceOf<LinearFundingPrevRateBase>(response, "response is LinearFundingPrevRateBase");
        }

        [Test]
        public void LinearFundingPrevRateWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearFundingPrevRateBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingPrevRateJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearFundingPrevRateWithHttpInfo(symbol);

            Assert.IsInstanceOf<ApiResponse<LinearFundingPrevRateBase>>(response, "response is ApiResponse<LinearFundingPrevRateBase>");
        }

        [Test]
        public async Task LinearFundingPrevRateAsync_ParametersAreValid_ShouldReturnLinearFundingPrevRateBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingPrevRateJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearFundingPrevRateAsync(symbol);

            Assert.IsInstanceOf<LinearFundingPrevRateBase>(response, "response is LinearFundingPrevRateBase");
        }

        [Test]
        public async Task LinearFundingPrevRateAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearFundingPrevRateBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearFundingPrevRateJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearFundingPrevRateAsyncWithHttpInfo(symbol);

            Assert.IsInstanceOf<ApiResponse<LinearFundingPrevRateBase>>(response, "response is ApiResponse<LinearFundingPrevRateBase>");
        }
    }
}