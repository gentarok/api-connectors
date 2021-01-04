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
    ///  Class for testing LinearExecutionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LinearExecutionApiTests
    {
        private LinearExecutionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LinearExecutionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearExecutionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<LinearExecutionApi>(instance, "instance is a LinearExecutionApi");
        }

        ///// <summary>
        ///// Test LinearExecutionGetTrades
        ///// </summary>
        //[Test]
        //public void LinearExecutionGetTradesTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //long? startTime = null;
        //    //long? endTime = null;
        //    //string execType = null;
        //    //long? page = null;
        //    //long? limit = null;
        //    //var response = instance.LinearExecutionGetTrades(symbol, startTime, endTime, execType, page, limit);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}
    }
}