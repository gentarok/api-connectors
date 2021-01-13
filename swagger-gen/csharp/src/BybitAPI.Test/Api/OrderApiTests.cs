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
    ///  Class for testing OrderApi
    /// </summary>
    [TestFixture]
    public class OrderApiTests
    {
        private static OrderApi Create()
        {
            var instance = new OrderApi();

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
            Assert.IsInstanceOf<OrderApi>(instance, "instance is a OrderApi");
        }

        private static readonly string orderCancelJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""user_id"": 1,
        ""order_id"": ""3bd1844f-f3c0-4e10-8c25-10fea03763f6"",
        ""symbol"": ""BTCUSD"",
        ""side"": ""Buy"",
        ""order_type"": ""Limit"",
        ""price"": 8800,
        ""qty"": 1,
        ""time_in_force"": ""GoodTillCancel"",
        ""order_status"": ""New"",
        ""last_exec_time"": 0,
        ""last_exec_price"": 0,
        ""leaves_qty"": 1,
        ""cum_exec_qty"": 0,
        ""cum_exec_value"": 0,
        ""cum_exec_fee"": 0,
        ""reject_reason"": """",
        ""order_link_id"": """",
        ""created_at"": ""2019-11-30T11:17:18.396Z"",
        ""updated_at"": ""2019-11-30T11:18:01.811Z""
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
        public void OrderCancel_ParametersAreValid_ShouldReturnOrderCancelBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.OrderCancel(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<OrderCancelBase>(response, "response is OrderCancelBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void OrderCancel_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.OrderCancel(symbol, orderId, orderLinkId);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, "")]
        public void OrderCancelWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfOrderCancelBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.OrderCancelWithHttpInfo(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderCancelBase>>(response, "response is ApiResponse<OrderCancelBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void OrderCancelWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.OrderCancelWithHttpInfo(symbol, orderId, orderLinkId);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task OrderCancelAsync_ParametersAreValid_ShouldReturnOrderCancelBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.OrderCancelAsync(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<OrderCancelBase>(response, "response is OrderCancelBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void OrderCancelAsync_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.OrderCancelAsync(symbol, orderId, orderLinkId);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task OrderCancelAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfOrderCancelBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.OrderCancelAsyncWithHttpInfo(symbol, orderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderCancelBase>>(response, "response is ApiResponse<OrderCancelBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void OrderCancelAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.OrderCancelAsyncWithHttpInfo(symbol, orderId, orderLinkId);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string orderCancelAllJson = @"
{
  ""ret_code"": 0,
  ""ret_msg"": ""OK"",
  ""ext_code"": """",
  ""ext_info"": """",
  ""result"": [
    {
      ""clOrdID"": ""89a38056-80f1-45b2-89d3-4d8e3a203a79"",
      ""user_id"": 1,
      ""symbol"": ""BTCUSD"",
      ""side"": ""Buy"",
      ""order_type"": ""Limit"",
      ""price"": ""7693.5"",
      ""qty"": 1,
      ""time_in_force"": ""GoodTillCancel"",
      ""create_type"": ""CreateByUser"",
      ""cancel_type"": ""CancelByUser"",
      ""order_status"": """",
      ""leaves_qty"": 1,
      ""leaves_value"": ""0"",
      ""created_at"": ""2019-11-30T10:38:53.564428Z"",
      ""updated_at"": ""2019-11-30T10:38:59.102589Z"",
      ""cross_status"": ""PendingCancel"",
      ""cross_seq"": 387734027
    }
  ],
  ""time_now"": ""1575110339.105675"",
  ""rate_limit_status"": 98,
  ""rate_limit_reset_ms"": 1580885703683,
  ""rate_limit"": 100
}
";

        [Test]
        public void OrderCancelAll_ParametersAreValid_ShouldReturnOrderCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.OrderCancelAll(symbol);

            // Assert
            Assert.IsInstanceOf<OrderCancelAllBase>(response, "response is OrderCancelAllBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void OrderCancelAllWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfOrderCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.OrderCancelAllWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderCancelAllBase>>(response, "response is ApiResponse<OrderCancelAllBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task OrderCancelAllAsync_ParametersAreValid_ShouldReturnOrderCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.OrderCancelAllAsync(symbol);

            // Assert
            Assert.IsInstanceOf<OrderCancelAllBase>(response, "response is OrderCancelAllBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task OrderCancelAllAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfOrderCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.OrderCancelAllAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderCancelAllBase>>(response, "response is ApiResponse<OrderCancelAllBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        //Note: Created from actual response. (TestNet)
        private static readonly string orderGetOrdersJson = @"
{
  ""ret_code"":0,
  ""ret_msg"":""OK"",
  ""ext_code"":"""",
  ""ext_info"":"""",
  ""result"":{
    ""data"":[
      {
        ""user_id"":135895,
        ""order_status"":""New"",
        ""symbol"":""BTCUSD"",
        ""side"":""Buy"",
        ""order_type"":""Limit"",
        ""price"":""30011.5"",
        ""qty"":""3"",
        ""time_in_force"":""PostOnly"",
        ""order_link_id"":"""",
        ""order_id"":""4af0791b-104f-4d0b-8a03-3835c4568781"",
        ""created_at"":""2021-01-10T13:02:29.000Z"",
        ""updated_at"":""2021-01-10T13:02:29.000Z"",
        ""leaves_qty"":""3"",
        ""leaves_value"":""0.00009996"",
        ""cum_exec_qty"":""0"",
        ""cum_exec_value"":""0"",
        ""cum_exec_fee"":""0"",
        ""reject_reason"":""NoError""
      },
      {
        ""user_id"":135895,
        ""order_status"":""Deactivated"",
        ""symbol"":""BTCUSD"",
        ""side"":""Buy"",
        ""order_type"":""Market"",
        ""price"":""0"",
        ""qty"":""3"",
        ""time_in_force"":""ImmediateOrCancel"",
        ""order_link_id"":"""",
        ""order_id"":""e016c67c-e6a6-486c-804a-43bce8236cd0"",
        ""created_at"":""2021-01-10T13:02:09.000Z"",
        ""updated_at"":""2021-01-10T13:02:16.000Z"",
        ""leaves_qty"":""3"",
        ""leaves_value"":""0"",
        ""cum_exec_qty"":""0"",
        ""cum_exec_value"":""0"",
        ""cum_exec_fee"":""0"",
        ""reject_reason"":""""
      },
      {
    ""user_id"":135895,
        ""order_status"":""Cancelled"",
        ""symbol"":""BTCUSD"",
        ""side"":""Buy"",
        ""order_type"":""Limit"",
        ""price"":""30000"",
        ""qty"":""1"",
        ""time_in_force"":""GoodTillCancel"",
        ""order_link_id"":"""",
        ""order_id"":""d84d9acf-2742-4ae9-b1e0-509d59a04e4e"",
        ""created_at"":""2021-01-10T08:54:58.000Z"",
        ""updated_at"":""2021-01-10T08:57:43.000Z"",
        ""leaves_qty"":""0"",
        ""leaves_value"":""0"",
        ""cum_exec_qty"":""0"",
        ""cum_exec_value"":""0"",
        ""cum_exec_fee"":""0"",
        ""reject_reason"":""EC_PerCancelRequest""
      },
      {
    ""user_id"":135895,
        ""order_status"":""Filled"",
        ""symbol"":""BTCUSD"",
        ""side"":""Sell"",
        ""order_type"":""Market"",
        ""price"":""38875"",
        ""qty"":""1"",
        ""time_in_force"":""ImmediateOrCancel"",
        ""order_link_id"":"""",
        ""order_id"":""b7af96c3-8c2f-4118-b2dc-b3a7effe3583"",
        ""created_at"":""2021-01-10T08:50:26.000Z"",
        ""updated_at"":""2021-01-10T08:50:26.000Z"",
        ""leaves_qty"":""0"",
        ""leaves_value"":""0"",
        ""cum_exec_qty"":""1"",
        ""cum_exec_value"":""0.00002443"",
        ""cum_exec_fee"":""0.00000002"",
        ""reject_reason"":""NoError""
      }
    ],
    ""cursor"":""68pYjAh7bBjFYfgC/cF3JivMPJ0kmgs7DvRw+5ujQNVH2YBBAcX+YaPqLfc8n5EC""
  },
  ""time_now"":""1610284124.412992"",
  ""rate_limit_status"":599,
  ""rate_limit_reset_ms"":1610284124409,
  ""rate_limit"":600
}
";

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(50)]
        public void OrderGetOrders_ParametersAreValid_ShouldReturnOrderGetOrdersBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            OrderStatus? orderStatus = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var response = instance.OrderGetOrders(symbol, limit, orderStatus, direction, cursor);

            // Assert
            Assert.IsInstanceOf<OrderGetOrdersBase>(response, "response is OrderGetOrdersBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(51)]
        public void OrderGetOrders_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            OrderStatus? orderStatus = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.OrderGetOrders(symbol, limit, orderStatus, direction, cursor);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(50)]
        public void OrderGetOrdersWithHttpInfo_ParametersAreValid_ShouldReturnOrderApiResponseOfGetOrdersBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            OrderStatus? orderStatus = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var response = instance.OrderGetOrdersWithHttpInfo(symbol, limit, orderStatus, direction, cursor);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderGetOrdersBase>>(response, "response is ApiResponse<OrderGetOrdersBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(51)]
        public void OrderGetOrdersWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            OrderStatus? orderStatus = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.OrderGetOrdersWithHttpInfo(symbol, limit, orderStatus, direction, cursor);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(50)]
        public async Task OrderGetOrdersAsync_ParametersAreValid_ShouldReturnOrderGetOrdersBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            OrderStatus? orderStatus = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var response = await instance.OrderGetOrdersAsync(symbol, limit, orderStatus, direction, cursor);

            // Assert
            Assert.IsInstanceOf<OrderGetOrdersBase>(response, "response is OrderGetOrdersBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(51)]
        public void OrderGetOrdersAsync_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            OrderStatus? orderStatus = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.OrderGetOrdersAsync(symbol, limit, orderStatus, direction, cursor);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(50)]
        public async Task OrderGetOrdersAsyncWithHttpInfo_ParametersAreValid_ShouldReturnOrderApiResponseOfGetOrdersBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            OrderStatus? orderStatus = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var response = await instance.OrderGetOrdersAsyncWithHttpInfo(symbol, limit, orderStatus, direction, cursor);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderGetOrdersBase>>(response, "response is ApiResponse<OrderGetOrdersBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(51)]
        public void OrderGetOrdersAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            OrderStatus? orderStatus = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.OrderGetOrdersAsyncWithHttpInfo(symbol, limit, orderStatus, direction, cursor);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string orderNewJson = @"
{
  ""ret_code"":0,
  ""ret_msg"":""OK"",
  ""ext_code"":"""",
  ""ext_info"":"""",
  ""result"":{
    ""user_id"":135895,
    ""order_id"":""afdc90d7-3261-4e67-a2fb-15cf31172b3c"",
    ""symbol"":""BTCUSD"",
    ""side"":""Buy"",
    ""order_type"":""Market"",
    ""price"":42751.5,
    ""qty"":1,
    ""time_in_force"":""ImmediateOrCancel"",
    ""order_status"":""Created"",
    ""last_exec_time"":0,
    ""last_exec_price"":0,
    ""leaves_qty"":1,
    ""cum_exec_qty"":0,
    ""cum_exec_value"":0,
    ""cum_exec_fee"":0,
    ""reject_reason"":""EC_NoError"",
    ""order_link_id"":"""",
    ""created_at"":""2021-01-10T08:47:15.491Z"",
    ""updated_at"":""2021-01-10T08:47:15.491Z""
  },
  ""time_now"":""1610268435.491495"",
  ""rate_limit_status"":99,
  ""rate_limit_reset_ms"":1610268435489,
  ""rate_limit"":100
}
";

        [Test]
        public void OrderNew_ParametersAreValid_ShouldReturnOrderNewBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = Side.Sell;
            var symbol = Symbol.BTCUSD;
            var orderType = OrderType.Market;
            var qty = 1;
            var timeInForce = TimeInForce.GoodTillCancel;
            decimal? price = null;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = instance.OrderNew(side, symbol, orderType, qty, timeInForce, price, takeProfit, stopLoss, reduceOnly, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<OrderNewBase>(response, "response is OrderNewBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void OrderNewWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfOrderNewBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = Side.Sell;
            var symbol = Symbol.BTCUSD;
            var orderType = OrderType.Market;
            var qty = 1;
            var timeInForce = TimeInForce.GoodTillCancel;
            decimal? price = null;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = instance.OrderNewWithHttpInfo(side, symbol, orderType, qty, timeInForce, price, takeProfit, stopLoss, reduceOnly, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderNewBase>>(response, "response is ApiResponse<OrderNewBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task OrderNewAsync_ParametersAreValid_ShouldReturnOrderNewBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = Side.Sell;
            var symbol = Symbol.BTCUSD;
            var orderType = OrderType.Market;
            var qty = 1;
            var timeInForce = TimeInForce.GoodTillCancel;
            decimal? price = null;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = await instance.OrderNewAsync(side, symbol, orderType, qty, timeInForce, price, takeProfit, stopLoss, reduceOnly, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<OrderNewBase>(response, "response is OrderNewBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task OrderNewAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfOrderNewBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = Side.Sell;
            var symbol = Symbol.BTCUSD;
            var orderType = OrderType.Market;
            var qty = 1;
            var timeInForce = TimeInForce.GoodTillCancel;
            decimal? price = null;
            decimal? takeProfit = null;
            decimal? stopLoss = null;
            bool? reduceOnly = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = await instance.OrderNewAsyncWithHttpInfo(side, symbol, orderType, qty, timeInForce, price, takeProfit, stopLoss, reduceOnly, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderNewBase>>(response, "response is ApiResponse<OrderNewBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string orderQueryJsonBySymbolAndOrderId = @"
{
  ""ret_code"":0,
  ""ret_msg"":""OK"",
  ""ext_code"":"""",
  ""ext_info"":"""",
  ""result"":{
    ""user_id"":135895,
    ""symbol"":""BTCUSD"",
    ""side"":""Buy"",
    ""order_type"":""Limit"",
    ""price"":""12344"",
    ""qty"":1,
    ""time_in_force"":""PostOnly"",
    ""order_status"":""New"",
    ""ext_fields"":{
      ""o_req_num"":201209
    },
    ""last_exec_time"":""1610290192.6050298"",
    ""leaves_qty"":1,
    ""leaves_value"":""0.00008101"",
    ""cum_exec_qty"":0,
    ""cum_exec_value"":null,
    ""cum_exec_fee"":null,
    ""reject_reason"":""EC_NoError"",
    ""cancel_type"":""UNKNOWN"",
    ""order_link_id"":"""",
    ""created_at"":""2021-01-10T14:49:52.604938117Z"",
    ""updated_at"":""2021-01-10T14:49:52.60503Z"",
    ""order_id"":""3f1bf46b-f7d2-48f9-8d96-025a861141bf""
  },
  ""time_now"":""1610294276.019401"",
  ""rate_limit_status"":599,
  ""rate_limit_reset_ms"":1610294276017,
  ""rate_limit"":600
}
";

        [Test]
        public void OrderQuery_SymbolAndOrderIdParametersAreValid_ShouldReturnOrderQueryBaseOrderOfQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderQueryJsonBySymbolAndOrderId);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var orderId = string.Empty;

            // Act
            var response = instance.OrderQuery(symbol, orderId);

            // Assert
            Assert.IsInstanceOf<OrderQueryBase<OrderQueryRes>>(response, "response is OrderQueryBase<OrderQueryRes>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void OrderQueryWithHttpInfo_SymbolAndOrderIdParametersAreValid_ShouldReturnApiResponseOfOrderQueryBaseOfOrderFQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderQueryJsonBySymbolAndOrderId);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var orderId = string.Empty;

            // Act
            var response = instance.OrderQueryWithHttpInfo(symbol, orderId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderQueryBase<OrderQueryRes>>>(response, "response is ApiResponse<OrderQueryBase<OrderQueryRes>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task OrderQueryAsync_SymbolAndOrderIdParametersAreValid_ShouldReturnOrderQueryBaseOrderOfQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderQueryJsonBySymbolAndOrderId);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var orderId = string.Empty;

            // Act
            var response = await instance.OrderQueryAsync(symbol, orderId);

            // Assert
            Assert.IsInstanceOf<OrderQueryBase<OrderQueryRes>>(response, "response is OrderQueryBase<OrderQueryRes>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task OrderQueryAsyncWithHttpInfo_SymbolAndOrderIdParametersAreValid_ShouldReturnApiResponseOfOrderQueryBaseOfOrderFQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderQueryJsonBySymbolAndOrderId);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var orderId = string.Empty;

            // Act
            var response = await instance.OrderQueryAsyncWithHttpInfo(symbol, orderId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderQueryBase<OrderQueryRes>>>(response, "response is ApiResponse<OrderQueryBase<OrderQueryRes>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string orderQueryJsonBySymbol = @"
{
  ""ret_code"":0,
  ""ret_msg"":""OK"",
  ""ext_code"":"""",
  ""ext_info"":"""",
  ""result"":[
    {
      ""user_id"":135895,
      ""symbol"":""BTCUSD"",
      ""side"":""Buy"",
      ""order_type"":""Limit"",
      ""price"":""12344"",
      ""qty"":1,
      ""time_in_force"":""PostOnly"",
      ""order_status"":""New"",
      ""ext_fields"":{
        ""o_req_num"":201209
      },
      ""last_exec_time"":""1610290192.60503"",
      ""leaves_qty"":1,
      ""leaves_value"":""0.00008101"",
      ""cum_exec_qty"":0,
      ""cum_exec_value"":null,
      ""cum_exec_fee"":null,
      ""reject_reason"":""EC_NoError"",
      ""cancel_type"":""UNKNOWN"",
      ""order_link_id"":"""",
      ""created_at"":""2021-01-10T14:49:52.604938117Z"",
      ""updated_at"":""2021-01-10T14:49:52.60503Z"",
      ""order_id"":""3f1bf46b-f7d2-48f9-8d96-025a861141bf""
    },
    {
    ""user_id"":135895,
      ""symbol"":""BTCUSD"",
      ""side"":""Buy"",
      ""order_type"":""Limit"",
      ""price"":""30011.5"",
      ""qty"":3,
      ""time_in_force"":""PostOnly"",
      ""order_status"":""New"",
      ""ext_fields"":{
        ""o_req_num"":142498
      },
      ""last_exec_time"":""1610283749.625556"",
      ""leaves_qty"":3,
      ""leaves_value"":""0.00009996"",
      ""cum_exec_qty"":0,
      ""cum_exec_value"":null,
      ""cum_exec_fee"":null,
      ""reject_reason"":""EC_NoError"",
      ""cancel_type"":""UNKNOWN"",
      ""order_link_id"":"""",
      ""created_at"":""2021-01-10T13:02:29.625431448Z"",
      ""updated_at"":""2021-01-10T13:02:29.625556Z"",
      ""order_id"":""4af0791b-104f-4d0b-8a03-3835c4568781""
    }
  ],
  ""time_now"":""1610294414.154484"",
  ""rate_limit_status"":599,
  ""rate_limit_reset_ms"":1610294414152,
  ""rate_limit"":600
}
";

        [Test]
        public void OrderQuery_ParametersAreValid_ShouldReturnQueryBaseOrderOfListForQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.OrderQuery(symbol);

            // Assert
            Assert.IsInstanceOf<OrderQueryBase<IReadOnlyList<OrderQueryRes>>>(response, "response is OrderQueryBase<IReadOnlyList<OrderQueryRes>>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void OrderQueryWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfQueryBaseOrderForListForQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.OrderQueryWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderQueryBase<IReadOnlyList<OrderQueryRes>>>>(response, "response is ApiResponse<OrderQueryBase<IReadOnlyList<OrderQueryRes>>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task OrderQueryAsync_ParameterAreValid_ShouldReturnQueryBaseOrderOfListForQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.OrderQueryAsync(symbol);

            // Assert
            Assert.IsInstanceOf<OrderQueryBase<IReadOnlyList<OrderQueryRes>>>(response, "response is OrderQueryBase<IReadOnlyList<OrderQueryRes>>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task OrderQueryAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfQueryBaseOrderForListForQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderQueryJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.OrderQueryAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderQueryBase<IReadOnlyList<OrderQueryRes>>>>(response, "response is ApiResponse<OrderQueryBase<IReadOnlyList<OrderQueryRes>>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string orderReplaceJson = @"
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
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, "")]
        public void OrderReplace_ParametersAreValid_ShouldReturnOrderReplaceBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? pRQty = null;
            string? pRPrice = null;

            // Act
            var response = instance.OrderReplace(symbol, orderId, orderLinkId, pRQty, pRPrice);

            // Assert
            Assert.IsInstanceOf<OrderReplaceBase>(response, "response is OrderReplaceBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void OrderReplace_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? pRQty = null;
            string? pRPrice = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.OrderReplace(symbol, orderId, orderLinkId, pRQty, pRPrice);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, "")]
        public void OrderReplaceWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfOrderReplaceBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? pRQty = null;
            string? pRPrice = null;

            // Act
            var response = instance.OrderReplaceWithHttpInfo(symbol, orderId, orderLinkId, pRQty, pRPrice);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderReplaceBase>>(response, "response is ApiResponse<OrderReplaceBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void OrderReplaceWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? pRQty = null;
            string? pRPrice = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.OrderReplaceWithHttpInfo(symbol, orderId, orderLinkId, pRQty, pRPrice);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task OrderReplaceAsync_ParametersAreValid_ShouldReturnOrderReplaceBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? pRQty = null;
            string? pRPrice = null;

            // Act
            var response = await instance.OrderReplaceAsync(symbol, orderId, orderLinkId, pRQty, pRPrice);

            // Assert
            Assert.IsInstanceOf<OrderReplaceBase>(response, "response is OrderReplaceBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void OrderReplaceAsync_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? pRQty = null;
            string? pRPrice = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.OrderReplaceAsync(symbol, orderId, orderLinkId, pRQty, pRPrice);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("", "")]
        [TestCase("", null)]
        [TestCase(null, "")]
        public async Task OrderReplaceAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfOrderReplaceBase(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? pRQty = null;
            string? pRPrice = null;

            // Act
            var response = await instance.OrderReplaceAsyncWithHttpInfo(symbol, orderId, orderLinkId, pRQty, pRPrice);

            // Assert
            Assert.IsInstanceOf<ApiResponse<OrderReplaceBase>>(response, "response is ApiResponse<OrderReplaceBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        public void OrderReplaceAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string? orderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, orderReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? pRQty = null;
            string? pRPrice = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.OrderReplaceAsyncWithHttpInfo(symbol, orderId, orderLinkId, pRQty, pRPrice);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }
    }
}