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
    ///  Class for testing LinearFundingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LinearFundingApiTests
    {
        private LinearFundingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LinearFundingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearFundingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LinearFundingApi
            //Assert.IsInstanceOfType(typeof(LinearFundingApi), instance, "instance is a LinearFundingApi");
        }

        /// <summary>
        /// Test LinearFundingMyLastFee
        /// </summary>
        [Test]
        public void LinearFundingMyLastFeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.LinearFundingMyLastFee(symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test LinearFundingPredicted
        /// </summary>
        [Test]
        public void LinearFundingPredictedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.LinearFundingPredicted(symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        /// <summary>
        /// Test LinearFundingPrevRate
        /// </summary>
        [Test]
        public void LinearFundingPrevRateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.LinearFundingPrevRate(symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }
}