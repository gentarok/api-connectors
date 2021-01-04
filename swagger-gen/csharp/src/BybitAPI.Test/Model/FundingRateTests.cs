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

namespace BybitAPI.Model.Test
{
    /// <summary>
    ///  Class for testing FundingRate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FundingRateTests
    {
        private FundingRate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FundingRate();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of FundingRate
        /// </summary>
        [Test]
        public void FundingRateInstanceTest()
        {
            Assert.IsInstanceOf<FundingRate>(instance, "variable 'instance' is a FundingRate");
        }

        ///// <summary>
        ///// Test the property 'Symbol'
        ///// </summary>
        //[Test]
        //public void SymbolTest()
        //{
        //    // TODO unit test for the property 'Symbol'
        //}

        ///// <summary>
        ///// Test the property '_FundingRate'
        ///// </summary>
        //[Test]
        //public void _FundingRateTest()
        //{
        //    // TODO unit test for the property '_FundingRate'
        //}

        ///// <summary>
        ///// Test the property 'FundingRateTimestamp'
        ///// </summary>
        //[Test]
        //public void FundingRateTimestampTest()
        //{
        //    // TODO unit test for the property 'FundingRateTimestamp'
        //}
    }
}