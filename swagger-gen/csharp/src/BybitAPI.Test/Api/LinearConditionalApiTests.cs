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
    ///  Class for testing LinearConditionalApi
    /// </summary>
    [TestFixture]
    public class LinearConditionalApiTests
    {
        private static LinearConditionalApi Create()
        {
            var instance = new LinearConditionalApi();

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
        /// Test an instance of LinearConditionalApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<LinearConditionalApi>(instance, "instance is a LinearConditionalApi");
        }

        private static readonly string linearConditionalCancelJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
         ""stop_order_id"":""bd1844f-f3c0-4e10-8c25-10fea03763f6"",
    },
    ""ext_info"": null,
    ""time_now"": ""1577452218.567120"",
    ""rate_limit_status"": 97,
    ""rate_limit_reset_ms"": 1577452218573,
    ""rate_limit"": ""100""
}
";

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        public void LinearConditionalCancel_ParametersAreValid_ShouldReturnLinearConditionalCancelBase(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearConditionalCancel(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<LinearConditionalCancelBase>(response, "response is LinearConditionalCancelBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalCancel_ParametersAreInvalid_ShouldRaiseApiException(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearConditionalCancel(symbol, stopOrderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        public void LinearConditionalCancelWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalCancelBase(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearConditionalCancelWithHttpInfo(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalCancelBase>>(response, "response is ApiResponse<LinearConditionalCancelBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalCancelWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearConditionalCancelWithHttpInfo(symbol, stopOrderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task LinearConditionalCancelAsync_ParametersAreValid_ShouldReturnLinearConditionalCancelBase(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearConditionalCancelAsync(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<LinearConditionalCancelBase>(response, "response is LinearConditionalCancelBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalCancelAsync_ParametersAreInvalid_ShouldRaiseApiException(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearConditionalCancelAsync(symbol, stopOrderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task LinearConditionalCancelAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalCancelBase(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearConditionalCancelAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalCancelBase>>(response, "response is ApiResponse<LinearConditionalCancelBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalCancelAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearConditionalCancelAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string linearConditionalCancelAllJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        ""89a38056-80f1-45b2-89d3-4d8e3a203a79"",
        ""89a38056-80f1-45b2-89d3-4d8e3a203a79"",
    ],
    ""time_now"": ""1577454993.799912"",
    ""rate_limit_status"": 90,
    ""rate_limit_reset_ms"": 1580885703683,
    ""rate_limit"": 100
}
";

        [Test]
        public void LinearConditionalCancelAll_ParametersAreValid_ShouldReturnLinearConditionalCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;
            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearConditionalCancelAll(symbol);

            // Assert
            Assert.IsInstanceOf<LinearConditionalCancelAllBase>(response, "response is LinearConditionalCancelAllBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearConditionalCancelAllWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;
            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearConditionalCancelAllWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalCancelAllBase>>(response, "response is ApiResponse<LinearConditionalCancelAllBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearConditionalCancelAllAsync_ParametersAreValid_ShouldReturnLinearConditionalCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;
            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearConditionalCancelAllAsync(symbol);

            // Assert
            Assert.IsInstanceOf<LinearConditionalCancelAllBase>(response, "response is LinearConditionalCancelAllBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearConditionalCancelAllAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;
            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearConditionalCancelAllAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalCancelAllBase>>(response, "response is ApiResponse<LinearConditionalCancelAllBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string linearConditionalGetOrdersJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
        ""current_page"": 1,
        ""last_page"": 1,
        ""data"": [
            {
                 ""stop_order_id"":""bd1844f-f3c0-4e10-8c25-10fea03763f6"",
                 ""user_id"": 1,
                 ""symbol"": ""BTCUSDT"",
                 ""side"": ""Sell"",
                 ""order_type"": ""Limit"",
                 ""price"": 8083,
                 ""qty"": 10,
                 ""time_in_force"": ""GoodTillCancel"",
                 ""order_status"": ""New"",
                 ""trigger_price"": 8003,
                 ""order_link_id"": """",
                 ""created_time"": ""2019-10-21T07:28:19.396246Z"",
                 ""updated_time"": ""2019-10-21T07:28:19.396246Z"",
                 ""take_profit"": 0,
                 ""stop_loss"": 0,
                 ""tp_trigger_by"": ""UNKNOWN"",
                 ""sl_trigger_by"": ""UNKNOWN"",
                 ""base_price"": ""16100.0000"",
                 ""trigger_by"": ""LastPrice"",
            },
            {
                 ""stop_order_id"":""bd1844f-f3c0-4e10-8c25-10fea03763f6"",
                 ""user_id"": 1,
                 ""symbol"": ""BTCUSDT"",
                 ""side"": ""Sell"",
                 ""order_type"": ""Limit"",
                 ""price"": 8083,
                 ""qty"": 10,
                 ""time_in_force"": ""GoodTillCancel"",
                 ""order_status"": ""New"",
                 ""trigger_price"": 8003,
                 ""order_link_id"": """",
                 ""created_time"": ""2019-10-21T07:28:19.396246Z"",
                 ""updated_time"": ""2019-10-21T07:28:19.396246Z"",
                 ""take_profit"": 0,
                 ""stop_loss"": 0,
                 ""tp_trigger_by"": ""UNKNOWN"",
                 ""sl_trigger_by"": ""UNKNOWN"",
                 ""base_price"": ""16100.0000"",
                 ""trigger_by"": ""LastPrice"",
                 ""reduce_only"": false,
                 ""close_on_trigger"": false,
            }
        ]
    },
    ""ext_info"": null,
    ""time_now"": ""1577451658.755468"",
    ""rate_limit_status"": 599,
    ""rate_limit_reset_ms"": 1577451658762,
    ""rate_limit"": 600
}
";

        [Test]
        public void LinearConditionalGetOrders_ParametersAreValid_SholudReturnLinearConditionalGetOrdersBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? stopOrderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            int? limit = null;
            LinearStopOrderStatus? stopOrderStatus = null;

            // Act
            var response = instance.LinearConditionalGetOrders(symbol, stopOrderId, orderLinkId, order, page, limit, stopOrderStatus);

            // Assert
            Assert.IsInstanceOf<LinearConditionalGetOrdersBase>(response, "response is LinearConditionalGetOrdersBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearConditionalGetOrdersWithHttpInfo_ParametersAreValid_SholudReturnApiResponseOfLinearConditionalGetOrdersBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? stopOrderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            int? limit = null;
            LinearStopOrderStatus? stopOrderStatus = null;

            // Act
            var response = instance.LinearConditionalGetOrdersWithHttpInfo(symbol, stopOrderId, orderLinkId, order, page, limit, stopOrderStatus);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalGetOrdersBase>>(response, "response is ApiResponse<LinearConditionalGetOrdersBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearConditionalGetOrdersAsync_ParametersAreValid_SholudReturnLinearConditionalGetOrdersBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? stopOrderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            int? limit = null;
            LinearStopOrderStatus? stopOrderStatus = null;

            // Act
            var response = await instance.LinearConditionalGetOrdersAsync(symbol, stopOrderId, orderLinkId, order, page, limit, stopOrderStatus);

            // Assert
            Assert.IsInstanceOf<LinearConditionalGetOrdersBase>(response, "response is LinearConditionalGetOrdersBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearConditionalGetOrdersAsyncWithHttpInfo_ParametersAreValid_SholudReturnApiResponseOfLinearConditionalGetOrdersBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            string? stopOrderId = null;
            string? orderLinkId = null;
            LinearOrder? order = null;
            int? page = null;
            int? limit = null;
            LinearStopOrderStatus? stopOrderStatus = null;

            // Act
            var response = await instance.LinearConditionalGetOrdersAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId, order, page, limit, stopOrderStatus);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalGetOrdersBase>>(response, "response is ApiResponse<LinearConditionalGetOrdersBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string linearConditionalNewJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
       ""stop_order_id"":""bd1844f-f3c0-4e10-8c25-10fea03763f6"",
       ""user_id"": 1,
       ""symbol"": ""BTCUSDT"",
       ""side"": ""Sell"",
       ""order_type"": ""Limit"",
       ""price"": 8083,
       ""qty"": 10,
       ""time_in_force"": ""GoodTillCancel"",
       ""order_status"": ""New"",
       ""base_price"": ""16100.0000"",
       ""trigger_by"": ""LastPrice"",
       ""trigger_price"": 8003,
       ""order_link_id"": """",
       ""reduce_only"": false,
       ""close_on_trigger"": false,
       ""created_time"": ""2019-10-21T07:28:19.396246Z"",
       ""updated_time"": ""2019-10-21T07:28:19.396246Z"",
       ""tp_trigger_by"": ""UNKNOWN"",
       ""sl_trigger_by"": ""UNKNOWN"",
    },
    ""ext_info"": null,
    ""time_now"": ""1577450904.327654"",
    ""rate_limit_status"": 99,
    ""rate_limit_reset_ms"": 1577450904335,
    ""rate_limit"": ""100""
}
";

        [Test]
        public void LinearConditionalNew_ParametersAreValid_ShouldReturnLinearConditionalNewOrderBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var orderType = LinearOrderType.Limit;
            var qty = 0;
            var basePrice = 0m;
            var stopPx = 0m;
            var timeInForce = LinearTimeInForce.FillOrKill;
            decimal? price = null;
            LinearTriggerPriceType? triggerBy = null;
            bool? reduceOnly = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;

            // Act
            var response = instance.LinearConditionalNew(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, reduceOnly, closeOnTrigger, orderLinkId, takeProfit, stopLoss, tpTriggerBy, slTriggerBy);

            // Assert
            Assert.IsInstanceOf<LinearConditionalNewOrderBase>(response, "response is LinearConditionalNewOrderBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearConditionalNewWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalNewOrderBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var orderType = LinearOrderType.Limit;
            var qty = 0;
            var basePrice = 0m;
            var stopPx = 0m;
            var timeInForce = LinearTimeInForce.FillOrKill;
            decimal? price = null;
            LinearTriggerPriceType? triggerBy = null;
            bool? reduceOnly = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;

            // Act
            var response = instance.LinearConditionalNewWithHttpInfo(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, reduceOnly, closeOnTrigger, orderLinkId, takeProfit, stopLoss, tpTriggerBy, slTriggerBy);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalNewOrderBase>>(response, "response is ApiResponse<LinearConditionalNewOrderBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearConditionalNewAsync_ParametersAreValid_ShouldReturnLinearConditionalNewOrderBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var orderType = LinearOrderType.Limit;
            var qty = 0;
            var basePrice = 0m;
            var stopPx = 0m;
            var timeInForce = LinearTimeInForce.FillOrKill;
            decimal? price = null;
            LinearTriggerPriceType? triggerBy = null;
            bool? reduceOnly = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;

            // Act
            var response = await instance.LinearConditionalNewAsync(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, reduceOnly, closeOnTrigger, orderLinkId, takeProfit, stopLoss, tpTriggerBy, slTriggerBy);

            // Assert
            Assert.IsInstanceOf<LinearConditionalNewOrderBase>(response, "response is LinearConditionalNewOrderBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearConditionalNewAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalNewOrderBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = LinearSide.Buy;
            var symbol = LinearSymbol.BCHUSDT;
            var orderType = LinearOrderType.Limit;
            var qty = 0;
            var basePrice = 0m;
            var stopPx = 0m;
            var timeInForce = LinearTimeInForce.FillOrKill;
            decimal? price = null;
            LinearTriggerPriceType? triggerBy = null;
            bool? reduceOnly = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;

            // Act
            var response = await instance.LinearConditionalNewAsyncWithHttpInfo(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, reduceOnly, closeOnTrigger, orderLinkId, takeProfit, stopLoss, tpTriggerBy, slTriggerBy);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalNewOrderBase>>(response, "response is ApiResponse<LinearConditionalNewOrderBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string linearConditionalQueryJsonBySymbol = @"
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
        [TestCase("", null)]
        [TestCase(null, "")]
        public void LinearConditionalQuery_ParametersAreValid_ShouldReturnLinearConditionalQueryBaseOfLinearConditionalQueryRes(string stopOrderId, string orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearConditionalQuery(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<LinearConditionalQueryBase<LinearConditionalQueryRes>>(response, "response is LinearConditionalQueryBase<LinearConditionalQueryRes>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalQuery_ParametersAreInvalid_ShouldRaiseApiException(string stopOrderId, string orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearConditionalQuery(symbol, stopOrderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        public void LinearConditionalQueryWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalQueryBaseOfLinearConditionalQueryRes(string stopOrderId, string orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearConditionalQueryWithHttpInfo(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalQueryBase<LinearConditionalQueryRes>>>(response, "response is ApiResponse<LinearConditionalQueryBase<LinearConditionalQueryRes>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalQueryWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string stopOrderId, string orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearConditionalQueryWithHttpInfo(symbol, stopOrderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task LinearConditionalQueryAsync_ParametersAreValid_ShouldReturnLinearConditionalQueryBaseOfLinearConditionalQueryRes(string stopOrderId, string orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearConditionalQueryAsync(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<LinearConditionalQueryBase<LinearConditionalQueryRes>>(response, "response is LinearConditionalQueryBase<LinearConditionalQueryRes>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalQueryAsync_ParametersAreInvalid_ShouldRaiseApiException(string stopOrderId, string orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearConditionalQueryAsync(symbol, stopOrderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task LinearConditionalQueryAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalQueryBaseOfLinearConditionalQueryRes(string stopOrderId, string orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearConditionalQueryAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalQueryBase<LinearConditionalQueryRes>>>(response, "response is ApiResponse<LinearConditionalQueryBase<LinearConditionalQueryRes>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalQueryAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string stopOrderId, string orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearConditionalQueryAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string linearConditionalQueryJson = @"
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
        public void LinearConditionalQuery_ParametersAreValid_ShouldReturnLinearConditionalQueryBaseOfIReadOnlyListOfLinearConditionalQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearConditionalQuery(symbol);

            // Assert
            Assert.IsInstanceOf<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>>(response, "response is LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearConditionalQueryWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalQueryBaseOfIReadOnlyListOfLinearConditionalQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearConditionalQueryWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>>>(response, "response is ApiResponse<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearConditionalQueryAsync_ParametersAreValid_ShouldReturnLinearConditionalQueryBaseOfIReadOnlyListOfLinearConditionalQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearConditionalQueryAsync(symbol);

            // Assert
            Assert.IsInstanceOf<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>>(response, "response is LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearConditionalQueryAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalQueryBaseOfIReadOnlyListOfLinearConditionalQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalQueryJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearConditionalQueryAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>>>(response, "response is ApiResponse<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string linearConditionalReplaceJson = @"
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
        [TestCase("", null)]
        [TestCase(null, "")]
        public void LinearConditionalReplace_ParametersAreValid_ShouldReturnLinearConditionalReplaceBase(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            decimal? pRQty = null;
            decimal? pRPrice = null;
            decimal? pRTriggerPrice = null;

            // Act
            var response = instance.LinearConditionalReplace(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);

            // Assert
            Assert.IsInstanceOf<LinearConditionalReplaceBase>(response, "response is LinearConditionalReplaceBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalReplace_ParametersAreInvalid_ShoulRaiseApiException(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            decimal? pRQty = null;
            decimal? pRPrice = null;
            decimal? pRTriggerPrice = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearConditionalReplace(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        public void LinearConditionalReplace_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalReplaceBase(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            decimal? pRQty = null;
            decimal? pRPrice = null;
            decimal? pRTriggerPrice = null;

            // Act
            var response = instance.LinearConditionalReplaceWithHttpInfo(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalReplaceBase>>(response, "response is ApiResponse<LinearConditionalReplaceBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalReplaceWithHttpInfo_ParametersAreInvalid_ShoulRaiseApiException(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            decimal? pRQty = null;
            decimal? pRPrice = null;
            decimal? pRTriggerPrice = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearConditionalReplaceWithHttpInfo(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task LinearConditionalReplaceAsync_ParametersAreValid_ShouldReturnLinearConditionalReplaceBase(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            decimal? pRQty = null;
            decimal? pRPrice = null;
            decimal? pRTriggerPrice = null;

            // Act
            var response = await instance.LinearConditionalReplaceAsync(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);

            // Assert
            Assert.IsInstanceOf<LinearConditionalReplaceBase>(response, "response is LinearConditionalReplaceBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalReplaceAsync_ParametersAreInvalid_ShoulRaiseApiException(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            decimal? pRQty = null;
            decimal? pRPrice = null;
            decimal? pRTriggerPrice = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearConditionalReplaceAsync(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task LinearConditionalReplaceAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearConditionalReplaceBase(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            decimal? pRQty = null;
            decimal? pRPrice = null;
            decimal? pRTriggerPrice = null;

            // Act
            var response = await instance.LinearConditionalReplaceAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearConditionalReplaceBase>>(response, "response is ApiResponse<LinearConditionalReplaceBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void LinearConditionalReplaceAsyncWithHttpInfo_ParametersAreInvalid_ShoulRaiseApiException(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearConditionalReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            decimal? pRQty = null;
            decimal? pRPrice = null;
            decimal? pRTriggerPrice = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearConditionalReplaceAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }
    }
}