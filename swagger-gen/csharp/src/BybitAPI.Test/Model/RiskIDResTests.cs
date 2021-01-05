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
    ///  Class for testing RiskIDRes
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RiskIDResTests
    {
        private RiskIDRes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RiskIDRes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of RiskIDRes
        /// </summary>
        [Test]
        public void RiskIDResInstance_ShouldBeCreated()
        {
            Assert.IsInstanceOf<RiskIDRes>(instance, "variable 'instance' is a RiskIDRes");
        }

        ///// <summary>
        ///// Test the property 'Id'
        ///// </summary>
        //[Test]
        //public void IdTest()
        //{
        //    // TODO unit test for the property 'Id'
        //}

        ///// <summary>
        ///// Test the property 'Coin'
        ///// </summary>
        //[Test]
        //public void CoinTest()
        //{
        //    // TODO unit test for the property 'Coin'
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
        ///// Test the property 'StartingMargin'
        ///// </summary>
        //[Test]
        //public void StartingMarginTest()
        //{
        //    // TODO unit test for the property 'StartingMargin'
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
        ///// Test the property 'IsLowestRisk'
        ///// </summary>
        //[Test]
        //public void IsLowestRiskTest()
        //{
        //    // TODO unit test for the property 'IsLowestRisk'
        //}

        ///// <summary>
        ///// Test the property 'CreatedAt'
        ///// </summary>
        //[Test]
        //public void CreatedAtTest()
        //{
        //    // TODO unit test for the property 'CreatedAt'
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