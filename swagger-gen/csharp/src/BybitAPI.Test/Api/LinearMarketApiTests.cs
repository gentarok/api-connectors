using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing LinearMarketApi
    /// </summary>
    [TestFixture]
    public class LinearMarketApiTests
    {
        private static LinearMarketApi Create()
        {
            var instance = new LinearMarketApi();

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

        /// <summary>
        /// Test an instance of LinearMarketApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<LinearMarketApi>(instance, "instance is a LinearMarketApi");
        }

        private static readonly string linearMarketTradingJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        {
            ""id"": ""18368131384"",
            ""symbol"": ""BTCUSDT"",
            ""price"": 9499.5,
            ""qty"": 9500,
            ""side"": ""Buy"",
            ""time"": ""2019-11-19T08:03:04.077Z"",
            ""trade_time_ms"":1587638305175
        }
    ],
    ""time_now"": ""1567109419.049271""
}
";

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public void LinearMarketTrading_ParametersAreValid_ShouldReturnLinearMarketTradingBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearMarketTradingJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearMarketTrading(symbol, limit);

            // Assert
            Assert.IsInstanceOf<LinearMarketTradingBase>(response, "response is LinearMarketTradingBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void LinearMarketTrading_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearMarketTradingJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearMarketTrading(symbol, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public void LinearMarketTradingWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearMarketTradingBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearMarketTradingJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearMarketTradingWithHttpInfo(symbol, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearMarketTradingBase>>(response, "response is ApiResponse<LinearMarketTradingBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void LinearMarketTradingWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearMarketTradingJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearMarketTradingWithHttpInfo(symbol, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public async Task LinearMarketTradingAsync_ParametersAreValid_ShouldReturnLinearMarketTradingBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearMarketTradingJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearMarketTradingAsync(symbol, limit);

            // Assert
            Assert.IsInstanceOf<LinearMarketTradingBase>(response, "response is LinearMarketTradingBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void LinearMarketTradingAsync_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearMarketTradingJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearMarketTradingAsync(symbol, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public async Task LinearMarketTradingAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearMarketTradingBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearMarketTradingJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearMarketTradingAsyncWithHttpInfo(symbol, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearMarketTradingBase>>(response, "response is ApiResponse<LinearMarketTradingBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void LinearMarketTradingAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearMarketTradingJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearMarketTradingAsyncWithHttpInfo(symbol, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }
    }
}