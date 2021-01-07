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
    ///  Class for testing LinearCancelOrderResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LinearCancelOrderResultTests
    {
        private LinearCancelOrderResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init() => instance = new LinearCancelOrderResult();

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearCancelOrderResult
        /// </summary>
        [Test]
        public void LinearCancelOrderResultInstance_ShouldBeCreated() => Assert.IsInstanceOf<LinearCancelOrderResult>(instance, "variable 'instance' is a LinearCancelOrderResult");

        ///// <summary>
        ///// Test the property 'OrderId'
        ///// </summary>
        //[Test]
        //public void OrderIdTest()
        //{
        //    // TODO unit test for the property 'OrderId'
        //}
    }
}