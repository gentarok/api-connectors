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
    ///  Class for testing ExchangeOrderList
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExchangeOrderListTests
    {
        private ExchangeOrderList instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExchangeOrderList();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of ExchangeOrderList
        /// </summary>
        [Test]
        public void ExchangeOrderListInstanceTest()
        {
            Assert.IsInstanceOf<ExchangeOrderList>(instance, "variable 'instance' is a ExchangeOrderList");
        }

        ///// <summary>
        ///// Test the property 'FromCoin'
        ///// </summary>
        //[Test]
        //public void FromCoinTest()
        //{
        //    // TODO unit test for the property 'FromCoin'
        //}

        ///// <summary>
        ///// Test the property 'ToCoin'
        ///// </summary>
        //[Test]
        //public void ToCoinTest()
        //{
        //    // TODO unit test for the property 'ToCoin'
        //}

        ///// <summary>
        ///// Test the property 'FromAmount'
        ///// </summary>
        //[Test]
        //public void FromAmountTest()
        //{
        //    // TODO unit test for the property 'FromAmount'
        //}

        ///// <summary>
        ///// Test the property 'ToAmount'
        ///// </summary>
        //[Test]
        //public void ToAmountTest()
        //{
        //    // TODO unit test for the property 'ToAmount'
        //}

        ///// <summary>
        ///// Test the property 'ExchangeRate'
        ///// </summary>
        //[Test]
        //public void ExchangeRateTest()
        //{
        //    // TODO unit test for the property 'ExchangeRate'
        //}

        ///// <summary>
        ///// Test the property 'FromFee'
        ///// </summary>
        //[Test]
        //public void FromFeeTest()
        //{
        //    // TODO unit test for the property 'FromFee'
        //}

        ///// <summary>
        ///// Test the property 'CreatedAt'
        ///// </summary>
        //[Test]
        //public void CreatedAtTest()
        //{
        //    // TODO unit test for the property 'CreatedAt'
        //}
    }
}