using NUnit.Framework;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing FundingApi
    /// </summary>
    [TestFixture]
    public class FundingApiTests
    {
        private FundingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init() => instance = new FundingApi();

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of FundingApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated() => Assert.IsInstanceOf<FundingApi>(instance, "instance is a FundingApi");

        ///// <summary>
        ///// Test FundingMyLastFee
        ///// </summary>
        //[Test]
        //public void FundingMyLastFeeTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //var response = instance.FundingMyLastFee(symbol);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test FundingPredicted
        ///// </summary>
        //[Test]
        //public void FundingPredictedTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //var response = instance.FundingPredicted(symbol);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        ///// <summary>
        ///// Test FundingPrevRate
        ///// </summary>
        //[Test]
        //public void FundingPrevRateTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //var response = instance.FundingPrevRate(symbol);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}
    }
}