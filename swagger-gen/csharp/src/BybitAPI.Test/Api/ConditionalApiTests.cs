using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing ConditionalApi
    /// </summary>
    [TestFixture]
    public class ConditionalApiTests
    {
        private static ConditionalApi Create()
        {
            var instance = new ConditionalApi();

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
            Assert.IsInstanceOf<ConditionalApi>(instance, "instance is a ConditionalApi");
        }

        private readonly string conditionalCancelJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
        ""stop_order_id"": ""c1025629-e85b-4c26-b4f3-76e86ad9f8cb""
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
        public void ConditionalCancel_ParametersAreValid_ShouldReturnConditionalCancelBase(string stopOrderId, string orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.ConditionalCancel(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ConditionalCancelBase>(response, "response is ConditionalCancelBase");
        }

        [Test]
        public void ConditionalCancel_ParametersAreInvalid_ShouldRaiseApiException()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? stopOrderId = null;
            string? orderLinkId = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.ConditionalCancel(symbol, stopOrderId, orderLinkId);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        private readonly string conditionalCancelAllJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        {
            ""clOrdID"": ""dea89649-9492-459d-a8c4-c298b87b3d26"",
            ""user_id"": 1,
            ""symbol"": ""BTCUSD"",
            ""side"": ""Sell"",
            ""order_type"": ""Limit"",
            ""price"": ""999999"",
            ""qty"": 1,
            ""time_in_force"": ""PostOnly"",
            ""create_type"": ""CreateByUser"",
            ""cancel_type"": ""CancelByUser"",
            ""order_status"": ""Cancelled"",
            ""leaves_qty"": 1,
            ""leaves_value"": ""0"",
            ""created_at"": ""2019-12-17T12:13:20Z"",
            ""updated_at"": ""2019-12-27T13:56:33.793799Z"",
            ""cross_status"": ""Deactivated"",
            ""cross_seq"": -1,
            ""stop_order_type"": ""Stop"",
            ""trigger_by"": ""LastPrice"",
            ""base_price"": ""6910.5"",
            ""expected_direction"": ""Rising""
        },
        {
            ""clOrdID"": ""a85cd1c0-a9a4-49d3-a1bd-bab5ebe946d5"",
            ""user_id"": 1,
            ""symbol"": ""BTCUSD"",
            ""side"": ""Buy"",
            ""order_type"": ""Limit"",
            ""price"": ""8000"",
            ""qty"": 1,
            ""time_in_force"": ""GoodTillCancel"",
            ""create_type"": ""CreateByStopOrder"",
            ""cancel_type"": ""CancelByUser"",
            ""order_status"": """",
            ""leaves_qty"": 1,
            ""leaves_value"": ""0"",
            ""created_at"": ""2019-12-27T12:48:24.339323Z"",
            ""updated_at"": ""2019-12-27T13:56:33.793802Z"",
            ""cross_status"": ""Deactivated"",
            ""cross_seq"": -1,
            ""stop_order_type"": ""Stop"",
            ""trigger_by"": ""LastPrice"",
            ""base_price"": ""7000"",
            ""expected_direction"": ""Rising""
        }
    ],
    ""time_now"": ""1577454993.799912"",
    ""rate_limit_status"": 90,
    ""rate_limit_reset_ms"": 1580885703683,
    ""rate_limit"": 100
}
";

        [Test]
        public void ConditionalCancelAll_ParametersAreValid_ShouldReturnConditionalCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.ConditionalCancelAll(symbol);

            // Assert
            Assert.IsInstanceOf<ConditionalCancelAllBase>(response, "response is ConditionalCancelAllBase");
        }

        [Test]
        public void ConditionalCancelAllWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfConditionalCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.ConditionalCancelAllWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<ConditionalCancelAllBase>>(response, "response is ApiResponseConditionalCancelAllBase>");
        }

        public async Task ConditionalCancelAllAsync_ParametersAreValid_ShouldReturnConditionalCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.ConditionalCancelAllAsync(symbol);

            // Assert
            Assert.IsInstanceOf<ConditionalCancelAllBase>(response, "response is ConditionalCancelAllBase");
        }

        public async Task ConditionalCancelAllAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfConditionalCancelAllBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.ConditionalCancelAllAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<ConditionalCancelAllBase>>(response, "response is ApiResponse<ConditionalCancelAllBase>");
        }

        private readonly string conditionalGetOrdersJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""data"": [
            {
                ""user_id"": 160861,
                ""stop_order_status"": ""Active"",
                ""symbol"": ""ETHUSD"",
                ""side"": ""Buy"",
                ""order_type"": ""Market"",
                ""stop_order_type"": ""TakeProfit"",
                ""price"": ""220"",
                ""qty"": ""120"",
                ""time_in_force"": ""ImmediateOrCancel"",
                ""base_price"": ""258"",
                ""order_link_id"": """",
                ""created_at"": ""2019-08-02T07:37:24Z"",
                ""updated_at"": ""2019-08-02T07:38:40Z"",
                ""stop_px"": ""224.3"",
                ""stop_order_id"": ""6d0dec74-f516-4d95-81f1-c85e60c9a331""
            }
        ],
        ""cursor"": ""zZtvOJ0gc3UOxZOwotsJSZyMTOgyC9tj1DmFyUU6eNHUL0X4NLwZvo8iqI6ltPIc""
    },
    ""time_now"": ""1604653512.292878"",
    ""rate_limit_status"": 599,
    ""rate_limit_reset_ms"": 1604653512287,
    ""rate_limit"": 600
}
";

        [Test]
        public void ConditionalGetOrders_ParametersAreValid_ShouldReturnConditionalGetOrdersResBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var stopOrderStatus = StopOrderStatus.Active;
            decimal? limit = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var response = instance.ConditionalGetOrders(symbol, stopOrderStatus, limit, direction, cursor);

            // Assert
            Assert.IsInstanceOf<ConditionalGetOrdersResBase>(response, "response is ConditionalGetOrdersResBase");
        }

        [Test]
        public void ConditionalGetOrdersWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfConditionalGetOrdersResBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var stopOrderStatus = StopOrderStatus.Active;
            decimal? limit = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var response = instance.ConditionalGetOrdersWithHttpInfo(symbol, stopOrderStatus, limit, direction, cursor);

            // Assert
            Assert.IsInstanceOf<ApiResponse<ConditionalGetOrdersResBase>>(response, "response is ConditionalGetOrdersResBase");
        }

        [Test]
        public async Task ConditionalGetOrdersAsync_ParametersAreValid_ShouldReturnConditionalGetOrdersResBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var stopOrderStatus = StopOrderStatus.Active;
            decimal? limit = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var response = await instance.ConditionalGetOrdersAsync(symbol, stopOrderStatus, limit, direction, cursor);

            // Assert
            Assert.IsInstanceOf<ConditionalGetOrdersResBase>(response, "response is ConditionalGetOrdersResBase");
        }

        [Test]
        public async Task ConditionalGetOrdersAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfConditionalGetOrdersResBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalGetOrdersJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var stopOrderStatus = StopOrderStatus.Active;
            decimal? limit = null;
            SearchDirection? direction = null;
            string? cursor = null;

            // Act
            var response = await instance.ConditionalGetOrdersAsyncWithHttpInfo(symbol, stopOrderStatus, limit, direction, cursor);

            // Assert
            Assert.IsInstanceOf<ApiResponse<ConditionalGetOrdersResBase>>(response, "response is ApiResponse<ConditionalGetOrdersResBase>");
        }

        private readonly string conditionalNewJson = @"
{
    ""ret_code"":0,
    ""ret_msg"":""OK"",
    ""ext_code"":"""",
    ""ext_info"":"""",
    ""result"":{
        ""user_id"":160880,
        ""symbol"":""BTCUSD"",
        ""side"":""Buy"",
        ""order_type"":""Limit"",
        ""price"":""9003"",
        ""qty"":""2"",
        ""time_in_force"":""GoodTillCancel"",
        ""remark"":""127.0.0.1"",
        ""leaves_qty"":""2"",
        ""leaves_value"":""0"",
        ""stop_px"":""8232"",
        ""reject_reason"":""EC_NoError"",
        ""stop_order_id"":""eaf205ac-9dcc-44f6-8731-734e2101e61b"",
        ""created_at"":""2020-11-06T07:48:43.940Z"",
        ""updated_at"":""2020-11-06T07:48:43.940Z""
    },
    ""time_now"":""1604648923.942177""
}
";

        [Test]
        public void ConditionalNew_ParametersAreValid_ReturnsConditionalNewOrderBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = Side.Buy;
            var symbol = Symbol.BTCUSD;
            var orderType = OrderType.Limit;
            var qty = 0;
            var basePrice = 0m;
            var stopPx = 0m;
            var timeInForce = TimeInForce.FillOrKill;
            decimal? price = null;
            TriggerPriceType? triggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = instance.ConditionalNew(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ConditionalNewOrderBase>(response, "response is ConditionalNewOrderBase");
        }

        [Test]
        public void ConditionalNewWithHttpInfo_ParametersAreValid_ReturnsApiResponseOfConditionalNewOrderBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = Side.Buy;
            var symbol = Symbol.BTCUSD;
            var orderType = OrderType.Limit;
            var qty = 0;
            var basePrice = 0m;
            var stopPx = 0m;
            var timeInForce = TimeInForce.FillOrKill;
            decimal? price = null;
            TriggerPriceType? triggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = instance.ConditionalNewWithHttpInfo(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<ConditionalNewOrderBase>>(response, "response is ApiResponse<ConditionalNewOrderBase>");
        }

        [Test]
        public async Task ConditionalNewAsync_ParametersAreValid_ReturnsConditionalNewOrderBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = Side.Buy;
            var symbol = Symbol.BTCUSD;
            var orderType = OrderType.Limit;
            var qty = 0;
            var basePrice = 0m;
            var stopPx = 0m;
            var timeInForce = TimeInForce.FillOrKill;
            decimal? price = null;
            TriggerPriceType? triggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = await instance.ConditionalNewAsync(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ConditionalNewOrderBase>(response, "response is ConditionalNewOrderBase");
        }

        [Test]
        public async Task ConditionalNewAsyncWithHttpInfo_ParametersAreValid_ReturnsApiResponseOfConditionalNewOrderBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalNewJson);
            instance.Configuration.ApiClient.RestClient = client;

            var side = Side.Buy;
            var symbol = Symbol.BTCUSD;
            var orderType = OrderType.Limit;
            var qty = 0;
            var basePrice = 0m;
            var stopPx = 0m;
            var timeInForce = TimeInForce.FillOrKill;
            decimal? price = null;
            TriggerPriceType? triggerBy = null;
            bool? closeOnTrigger = null;
            string? orderLinkId = null;

            // Act
            var response = await instance.ConditionalNewAsyncWithHttpInfo(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, closeOnTrigger, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ApiResponse<ConditionalNewOrderBase>>(response, "response is ApiResponse<ConditionalNewOrderBase>");
        }

        //Note: In the documented response example, the 'trigger_by' field is not included, but it was added in the API update.
        //see: https://bybit-exchange.github.io/docs/inverse/?console#2020-11-20
        private readonly string conditionalQueryJson = @"
{
  ""ret_code"":0,
  ""ret_msg"":""OK"",
  ""ext_code"":"""",
  ""ext_info"":"""",
  ""result"":{
    ""user_id"":135895,
    ""symbol"":""BTCUSD"",
    ""side"":""Sell"",
    ""order_type"":""Market"",
    ""price"":""0"",
    ""qty"":3,
    ""stop_px"":""50000.0000"",
    ""base_price"":""39392.5000"",
    ""time_in_force"":""ImmediateOrCancel"",
    ""order_status"":""Untriggered"",
    ""ext_fields"":{
      ""o_req_num"":207406
    },
    ""leaves_qty"":3,
    ""leaves_value"":""0"",
    ""cum_exec_qty"":0,
    ""cum_exec_value"":null,
    ""cum_exec_fee"":null,
    ""reject_reason"":""EC_NoError"",
    ""cancel_type"":""UNKNOWN"",
    ""order_link_id"":"""",
    ""created_at"":""2021-01-10T15:01:10.756251191Z"",
    ""updated_at"":""2021-01-10T15:01:10.756251191Z"",
    ""order_id"":""da5fc794-6c65-4222-b06f-58fee13a1f0c"",
    ""trigger_by"":""LastPrice""
  },
  ""time_now"":""1610294929.648060"",
  ""rate_limit_status"":599,
  ""rate_limit_reset_ms"":1610294929646,
  ""rate_limit"":600
}
";

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        [TestCase("", "")]
        public void ConditionalQuery_ParametersAreValid_ShouldReturnConditionalQueryBaseOfConditionalQueryRes(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalQueryJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            //string? stopOrderId = string.Empty;
            //string? orderLinkId = null;

            // Act
            var response = instance.ConditionalQuery(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<ConditionalQueryBase<ConditionalQueryRes>>(response, "response is ConditionalQueryBase<ConditionalQueryRes>");
        }

        private readonly string conditionalQueryBySymbolJson = @"
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
      ""order_type"":""Market"",
      ""price"":""0"",
      ""qty"":1,
      ""stop_px"":""3000.0000"",
      ""base_price"":""41315.0000"",
      ""time_in_force"":""ImmediateOrCancel"",
      ""order_status"":""Untriggered"",
      ""ext_fields"":{
        ""o_req_num"":1896391
      },
      ""leaves_qty"":1,
      ""leaves_value"":""0"",
      ""cum_exec_qty"":0,
      ""cum_exec_value"":null,
      ""cum_exec_fee"":null,
      ""reject_reason"":""EC_NoError"",
      ""cancel_type"":""UNKNOWN"",
      ""order_link_id"":"""",
      ""created_at"":""2021-01-08T17:30:07.306465866Z"",
      ""updated_at"":""2021-01-08T17:30:07.306465866Z"",
      ""order_id"":""c3cc95af-a362-43a4-9755-a009fb00de35"",
      ""trigger_by"":""LastPrice""
    }
  ],
  ""time_now"":""1610127024.078614"",
  ""rate_limit_status"":598,
  ""rate_limit_reset_ms"":1610127024076,
  ""rate_limit"":600
}
";

        [Test]
        public void ConditionalQuery_ParametersAreValid_ShouldReturnConditionalQueryBaseOfListForConditionalQueryRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalQueryBySymbolJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.ConditionalQuery(symbol);

            // Assert
            Assert.IsInstanceOf<ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>>>(response, "response is ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>>>");
            Assert.That(response.Result?[0].CreatedAt, Is.EqualTo(DateTimeOffset.Parse("2021-01-08T17:30:07.306465866Z")));
        }

        private readonly string conditionalReplaceJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
        ""stop_order_id"": ""378a1bbc-a93a-4e75-87f4-502ea754ba36""
    },
    ""ext_info"": null,
    ""time_now"": ""1577475760.604942"",
    ""rate_limit_status"": 96,
    ""rate_limit_reset_ms"": 1577475760612,
    ""rate_limit"": ""100""
}
";

        [Test]
        [TestCase("", null)]
        [TestCase(null, "")]
        public void ConditionalReplace_ParametersAreValid_ShouldReturnConditionalReplaceBase(string? stopOrderId, string? orderLinkId)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            int? pRQty = null;
            decimal? pRPrice = null;
            decimal? pRTriggerPrice = null;

            // Act
            var response = instance.ConditionalReplace(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);

            // Assert
            Assert.IsInstanceOf<ConditionalReplaceBase>(response, "response is ConditionalReplaceBase");
        }

        [Test]
        public void ConditionalReplace_ParametersAreInValid_ShouldRaiseApiException()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalReplaceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            string? stopOrderId = null;
            string? orderLinkId = null;
            int? pRQty = null;
            decimal? pRPrice = null;
            decimal? pRTriggerPrice = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.ConditionalReplace(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }
    }
}