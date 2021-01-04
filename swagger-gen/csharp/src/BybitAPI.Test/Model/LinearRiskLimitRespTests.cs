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
    ///  Class for testing LinearRiskLimitResp
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LinearRiskLimitRespTests
    {
        private LinearRiskLimitResp instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LinearRiskLimitResp();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearRiskLimitResp
        /// </summary>
        [Test]
        public void LinearRiskLimitRespInstanceTest()
        {
            Assert.IsInstanceOf<LinearRiskLimitResp>(instance, "variable 'instance' is a LinearRiskLimitResp");
        }

        ///// <summary>
        ///// Test the property 'CreatedAt'
        ///// </summary>
        //[Test]
        //public void CreatedAtTest()
        //{
        //    // TODO unit test for the property 'CreatedAt'
        //}

        ///// <summary>
        ///// Test the property 'Id'
        ///// </summary>
        //[Test]
        //public void IdTest()
        //{
        //    // TODO unit test for the property 'Id'
        //}

        ///// <summary>
        ///// Test the property 'IsLowestRisk'
        ///// </summary>
        //[Test]
        //public void IsLowestRiskTest()
        //{
        //    // TODO unit test for the property 'IsLowestRisk'
        //}

        ///// <summary>
        ///// Test the property 'Limit'
        ///// </summary>
        //[Test]
        //public void LimitTest()
        //{
        //    // TODO unit test for the property 'Limit'
        //}

        ///// <summary>
        ///// Test the property 'MaintainMargin'
        ///// </summary>
        //[Test]
        //public void MaintainMarginTest()
        //{
        //    // TODO unit test for the property 'MaintainMargin'
        //}

        ///// <summary>
        ///// Test the property 'Section'
        ///// </summary>
        //[Test]
        //public void SectionTest()
        //{
        //    // TODO unit test for the property 'Section'
        //}

        ///// <summary>
        ///// Test the property 'StartingMargin'
        ///// </summary>
        //[Test]
        //public void StartingMarginTest()
        //{
        //    // TODO unit test for the property 'StartingMargin'
        //}

        ///// <summary>
        ///// Test the property 'Symbol'
        ///// </summary>
        //[Test]
        //public void SymbolTest()
        //{
        //    // TODO unit test for the property 'Symbol'
        //}

        ///// <summary>
        ///// Test the property 'UpdatedAt'
        ///// </summary>
        //[Test]
        //public void UpdatedAtTest()
        //{
        //    // TODO unit test for the property 'UpdatedAt'
        //}
    }
}