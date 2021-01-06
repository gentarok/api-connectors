using BybitAPI.Api;
using BybitAPI.Client;
using BybitAPI.IntegrationTest.Util;
using NUnit.Framework;
using System;

namespace BybitAPI.IntegrationTest
{
    public class ConditionalApiTests
    {
        private ConditionalApi instance;

        [SetUp]
        public void Setup()
        {
            // Prepeare configurations to test.
            var configuration = new Configuration
            {
                BasePath = TestUtil.TESTNET_URI
            };
            configuration.ApiKey.Add("api_key", TestUtil.GetTestApiKey());
            configuration.ApiKey.Add("api_secret", TestUtil.GetTestApiSecret());
            configuration.ApiKey.Add("timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString());
            instance = new ConditionalApi(configuration);
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
        [TestCase("", "", "", 10001)]
        [TestCase("BTCUSD", "0", null, 20001)]
        [TestCase("BTCUSD", null, "0", 20001)]
        public void ConditionalCancel_ParametersAreInvalid_ShouldReturnApiError(string symbol, string stopOrderId, string orderLinkId, decimal expectedRetCode)
        {
            // Arrange

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

        //    //TODO: Create new conditional order.

        //    string symbol = "BTCUSD";

        //    // Act
        //    var response = instance.ConditionalCancelAll(symbol);

        //    // Assert
        //    Assert.That(response.RetCode, Is.EqualTo(0), $"API error has occered: {response.RetMsg}");
        //}
    }
}