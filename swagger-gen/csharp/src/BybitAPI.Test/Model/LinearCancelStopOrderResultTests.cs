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
    ///  Class for testing LinearCancelStopOrderResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LinearCancelStopOrderResultTests
    {
        private LinearCancelStopOrderResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LinearCancelStopOrderResult();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearCancelStopOrderResult
        /// </summary>
        [Test]
        public void LinearCancelStopOrderResultInstance_ShouldBeCreated()
        {
            Assert.IsInstanceOf<LinearCancelStopOrderResult>(instance, "variable 'instance' is a LinearCancelStopOrderResult");
        }

        ///// <summary>
        ///// Test the property 'StopOrderId'
        ///// </summary>
        //[Test]
        //public void StopOrderIdTest()
        //{
        //    // TODO unit test for the property 'StopOrderId'
        //}
    }
}