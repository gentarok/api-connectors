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
    ///  Class for testing LeverageResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LeverageResultTests
    {
        private LeverageResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LeverageResult();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LeverageResult
        /// </summary>
        [Test]
        public void LeverageResultInstance_ShouldBeCreated()
        {
            Assert.IsInstanceOf<LeverageResult>(instance, "variable 'instance' is a LeverageResult");
        }

        ///// <summary>
        ///// Test the property 'BTCUSD'
        ///// </summary>
        //[Test]
        //public void BTCUSDTest()
        //{
        //    // TODO unit test for the property 'BTCUSD'
        //}

        ///// <summary>
        ///// Test the property 'EOSUSD'
        ///// </summary>
        //[Test]
        //public void EOSUSDTest()
        //{
        //    // TODO unit test for the property 'EOSUSD'
        //}

        ///// <summary>
        ///// Test the property 'ETHUSD'
        ///// </summary>
        //[Test]
        //public void ETHUSDTest()
        //{
        //    // TODO unit test for the property 'ETHUSD'
        //}

        ///// <summary>
        ///// Test the property 'XRPUSD'
        ///// </summary>
        //[Test]
        //public void XRPUSDTest()
        //{
        //    // TODO unit test for the property 'XRPUSD'
        //}
    }
}