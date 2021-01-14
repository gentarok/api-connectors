using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing LinearExecutionApi
    /// </summary>
    [TestFixture]
    public class LinearExecutionApiTests
    {
        private static LinearExecutionApi Create()
        {
            var instance = new LinearExecutionApi();

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
        /// Test an instance of LinearExecutionApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<LinearExecutionApi>(instance, "instance is a LinearExecutionApi");
        }

        private static readonly string linearExecutionGetTradesJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""current_page"": 1,
        ""data"": [
            {
                ""order_id"": ""7369b2f4-52f1-4698-abf7-368e4ba9aefa"",
                ""order_link_id"": """",
                ""side"": ""Buy"",
                ""symbol"": ""BTCUSDT"",
                ""exec_id"": ""9b8216fa-98d7-55c0-b5fa-279db5727996"",
                ""price"": 5894,
                ""order_price"": 5894,
                ""order_qty"": 0.001,
                ""order_type"": ""Limit"",
                ""fee_rate"": 0.00075,
                ""exec_price"": 5894,
                ""exec_type"": ""Trade"",
                ""exec_qty"": 0.001,
                ""exec_fee"": 0.0044205,
                ""exec_value"": 5.894,
                ""leaves_qty"": 0,
                ""closed_size"": 0,
                ""last_liquidity_ind"": ""RemovedLiquidity"",
                ""trade_time"": 1585547384,
                ""trade_time_ms"": 1585547384847
            }
        ]
    },
    ""time_now"": ""1577480599.097287"",
    ""rate_limit_status"": 119,
    ""rate_limit_reset_ms"": 1580885703683,
    ""rate_limit"": 120
}
";

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(200)]
        public void LinearExecutionGetTrades_ParametersAreValid_ShouldReturnLinearExecutionGetTradesBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearExecutionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            LinearExecType? execType = null;
            int? page = null;

            // Act
            var response = instance.LinearExecutionGetTrades(symbol, startTime, endTime, execType, page, limit);

            // Assert
            Assert.IsInstanceOf<LinearExecutionGetTradesBase>(response, "response is LinearExecutionGetTradesBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(201)]
        public void LinearExecutionGetTrades_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearExecutionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            LinearExecType? execType = null;
            int? page = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearExecutionGetTrades(symbol, startTime, endTime, execType, page, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(200)]
        public void LinearExecutionGetTradesWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearExecutionGetTradesBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearExecutionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            LinearExecType? execType = null;
            int? page = null;

            // Act
            var response = instance.LinearExecutionGetTradesWithHttpInfo(symbol, startTime, endTime, execType, page, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearExecutionGetTradesBase>>(response, "response is ApiResponse<LinearExecutionGetTradesBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(201)]
        public void LinearExecutionGetTradesWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearExecutionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            LinearExecType? execType = null;
            int? page = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearExecutionGetTradesWithHttpInfo(symbol, startTime, endTime, execType, page, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(200)]
        public async Task LinearExecutionGetTradesAsync_ParametersAreValid_ShouldReturnLinearExecutionGetTradesBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearExecutionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            LinearExecType? execType = null;
            int? page = null;

            // Act
            var response = await instance.LinearExecutionGetTradesAsync(symbol, startTime, endTime, execType, page, limit);

            // Assert
            Assert.IsInstanceOf<LinearExecutionGetTradesBase>(response, "response is LinearExecutionGetTradesBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(201)]
        public void LinearExecutionGetTradesAsync_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearExecutionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            LinearExecType? execType = null;
            int? page = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearExecutionGetTradesAsync(symbol, startTime, endTime, execType, page, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(200)]
        public async Task LinearExecutionGetTradesAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearExecutionGetTradesBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearExecutionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            LinearExecType? execType = null;
            int? page = null;

            // Act
            var response = await instance.LinearExecutionGetTradesAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearExecutionGetTradesBase>>(response, "response is ApiResponse<LinearExecutionGetTradesBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(201)]
        public void LinearExecutionGetTradesAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearExecutionGetTradesJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            LinearExecType? execType = null;
            int? page = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearExecutionGetTradesAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }
    }
}