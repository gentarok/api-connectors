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
    ///  Class for testing ExecutionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ExecutionApiTests
    {
        private ExecutionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExecutionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of ExecutionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ExecutionApi
            //Assert.IsInstanceOfType(typeof(ExecutionApi), instance, "instance is a ExecutionApi");
        }

        /// <summary>
        /// Test ExecutionGetTrades
        /// </summary>
        [Test]
        public void ExecutionGetTradesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //string symbol = null;
            //string startTime = null;
            //string page = null;
            //string limit = null;
            //var response = instance.ExecutionGetTrades(orderId, symbol, startTime, page, limit);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test PositionsClosePnlRecords
        /// </summary>
        [Test]
        public void PositionsClosePnlRecordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //int? startTime = null;
            //int? endTime = null;
            //string execType = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.PositionsClosePnlRecords(symbol, startTime, endTime, execType, page, limit);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }
}