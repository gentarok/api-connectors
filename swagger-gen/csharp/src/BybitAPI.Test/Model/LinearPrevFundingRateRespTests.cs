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
    ///  Class for testing LinearPrevFundingRateResp
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LinearPrevFundingRateRespTests
    {
        private LinearPrevFundingRateResp instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LinearPrevFundingRateResp();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearPrevFundingRateResp
        /// </summary>
        [Test]
        public void LinearPrevFundingRateRespInstance_ShouldBeCreated()
        {
            Assert.IsInstanceOf<LinearPrevFundingRateResp>(instance, "variable 'instance' is a LinearPrevFundingRateResp");
        }

        ///// <summary>
        ///// Test the property 'FundingRate'
        ///// </summary>
        //[Test]
        //public void FundingRateTest()
        //{
        //    // TODO unit test for the property 'FundingRate'
        //}

        ///// <summary>
        ///// Test the property 'FundingRateTimestamp'
        ///// </summary>
        //[Test]
        //public void FundingRateTimestampTest()
        //{
        //    // TODO unit test for the property 'FundingRateTimestamp'
        //}

        ///// <summary>
        ///// Test the property 'Symbol'
        ///// </summary>
        //[Test]
        //public void SymbolTest()
        //{
        //    // TODO unit test for the property 'Symbol'
        //}
    }
}