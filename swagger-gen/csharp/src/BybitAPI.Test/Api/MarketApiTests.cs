using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing MarketApi
    /// </summary>
    /// <remarks>
    [TestFixture]
    public class MarketApiTests
    {
        private static MarketApi Create()
        {
            var instance = new MarketApi();

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
            Assert.IsInstanceOf<MarketApi>(instance, "instance is a MarketApi");
        }

        private static readonly string marketAccountRatioJson = @"
{
    ""ret_code"":0,
    ""ret_msg"":""OK"",
    ""ext_code"":"""",
    ""ext_info"":"""",
    ""result"":[
        {
            ""symbol"":""BTCUSD"",
            ""buy_ratio"":0.6538,
            ""sell_ratio"":0.3462,
            ""timestamp"":1597659000
        },
        {
            ""symbol"":""BTCUSD"",
            ""buy_ratio"":0.6533,
            ""sell_ratio"":0.3467,
            ""timestamp"":1597658700
        }
    ],
    ""time_now"":""1597659230.743313""
}
";

        [Test]
        [TestCase("5min", null)]
        [TestCase("15min", null)]
        [TestCase("30min", null)]
        [TestCase("1h", null)]
        [TestCase("4h", null)]
        [TestCase("1d", null)]
        [TestCase("5min", 0)]
        [TestCase("5min", 500)]
        public void MarketAccountRatio_ParametersAreValid_ShouldReturnMarketAccountRatioBase(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketAccountRatioJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.MarketAccountRatio(symbol, period, limit);

            // Assert
            Assert.IsInstanceOf<MarketAccountRatioBase>(response, "response is MarketAccountRatioBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase("5min", -1)]
        [TestCase("5min", 501)]
        public void MarketAccountRatio_ParametersAreInvalid_ShouldRaiseApiException(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketAccountRatioJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.MarketAccountRatio(symbol, period, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("5min", null)]
        [TestCase("15min", null)]
        [TestCase("30min", null)]
        [TestCase("1h", null)]
        [TestCase("4h", null)]
        [TestCase("1d", null)]
        [TestCase("5min", 0)]
        [TestCase("5min", 500)]
        public void MarketAccountRatioWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketAccountRatioBase(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketAccountRatioJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.MarketAccountRatioWithHttpInfo(symbol, period, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketAccountRatioBase>>(response, "response is ApiResponse<MarketAccountRatioBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase("5min", -1)]
        [TestCase("5min", 501)]
        public void MarketAccountRatioWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketAccountRatioJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.MarketAccountRatioWithHttpInfo(symbol, period, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("5min", null)]
        [TestCase("15min", null)]
        [TestCase("30min", null)]
        [TestCase("1h", null)]
        [TestCase("4h", null)]
        [TestCase("1d", null)]
        [TestCase("5min", 0)]
        [TestCase("5min", 500)]
        public async Task MarketAccountRatioAsync_ParametersAreValid_ShouldReturnMarketAccountRatioBase(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketAccountRatioJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.MarketAccountRatioAsync(symbol, period, limit);

            // Assert
            Assert.IsInstanceOf<MarketAccountRatioBase>(response, "response is MarketAccountRatioBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase("5min", -1)]
        [TestCase("5min", 501)]
        public void MarketAccountRatioAsync_ParametersAreInvalid_ShouldRaiseApiException(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketAccountRatioJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.MarketAccountRatioAsync(symbol, period, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("5min", null)]
        [TestCase("15min", null)]
        [TestCase("30min", null)]
        [TestCase("1h", null)]
        [TestCase("4h", null)]
        [TestCase("1d", null)]
        [TestCase("5min", 0)]
        [TestCase("5min", 500)]
        public async Task MarketAccountRatioAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketAccountRatioBase(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketAccountRatioJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.MarketAccountRatioAsyncWithHttpInfo(symbol, period, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketAccountRatioBase>>(response, "response is ApiResponse<MarketAccountRatioBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase("5min", -1)]
        [TestCase("5min", 501)]
        public void MarketAccountRatioAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketAccountRatioJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.MarketAccountRatioAsyncWithHttpInfo(symbol, period, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string marketBigDealJson = @"
{
    ""ret_code"":0,
    ""ret_msg"":""OK"",
    ""ext_code"":"""",
    ""ext_info"":"""",
    ""result"":[
        {
            ""symbol"":""BTCUSD"",
            ""side"":""Sell"",
            ""timestamp"":1597623362,
            ""value"":1242368
        },
        {
            ""symbol"":""BTCUSD"",
            ""side"":""Buy"",
            ""timestamp"":1597623363,
            ""value"":1242368
        }
    ],
    ""time_now"":""1597658434.219859""
}
";

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public void MarketBigDeal_ParametersAreValid_ShouldReturnMarketBigDealBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketBigDealJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.MarketBigDeal(symbol, limit);

            // Assert
            Assert.IsInstanceOf<MarketBigDealBase>(response, "response is MarketBigDealBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketBigDeal_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketBigDealJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.MarketBigDeal(symbol, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public void MarketBigDealWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketBigDealBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketBigDealJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.MarketBigDealWithHttpInfo(symbol, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketBigDealBase>>(response, "response is ApiResponse<MarketBigDealBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketBigDealWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketBigDealJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.MarketBigDealWithHttpInfo(symbol, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public async Task MarketBigDealAsync_ParametersAreValid_ShouldReturnMarketBigDealBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketBigDealJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.MarketBigDealAsync(symbol, limit);

            // Assert
            Assert.IsInstanceOf<MarketBigDealBase>(response, "response is MarketBigDealBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketBigDealAsync_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketBigDealJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.MarketBigDealAsync(symbol, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public async Task MarketBigDealAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketBigDealBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketBigDealJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.MarketBigDealAsyncWithHttpInfo(symbol, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketBigDealBase>>(response, "response is ApiResponse<MarketBigDealBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketBigDealAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketBigDealJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.MarketBigDealAsyncWithHttpInfo(symbol, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string marketLiqRecordsJson = @"
{
    ""ret_code"":0,
    ""ret_msg"":""OK"",
    ""ext_code"":"""",
    ""ext_info"":"""",
    ""result"":[
        {
            ""id"":2369683,
            ""qty"":155,
            ""side"":""Buy"",
            ""time"":1590030126798,
            ""symbol"":""BTCUSD"",
            ""price"":9444
        }
    ],
    ""time_now"":""1590068362.493540""
}
";

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public void MarketLiqRecords_ParametersAreValid_ShouldReturnMarketLiqRecordsBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketLiqRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = null;
            long? startTime = 0;
            long? endTime = 0;

            // Act
            var response = instance.MarketLiqRecords(symbol, from, limit, startTime, endTime);

            // Assert
            Assert.IsInstanceOf<MarketLiqRecordsBase>(response, "response is MarketLiqRecordsBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketLiqRecords_ParametersAreValid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketLiqRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = null;
            long? startTime = 0;
            long? endTime = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
           {
               var response = instance.MarketLiqRecords(symbol, from, limit, startTime, endTime);
           });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public void MarketLiqRecordsWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketLiqRecordsBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketLiqRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = null;
            long? startTime = 0;
            long? endTime = 0;

            // Act
            var response = instance.MarketLiqRecordsWithHttpInfo(symbol, from, limit, startTime, endTime);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketLiqRecordsBase>>(response, "response is ApiResponse<MarketLiqRecordsBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketLiqRecordsWithHttpInfo_ParametersAreValid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketLiqRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = null;
            long? startTime = 0;
            long? endTime = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.MarketLiqRecordsWithHttpInfo(symbol, from, limit, startTime, endTime);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public async Task MarketLiqRecordsAsync_ParametersAreValid_ShouldReturnMarketLiqRecordsBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketLiqRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = null;
            long? startTime = 0;
            long? endTime = 0;

            // Act
            var response = await instance.MarketLiqRecordsAsync(symbol, from, limit, startTime, endTime);

            // Assert
            Assert.IsInstanceOf<MarketLiqRecordsBase>(response, "response is MarketLiqRecordsBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketLiqRecordsAsync_ParametersAreValid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketLiqRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = null;
            long? startTime = 0;
            long? endTime = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.MarketLiqRecordsAsync(symbol, from, limit, startTime, endTime);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(1000)]
        public async Task MarketLiqRecordsAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketLiqRecordsBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketLiqRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = null;
            long? startTime = 0;
            long? endTime = 0;

            // Act
            var response = await instance.MarketLiqRecordsAsyncWithHttpInfo(symbol, from, limit, startTime, endTime);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketLiqRecordsBase>>(response, "response is ApiResponse<MarketLiqRecordsBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketLiqRecordsAsyncWithHttpInfo_ParametersAreValid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketLiqRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = null;
            long? startTime = 0;
            long? endTime = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.MarketLiqRecordsAsyncWithHttpInfo(symbol, from, limit, startTime, endTime);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string marketOpenInterestJson = @"
{
    ""ret_code"":0,
    ""ret_msg"":""OK"",
    ""ext_code"":"""",
    ""ext_info"":"""",
    ""result"":[
        {
            ""open_interest"":371491978,
            ""timestamp"":1597658100,
            ""symbol"":""BTCUSD""
        },
        {
            ""open_interest"":370696076,
            ""timestamp"":1597657800,
            ""symbol"":""BTCUSD""
        }
    ],
    ""time_now"":""1597658304.938839""
}
";

        [Test]
        [TestCase("5min", null)]
        [TestCase("15min", null)]
        [TestCase("30min", null)]
        [TestCase("1h", null)]
        [TestCase("4h", null)]
        [TestCase("1d", null)]
        [TestCase("5min", 0)]
        [TestCase("5min", 200)]
        public void MarketOpenInterest_ParametersAreValid_ShouldReturnMarketOpenInterestBase(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOpenInterestJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.MarketOpenInterest(symbol, period, limit);

            // Assert
            Assert.IsInstanceOf<MarketOpenInterestBase>(response, "response is MarketOpenInterestBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, 1)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void MarketOpenInterest_ParametersAreInvalid_ShouldRaiseApiException(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOpenInterestJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.MarketOpenInterest(symbol, period, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("5min", null)]
        [TestCase("15min", null)]
        [TestCase("30min", null)]
        [TestCase("1h", null)]
        [TestCase("4h", null)]
        [TestCase("1d", null)]
        [TestCase("5min", 0)]
        [TestCase("5min", 200)]
        public void MarketOpenInterestWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketOpenInterestBase(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOpenInterestJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.MarketOpenInterestWithHttpInfo(symbol, period, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketOpenInterestBase>>(response, "response is ApiResponse<MarketOpenInterestBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, 1)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void MarketOpenInterestWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOpenInterestJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.MarketOpenInterestWithHttpInfo(symbol, period, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("5min", null)]
        [TestCase("15min", null)]
        [TestCase("30min", null)]
        [TestCase("1h", null)]
        [TestCase("4h", null)]
        [TestCase("1d", null)]
        [TestCase("5min", 0)]
        [TestCase("5min", 200)]
        public async Task MarketOpenInterestAsync_ParametersAreValid_ShouldReturnMarketOpenInterestBase(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOpenInterestJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.MarketOpenInterestAsync(symbol, period, limit);

            // Assert
            Assert.IsInstanceOf<MarketOpenInterestBase>(response, "response is MarketOpenInterestBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, 1)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void MarketOpenInterestAsync_ParametersAreInvalid_ShouldRaiseApiException(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOpenInterestJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.MarketOpenInterestAsync(symbol, period, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("5min", null)]
        [TestCase("15min", null)]
        [TestCase("30min", null)]
        [TestCase("1h", null)]
        [TestCase("4h", null)]
        [TestCase("1d", null)]
        [TestCase("5min", 0)]
        [TestCase("5min", 200)]
        public async Task MarketOpenInterestAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketOpenInterestBase(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOpenInterestJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.MarketOpenInterestAsyncWithHttpInfo(symbol, period, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketOpenInterestBase>>(response, "response is ApiResponse<MarketOpenInterestBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, 1)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void MarketOpenInterestAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string period, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOpenInterestJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.MarketOpenInterestAsyncWithHttpInfo(symbol, period, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string marketOrderbookJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        {
            ""symbol"": ""BTCUSD"",
            ""price"": ""9487"",
            ""size"": 336241,
            ""side"": ""Buy""
        },
        {
            ""symbol"": ""BTCUSD"",
            ""price"": ""9487.5"",
            ""size"": 522147,
            ""side"": ""Sell""
        }
    ],
    ""time_now"": ""1567108756.834357""
}
";

        [Test]
        public void MarketOrderbook_ParametersAreValid_ShouldReturnMarketOrderbookBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOrderbookJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.MarketOrderbook(symbol);

            // Assert
            Assert.IsInstanceOf<MarketOrderbookBase>(response, "response is MarketOrderbookBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void MarketOrderbookWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketOrderbookBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOrderbookJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.MarketOrderbookWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketOrderbookBase>>(response, "response is ApiResponse<MarketOrderbookBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task MarketOrderbookAsync_ParametersAreValid_ShouldReturnMarketOrderbookBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOrderbookJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.MarketOrderbookAsync(symbol);

            // Assert
            Assert.IsInstanceOf<MarketOrderbookBase>(response, "response is MarketOrderbookBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task MarketOrderbookAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketOrderbookBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketOrderbookJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.MarketOrderbookAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketOrderbookBase>>(response, "response is ApiResponse<MarketOrderbookBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string marketSymbolInfoJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        {
            ""symbol"": ""BTCUSD"",
            ""bid_price"": ""7230"",
            ""ask_price"": ""7230.5"",
            ""last_price"": ""7230.00"",
            ""last_tick_direction"": ""ZeroMinusTick"",
            ""prev_price_24h"": ""7163.00"",
            ""price_24h_pcnt"": ""0.009353"",
            ""high_price_24h"": ""7267.50"",
            ""low_price_24h"": ""7067.00"",
            ""prev_price_1h"": ""7209.50"",
            ""price_1h_pcnt"": ""0.002843"",
            ""mark_price"": ""7230.31"",
            ""index_price"": ""7230.14"",
            ""open_interest"": 117860186,
            ""open_value"": ""16157.26"",
            ""total_turnover"": ""3412874.21"",
            ""turnover_24h"": ""10864.63"",
            ""total_volume"": 28291403954,
            ""volume_24h"": 78053288,
            ""funding_rate"": ""0.0001"",
            ""predicted_funding_rate"": ""0.0001"",
            ""next_funding_time"": ""2019-12-28T00:00:00Z"",
            ""countdown_hour"": 2
        }
    ],
    ""time_now"": ""1577484619.817968""
}
";

        [Test]
        public void MarketSymbolInfo_ParametersAreValid_ShouldReturnMarketSymbolInfoBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketSymbolInfoJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.MarketSymbolInfo(symbol);

            // Assert
            Assert.IsInstanceOf<MarketSymbolInfoBase>(response, "response is MarketSymbolInfoBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void MarketSymbolInfoWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketSymbolInfoBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketSymbolInfoJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.MarketSymbolInfoWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketSymbolInfoBase>>(response, "response is ApiResponse<MarketSymbolInfoBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task MarketSymbolInfoAsync_ParametersAreValid_ShouldReturnMarketSymbolInfoBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketSymbolInfoJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.MarketSymbolInfoAsync(symbol);

            // Assert
            Assert.IsInstanceOf<MarketSymbolInfoBase>(response, "response is MarketSymbolInfoBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task MarketSymbolInfoAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketSymbolInfoBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketSymbolInfoJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.MarketSymbolInfoAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketSymbolInfoBase>>(response, "response is ApiResponse<MarketSymbolInfoBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string marketTradingRecordsJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        {
            ""id"": 7724919,
            ""symbol"": ""BTCUSD"",
            ""price"": 9499.5,
            ""qty"": 9500,
            ""side"": ""Buy"",
            ""time"": ""2019-11-19T08:03:04.077Z""
        }
    ],
    ""time_now"": ""1567109419.049271""
}
";

        [Test]
        [TestCase(0)]
        [TestCase(1000)]
        public void MarketTradingRecords_ParametersAreValid_ShouldReturnMarketTradingRecordsBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketTradingRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = 0;

            // Act
            var response = instance.MarketTradingRecords(symbol, from, limit);

            // Assert
            Assert.IsInstanceOf<MarketTradingRecordsBase>(response, "response is MarketTradingRecordsBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketTradingRecords_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketTradingRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.MarketTradingRecords(symbol, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0)]
        [TestCase(1000)]
        public void MarketTradingRecordsWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketTradingRecordsBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketTradingRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = 0;

            // Act
            var response = instance.MarketTradingRecordsWithHttpInfo(symbol, from, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketTradingRecordsBase>>(response, "response is ApiResponse<MarketTradingRecordsBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketTradingRecordsWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketTradingRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.MarketTradingRecordsWithHttpInfo(symbol, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0)]
        [TestCase(1000)]
        public async Task MarketTradingRecordsAsync_ParametersAreValid_ShouldReturnMarketTradingRecordsBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketTradingRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = 0;

            // Act
            var response = await instance.MarketTradingRecordsAsync(symbol, from, limit);

            // Assert
            Assert.IsInstanceOf<MarketTradingRecordsBase>(response, "response is MarketTradingRecordsBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketTradingRecordsAsync_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketTradingRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.MarketTradingRecordsAsync(symbol, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0)]
        [TestCase(1000)]
        public async Task MarketTradingRecordsAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfMarketTradingRecordsBase(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketTradingRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = 0;

            // Act
            var response = await instance.MarketTradingRecordsAsyncWithHttpInfo(symbol, from, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<MarketTradingRecordsBase>>(response, "response is ApiResponse<MarketTradingRecordsBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1001)]
        public void MarketTradingRecordsAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, marketTradingRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? from = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.MarketTradingRecordsAsyncWithHttpInfo(symbol, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }
    }
}