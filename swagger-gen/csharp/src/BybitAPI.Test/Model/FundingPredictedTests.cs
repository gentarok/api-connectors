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
    ///  Class for testing FundingPredicted
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FundingPredictedTests
    {
        private FundingPredicted instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FundingPredicted();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of FundingPredicted
        /// </summary>
        [Test]
        public void FundingPredictedInstanceTest()
        {
            Assert.IsInstanceOf<FundingPredicted>(instance, "variable 'instance' is a FundingPredicted");
        }

        ///// <summary>
        ///// Test the property 'PredictedFundingRate'
        ///// </summary>
        //[Test]
        //public void PredictedFundingRateTest()
        //{
        //    // TODO unit test for the property 'PredictedFundingRate'
        //}

        ///// <summary>
        ///// Test the property 'PredictedFundingFee'
        ///// </summary>
        //[Test]
        //public void PredictedFundingFeeTest()
        //{
        //    // TODO unit test for the property 'PredictedFundingFee'
        //}
    }
}