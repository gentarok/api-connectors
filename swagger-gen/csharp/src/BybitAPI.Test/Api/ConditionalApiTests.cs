/*
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api.bybit.com]
 *
 * OpenAPI spec version: 0.2.10
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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
    ///  Class for testing ConditionalApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConditionalApiTests
    {
        private ConditionalApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConditionalApi();

            // Prepeare configurations to test.
            instance.Configuration.AddApiKey("api_key", "");
            instance.Configuration.AddApiKey("api_secret", "");
            instance.Configuration.AddApiKey("timestamp", "");
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void Instance_ShouldBeCreated() => Assert.IsInstanceOf<ConditionalApi>(instance, "instance is a ConditionalApi");

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
        public void ConditionalCancel_SymbolIsNotNullAndEitherStopOrderIdOrOrderLinkIdIsNotNull_ShouldReturnV2ConditionalBaseOfOrderIdRes(string stopOrderId, string orderLinkId)
        {
            // Arrange
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = string.Empty;
            //string stopOrderId = null;
            //string orderLinkId = null;

            // Act
            var response = instance.ConditionalCancel(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.IsInstanceOf<V2ConditionalBase<OrderIdRes>>(response, "response is ConditionalCancelBase");
        }

        [Test]
        [TestCase(null, "", null)]
        [TestCase(null, null, "")]
        [TestCase("", null, null)]
        public void ConditionalCancel_SymbolIsNullOrBothStopOrderIdAndOrderLinkIdAreNull_ShouldRaiseApiException(string symbol, string stopOrderId, string orderLinkId)
        {
            // Arrange
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelJson);
            instance.Configuration.ApiClient.RestClient = client;

            //string symbol = string.Empty;
            //string stopOrderId = null;
            //string orderLinkId = null;

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
            ""order_status"": """",
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
        public void ConditionalCancelAll_ShouldReturnConditionalV2ConditionalBaseOfListOfConditionalCancelAllRes()
        {
            // Arrange
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = string.Empty;

            // Act
            var response = instance.ConditionalCancelAll(symbol);

            // Assert
            Assert.IsInstanceOf<V2ConditionalBase<List<ConditionalCancelAllRes>>>(response, "response is V2ConditionalBase<List<ConditionalCancelAllRes>>");
        }

        [Test]
        public void ConditionalCancelAll_SymbolIsNull_ShouldRaiseApiException()
        {
            // Arrange
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            string symbol = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.ConditionalCancelAll(symbol);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        public void ConditionalCancelAllWithHttpInfo_ShouldReturnApiResponseOfV2ConditionalBaseOfListOfConditionalCancelAllRes()
        {
            // Arrange
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = string.Empty;

            // Act
            var response = instance.ConditionalCancelAllWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<V2ConditionalBase<List<ConditionalCancelAllRes>>>>(response, "response is ApiResponse<V2ConditionalBase<List<ConditionalCancelAllRes>>>");
        }

        [Test]
        public void ConditionalCancelAllWithHttpInfo_SymbolIsNull_ShouldRaiseApiException()
        {
            // Arrange
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            string symbol = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.ConditionalCancelAllWithHttpInfo(symbol);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        public async Task ConditionalCancelAllAsync_ShouldReturnConditionalCancelAllBase()
        {
            // Arrange
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = string.Empty;

            // Act
            var response = await instance.ConditionalCancelAllAsync(symbol);

            // Assert
            Assert.IsInstanceOf<ConditionalCancelAllBase>(response, "response is ConditionalCancelAllBase");
        }

        [Test]
        public void ConditionalCancelAllAsync_SymbolIsNull_ShouldRaiseApiException()
        {
            // Arrange
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            string symbol = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.ConditionalCancelAllAsync(symbol);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        public async Task ConditionalCancelAllAsyncWithHttpInfo_ShouldReturnApiResponseOfConditionalCancelAllBase()
        {
            // Arrange
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = string.Empty;

            // Act
            var response = await instance.ConditionalCancelAllAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<ConditionalCancelAllBase>>(response, "response is ApiResponse<ConditionalCancelAllBase>");
        }

        [Test]
        public void ConditionalCancelAllAsyncWithHttpInfo_SymbolIsNull_ShouldRaiseApiException()
        {
            // Arrange
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, conditionalCancelAllJson);
            instance.Configuration.ApiClient.RestClient = client;

            string symbol = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.ConditionalCancelAllAsyncWithHttpInfo(symbol);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
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

        ///// <summary>
        ///// Test ConditionalGetOrders
        ///// </summary>
        //[Test]
        //public void ConditionalGetOrdersTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //string stopOrderStatus = null;
        //    //decimal? limit = null;
        //    //string direction = null;
        //    //string cursor = null;
        //    //var response = instance.ConditionalGetOrders(symbol, stopOrderStatus, limit, direction, cursor);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test ConditionalNew
        ///// </summary>
        //[Test]
        //public void ConditionalNewTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string side = null;
        //    //string symbol = null;
        //    //string orderType = null;
        //    //string qty = null;
        //    //string basePrice = null;
        //    //string stopPx = null;
        //    //string timeInForce = null;
        //    //string price = null;
        //    //string triggerBy = null;
        //    //bool? closeOnTrigger = null;
        //    //string orderLinkId = null;
        //    //var response = instance.ConditionalNew(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, closeOnTrigger, orderLinkId);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test ConditionalQuery
        ///// </summary>
        //[Test]
        //public void ConditionalQueryTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string stopOrderId = null;
        //    //string orderLinkId = null;
        //    //string symbol = null;
        //    //var response = instance.ConditionalQuery(stopOrderId, orderLinkId, symbol);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test ConditionalReplace
        ///// </summary>
        //[Test]
        //public void ConditionalReplaceTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //string stopOrderId = null;
        //    //string orderLinkId = null;
        //    //string pRQty = null;
        //    //string pRPrice = null;
        //    //string pRTriggerPrice = null;
        //    //var response = instance.ConditionalReplace(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}
    }
}