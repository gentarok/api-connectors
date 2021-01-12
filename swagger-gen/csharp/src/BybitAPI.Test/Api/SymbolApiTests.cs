using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing SymbolApi
    /// </summary>
    [TestFixture]
    public class SymbolApiTests
    {
        private static SymbolApi Create()
        {
            var instance = new SymbolApi();

            // Prepeare configurations to test.
            instance.Configuration.AddApiKey("api_key", "");
            instance.Configuration.AddApiKey("api_secret", "");
            return instance;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<SymbolApi>(instance, "instance is a SymbolApi");
        }

        private static readonly string symbolGetJson = @"
{
  ""ret_code"": 0,
  ""ret_msg"": ""OK"",
  ""ext_code"": """",
  ""ext_info"": """",
  ""result"": [
    {
      ""name"": ""BTCUSD"",
      ""base_currency"": ""BTC"",
      ""quote_currency"": ""USD"",
      ""price_scale"": 2,
      ""taker_fee"": ""0.00075"",
      ""maker_fee"": ""-0.00025"",
      ""leverage_filter"": {
        ""min_leverage"": 1,
        ""max_leverage"": 100,
        ""leverage_step"": ""0.01""
      },
      ""price_filter"": {
        ""min_price"": ""0.5"",
        ""max_price"": ""999999.5"",
        ""tick_size"": ""0.5""
      },
      ""lot_size_filter"": {
    ""max_trading_qty"": 1000000,
        ""min_trading_qty"": 1,
        ""qty_step"": 1
      }
    },
    {
    ""name"": ""ETHUSD"",
      ""base_currency"": ""ETH"",
      ""quote_currency"": ""USD"",
      ""price_scale"": 2,
      ""taker_fee"": ""0.00075"",
      ""maker_fee"": ""-0.00025"",
      ""leverage_filter"": {
        ""min_leverage"": 1,
        ""max_leverage"": 50,
        ""leverage_step"": ""0.01""
      },
      ""price_filter"": {
        ""min_price"": ""0.05"",
        ""max_price"": ""99999.95"",
        ""tick_size"": ""0.05""
      },
      ""lot_size_filter"": {
        ""max_trading_qty"": 1000000,
        ""min_trading_qty"": 1,
        ""qty_step"": 1
      }
},
    {
    ""name"": ""EOSUSD"",
      ""base_currency"": ""EOS"",
      ""quote_currency"": ""USD"",
      ""price_scale"": 3,
      ""taker_fee"": ""0.00075"",
      ""maker_fee"": ""-0.00025"",
      ""leverage_filter"": {
        ""min_leverage"": 1,
        ""max_leverage"": 50,
        ""leverage_step"": ""0.01""
      },
      ""price_filter"": {
        ""min_price"": ""0.001"",
        ""max_price"": ""1999.999"",
        ""tick_size"": ""0.001""
      },
      ""lot_size_filter"": {
        ""max_trading_qty"": 1000000,
        ""min_trading_qty"": 1,
        ""qty_step"": 1
      }
},
    {
    ""name"": ""XRPUSD"",
      ""base_currency"": ""XRP"",
      ""quote_currency"": ""USD"",
      ""price_scale"": 4,
      ""taker_fee"": ""0.00075"",
      ""maker_fee"": ""-0.00025"",
      ""leverage_filter"": {
        ""min_leverage"": 1,
        ""max_leverage"": 50,
        ""leverage_step"": ""0.01""
      },
      ""price_filter"": {
        ""min_price"": ""0.0001"",
        ""max_price"": ""199.9999"",
        ""tick_size"": ""0.0001""
      },
      ""lot_size_filter"": {
        ""max_trading_qty"": 1000000,
        ""min_trading_qty"": 1,
        ""qty_step"": 1
      }
}
  ],
  ""time_now"": ""1581411225.414179""
}
";

        [Test]
        public void SymbolGet_NoConditions_ShouldReturnSymbolGetBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, symbolGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = instance.SymbolGet();

            // Assert
            Assert.IsInstanceOf<SymbolGetBase>(response, "response is SymbolGetBase");
        }

        [Test]
        public void SymbolGetWithHttpInfo_NoConditions_ShouldReturnApiResponseOfSymbolGetBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, symbolGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = instance.SymbolGetWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<SymbolGetBase>>(response, "response is ApiResponse<SymbolGetBase>");
        }

        [Test]
        public async Task SymbolGetAsync_NoConditions_ShouldReturnSymbolGetBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, symbolGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = await instance.SymbolGetAsync();

            // Assert
            Assert.IsInstanceOf<SymbolGetBase>(response, "response is SymbolGetBase");
        }

        [Test]
        public async Task SymbolGetAsyncWithHttpInfo_NoConditions_ShouldReturnApiResponseOfSymbolGetBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, symbolGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = await instance.SymbolGetAsyncWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<SymbolGetBase>>(response, "response is ApiResponse<SymbolGetBase>");
        }
    }
}