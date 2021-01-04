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
    ///  Class for testing V2OrderListData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class V2OrderListDataTests
    {
        private V2OrderListData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new V2OrderListData();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of V2OrderListData
        /// </summary>
        [Test]
        public void V2OrderListDataInstanceTest()
        {
            Assert.IsInstanceOf<V2OrderListData>(instance, "variable 'instance' is a V2OrderListData");
        }

        ///// <summary>
        ///// Test the property 'Data'
        ///// </summary>
        //[Test]
        //public void DataTest()
        //{
        //    // TODO unit test for the property 'Data'
        //}

        ///// <summary>
        ///// Test the property 'Cursor'
        ///// </summary>
        //[Test]
        //public void CursorTest()
        //{
        //    // TODO unit test for the property 'Cursor'
        //}
    }
}