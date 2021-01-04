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

namespace BybitAPI.Test
{
    /// <summary>
    ///  Class for testing LinearOrderRecordsResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LinearOrderRecordsResponseTests
    {
        private LinearOrderRecordsResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LinearOrderRecordsResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearOrderRecordsResponse
        /// </summary>
        [Test]
        public void LinearOrderRecordsResponseInstanceTest()
        {
            Assert.IsInstanceOf<LinearOrderRecordsResponse>(instance, "variable 'instance' is a LinearOrderRecordsResponse");
        }

        ///// <summary>
        ///// Test the property 'CurrentPage'
        ///// </summary>
        //[Test]
        //public void CurrentPageTest()
        //{
        //    // TODO unit test for the property 'CurrentPage'
        //}

        ///// <summary>
        ///// Test the property 'Data'
        ///// </summary>
        //[Test]
        //public void DataTest()
        //{
        //    // TODO unit test for the property 'Data'
        //}
    }
}