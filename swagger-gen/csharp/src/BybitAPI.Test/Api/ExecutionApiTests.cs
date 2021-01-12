using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing ExecutionApi
    /// </summary>
    [TestFixture]
    public class ExecutionApiTests
    {
        private static ExecutionApi Create()
        {
            var instance = new ExecutionApi();

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
            Assert.IsInstanceOf<ExecutionApi>(instance, "instance is a ExecutionApi");
        }

        private static readonly string executionGetTradesJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""trade_list"": [
            {
                ""closed_size"": 0,
                ""cross_seq"": 277136382,
                ""exec_fee"": ""0.0000001"",
                ""exec_id"": ""256e5ef8-abfe-5772-971b-f944e15e0d68"",
                ""exec_price"": ""8178.5"",
                ""exec_qty"": 1,
                ""exec_time"": ""1571676941.70682"",
                ""exec_type"": ""Trade"",
                ""exec_value"": ""0.00012227"",
                ""fee_rate"": ""0.00075"",
                ""last_liquidity_ind"": ""RemovedLiquidity"",
                ""leaves_qty"": 0,
                ""nth_fill"": 2,
                ""order_id"": ""7ad50cb1-9ad0-4f74-804b-d82a516e1029"",
                ""order_link_id"": """",
                ""order_price"": ""8178"",
                ""order_qty"": 1,
                ""order_type"": ""Market"",
                ""side"": ""Buy"",
                ""symbol"": ""BTCUSD"",
                ""user_id"": 1,
                ""trade_time_ms"": 1577480599000
            }
        ]
    },
    ""time_now"": ""1577483699.281488"",
    ""rate_limit_status"": 118,
    ""rate_limit_reset_ms"": 1577483699244737,
    ""rate_limit"": 120
}
";

        [Test]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 200)]
        public void ExecutionGetTrades_ParametersAreValid_ShouldReturnExecutionGetTradesBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, executionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? orderId = null;
            long? startTime = null;

            // Act
            var response = instance.ExecutionGetTrades(symbol, orderId, startTime, page, limit);

            // Assert
            Assert.IsInstanceOf<ExecutionGetTradesBase>(response, "response is ExecutionGetTradesBase");
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 201)]
        public void ExecutionGetTrades_ParametersAreInvalid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, executionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? orderId = null;
            long? startTime = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.ExecutionGetTrades(symbol, orderId, startTime, page, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 200)]
        public async Task ExecutionGetTradesAsync_ParametersAreValid_ShouldReturnExecutionGetTradesBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, executionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? orderId = null;
            long? startTime = null;

            // Act
            var response = await instance.ExecutionGetTradesAsync(symbol, orderId, startTime, page, limit);

            // Assert
            Assert.IsInstanceOf<ExecutionGetTradesBase>(response, "response is ExecutionGetTradesBase");
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 201)]
        public void ExecutionGetTradesAsync_ParametersAreInvalid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, executionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? orderId = null;
            long? startTime = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.ExecutionGetTradesAsync(symbol, orderId, startTime, page, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 200)]
        public void ExecutionGetTradesWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfExecutionGetTradesBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, executionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? orderId = null;
            long? startTime = null;

            // Act
            var response = instance.ExecutionGetTradesWithHttpInfo(symbol, orderId, startTime, page, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<ExecutionGetTradesBase>>(response, "response is ApiResponse<ExecutionGetTradesBase>");
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 201)]
        public void ExecutionGetTradesWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, executionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? orderId = null;
            long? startTime = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.ExecutionGetTradesWithHttpInfo(symbol, orderId, startTime, page, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 200)]
        public async Task ExecutionGetTradesAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfExecutionGetTradesBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, executionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? orderId = null;
            long? startTime = null;

            // Act
            var response = await instance.ExecutionGetTradesAsyncWithHttpInfo(symbol, orderId, startTime, page, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<ExecutionGetTradesBase>>(response, "response is ApiRepsonse<ExecutionGetTradesBase>");
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 201)]
        public void ExecutionGetTradesAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, executionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? orderId = null;
            long? startTime = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.ExecutionGetTradesAsyncWithHttpInfo(symbol, orderId, startTime, page, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }
    }
}