using BybitAPI.Api;
using BybitAPI.Client;
using BybitAPI.IntegrationTest.Util;
using BybitAPI.Model;
using NUnit.Framework;

namespace BybitAPI.IntegrationTest
{
    [TestFixture]
    public class OrderApiTests
    {
        private static OrderApi Create()
        {
            // Prepeare configurations to test.
            var configuration = new Configuration
            {
                BasePath = TestUtil.TESTNET_URI
            };
            configuration.ApiKey.Add("api_key", TestUtil.GetTestApiKey());
            configuration.ApiKey.Add("api_secret", TestUtil.GetTestApiSecret());
            return new OrderApi(configuration);
        }

        [Test]
        public void Test()
        {
            // Arragne
            var instance = Create();

            // Act
            //var response = instance.OrderNew(side, symbol, orderType, qty, timeInForce, price, takeProfit, stopLoss, reduceOnly, closeOnTrigger, orderLinkId);

            //var orderId = "707c2e31-7b4a-4b3e-b8f6-1e2c915438ca";
            //var response2 = instance.OrderCancel(Symbol.BTCUSD, orderId);
            //var response3 = instance.OrderCancelAll(Symbol.BTCUSD);
            //var response4 = instance.OrderGetOrders(Symbol.BTCUSD);
            //var response5 = instance.OrderNew(Side.Buy, Symbol.BTCUSD, OrderType.Limit, 1, TimeInForce.PostOnly, 12344);
            var response6 = instance.OrderQuery(Symbol.BTCUSD, "f9622175-67b0-4d0b-8f46-49806bf5b97f");

            //803a6dd0-ca2d-4d9a-95a7-4e0190f512bf

            // Assert
            //Assert.Fail();
        }
    }
}