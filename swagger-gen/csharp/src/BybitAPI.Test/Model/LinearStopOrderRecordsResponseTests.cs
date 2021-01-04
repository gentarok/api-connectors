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
    ///  Class for testing LinearStopOrderRecordsResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LinearStopOrderRecordsResponseTests
    {
        private LinearStopOrderRecordsResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LinearStopOrderRecordsResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearStopOrderRecordsResponse
        /// </summary>
        [Test]
        public void LinearStopOrderRecordsResponseInstanceTest()
        {
            Assert.IsInstanceOf<LinearStopOrderRecordsResponse>(instance, "variable 'instance' is a LinearStopOrderRecordsResponse");
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
        ///// Test the property 'LastPage'
        ///// </summary>
        //[Test]
        //public void LastPageTest()
        //{
        //    // TODO unit test for the property 'LastPage'
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