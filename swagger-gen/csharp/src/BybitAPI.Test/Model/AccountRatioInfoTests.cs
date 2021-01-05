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
    ///  Class for testing AccountRatioInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AccountRatioInfoTests
    {
        private AccountRatioInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountRatioInfo();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of AccountRatioInfo
        /// </summary>
        [Test]
        public void AccountRatioInfoInstance_ShouldBeCreated()
        {
            Assert.IsInstanceOf<AccountRatioInfo>(instance, "variable 'instance' is a AccountRatioInfo");
        }

        ///// <summary>
        ///// Test the property 'BuyRatio'
        ///// </summary>
        //[Test]
        //public void BuyRatioTest()
        //{
        //    // TODO unit test for the property 'BuyRatio'
        //}

        ///// <summary>
        ///// Test the property 'SellRatio'
        ///// </summary>
        //[Test]
        //public void SellRatioTest()
        //{
        //    // TODO unit test for the property 'SellRatio'
        //}

        ///// <summary>
        ///// Test the property 'Timestamp'
        ///// </summary>
        //[Test]
        //public void TimestampTest()
        //{
        //    // TODO unit test for the property 'Timestamp'
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