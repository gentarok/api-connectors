/* 
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api.bybit.com]  
 *
 * OpenAPI spec version: 0.2.10
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using BybitAPI.Client;
using BybitAPI.Api;

namespace BybitAPI.Test
{
    /// <summary>
    ///  Class for testing LinearConditionalApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LinearConditionalApiTests
    {
        private LinearConditionalApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LinearConditionalApi();
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
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LinearConditionalApi
            //Assert.IsInstanceOfType(typeof(LinearConditionalApi), instance, "instance is a LinearConditionalApi");
        }

        
        /// <summary>
        /// Test LinearConditionalCancel
        /// </summary>
        [Test]
        public void LinearConditionalCancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stopOrderId = null;
            //string orderLinkId = null;
            //string symbol = null;
            //var response = instance.LinearConditionalCancel(stopOrderId, orderLinkId, symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test LinearConditionalCancelAll
        /// </summary>
        [Test]
        public void LinearConditionalCancelAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.LinearConditionalCancelAll(symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test LinearConditionalGetOrders
        /// </summary>
        [Test]
        public void LinearConditionalGetOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stopOrderId = null;
            //string orderLinkId = null;
            //string symbol = null;
            //string order = null;
            //string page = null;
            //string limit = null;
            //string stopOrderStatus = null;
            //var response = instance.LinearConditionalGetOrders(stopOrderId, orderLinkId, symbol, order, page, limit, stopOrderStatus);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test LinearConditionalNew
        /// </summary>
        [Test]
        public void LinearConditionalNewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string side = null;
            //string orderType = null;
            //double? qty = null;
            //double? price = null;
            //double? basePrice = null;
            //double? stopPx = null;
            //string timeInForce = null;
            //string triggerBy = null;
            //bool? reduceOnly = null;
            //bool? closeOnTrigger = null;
            //string orderLinkId = null;
            //double? takeProfit = null;
            //double? stopLoss = null;
            //string tpTriggerBy = null;
            //string slTriggerBy = null;
            //var response = instance.LinearConditionalNew(symbol, side, orderType, qty, price, basePrice, stopPx, timeInForce, triggerBy, reduceOnly, closeOnTrigger, orderLinkId, takeProfit, stopLoss, tpTriggerBy, slTriggerBy);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test LinearConditionalQuery
        /// </summary>
        [Test]
        public void LinearConditionalQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string stopOrderId = null;
            //string orderLinkId = null;
            //var response = instance.LinearConditionalQuery(symbol, stopOrderId, orderLinkId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test LinearConditionalReplace
        /// </summary>
        [Test]
        public void LinearConditionalReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string stopOrderId = null;
            //string orderLinkId = null;
            //string pRQty = null;
            //decimal? pRPrice = null;
            //decimal? pRTriggerPrice = null;
            //var response = instance.LinearConditionalReplace(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
