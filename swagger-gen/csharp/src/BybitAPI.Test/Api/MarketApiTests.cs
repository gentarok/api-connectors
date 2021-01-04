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
    ///  Class for testing MarketApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MarketApiTests
    {
        private MarketApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MarketApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of MarketApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MarketApi
            Assert.IsInstanceOf(typeof(MarketApi), instance, "instance is a MarketApi");
        }

        /// <summary>
        /// Test MarketAccountRatio
        /// </summary>
        [Test]
        public void MarketAccountRatioTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string period = null;
            //int? limit = null;
            //var response = instance.MarketAccountRatio(symbol, period, limit);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test MarketBigDeal
        /// </summary>
        [Test]
        public void MarketBigDealTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //int? limit = null;
            //var response = instance.MarketBigDeal(symbol, limit);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test MarketLiqRecords
        /// </summary>
        [Test]
        public void MarketLiqRecordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //int? from = null;
            //int? limit = null;
            //int? startTime = null;
            //int? endTime = null;
            //var response = instance.MarketLiqRecords(symbol, from, limit, startTime, endTime);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test MarketOpenInterest
        /// </summary>
        [Test]
        public void MarketOpenInterestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string period = null;
            //int? limit = null;
            //var response = instance.MarketOpenInterest(symbol, period, limit);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test MarketOrderbook
        /// </summary>
        [Test]
        public void MarketOrderbookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.MarketOrderbook(symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test MarketSymbolInfo
        /// </summary>
        [Test]
        public void MarketSymbolInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.MarketSymbolInfo(symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test MarketTradingRecords
        /// </summary>
        [Test]
        public void MarketTradingRecordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //int? from = null;
            //int? limit = null;
            //var response = instance.MarketTradingRecords(symbol, from, limit);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }
}
