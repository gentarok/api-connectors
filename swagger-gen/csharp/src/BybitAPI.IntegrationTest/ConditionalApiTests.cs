using BybitAPI.Api;
using BybitAPI.Client;
using BybitAPI.IntegrationTest.Util;
using BybitAPI.Model;
using NUnit.Framework;

namespace BybitAPI.IntegrationTest
{
    [TestFixture]
    public class ConditionalApiTests
    {
        private static ConditionalApi Create()
        {
            // Prepeare configurations to test.
            var configuration = new Configuration
            {
                BasePath = TestUtil.TESTNET_URI
            };
            configuration.ApiKey.Add("api_key", TestUtil.GetTestApiKey());
            configuration.ApiKey.Add("api_secret", TestUtil.GetTestApiSecret());
            return new ConditionalApi(configuration);
        }

        //[Test]
        //public void ConditionalCancel_ShouldReturnOrderCancelBase()
        //{
        //    // Arrange

        //    //TODO: Create new conditional order.

        //    string symbol = "BTCUSD";
        //    string stopOrderId = "0";
        //    string orderLinkId = null;

        //    // Act
        //    var response = instance.ConditionalCancel(symbol, stopOrderId, orderLinkId);

        //    // Assert
        //    Assert.IsInstanceOf<OrderCancelBase>(response, "response is APIKeyBase");
        //    Assert.That(response.RetCode, Is.EqualTo(0), $"API error has occered: {response.RetMsg}");
        //}

        [Test]
        [TestCase("", "", 10001)]
        [TestCase("0", null, 20001)]
        [TestCase(null, "0", 20001)]
        public void ConditionalCancel_ParametersAreInvalid_ShouldReturnApiError(string stopOrderId, string orderLinkId, decimal expectedRetCode)
        {
            // Arrange
            var instance = Create();

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.ConditionalCancel(symbol, stopOrderId, orderLinkId);

            // Assert
            Assert.That(response.RetCode, Is.EqualTo(expectedRetCode), $"API error has occered: {response.RetMsg}");
        }

        //[Test]
        //public void ConditionalCancelWithHttpInfo_ShouldReturnApiRespenseOfOrderCancelBase()
        //{
        //    // Arrange

        //    //TODO: Create new conditional order.

        //    string symbol = "BTCUSD";
        //    string stopOrderId = "0";
        //    string orderLinkId = null;

        //    // Act
        //    var response = instance.ConditionalCancelWithHttpInfo(symbol, stopOrderId, orderLinkId);

        //    // Assert
        //    Assert.IsInstanceOf<ApiResponse<OrderCancelBase>>(response, "response is ApiResponce<APIKeyBase>");
        //    Assert.That(response.Data.RetCode, Is.EqualTo(0), $"API error has occered: {response.Data.RetMsg}");
        //}

        //[Test]
        //public void ConditionalCancelAll_ParametersIsValid_ShouldReturnSuccess()
        //{
        //    // Arrange
        //    var instance = Create();

        //    //TODO: Create new conditional order.

        //    var symbol = Symbol.BTCUSD;

        //    // Act
        //    var response = instance.ConditionalCancelAll(symbol);

        //    // Assert
        //    Assert.That(response.RetCode, Is.EqualTo(0), $"API error has occered: {response.RetMsg}");
        //}

        [Test]
        public void ConditionalQuery_ParamsAreInvalid_ShouldReturnApiError()
        {
            //// Arrange
            //var instance = Create();

            //var symbol = Symbol.BTCUSD;

            //// Act
            //var response = instance.ConditionalQuery(symbol, null, null);

            //// Assert
            //Assert.That(response.RetCode, Is.EqualTo(10001), $"API error has occered: {response.RetMsg}");
        }

        [Test]
        public void ConditionalQueryTest()
        {
            // Arrange
            var instance = Create();

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.ConditionalQuery(symbol, "da5fc794-6c65-4222-b06f-58fee13a1f0c");

            // Assert
            System.Diagnostics.Debug.WriteLine(response);
            Assert.Fail();
            //Assert.That(response.RetCode, Is.EqualTo(0), $"API error has occered: {response.RetMsg}");
        }
    }
}