/*
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api.bybit.com]
 *
 * OpenAPI spec version: 0.2.10
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using BybitAPI.Api;
using NUnit.Framework;

namespace BybitAPI.Test
{
    /// <summary>
    ///  Class for testing OrderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderApiTests
    {
        private OrderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of OrderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderApi
            Assert.IsInstanceOf(typeof(OrderApi), instance, "instance is a OrderApi");
        }

        /// <summary>
        /// Test OrderCancel
        /// </summary>
        [Test]
        public void OrderCancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string orderId = null;
            //string orderLinkId = null;
            //var response = instance.OrderCancel(symbol, orderId, orderLinkId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test OrderCancelAll
        /// </summary>
        [Test]
        public void OrderCancelAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.OrderCancelAll(symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test OrderGetOrders
        /// </summary>
        [Test]
        public void OrderGetOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //decimal? limit = null;
            //string orderStatus = null;
            //string direction = null;
            //string cursor = null;
            //var response = instance.OrderGetOrders(symbol, limit, orderStatus, direction, cursor);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test OrderNew
        /// </summary>
        [Test]
        public void OrderNewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string side = null;
            //string symbol = null;
            //string orderType = null;
            //decimal? qty = null;
            //string timeInForce = null;
            //double? price = null;
            //double? takeProfit = null;
            //double? stopLoss = null;
            //bool? reduceOnly = null;
            //bool? closeOnTrigger = null;
            //string orderLinkId = null;
            //var response = instance.OrderNew(side, symbol, orderType, qty, timeInForce, price, takeProfit, stopLoss, reduceOnly, closeOnTrigger, orderLinkId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test OrderQuery
        /// </summary>
        [Test]
        public void OrderQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //string symbol = null;
            //var response = instance.OrderQuery(orderId, symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test OrderReplace
        /// </summary>
        [Test]
        public void OrderReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string orderId = null;
            //string orderLinkId = null;
            //string pRQty = null;
            //string pRPrice = null;
            //var response = instance.OrderReplace(symbol, orderId, orderLinkId, pRQty, pRPrice);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }
}
