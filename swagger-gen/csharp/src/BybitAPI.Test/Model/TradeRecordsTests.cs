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
    ///  Class for testing TradeRecords
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TradeRecordsTests
    {
        private TradeRecords instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TradeRecords();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of TradeRecords
        /// </summary>
        [Test]
        public void TradeRecordsInstance_ShouldBeCreated()
        {
            Assert.IsInstanceOf<TradeRecords>(instance, "variable 'instance' is a TradeRecords");
        }

        ///// <summary>
        ///// Test the property 'OrderId'
        ///// </summary>
        //[Test]
        //public void OrderIdTest()
        //{
        //    // TODO unit test for the property 'OrderId'
        //}

        ///// <summary>
        ///// Test the property 'TradeList'
        ///// </summary>
        //[Test]
        //public void TradeListTest()
        //{
        //    // TODO unit test for the property 'TradeList'
        //}
    }
}