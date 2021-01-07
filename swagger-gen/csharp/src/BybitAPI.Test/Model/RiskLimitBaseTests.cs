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
    ///  Class for testing RiskLimitBase
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RiskLimitBaseTests
    {
        private RiskLimitBase instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init() => instance = new RiskLimitBase();

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of RiskLimitBase
        /// </summary>
        [Test]
        public void RiskLimitBaseInstance_ShouldBeCreated() => Assert.IsInstanceOf<RiskLimitBase>(instance, "variable 'instance' is a RiskLimitBase");

        ///// <summary>
        ///// Test the property 'RetCode'
        ///// </summary>
        //[Test]
        //public void RetCodeTest()
        //{
        //    // TODO unit test for the property 'RetCode'
        //}

        ///// <summary>
        ///// Test the property 'RetMsg'
        ///// </summary>
        //[Test]
        //public void RetMsgTest()
        //{
        //    // TODO unit test for the property 'RetMsg'
        //}

        ///// <summary>
        ///// Test the property 'ExtCode'
        ///// </summary>
        //[Test]
        //public void ExtCodeTest()
        //{
        //    // TODO unit test for the property 'ExtCode'
        //}

        ///// <summary>
        ///// Test the property 'ExtInfo'
        ///// </summary>
        //[Test]
        //public void ExtInfoTest()
        //{
        //    // TODO unit test for the property 'ExtInfo'
        //}

        ///// <summary>
        ///// Test the property 'Result'
        ///// </summary>
        //[Test]
        //public void ResultTest()
        //{
        //    // TODO unit test for the property 'Result'
        //}

        ///// <summary>
        ///// Test the property 'TimeNow'
        ///// </summary>
        //[Test]
        //public void TimeNowTest()
        //{
        //    // TODO unit test for the property 'TimeNow'
        //}
    }
}