using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing LinearOrderApi
    /// </summary>
    [TestFixture]
    public class LinearOrderApiTests
    {
        private static LinearOrderApi Create()
        {
            var instance = new LinearOrderApi();

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
        /// Test an instance of LinearOrderApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<LinearOrderApi>(instance, "instance is a LinearOrderApi");
        }

        private static readonly string linearOrderCancelJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""order_id"":""bd1844f-f3c0-4e10-8c25-10fea03763f6"",
    },
    ""time_now"": ""1575112681.814760"",
    ""rate_limit_status"": 98,
    ""rate_limit_reset_ms"": 1580885703683,
    ""rate_limit"": 100
}
";

        [Test]
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, "")]
        public void LinearOrderCancel_ParametersAreValid_ShouldReturnlinearOrderCancelBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearOrderCancel(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<LinearOrderCancelBase>(response, "response is LinearOrderCancelBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearOrderCancel_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearOrderCancel(symbol, orderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, "")]
        public void LinearOrderCancelWithHttpInfo_ParametersAreValid_ShouldReturnlinearOrderCancelBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearOrderCancelWithHttpInfo(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderCancelBase>>(response, "response is ApiResponse<LinearOrderCancelBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearOrderCancelWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearOrderCancelWithHttpInfo(symbol, orderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task LinearOrderCancelAsync_ParametersAreValid_ShouldReturnlinearOrderCancelBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearOrderCancelAsync(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<LinearOrderCancelBase>(response, "response is LinearOrderCancelBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearOrderCancelAsync_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearOrderCancelAsync(symbol, orderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task LinearOrderCancelAsyncWithHttpInfo_ParametersAreValid_ShouldReturnlinearOrderCancelBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearOrderCancelAsyncWithHttpInfo(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderCancelBase>>(response, "response is ApiResponse<LinearOrderCancelBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearOrderCancelAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearOrderCancelAsyncWithHttpInfo(symbol, orderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string linearOrderCancelAllJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        ""89a38056-80f1-45b2-89d3-4d8e3a203a79"",
        ""89a38056-80f1-45b2-89d3-4d8e3a203a79"",
    ],
    ""time_now"": ""1575110339.105675"",
    ""rate_limit_status"": 98,
    ""rate_limit_reset_ms"": 1580885703683,
    ""rate_limit"": 100
}
";

        [Test]
        public void LinearOrderCancelAll_ParametersAreValid_ShouldReturnLinearOrderCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearOrderCancelAll(symbol);

            // Assert
            Assert.IsInstanceOf<LinearOrderCancelAllBase>(response, "response is LinearOrderCancelAllBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearOrderCancelAllWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearOrderCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearOrderCancelAllWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderCancelAllBase>>(response, "response is ApiResponse<LinearOrderCancelAllBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearOrderCancelAllAsync_ParametersAreValid_ShouldReturnLinearOrderCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearOrderCancelAllAsync(symbol);

            // Assert
            Assert.IsInstanceOf<LinearOrderCancelAllBase>(response, "response is LinearOrderCancelAllBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearOrderCancelAllAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearOrderCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearOrderCancelAllAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderCancelAllBase>>(response, "response is ApiResponse<LinearOrderCancelAllBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string linearOrderGetOrdersJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
        ""current_page"": 1,
        ""last_page"": 6,
        ""data"": [
            {
                ""order_id"":""bd1844f-f3c0-4e10-8c25-10fea03763f6"",
                ""user_id"": 1,
                ""symbol"": ""BTCUSDT"",
                ""side"": ""Sell"",
                ""order_type"": ""Limit"",
                ""price"": 8083,
                ""qty"": 10,
                ""time_in_force"": ""GoodTillCancel"",
                ""order_status"": ""New"",
                ""last_exec_price"": 8083,
                ""cum_exec_qty"": 0,
                ""cum_exec_value"": 0,
                ""cum_exec_fee"": 0,
                ""order_link_id"": """",
                ""reduce_only"": false,
                ""close_on_trigger"": false,
                ""created_time"": ""2019-10-21T07:28:19.396246Z"",
                ""updated_time"": ""2019-10-21T07:28:19.396246Z"",
            }
        ]
    },
    ""ext_info"": null,
    ""time_now"": ""1577448922.437871"",
    ""rate_limit_status"": 98,
    ""rate_limit_reset_ms"": 1580885703683,
    ""rate_limit"": 100
}
";

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(50)]
        public void LinearOrderGetOrders_ParametersAreValid_ShouldReturnLinearOrderGetOrdersBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            LinearOrderStatus? orderStatus = null;

            // Act
            var response = instance.LinearOrderGetOrders(symbol, orderId, orderLinkId, order, page, limit, orderStatus);

            // Assert
            Assert.IsInstanceOf<LinearOrderGetOrdersBase>(response, "response is LinearOrderGetOrdersBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(51)]
        public void LinearOrderGetOrders_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            LinearOrderStatus? orderStatus = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearOrderGetOrders(symbol, orderId, orderLinkId, order, page, limit, orderStatus);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(50)]
        public void LinearOrderGetOrdersWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearOrderGetOrdersBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            LinearOrderStatus? orderStatus = null;

            // Act
            var response = instance.LinearOrderGetOrdersWithHttpInfo(symbol, orderId, orderLinkId, order, page, limit, orderStatus);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderGetOrdersBase>>(response, "response is ApiResponse<LinearOrderGetOrdersBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(51)]
        public void LinearOrderGetOrdersWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            LinearOrderStatus? orderStatus = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearOrderGetOrdersWithHttpInfo(symbol, orderId, orderLinkId, order, page, limit, orderStatus);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(50)]
        public async Task LinearOrderGetOrdersAsync_ParametersAreValid_ShouldReturnLinearOrderGetOrdersBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            LinearOrderStatus? orderStatus = null;

            // Act
            var response = await instance.LinearOrderGetOrdersAsync(symbol, orderId, orderLinkId, order, page, limit, orderStatus);

            // Assert
            Assert.IsInstanceOf<LinearOrderGetOrdersBase>(response, "response is LinearOrderGetOrdersBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(51)]
        public void LinearOrderGetOrdersAsync_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            LinearOrderStatus? orderStatus = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearOrderGetOrdersAsync(symbol, orderId, orderLinkId, order, page, limit, orderStatus);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(50)]
        public async Task LinearOrderGetOrdersAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearOrderGetOrdersBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            LinearOrderStatus? orderStatus = null;

            // Act
            var response = await instance.LinearOrderGetOrdersAsyncWithHttpInfo(symbol, orderId, orderLinkId, order, page, limit, orderStatus);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderGetOrdersBase>>(response, "response is ApiResponse<LinearOrderGetOrdersBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(51)]
        public void LinearOrderGetOrdersAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            LinearOrderStatus? orderStatus = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearOrderGetOrdersAsyncWithHttpInfo(symbol, orderId, orderLinkId, order, page, limit, orderStatus);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string linearOrderNewJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""order_id"":""bd1844f-f3c0-4e10-8c25-10fea03763f6"",
        ""user_id"": 1,
        ""symbol"": ""BTCUSDT"",
        ""side"": ""Sell"",
        ""order_type"": ""Limit"",
        ""price"": 8083,
        ""qty"": 10,
        ""time_in_force"": ""GoodTillCancel"",
        ""order_status"": ""New"",
        ""last_exec_price"": 8083,
        ""cum_exec_qty"": 0,
        ""cum_exec_value"": 0,
        ""cum_exec_fee"": 0,
        ""reduce_only"": false,
        ""close_on_trigger"": false,
        ""order_link_id"": """",
        ""created_time"": ""2019-10-21T07:28:19.396246Z"",
        ""updated_time"": ""2019-10-21T07:28:19.396246Z"",
    },
    ""time_now"": ""1575111823.458705"",
    ""rate_limit_status"": 98,
    ""rate_limit_reset_ms"": 1580885703683,
    ""rate_limit"": 100
}
";

        [Test]
        [TestCase(LinearOrderType.Market, null, 0)]
        [TestCase(LinearOrderType.Limit, 0, 0)]
        //[TestCase(LinearOrderType.Market, null, 0.5)]
        //[TestCase(LinearOrderType.Market, null, 1)]
        //[TestCase(LinearOrderType.Market, null, 2)]
        //[TestCase(LinearOrderType.Market, null, 10.5)]
        public void LinearOrderNew_ParametersAreValid_ShouldReturnLinearOrderNewBase(LinearOrderType orderType, decimal? price, decimal qty)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var timeInForce = LinearTimeInForce.FillOrKill;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = instance.LinearOrderNew(side, symbol, orderType, timeInForce, qty, price, takeProfit, stopLoss, reduceOnly, tpTriggerBy, slTriggerBy, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<LinearOrderNewBase>(response, "response is LinearOrderNewBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(LinearOrderType.Limit, null, 0)]
        //[TestCase(LinearOrderType.Market, null, 0.1)]
        //[TestCase(LinearOrderType.Market, null, 0.15)]
        public void LinearOrderNew_ParametersAreInvalid_ShouldRaiseApiException(LinearOrderType orderType, decimal? price, decimal qty)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var timeInForce = LinearTimeInForce.FillOrKill;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearOrderNew(side, symbol, orderType, timeInForce, qty, price, takeProfit, stopLoss, reduceOnly, tpTriggerBy, slTriggerBy, closeOnTrigger, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(LinearOrderType.Market, null)]
        [TestCase(LinearOrderType.Limit, 0)]
        public void LinearOrderNewWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearOrderNewBase(LinearOrderType orderType, decimal? price)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var timeInForce = LinearTimeInForce.FillOrKill;
            var qty = 0m;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = instance.LinearOrderNewWithHttpInfo(side, symbol, orderType, timeInForce, qty, price, takeProfit, stopLoss, reduceOnly, tpTriggerBy, slTriggerBy, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderNewBase>>(response, "response is LinearOrderNewBase");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(LinearOrderType.Limit, null)]
        public void LinearOrderNewWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(LinearOrderType orderType, decimal? price)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var timeInForce = LinearTimeInForce.FillOrKill;
            var qty = 0m;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearOrderNewWithHttpInfo(side, symbol, orderType, timeInForce, qty, price, takeProfit, stopLoss, reduceOnly, tpTriggerBy, slTriggerBy, closeOnTrigger, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(LinearOrderType.Market, null)]
        [TestCase(LinearOrderType.Limit, 0)]
        public async Task LinearOrderNewAsync_ParametersAreValid_ShouldReturnLinearOrderNewBase(LinearOrderType orderType, decimal? price)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var timeInForce = LinearTimeInForce.FillOrKill;
            var qty = 0m;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = await instance.LinearOrderNewAsync(side, symbol, orderType, timeInForce, qty, price, takeProfit, stopLoss, reduceOnly, tpTriggerBy, slTriggerBy, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<LinearOrderNewBase>(response, "response is LinearOrderNewBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(LinearOrderType.Limit, null)]
        public void LinearOrderNewAsync_ParametersAreInvalid_ShouldRaiseApiException(LinearOrderType orderType, decimal? price)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var timeInForce = LinearTimeInForce.FillOrKill;
            var qty = 0m;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearOrderNewAsync(side, symbol, orderType, timeInForce, qty, price, takeProfit, stopLoss, reduceOnly, tpTriggerBy, slTriggerBy, closeOnTrigger, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(LinearOrderType.Market, null)]
        [TestCase(LinearOrderType.Limit, 0)]
        public async Task LinearOrderNewAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearOrderNewBase(LinearOrderType orderType, decimal? price)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var timeInForce = LinearTimeInForce.FillOrKill;
            var qty = 0m;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = await instance.LinearOrderNewAsyncWithHttpInfo(side, symbol, orderType, timeInForce, qty, price, takeProfit, stopLoss, reduceOnly, tpTriggerBy, slTriggerBy, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderNewBase>>(response, "response is LinearOrderNewBase");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(LinearOrderType.Limit, null)]
        public void LinearOrderAsyncNewWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(LinearOrderType orderType, decimal? price)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var timeInForce = LinearTimeInForce.FillOrKill;
            var qty = 0m;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearOrderNewAsyncWithHttpInfo(side, symbol, orderType, timeInForce, qty, price, takeProfit, stopLoss, reduceOnly, tpTriggerBy, slTriggerBy, closeOnTrigger, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        //Note: Comparing with the actual response, it seems that the 'Response Example' in the documentation is not maintained.
        // In the actual response, the fields below 'stop_loss' are present, but not in the documentation.
        private static readonly string linearOrderQueryJsonById = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""order_id"": ""e3f7662b-8b94-42e2-8d46-dead09dd2a52"",
        ""user_id"": 106958,
        ""symbol"": ""BTCUSDT"",
        ""side"": ""Sell"",
        ""order_type"": ""Market"",
        ""price"": 11775,
        ""qty"": 0.001,
        ""time_in_force"": ""ImmediateOrCancel"",
        ""order_status"": ""Filled"",
        ""last_exec_price"": 11874.5,
        ""cum_exec_qty"": 0.001,
        ""cum_exec_value"": 11.8745,
        ""cum_exec_fee"": 0.00890588,
        ""order_link_id"": """",
        ""reduce_only"": false,
        ""close_on_trigger"": false,
        ""created_time"": ""2020-08-10T19:28:56Z"",
        ""updated_time"": ""2020-08-10T19:28:57Z""
    },
    ""time_now"": ""1597171508.869341"",
    ""rate_limit_status"": 598,
    ""rate_limit_reset_ms"": 1597171508867,
    ""rate_limit"": 600
}
";

        [Test]
        public void LinearOrderQuery_ParametersAreValid_ShouldeReturnLinearOrderQueryBaseOfLinearOrderQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderQueryJsonById);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;

            // Act
            var response = instance.LinearOrderQuery(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<LinearOrderQueryBase<LinearOrderQueryRes>>(response, "response is LinearOrderQueryBase<LinearOrderQueryRes>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearOrderQueryWithHttpInfo_ParametersAreValid_ShouldeReturnApiResponseOfLinearOrderQueryBaseOfLinearOrderQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderQueryJsonById);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;

            // Act
            var response = instance.LinearOrderQueryWithHttpInfo(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderQueryBase<LinearOrderQueryRes>>>(response, "response is ApiResponse<LinearOrderQueryBase<LinearOrderQueryRes>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearOrderQueryAsync_ParametersAreValid_ShouldeReturnLinearOrderQueryBaseOfLinearOrderQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderQueryJsonById);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;

            // Act
            var response = await instance.LinearOrderQueryAsync(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<LinearOrderQueryBase<LinearOrderQueryRes>>(response, "response is LinearOrderQueryBase<LinearOrderQueryRes>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearOrderQueryAsyncWithHttpInfo_ParametersAreValid_ShouldeReturnApiResponseOfLinearOrderQueryBaseOfLinearOrderQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderQueryJsonById);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;

            // Act
            var response = await instance.LinearOrderQueryAsyncWithHttpInfo(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderQueryBase<LinearOrderQueryRes>>>(response, "response is ApiResponse<LinearOrderQueryBase<LinearOrderQueryRes>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        //Note: The 'close_on_trigger' field is missing in the 'Response Example' of the documentation.
        private static readonly string linearOrderQueryJsonBySymbol = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        {
            ""order_id"": ""6449d89e-6ef5-4f54-a065-12b2744de0ae"",
            ""user_id"": 118921,
            ""symbol"": ""LINKUSDT"",
            ""side"": ""Buy"",
            ""order_type"": ""Limit"",
            ""price"": 9,
            ""qty"": 0.1,
            ""time_in_force"": ""GoodTillCancel"",
            ""order_status"": ""New"",
            ""last_exec_price"": 11874.5,
            ""cum_exec_qty"": 0.005,
            ""cum_exec_value"": 11.8745,
            ""cum_exec_fee"": 0.00890588,
            ""order_link_id"": """",
            ""reduce_only"": false,
            ""close_on_trigger"": false,
            ""created_time"": ""2020-11-27T08:25:44Z"",
            ""updated_time"": ""2020-11-27T08:25:44Z"",
            ""take_profit"": 0,
            ""stop_loss"": 0,
            ""tp_trigger_by"": ""UNKNOWN"",
            ""sl_trigger_by"": ""UNKNOWN""
        },
        {
            ""order_id"": ""6d4dc4e0-b4e3-4fc5-a92d-3d693bdff4a5"",
            ""user_id"": 118921,
            ""symbol"": ""LINKUSDT"",
            ""side"": ""Buy"",
            ""order_type"": ""Limit"",
            ""price"": 8.2,
            ""qty"": 9999,
            ""time_in_force"": ""GoodTillCancel"",
            ""order_status"": ""New"",
            ""last_exec_price"": 11888.5,
            ""cum_exec_qty"": 0.004,
            ""cum_exec_value"": 11.8745,
            ""cum_exec_fee"": 0.00890588,
            ""order_link_id"": """",
            ""reduce_only"": false,
            ""close_on_trigger"": false,
            ""created_time"": ""2020-11-23T09:19:49Z"",
            ""updated_time"": ""2020-11-23T09:20:31Z"",
            ""take_profit"": 0,
            ""stop_loss"": 0,
            ""tp_trigger_by"": ""UNKNOWN"",
            ""sl_trigger_by"": ""UNKNOWN""
        }
    ],
    ""time_now"": ""1606465563.551193"",
    ""rate_limit_status"": 599,
    ""rate_limit_reset_ms"": 1606465563547,
    ""rate_limit"": 600
}
";

        [Test]
        public void LinearOrderQuery_ParametersAreValid_ShouldeReturnLinearOrderQueryBaseOfListOfLinearOrderQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearOrderQuery(symbol);

            // Assert
            Assert.IsInstanceOf<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>>(response, "response is LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearOrderQueryWithHttpInfo_ParametersAreValid_ShouldeReturnApiResponseOfLinearOrderQueryBaseOfListOfLinearOrderQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearOrderQueryWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>>>(response, "response is ApiResponse<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearOrderQueryAsync_ParametersAreValid_ShouldeReturnLinearOrderQueryBaseOfListOfLinearOrderQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearOrderQueryAsync(symbol);

            // Assert
            Assert.IsInstanceOf<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>>(response, "response is LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearOrderQueryAsyncWithHttpInfo_ParametersAreValid_ShouldeReturnApiResponseOfLinearOrderQueryBaseOfListOfLinearOrderQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearOrderQueryAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>>>(response, "response is ApiResponse<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string linearOrderReplaceJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
        ""order_id"": ""efa44157-c355-4a98-b6d6-1d846a936b93""
    },
    ""time_now"": ""1539778407.210858"",
    ""rate_limit_status"": 99,
    ""rate_limit_reset_ms"": 1580885703683,
    ""rate_limit"": 100
}
";

        [Test]
        public void LinearOrderReplace_ParametersAreValid_ShouldReturnLinearOrderReplaceBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            decimal? pRQty = null;
            decimal? pRPrice = null;

            // Act
            var response = instance.LinearOrderReplace(symbol, orderId, orderLinkId, pRQty, pRPrice);

            // Assert
            Assert.IsInstanceOf<LinearOrderReplaceBase>(response, "response is LinearOrderReplaceBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearOrderReplaceWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearOrderReplaceBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            decimal? pRQty = null;
            decimal? pRPrice = null;

            // Act
            var response = instance.LinearOrderReplaceWithHttpInfo(symbol, orderId, orderLinkId, pRQty, pRPrice);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderReplaceBase>>(response, "response is ApiResponse<LinearOrderReplaceBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearOrderReplaceAsync_ParametersAreValid_ShouldReturnLinearOrderReplaceBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            decimal? pRQty = null;
            decimal? pRPrice = null;

            // Act
            var response = await instance.LinearOrderReplaceAsync(symbol, orderId, orderLinkId, pRQty, pRPrice);

            // Assert
            Assert.IsInstanceOf<LinearOrderReplaceBase>(response, "response is LinearOrderReplaceBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearOrderReplaceAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearOrderReplaceBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearOrderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? orderId = null;
            string? orderLinkId = null;
            decimal? pRQty = null;
            decimal? pRPrice = null;

            // Act
            var response = await instance.LinearOrderReplaceAsyncWithHttpInfo(symbol, orderId, orderLinkId, pRQty, pRPrice);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearOrderReplaceBase>>(response, "response is ApiResponse<LinearOrderReplaceBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }
    }
}