using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing LinearPositionsApi
    /// </summary>
    [TestFixture]
    public class LinearPositionsApiTests
    {
        private static LinearPositionsApi Create()
        {
            var instance = new LinearPositionsApi();

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
        /// Test an instance of LinearOrderApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<LinearPositionsApi>(instance, "instance is a LinearPositionsApi");
        }

        private static readonly string linearPositionsChangeMarginJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""PositionListResult"": {
            ""user_id"": 160815,
            ""symbol"": ""BTCUSDT"",
            ""side"": ""Buy"",
            ""size"": 3.14,
            ""position_value"": 18843.14,
            ""entry_price"": 6001,
            ""liq_price"": 5428,
            ""bust_price"": 5398,
            ""leverage"": 10,
            ""position_margin"": 1907.0331195,
            ""occ_closing_fee"": 12.71229,
            ""realised_pnl"": 3052.20905294,
            ""cum_realised_pnl"": 75628.40815795,
            ""free_qty"": 0
        },
        ""wallet_balance"": 68738.01696765,
        ""available_balance"": 66830.98384815
    },
     ""time_now"": ""1577480599.097287"",
     ""rate_limit_status"": 119,
     ""rate_limit_reset_ms"": 1580885703683,
     ""rate_limit"": 120
}
";

        [Test]
        public void LinearPositionsChangeMargin_ParametersAreValid_ShouldReturnLinearPositionsChangeMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsChangeMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            var margin = 0m;

            // Act
            var response = instance.LinearPositionsChangeMargin(symbol, side, margin);

            // Assert
            Assert.IsInstanceOf<LinearPositionsChangeMarginBase>(response, "response is LinearPositionsChangeMarginBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearPositionsChangeMarginWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsChangeMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsChangeMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            var margin = 0m;

            // Act
            var response = instance.LinearPositionsChangeMarginWithHttpInfo(symbol, side, margin);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsChangeMarginBase>>(response, "response is ApiResponse<LinearPositionsChangeMarginBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearPositionsChangeMarginAsync_ParametersAreValid_ShouldReturnLinearPositionsChangeMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsChangeMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            var margin = 0m;

            // Act
            var response = await instance.LinearPositionsChangeMarginAsync(symbol, side, margin);

            // Assert
            Assert.IsInstanceOf<LinearPositionsChangeMarginBase>(response, "response is LinearPositionsChangeMarginBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearPositionsChangeMarginAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsChangeMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsChangeMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            var margin = 0m;

            // Act
            var response = await instance.LinearPositionsChangeMarginAsyncWithHttpInfo(symbol, side, margin);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsChangeMarginBase>>(response, "response is ApiResponse<LinearPositionsChangeMarginBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string linearPositionsClosePnlRecordsJson = @"";

        [Test]
        public void LinearPositionsClosePnlRecordsTest()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsClosePnlRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            string symbol = null;
            long? startTime = null;
            long? endTime = null;
            string execType = null;
            long? page = null;
            long? limit = null;

            // Act
            var response = instance.LinearPositionsClosePnlRecords(symbol, startTime, endTime, execType, page, limit);

            // Assert
            Assert.IsInstanceOf<LinearPositionsClosePnlRecordsBase>(response, "response is LinearPositionsClosePnlRecordsBase");
        }

        //[Test]
        //public void LinearPositionsMyPositionTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //var response = instance.LinearPositionsMyPosition(symbol);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        //[Test]
        //public void LinearPositionsSaveLeverageTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //double? buyLeverage = null;
        //    //double? sellLeverage = null;
        //    //var response = instance.LinearPositionsSaveLeverage(symbol, buyLeverage, sellLeverage);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        //[Test]
        //public void LinearPositionsSetAutoAddMarginTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //string side = null;
        //    //bool? autoAddMargin = null;
        //    //var response = instance.LinearPositionsSetAutoAddMargin(symbol, side, autoAddMargin);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        //[Test]
        //public void LinearPositionsSwitchIsolatedTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //bool? isIsolated = null;
        //    //double? buyLeverage = null;
        //    //double? sellLeverage = null;
        //    //var response = instance.LinearPositionsSwitchIsolated(symbol, isIsolated, buyLeverage, sellLeverage);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        //[Test]
        //public void LinearPositionsSwitchModeTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //string tpSlMode = null;
        //    //var response = instance.LinearPositionsSwitchMode(symbol, tpSlMode);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}

        //[Test]
        //public void LinearPositionsTradingStopTest()
        //{
        //    // TODO uncomment below to test the method and replace null with proper value
        //    //string symbol = null;
        //    //string side = null;
        //    //double? takeProfit = null;
        //    //double? stopLoss = null;
        //    //double? trailingStop = null;
        //    //string tpTriggerBy = null;
        //    //string slTriggerBy = null;
        //    //double? slSize = null;
        //    //double? tpSize = null;
        //    //var response = instance.LinearPositionsTradingStop(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize);
        //    //Assert.IsInstanceOf<Object> (response, "response is Object");
        //}
    }
}