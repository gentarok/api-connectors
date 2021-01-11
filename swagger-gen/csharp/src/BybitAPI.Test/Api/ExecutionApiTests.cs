using NUnit.Framework;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing ExecutionApi
    /// </summary>
    [TestFixture]
    public class ExecutionApiTests
    {
        private ExecutionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init() => instance = new ExecutionApi();

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of ExecutionApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated() => Assert.IsInstanceOf<ExecutionApi>(instance, "instance is a ExecutionApi");

        /// <summary>
        /// Test ExecutionGetTrades
        /// </summary>
        [Test]
        public void ExecutionGetTradesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //string symbol = null;
            //string startTime = null;
            //string page = null;
            //string limit = null;
            //var response = instance.ExecutionGetTrades(orderId, symbol, startTime, page, limit);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }
}