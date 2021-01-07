/*
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api.bybit.com]
 *
 * OpenAPI spec version: 0.2.10
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing LinearMarketApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LinearMarketApiTests
    {
        private LinearMarketApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init() => instance = new LinearMarketApi();

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearMarketApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated() => Assert.IsInstanceOf<LinearMarketApi>(instance, "instance is a LinearMarketApi");

        ///// <summary>
        ///// Test LinearMarketTrading
        ///// </summary>
        //[Test]
        //public void LinearMarketTradingTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //string limit = null;
        //    //var response = instance.LinearMarketTrading(symbol, limit);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}
    }
}