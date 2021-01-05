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
    ///  Class for testing LinearKlineApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LinearKlineApiTests
    {
        private LinearKlineApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LinearKlineApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearKlineApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated()
        {
            Assert.IsInstanceOf<LinearKlineApi>(instance, "instance is a LinearKlineApi");
        }

        ///// <summary>
        ///// Test LinearKlineGet
        ///// </summary>
        //[Test]
        //public void LinearKlineGetTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //string interval = null;
        //    //decimal? from = null;
        //    //decimal? limit = null;
        //    //var response = instance.LinearKlineGet(symbol, interval, from, limit);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test LinearKlineMarkPrice
        ///// </summary>
        //[Test]
        //public void LinearKlineMarkPriceTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //string interval = null;
        //    //decimal? from = null;
        //    //decimal? limit = null;
        //    //var response = instance.LinearKlineMarkPrice(symbol, interval, from, limit);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}
    }
}