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
    ///  Class for testing FundingRecords
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FundingRecordsTests
    {
        private FundingRecords instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FundingRecords();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of FundingRecords
        /// </summary>
        [Test]
        public void FundingRecordsInstance_ShouldBeCreated()
        {
            Assert.IsInstanceOf<FundingRecords>(instance, "variable 'instance' is a FundingRecords");
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
        ///// Test the property 'UserId'
        ///// </summary>
        //[Test]
        //public void UserIdTest()
        //{
        //    // TODO unit test for the property 'UserId'
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
        ///// Test the property 'WalletId'
        ///// </summary>
        //[Test]
        //public void WalletIdTest()
        //{
        //    // TODO unit test for the property 'WalletId'
        //}

        ///// <summary>
        ///// Test the property 'Type'
        ///// </summary>
        //[Test]
        //public void TypeTest()
        //{
        //    // TODO unit test for the property 'Type'
        //}

        ///// <summary>
        ///// Test the property 'Amount'
        ///// </summary>
        //[Test]
        //public void AmountTest()
        //{
        //    // TODO unit test for the property 'Amount'
        //}

        ///// <summary>
        ///// Test the property 'TxId'
        ///// </summary>
        //[Test]
        //public void TxIdTest()
        //{
        //    // TODO unit test for the property 'TxId'
        //}

        ///// <summary>
        ///// Test the property 'Address'
        ///// </summary>
        //[Test]
        //public void AddressTest()
        //{
        //    // TODO unit test for the property 'Address'
        //}

        ///// <summary>
        ///// Test the property 'WalletBalance'
        ///// </summary>
        //[Test]
        //public void WalletBalanceTest()
        //{
        //    // TODO unit test for the property 'WalletBalance'
        //}

        ///// <summary>
        ///// Test the property 'ExecTime'
        ///// </summary>
        //[Test]
        //public void ExecTimeTest()
        //{
        //    // TODO unit test for the property 'ExecTime'
        //}

        ///// <summary>
        ///// Test the property 'CrossSeq'
        ///// </summary>
        //[Test]
        //public void CrossSeqTest()
        //{
        //    // TODO unit test for the property 'CrossSeq'
        //}
    }
}