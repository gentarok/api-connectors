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
    ///  Class for testing OrderRes
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class OrderResTests
    {
        private OrderRes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderRes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of OrderRes
        /// </summary>
        [Test]
        public void OrderResInstanceTest()
        {
            Assert.IsInstanceOf<OrderRes>(instance, "variable 'instance' is a OrderRes");
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
        ///// Test the property 'UserId'
        ///// </summary>
        //[Test]
        //public void UserIdTest()
        //{
        //    // TODO unit test for the property 'UserId'
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
        ///// Test the property 'Side'
        ///// </summary>
        //[Test]
        //public void SideTest()
        //{
        //    // TODO unit test for the property 'Side'
        //}

        ///// <summary>
        ///// Test the property 'OrderType'
        ///// </summary>
        //[Test]
        //public void OrderTypeTest()
        //{
        //    // TODO unit test for the property 'OrderType'
        //}

        ///// <summary>
        ///// Test the property 'Price'
        ///// </summary>
        //[Test]
        //public void PriceTest()
        //{
        //    // TODO unit test for the property 'Price'
        //}

        ///// <summary>
        ///// Test the property 'Qty'
        ///// </summary>
        //[Test]
        //public void QtyTest()
        //{
        //    // TODO unit test for the property 'Qty'
        //}

        ///// <summary>
        ///// Test the property 'TimeInForce'
        ///// </summary>
        //[Test]
        //public void TimeInForceTest()
        //{
        //    // TODO unit test for the property 'TimeInForce'
        //}

        ///// <summary>
        ///// Test the property 'OrderStatus'
        ///// </summary>
        //[Test]
        //public void OrderStatusTest()
        //{
        //    // TODO unit test for the property 'OrderStatus'
        //}

        ///// <summary>
        ///// Test the property 'LastExecTime'
        ///// </summary>
        //[Test]
        //public void LastExecTimeTest()
        //{
        //    // TODO unit test for the property 'LastExecTime'
        //}

        ///// <summary>
        ///// Test the property 'LastExecPrice'
        ///// </summary>
        //[Test]
        //public void LastExecPriceTest()
        //{
        //    // TODO unit test for the property 'LastExecPrice'
        //}

        ///// <summary>
        ///// Test the property 'LeavesQty'
        ///// </summary>
        //[Test]
        //public void LeavesQtyTest()
        //{
        //    // TODO unit test for the property 'LeavesQty'
        //}

        ///// <summary>
        ///// Test the property 'CumExecQty'
        ///// </summary>
        //[Test]
        //public void CumExecQtyTest()
        //{
        //    // TODO unit test for the property 'CumExecQty'
        //}

        ///// <summary>
        ///// Test the property 'CumExecValue'
        ///// </summary>
        //[Test]
        //public void CumExecValueTest()
        //{
        //    // TODO unit test for the property 'CumExecValue'
        //}

        ///// <summary>
        ///// Test the property 'CumExecFee'
        ///// </summary>
        //[Test]
        //public void CumExecFeeTest()
        //{
        //    // TODO unit test for the property 'CumExecFee'
        //}

        ///// <summary>
        ///// Test the property 'RejectReason'
        ///// </summary>
        //[Test]
        //public void RejectReasonTest()
        //{
        //    // TODO unit test for the property 'RejectReason'
        //}

        ///// <summary>
        ///// Test the property 'OrderLinkId'
        ///// </summary>
        //[Test]
        //public void OrderLinkIdTest()
        //{
        //    // TODO unit test for the property 'OrderLinkId'
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