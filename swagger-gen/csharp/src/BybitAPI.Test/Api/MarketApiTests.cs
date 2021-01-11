using NUnit.Framework;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing MarketApi
    /// </summary>
    /// <remarks>
    [TestFixture]
    public class MarketApiTests
    {
        private MarketApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init() => instance = new MarketApi();

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of MarketApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated() => Assert.IsInstanceOf<MarketApi>(instance, "instance is a MarketApi");

        ///// <summary>
        ///// Test MarketAccountRatio
        ///// </summary>
        //[Test]
        //public void MarketAccountRatioTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //string period = null;
        //    //int? limit = null;
        //    //var response = instance.MarketAccountRatio(symbol, period, limit);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test MarketBigDeal
        ///// </summary>
        //[Test]
        //public void MarketBigDealTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //int? limit = null;
        //    //var response = instance.MarketBigDeal(symbol, limit);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test MarketLiqRecords
        ///// </summary>
        //[Test]
        //public void MarketLiqRecordsTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //int? from = null;
        //    //int? limit = null;
        //    //int? startTime = null;
        //    //int? endTime = null;
        //    //var response = instance.MarketLiqRecords(symbol, from, limit, startTime, endTime);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test MarketOpenInterest
        ///// </summary>
        //[Test]
        //public void MarketOpenInterestTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //string period = null;
        //    //int? limit = null;
        //    //var response = instance.MarketOpenInterest(symbol, period, limit);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test MarketOrderbook
        ///// </summary>
        //[Test]
        //public void MarketOrderbookTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //var response = instance.MarketOrderbook(symbol);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test MarketSymbolInfo
        ///// </summary>
        //[Test]
        //public void MarketSymbolInfoTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //var response = instance.MarketSymbolInfo(symbol);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test MarketTradingRecords
        ///// </summary>
        //[Test]
        //public void MarketTradingRecordsTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //int? from = null;
        //    //int? limit = null;
        //    //var response = instance.MarketTradingRecords(symbol, from, limit);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}
    }
}