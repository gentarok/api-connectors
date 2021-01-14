using NUnit.Framework;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing LinearWalletApi
    /// </summary>
    [TestFixture]
    public class LinearWalletApiTests
    {
        private LinearWalletApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init() => instance = new LinearWalletApi();

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// Test an instance of LinearWalletApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated() => Assert.IsInstanceOf<LinearWalletApi>(instance, "instance is a LinearWalletApi");

        ///// <summary>
        ///// Test LinearWalletGetRiskLimit
        ///// </summary>
        //[Test]
        //public void LinearWalletGetRiskLimitTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //var response = instance.LinearWalletGetRiskLimit();
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}
    }
}