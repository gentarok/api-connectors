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
    ///  Class for testing KlineRes
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class KlineResTests
    {
        private KlineRes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new KlineRes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of KlineRes
        /// </summary>
        [Test]
        public void KlineResInstanceTest()
        {
            Assert.IsInstanceOf<KlineRes>(instance, "variable 'instance' is a KlineRes");
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
        ///// Test the property 'Interval'
        ///// </summary>
        //[Test]
        //public void IntervalTest()
        //{
        //    // TODO unit test for the property 'Interval'
        //}

        ///// <summary>
        ///// Test the property 'OpenTime'
        ///// </summary>
        //[Test]
        //public void OpenTimeTest()
        //{
        //    // TODO unit test for the property 'OpenTime'
        //}

        ///// <summary>
        ///// Test the property 'Open'
        ///// </summary>
        //[Test]
        //public void OpenTest()
        //{
        //    // TODO unit test for the property 'Open'
        //}

        ///// <summary>
        ///// Test the property 'High'
        ///// </summary>
        //[Test]
        //public void HighTest()
        //{
        //    // TODO unit test for the property 'High'
        //}

        ///// <summary>
        ///// Test the property 'Low'
        ///// </summary>
        //[Test]
        //public void LowTest()
        //{
        //    // TODO unit test for the property 'Low'
        //}

        ///// <summary>
        ///// Test the property 'Close'
        ///// </summary>
        //[Test]
        //public void CloseTest()
        //{
        //    // TODO unit test for the property 'Close'
        //}

        ///// <summary>
        ///// Test the property 'Volume'
        ///// </summary>
        //[Test]
        //public void VolumeTest()
        //{
        //    // TODO unit test for the property 'Volume'
        //}
    }
}