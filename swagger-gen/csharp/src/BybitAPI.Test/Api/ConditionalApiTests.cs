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
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of ConditionalApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ConditionalApi
            Assert.IsInstanceOf(typeof(ConditionalApi), instance, "instance is a ConditionalApi");
        }

        /// <summary>
        /// Test ConditionalCancel
        /// </summary>
        [Test]
        public void ConditionalCancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string stopOrderId = null;
            //string orderLinkId = null;
            //var response = instance.ConditionalCancel(symbol, stopOrderId, orderLinkId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test ConditionalCancelAll
        /// </summary>
        [Test]
        public void ConditionalCancelAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.ConditionalCancelAll(symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test ConditionalGetOrders
        /// </summary>
        [Test]
        public void ConditionalGetOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string stopOrderStatus = null;
            //decimal? limit = null;
            //string direction = null;
            //string cursor = null;
            //var response = instance.ConditionalGetOrders(symbol, stopOrderStatus, limit, direction, cursor);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test ConditionalNew
        /// </summary>
        [Test]
        public void ConditionalNewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string side = null;
            //string symbol = null;
            //string orderType = null;
            //string qty = null;
            //string basePrice = null;
            //string stopPx = null;
            //string timeInForce = null;
            //string price = null;
            //string triggerBy = null;
            //bool? closeOnTrigger = null;
            //string orderLinkId = null;
            //var response = instance.ConditionalNew(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, closeOnTrigger, orderLinkId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test ConditionalQuery
        /// </summary>
        [Test]
        public void ConditionalQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stopOrderId = null;
            //string orderLinkId = null;
            //string symbol = null;
            //var response = instance.ConditionalQuery(stopOrderId, orderLinkId, symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test ConditionalReplace
        /// </summary>
        [Test]
        public void ConditionalReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string stopOrderId = null;
            //string orderLinkId = null;
            //string pRQty = null;
            //string pRPrice = null;
            //string pRTriggerPrice = null;
            //var response = instance.ConditionalReplace(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }
}
