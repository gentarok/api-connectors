/*
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api.bybit.com]
 *
 * OpenAPI spec version: 0.2.10
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using BybitAPI.Model;
using NUnit.Framework;

namespace BybitAPI.Model.Test
{
    /// <summary>
    ///  Class for testing PriceFilter
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PriceFilterTests
    {
        private PriceFilter instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PriceFilter();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of PriceFilter
        /// </summary>
        [Test]
        public void PriceFilterInstanceTest()
        {
            Assert.IsInstanceOf<PriceFilter>(instance, "variable 'instance' is a PriceFilter");
        }

        ///// <summary>
        ///// Test the property 'MinPrice'
        ///// </summary>
        //[Test]
        //public void MinPriceTest()
        //{
        //    // TODO unit test for the property 'MinPrice'
        //}

        ///// <summary>
        ///// Test the property 'MaxPrice'
        ///// </summary>
        //[Test]
        //public void MaxPriceTest()
        //{
        //    // TODO unit test for the property 'MaxPrice'
        //}

        ///// <summary>
        ///// Test the property 'TickSize'
        ///// </summary>
        //[Test]
        //public void TickSizeTest()
        //{
        //    // TODO unit test for the property 'TickSize'
        //}
    }
}