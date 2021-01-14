using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing KlineApi
    /// </summary>
    [TestFixture]
    public class KlineApiTests
    {
        private static KlineApi Create()
        {
            var instance = new KlineApi();

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
            Assert.IsInstanceOf<KlineApi>(instance, "instance is a KlineApi");
        }

        private static readonly string klineGetJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [{
        ""symbol"": ""BTCUSD"",
        ""interval"": ""1"",
        ""open_time"": 1581231300,
        ""open"": ""10112.5"",
        ""high"": ""10112.5"",
        ""low"": ""10112"",
        ""close"": ""10112"",
        ""volume"": ""75981"",
        ""turnover"": ""7.51394369""
    }, {
        ""symbol"": ""BTCUSD"",
        ""interval"": ""1"",
        ""open_time"": 1581231360,
        ""open"": ""10112"",
        ""high"": ""10112.5"",
        ""low"": ""10112"",
        ""close"": ""10112"",
        ""volume"": ""24616"",
        ""turnover"": ""2.4343353100000003""
    }],
    ""time_now"": ""1581928016.558522""
}
";

        [Test]
        [TestCase("1", null)]
        [TestCase("3", null)]
        [TestCase("5", null)]
        [TestCase("15", null)]
        [TestCase("30", null)]
        [TestCase("60", null)]
        [TestCase("120", null)]
        [TestCase("240", null)]
        [TestCase("360", null)]
        [TestCase("720", null)]
        [TestCase("D", null)]
        [TestCase("M", null)]
        [TestCase("W", null)]
        [TestCase("1", 0)]
        [TestCase("1", 200)]
        public void KlineGet_ParametersAreValid_ShouldReturnKlineGetBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var response = instance.KlineGet(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<KlineGetBase>(response, "response is KlineGetBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void KlineGet_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.KlineGet(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("1", null)]
        [TestCase("3", null)]
        [TestCase("5", null)]
        [TestCase("15", null)]
        [TestCase("30", null)]
        [TestCase("60", null)]
        [TestCase("120", null)]
        [TestCase("240", null)]
        [TestCase("360", null)]
        [TestCase("720", null)]
        [TestCase("D", null)]
        [TestCase("M", null)]
        [TestCase("W", null)]
        [TestCase("1", 0)]
        [TestCase("1", 200)]
        public void KlineGetWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfKlineGetBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var response = instance.KlineGetWithHttpInfo(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<KlineGetBase>>(response, "response is ApiResponse<KlineGetBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void KlineGetWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.KlineGetWithHttpInfo(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("1", null)]
        [TestCase("3", null)]
        [TestCase("5", null)]
        [TestCase("15", null)]
        [TestCase("30", null)]
        [TestCase("60", null)]
        [TestCase("120", null)]
        [TestCase("240", null)]
        [TestCase("360", null)]
        [TestCase("720", null)]
        [TestCase("D", null)]
        [TestCase("M", null)]
        [TestCase("W", null)]
        [TestCase("1", 0)]
        [TestCase("1", 200)]
        public async Task KlineGetAsync_ParametersAreValid_ShouldReturnKlineGetBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var response = await instance.KlineGetAsync(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<KlineGetBase>(response, "response is KlineGetBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void KlineGetAsync_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.KlineGetAsync(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("1", null)]
        [TestCase("3", null)]
        [TestCase("5", null)]
        [TestCase("15", null)]
        [TestCase("30", null)]
        [TestCase("60", null)]
        [TestCase("120", null)]
        [TestCase("240", null)]
        [TestCase("360", null)]
        [TestCase("720", null)]
        [TestCase("D", null)]
        [TestCase("M", null)]
        [TestCase("W", null)]
        [TestCase("1", 0)]
        [TestCase("1", 200)]
        public async Task KlineGetAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfKlineGetBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var response = await instance.KlineGetAsyncWithHttpInfo(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<KlineGetBase>>(response, "response is ApiResponse<KlineGetBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void KlineGetAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.KlineGetAsyncWithHttpInfo(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string klineMarkPriceJson = @"
{
    ""ret_code"":0,
    ""ret_msg"":""OK"",
    ""ext_code"":"""",
    ""ext_info"":"""",
    ""result"":[
        {
            ""id"":2,
            ""symbol"":""BTCUSD"",
            ""period"":""1"",
            ""start_at"":1582231260,
            ""open"":100,
            ""high"":120,
            ""low"":88,
            ""close"":115
        }
    ],
    ""time_now"":""1591263582.601795""
}
";

        [Test]
        [TestCase("1", null)]
        [TestCase("3", null)]
        [TestCase("5", null)]
        [TestCase("15", null)]
        [TestCase("30", null)]
        [TestCase("60", null)]
        [TestCase("120", null)]
        [TestCase("240", null)]
        [TestCase("360", null)]
        [TestCase("720", null)]
        [TestCase("D", null)]
        [TestCase("M", null)]
        [TestCase("W", null)]
        [TestCase("1", 0)]
        [TestCase("1", 200)]
        public void KlineMarkPrice_ParametersAreValid_ShouldReturnKlineMarkPriceBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var response = instance.KlineMarkPrice(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<KlineMarkPriceBase>(response, "response is KlineMarkPriceBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void KlineMarkPrice_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.KlineMarkPrice(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("1", null)]
        [TestCase("3", null)]
        [TestCase("5", null)]
        [TestCase("15", null)]
        [TestCase("30", null)]
        [TestCase("60", null)]
        [TestCase("120", null)]
        [TestCase("240", null)]
        [TestCase("360", null)]
        [TestCase("720", null)]
        [TestCase("D", null)]
        [TestCase("M", null)]
        [TestCase("W", null)]
        [TestCase("1", 0)]
        [TestCase("1", 200)]
        public void KlineMarkPriceWithHttpInfo_ParametersAreValid_ShouldReturnApiRenponseOfKlineMarkPriceBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var response = instance.KlineMarkPriceWithHttpInfo(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<KlineMarkPriceBase>>(response, "response is ApiResponse<KlineMarkPriceBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void KlineMarkPriceWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.KlineMarkPriceWithHttpInfo(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("1", null)]
        [TestCase("3", null)]
        [TestCase("5", null)]
        [TestCase("15", null)]
        [TestCase("30", null)]
        [TestCase("60", null)]
        [TestCase("120", null)]
        [TestCase("240", null)]
        [TestCase("360", null)]
        [TestCase("720", null)]
        [TestCase("D", null)]
        [TestCase("M", null)]
        [TestCase("W", null)]
        [TestCase("1", 0)]
        [TestCase("1", 200)]
        public async Task KlineMarkPriceAsync_ParametersAreValid_ShouldReturnKlineMarkPriceBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var response = await instance.KlineMarkPriceAsync(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<KlineMarkPriceBase>(response, "response is KlineMarkPriceBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void KlineMarkPriceAsync_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.KlineMarkPriceAsync(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase("1", null)]
        [TestCase("3", null)]
        [TestCase("5", null)]
        [TestCase("15", null)]
        [TestCase("30", null)]
        [TestCase("60", null)]
        [TestCase("120", null)]
        [TestCase("240", null)]
        [TestCase("360", null)]
        [TestCase("720", null)]
        [TestCase("D", null)]
        [TestCase("M", null)]
        [TestCase("W", null)]
        [TestCase("1", 0)]
        [TestCase("1", 200)]
        public async Task KlineMarkPriceAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiRenponseOfKlineMarkPriceBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var response = await instance.KlineMarkPriceAsyncWithHttpInfo(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<KlineMarkPriceBase>>(response, "response is ApiResponse<KlineMarkPriceBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("1", -1)]
        [TestCase("1", 201)]
        public void KlineMarkPriceAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, klineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var from = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.KlineMarkPriceAsyncWithHttpInfo(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }
    }
}