using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing LinearKlineApi
    /// </summary>
    [TestFixture]
    public class LinearKlineApiTests
    {
        private static LinearKlineApi Create()
        {
            var instance = new LinearKlineApi();

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
        /// Test an instance of LinearKlineApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<LinearKlineApi>(instance, "instance is a LinearKlineApi");
        }

        private static readonly string linearKlineGetJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
    {
        ""id"": 3866948,
        ""symbol"": ""BTCUSDT"",
        ""period"": ""1"",
        ""start_at"": 1577836800,
        ""volume"": 1451.59,
        ""open"": 7700,
        ""high"": 999999,
        ""low"": 0.5,
        ""close"": 6000,
        ""interval"": ""1"",
        ""open_time"": 1577836800,
        ""turnover"": 2.4343353100000003,
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
        public void LinearKlineGet_ParametersAreValid_ShouldReturnLinearKlineGetBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var response = instance.LinearKlineGet(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<LinearKlineGetBase>(response, "response is LinearKlineGetBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("", -1)]
        [TestCase("", 201)]
        public void LinearKlineGet_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearKlineGet(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
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
        public void LinearKlineGetLinearKlineGetWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearKlineGetBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var response = instance.LinearKlineGetWithHttpInfo(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearKlineGetBase>>(response, "response is ApiResponse<LinearKlineGetBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("", -1)]
        [TestCase("", 201)]
        public void LinearKlineGetWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearKlineGetWithHttpInfo(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
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
        public async Task LinearKlineGetAsync_ParametersAreValid_ShouldReturnLinearKlineGetBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var response = await instance.LinearKlineGetAsync(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<LinearKlineGetBase>(response, "response is LinearKlineGetBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("", -1)]
        [TestCase("", 201)]
        public void LinearKlineGetAsync_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearKlineGetAsync(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
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
        public async Task LinearKlineGetLinearKlineAsyncGetWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearKlineGetBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var response = await instance.LinearKlineGetAsyncWithHttpInfo(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearKlineGetBase>>(response, "response is ApiResponse<LinearKlineGetBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("", -1)]
        [TestCase("", 201)]
        public void LinearKlineGetAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearKlineGetAsyncWithHttpInfo(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string linearKlineMarkPriceJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [{
        ""id"": 3866948,
        ""symbol"": ""BTCUSDT"",
        ""period"": ""1"",
        ""start_at"": 1577836800,
        ""volume"": 1451.59,
        ""open"": 7700,
        ""high"": 999999,
        ""low"": 0.5,
        ""close"": 6000
    },
    {
        ""id"": 3866948,
        ""symbol"": ""BTCUSDT"",
        ""period"": ""1"",
        ""start_at"": 1577836800,
        ""volume"": 1451.59,
        ""open"": 7700,
        ""high"": 999999,
        ""low"": 0.5,
        ""close"": 6000
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
        public void LinearKlineMarkPrice_ParametersAreValid_ShouldReturnLinearKlineMarkPriceBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var response = instance.LinearKlineMarkPrice(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<LinearKlineMarkPriceBase>(response, "response is LinearKlineMarkPriceBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("", -1)]
        [TestCase("", 201)]
        public void LinearKlineMarkPrice_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearKlineMarkPrice(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
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
        public void LinearKlineMarkPriceWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearKlineMarkPriceBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var response = instance.LinearKlineMarkPriceWithHttpInfo(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearKlineMarkPriceBase>>(response, "response is ApiResponse<LinearKlineMarkPriceBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("", -1)]
        [TestCase("", 201)]
        public void LinearKlineMarkPriceWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearKlineMarkPriceWithHttpInfo(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
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
        public async Task LinearKlineMarkPriceAsync_ParametersAreValid_ShouldReturnLinearKlineMarkPriceBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var response = await instance.LinearKlineMarkPriceAsync(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<LinearKlineMarkPriceBase>(response, "response is LinearKlineMarkPriceBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("", -1)]
        [TestCase("", 201)]
        public void LinearKlineMarkPriceAsync_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearKlineMarkPriceAsync(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
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
        public async Task LinearKlineMarkPriceAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearKlineMarkPriceBase(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineMarkPriceJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var response = await instance.LinearKlineMarkPriceAsyncWithHttpInfo(symbol, interval, from, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearKlineMarkPriceBase>>(response, "response is ApiResponse<LinearKlineMarkPriceBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", null)]
        [TestCase("2", null)]
        [TestCase("A", null)]
        [TestCase("", -1)]
        [TestCase("", 201)]
        public void LinearKlineMarkPriceAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(string interval, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearKlineGetJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long from = 0;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearKlineMarkPriceAsyncWithHttpInfo(symbol, interval, from, limit);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }
    }
}