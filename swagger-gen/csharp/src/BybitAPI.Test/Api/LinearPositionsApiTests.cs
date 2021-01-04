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
    ///  Class for testing LinearPositionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LinearPositionsApiTests
    {
        private LinearPositionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LinearPositionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearPositionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LinearPositionsApi
            //Assert.IsInstanceOfType(typeof(LinearPositionsApi), instance, "instance is a LinearPositionsApi");
        }

        /// <summary>
        /// Test LinearPositionsChangeMargin
        /// </summary>
        [Test]
        public void LinearPositionsChangeMarginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string side = null;
            //double? margin = null;
            //var response = instance.LinearPositionsChangeMargin(symbol, side, margin);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test LinearPositionsClosePnlRecords
        /// </summary>
        [Test]
        public void LinearPositionsClosePnlRecordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //long? startTime = null;
            //long? endTime = null;
            //string execType = null;
            //long? page = null;
            //long? limit = null;
            //var response = instance.LinearPositionsClosePnlRecords(symbol, startTime, endTime, execType, page, limit);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test LinearPositionsMyPosition
        /// </summary>
        [Test]
        public void LinearPositionsMyPositionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.LinearPositionsMyPosition(symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test LinearPositionsSaveLeverage
        /// </summary>
        [Test]
        public void LinearPositionsSaveLeverageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //double? buyLeverage = null;
            //double? sellLeverage = null;
            //var response = instance.LinearPositionsSaveLeverage(symbol, buyLeverage, sellLeverage);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test LinearPositionsSetAutoAddMargin
        /// </summary>
        [Test]
        public void LinearPositionsSetAutoAddMarginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string side = null;
            //bool? autoAddMargin = null;
            //var response = instance.LinearPositionsSetAutoAddMargin(symbol, side, autoAddMargin);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test LinearPositionsSwitchIsolated
        /// </summary>
        [Test]
        public void LinearPositionsSwitchIsolatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //bool? isIsolated = null;
            //double? buyLeverage = null;
            //double? sellLeverage = null;
            //var response = instance.LinearPositionsSwitchIsolated(symbol, isIsolated, buyLeverage, sellLeverage);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test LinearPositionsSwitchMode
        /// </summary>
        [Test]
        public void LinearPositionsSwitchModeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string tpSlMode = null;
            //var response = instance.LinearPositionsSwitchMode(symbol, tpSlMode);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test LinearPositionsTradingStop
        /// </summary>
        [Test]
        public void LinearPositionsTradingStopTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string side = null;
            //double? takeProfit = null;
            //double? stopLoss = null;
            //double? trailingStop = null;
            //string tpTriggerBy = null;
            //string slTriggerBy = null;
            //double? slSize = null;
            //double? tpSize = null;
            //var response = instance.LinearPositionsTradingStop(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }
}