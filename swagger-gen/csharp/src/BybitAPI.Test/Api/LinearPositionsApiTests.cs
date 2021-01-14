using BybitAPI.Client;
using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System.Collections.Generic;
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

        private static readonly string linearPositionsClosePnlRecordsJson = @"
{
     ""ret_code"": 0,
     ""ret_msg"": ""OK"",
     ""ext_code"": """",
     ""ext_info"": """",
     ""result"": {
         ""current_page"": 1,
         ""data"": [
             {
                 ""id"": 1710,
                 ""user_id"": 160815,
                 ""symbol"": ""BTCUSDT"",
                 ""order_id"": ""e6a11e08-6dd0-404e-bea7-dc22b7ab0228"",
                 ""side"": ""Buy"",
                 ""qty"": 0.5,
                 ""order_price"": 999999,
                 ""order_type"": ""Market"",
                 ""exec_type"": ""Trade"",
                 ""closed_size"": 0.5,
                 ""cum_entry_value"": 3000,
                 ""avg_entry_price"": 6000,
                 ""cum_exit_value"": 3000.5,
                 ""avg_exit_price"": 6001,
                 ""closed_pnl"": -5.000375,
                 ""fill_count"": 1,
                 ""leverage"": 100,
                 ""created_at"": 1577480599
             }
         ]
     },
     ""time_now"": ""1577480599.097287"",
     ""rate_limit_status"": 119,
     ""rate_limit_reset_ms"": 1580885703683,
     ""rate_limit"": 120
}
";

        [Test]
        [TestCase(null, null)]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 50)]
        public void LinearPositionsClosePnlRecords_ParametersAreValid_ShouldReturnLinearPositionsClosePnlRecordsBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsClosePnlRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            var execType = LinearExecType.AdlTrade;

            // Act
            var response = instance.LinearPositionsClosePnlRecords(symbol, startTime, endTime, execType, page, limit);

            Assert.IsInstanceOf<LinearPositionsClosePnlRecordsBase>(response, "response is LinearPositionsClosePnlRecordsBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 51)]
        public void LinearPositionsClosePnlRecords_ParametersAreInvalid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsClosePnlRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            var execType = LinearExecType.AdlTrade;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearPositionsClosePnlRecords(symbol, startTime, endTime, execType, page, limit);
            });

            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null, null)]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 50)]
        public void LinearPositionsClosePnlRecordsWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsClosePnlRecordsBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsClosePnlRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            var execType = LinearExecType.AdlTrade;

            // Act
            var response = instance.LinearPositionsClosePnlRecordsWithHttpInfo(symbol, startTime, endTime, execType, page, limit);

            Assert.IsInstanceOf<ApiResponse<LinearPositionsClosePnlRecordsBase>>(response, "response is ApiResponse<LinearPositionsClosePnlRecordsBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 51)]
        public void LinearPositionsClosePnlRecordsWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsClosePnlRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            var execType = LinearExecType.AdlTrade;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearPositionsClosePnlRecordsWithHttpInfo(symbol, startTime, endTime, execType, page, limit);
            });

            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null, null)]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 50)]
        public async Task LinearPositionsClosePnlRecordsAsync_ParametersAreValid_ShouldReturnLinearPositionsClosePnlRecordsBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsClosePnlRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            var execType = LinearExecType.AdlTrade;

            // Act
            var response = await instance.LinearPositionsClosePnlRecordsAsync(symbol, startTime, endTime, execType, page, limit);

            Assert.IsInstanceOf<LinearPositionsClosePnlRecordsBase>(response, "response is LinearPositionsClosePnlRecordsBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 51)]
        public void LinearPositionsClosePnlRecordsAsync_ParametersAreInvalid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsClosePnlRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            var execType = LinearExecType.AdlTrade;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearPositionsClosePnlRecordsAsync(symbol, startTime, endTime, execType, page, limit);
            });

            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null, null)]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 50)]
        public async Task LinearPositionsClosePnlRecordsAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsClosePnlRecordsBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsClosePnlRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            var execType = LinearExecType.AdlTrade;

            // Act
            var response = await instance.LinearPositionsClosePnlRecordsAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit);

            Assert.IsInstanceOf<ApiResponse<LinearPositionsClosePnlRecordsBase>>(response, "response is ApiResponse<LinearPositionsClosePnlRecordsBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 51)]
        public void LinearPositionsClosePnlRecordsAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsClosePnlRecordsJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            long? startTime = null;
            long? endTime = null;
            var execType = LinearExecType.AdlTrade;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearPositionsClosePnlRecordsAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit);
            });

            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string linearPositionsMyPositionJsonBySymbol = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
       {
               ""user_id"":100004,
               ""symbol"":""BTCUSDT"",
               ""side"":""Buy"",
               ""size"":0,
               ""position_value"":0,
               ""entry_price"":0,
               ""liq_price"":1,
               ""bust_price"":100,
               ""leverage"":0,
               ""is_isolated"":true,
               ""auto_add_margin"": 0,
               ""position_margin"":0,
               ""occ_closing_fee"":0,
               ""realised_pnl"":0,
               ""cum_realised_pnl"":0,
               ""free_qty"": 30,
               ""tp_sl_mode"": ""Full"",
               ""unrealised_pnl"": 0,
               ""deleverage_indicator"": 0,
           },
           {
               ""user_id"":100004,
               ""symbol"":""BTCUSDT"",
               ""side"":""Sell"",
               ""size"":0,
               ""position_value"":0,
               ""entry_price"":0,
               ""liq_price"":1,
               ""bust_price"":100,
               ""leverage"":0,
               ""is_isolated"":true,
               ""auto_add_margin"": 0,
               ""position_margin"":0,
               ""occ_closing_fee"":0,
               ""realised_pnl"":0,
               ""cum_realised_pnl"":0,
               ""free_qty"": 30,
               ""tp_sl_mode"": ""Full"",
               ""unrealised_pnl"": 0,
               ""deleverage_indicator"": 0,
           }
    ],
    ""time_now"": ""1577480599.097287"",
    ""rate_limit_status"": 119,
    ""rate_limit_reset_ms"": 1580885703683,
    ""rate_limit"": 120
}
";

        [Test]
        public void LinearPositionsMyPosition_ParametersAreValid_ShouldReturnLinearPositionsMyPositionBaseOfListOfLinearPositionsMyPositionRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsMyPositionJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearPositionsMyPosition(symbol);

            // Assert
            Assert.IsInstanceOf<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>>(response, "response is LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>");
        }

        [Test]
        public void LinearPositionsMyPositionWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsMyPositionBaseOfListOfLinearPositionsMyPositionRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsMyPositionJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = instance.LinearPositionsMyPositionWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>>>(response, "response is ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>>");
        }

        [Test]
        public async Task LinearPositionsMyPositionAsync_ParametersAreValid_ShouldReturnLinearPositionsMyPositionBaseOfListOfLinearPositionsMyPositionRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsMyPositionJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearPositionsMyPositionAsync(symbol);

            // Assert
            Assert.IsInstanceOf<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>>(response, "response is LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>");
        }

        [Test]
        public async Task LinearPositionsMyPositionAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsMyPositionBaseOfListOfLinearPositionsMyPositionRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsMyPositionJsonBySymbol);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;

            // Act
            var response = await instance.LinearPositionsMyPositionAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>>>(response, "response is ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>>");
        }

        private static readonly string linearPositionsMyPositionJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        {
            ""is_valid"": true,
            ""data"": {
                ""user_id"": 118921,
                ""symbol"": ""BTCUSDT"",
                ""side"": ""Buy"",
                ""size"": 0.009,
                ""position_value"": 117.6845,
                ""entry_price"": 13076.05555555,
                ""liq_price"": 11834,
                ""bust_price"": 11768.5,
                ""leverage"": 10,
                ""is_isolated"":true,
                ""auto_add_margin"": 0,
                ""position_margin"": 11.84788704,
                ""occ_closing_fee"": 0.07943738,
                ""realised_pnl"": 0,
                ""cum_realised_pnl"": -1.50755354,
                ""free_qty"": 0.009,
                ""tp_sl_mode"": ""Full"",
                ""unrealised_pnl"": 0,
                ""deleverage_indicator"": 0,
            }
        },
        {
             ""is_valid"": true,
            ""data"": {
                ""user_id"": 118921,
                ""symbol"": ""BTCUSDT"",
                ""side"": ""Sell"",
                ""size"": 0.001,
                ""position_value"": 13.078,
                ""entry_price"": 13078,
                ""liq_price"": 14320,
                ""bust_price"": 14385.5,
                ""leverage"": 10,
                ""is_isolated"":true,
                ""auto_add_margin"": 0,
                ""position_margin"": 1.31858935,
                ""occ_closing_fee"": 0.01078913,
                ""realised_pnl"": 0,
                ""cum_realised_pnl"": 164.30402588,
                ""free_qty"": 0.001,
                ""tp_sl_mode"": ""Full"",
                ""unrealised_pnl"": 0,
                ""deleverage_indicator"": 0,
            }
        },
        {
            ""is_valid"": true,
            ""data"": {
              ""user_id"": 118921,
                ""symbol"": ""XTZUSDT"",
                ""side"": ""Buy"",
                ""size"": 0,
                ""position_value"": 0,
                ""entry_price"": 0,
                ""liq_price"": 0,
                ""bust_price"": 0,
                ""leverage"": 25,
                ""is_isolated"":true,
                ""auto_add_margin"": 0,
                ""position_margin"": 0,
                ""occ_closing_fee"": 0,
                ""realised_pnl"": 0,
                ""cum_realised_pnl"": 0,
                ""free_qty"": 0,
                ""tp_sl_mode"": ""Full"",
                ""unrealised_pnl"": 0,
                ""deleverage_indicator"": 0,
            }
        },
        {
            ""is_valid"": true,
            ""data"": {
                ""user_id"": 118921,
                ""symbol"": ""XTZUSDT"",
                ""side"": ""Sell"",
                ""size"": 0,
                ""position_value"": 0,
                ""entry_price"": 0,
                ""liq_price"": 0,
                ""bust_price"": 0,
                ""leverage"": 25,
                ""is_isolated"":true,
                ""auto_add_margin"": 0,
                ""position_margin"": 0,
                ""occ_closing_fee"": 0,
                ""realised_pnl"": 0,
                ""cum_realised_pnl"": 0,
                ""free_qty"": 0,
                ""tp_sl_mode"": ""Full"",
                ""unrealised_pnl"": 0,
                ""deleverage_indicator"": 0,
            }
        }
    ],
    ""time_now"": ""1604302080.356538"",
    ""rate_limit_status"": 119,
    ""rate_limit_reset_ms"": 1604302080353,
    ""rate_limit"": 120
}
";

        [Test]
        public void LinearPositionsMyPosition_ParametersAreValid_ShouldReturnLinearPositionsMyPositionBaseOfListOfLinearPositionsMyPositionResBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsMyPositionJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = instance.LinearPositionsMyPosition();

            // Assert
            Assert.IsInstanceOf<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>>(response, "response is LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>");
        }

        [Test]
        public void LinearPositionsMyPositionWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsMyPositionBaseOfListOfLinearPositionsMyPositionResBaso()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsMyPositionJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = instance.LinearPositionsMyPositionWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>>>(response, "response is ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>>");
        }

        [Test]
        public async Task LinearPositionsMyPositionAsync_ParametersAreValid_ShouldReturnLinearPositionsMyPositionBaseOfListOfLinearPositionsMyPositionResBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsMyPositionJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = await instance.LinearPositionsMyPositionAsync();

            // Assert
            Assert.IsInstanceOf<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>>(response, "response is LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>");
        }

        [Test]
        public async Task LinearPositionsMyPositionAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsMyPositionBaseOfListOfLinearPositionsMyPositionResBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsMyPositionJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = await instance.LinearPositionsMyPositionAsyncWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>>>(response, "response is ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>>");
        }

        private static readonly string linearPositionsSaveLeverageJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": null,
    ""time_now"": ""1585881527.650138"",
    ""rate_limit_status"": 74,
    ""rate_limit_reset_ms"": 1585881527648,
    ""rate_limit"": 75
}
";

        [Test]
        [TestCase(0.5, 0.5)]
        [TestCase(1, 1)]
        [TestCase(100, 100)]
        public void LinearPositionsSaveLeverage_ParametersAreValid_ShouldReturnLinearPositionsSaveLeverageBase(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSaveLeverageJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var response = instance.LinearPositionsSaveLeverage(symbol, buyLeverage, sellLeverage);

            // Assert
            Assert.IsInstanceOf<LinearPositionsSaveLeverageBase>(response, "response is LinearPositionsSaveLeverageBase");
            Assert.IsNull(response.Result);
        }

        [Test]
        [TestCase(0, 0.5)]
        [TestCase(0.1, 0)]
        [TestCase(-1, 100)]
        [TestCase(100, -1)]
        public void LinearPositionsSaveLeverage_ParametersAreInvalid_ShouldRaiseApiException(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSaveLeverageJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearPositionsSaveLeverage(symbol, buyLeverage, sellLeverage);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0.5, 0.5)]
        [TestCase(1, 1)]
        [TestCase(100, 100)]
        public void LinearPositionsSaveLeverageWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsSaveLeverageBase(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSaveLeverageJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var response = instance.LinearPositionsSaveLeverageWithHttpInfo(symbol, buyLeverage, sellLeverage);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsSaveLeverageBase>>(response, "response is ApiResponse<LinearPositionsSaveLeverageBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNull(response.Data.Result);
        }

        [Test]
        [TestCase(0, 0.5)]
        [TestCase(0.1, 0)]
        [TestCase(-1, 100)]
        [TestCase(100, -1)]
        public void LinearPositionsSaveLeverageWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSaveLeverageJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearPositionsSaveLeverageWithHttpInfo(symbol, buyLeverage, sellLeverage);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0.5, 0.5)]
        [TestCase(1, 1)]
        [TestCase(100, 100)]
        public async Task LinearPositionsSaveLeverageAsync_ParametersAreValid_ShouldReturnLinearPositionsSaveLeverageBase(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSaveLeverageJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var response = await instance.LinearPositionsSaveLeverageAsync(symbol, buyLeverage, sellLeverage);

            // Assert
            Assert.IsInstanceOf<LinearPositionsSaveLeverageBase>(response, "response is LinearPositionsSaveLeverageBase");
            Assert.IsNull(response.Result);
        }

        [Test]
        [TestCase(0, 0.5)]
        [TestCase(0.1, 0)]
        [TestCase(-1, 100)]
        [TestCase(100, -1)]
        public void LinearPositionsSaveLeverageAsync_ParametersAreInvalid_ShouldRaiseApiException(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSaveLeverageJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearPositionsSaveLeverageAsync(symbol, buyLeverage, sellLeverage);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0.5, 0.5)]
        [TestCase(1, 1)]
        [TestCase(100, 100)]
        public async Task LinearPositionsSaveLeverageAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsSaveLeverageBase(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSaveLeverageJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var response = await instance.LinearPositionsSaveLeverageAsyncWithHttpInfo(symbol, buyLeverage, sellLeverage);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsSaveLeverageBase>>(response, "response is ApiResponse<LinearPositionsSaveLeverageBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNull(response.Data.Result);
        }

        [Test]
        [TestCase(0, 0.5)]
        [TestCase(0.1, 0)]
        [TestCase(-1, 100)]
        [TestCase(100, -1)]
        public void LinearPositionsSaveLeverageAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSaveLeverageJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BTCUSDT;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearPositionsSaveLeverageAsyncWithHttpInfo(symbol, buyLeverage, sellLeverage);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string linearPositionsSetAutoAddMarginJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": null,
    ""time_now"": ""1586780385.549188"",
    ""rate_limit_status"": 74,
    ""rate_limit_reset_ms"": 1586780385547,
    ""rate_limit"": 75
}
";

        [Test]
        public void LinearPositionsSetAutoAddMargin_ParametersAreValid_ShouldReturnLinearPositionsSetAutoAddMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSetAutoAddMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            bool autoAddMargin = false;

            // Act
            var response = instance.LinearPositionsSetAutoAddMargin(symbol, side, autoAddMargin);

            // Assert
            Assert.IsInstanceOf<LinearPositionsSetAutoAddMarginBase>(response, "response is LinearPositionsSetAutoAddMarginBase");
            Assert.IsNull(response.Result);
        }

        [Test]
        public void LinearPositionsSetAutoAddMarginWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsSetAutoAddMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSetAutoAddMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            bool autoAddMargin = false;

            // Act
            var response = instance.LinearPositionsSetAutoAddMarginWithHttpInfo(symbol, side, autoAddMargin);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsSetAutoAddMarginBase>>(response, "response is ApiResponse<LinearPositionsSetAutoAddMarginBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNull(response.Data.Result);
        }

        [Test]
        public async Task LinearPositionsSetAutoAddMarginAsync_ParametersAreValid_ShouldReturnLinearPositionsSetAutoAddMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSetAutoAddMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            bool autoAddMargin = false;

            // Act
            var response = await instance.LinearPositionsSetAutoAddMarginAsync(symbol, side, autoAddMargin);

            // Assert
            Assert.IsInstanceOf<LinearPositionsSetAutoAddMarginBase>(response, "response is LinearPositionsSetAutoAddMarginBase");
            Assert.IsNull(response.Result);
        }

        [Test]
        public async Task LinearPositionsSetAutoAddMarginAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsSetAutoAddMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSetAutoAddMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            bool autoAddMargin = false;

            // Act
            var response = await instance.LinearPositionsSetAutoAddMarginAsyncWithHttpInfo(symbol, side, autoAddMargin);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsSetAutoAddMarginBase>>(response, "response is ApiResponse<LinearPositionsSetAutoAddMarginBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNull(response.Data.Result);
        }

        private static readonly string linearPositionsSwitchIsolatedJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": null,
    ""time_now"": ""1585881597.006026"",
    ""rate_limit_status"": 74,
    ""rate_limit_reset_ms"": 1585881597004,
    ""rate_limit"": 75
}
";

        [Test]
        [TestCase(0.5, 0.5)]
        [TestCase(1, 1)]
        [TestCase(100, 100)]
        public void LinearPositionsSwitchIsolated_ParametersAreValid_ShouldReturnLinearPositionsSwitchIsolatedBase(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchIsolatedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var isIsolated = false;

            var response = instance.LinearPositionsSwitchIsolated(symbol, isIsolated, buyLeverage, sellLeverage);
            Assert.IsInstanceOf<LinearPositionsSwitchIsolatedBase>(response, "response is LinearPositionsSwitchIsolatedBase");
            Assert.IsNull(response.Result);
        }

        [Test]
        [TestCase(0, 0.5)]
        [TestCase(0.1, 0)]
        [TestCase(-1, 100)]
        [TestCase(100, -1)]
        public void LinearPositionsSwitchIsolated_ParametersAreInvalid_ShouldRaiseApiException(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchIsolatedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var isIsolated = false;

            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearPositionsSwitchIsolated(symbol, isIsolated, buyLeverage, sellLeverage);
            });

            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0.5, 0.5)]
        [TestCase(1, 1)]
        [TestCase(100, 100)]
        public void LinearPositionsSwitchIsolatedWithHttpInfo_ParametersAreValid_ShouldReturnApiExceptionOfLinearPositionsSwitchIsolatedBase(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchIsolatedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var isIsolated = false;

            var response = instance.LinearPositionsSwitchIsolatedWithHttpInfo(symbol, isIsolated, buyLeverage, sellLeverage);
            Assert.IsInstanceOf<ApiResponse<LinearPositionsSwitchIsolatedBase>>(response, "response is ApiResponse<LinearPositionsSwitchIsolatedBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNull(response.Data.Result);
        }

        [Test]
        [TestCase(0, 0.5)]
        [TestCase(0.1, 0)]
        [TestCase(-1, 100)]
        [TestCase(100, -1)]
        public void LinearPositionsSwitchIsolatedWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchIsolatedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var isIsolated = false;

            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearPositionsSwitchIsolatedWithHttpInfo(symbol, isIsolated, buyLeverage, sellLeverage);
            });

            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0.5, 0.5)]
        [TestCase(1, 1)]
        [TestCase(100, 100)]
        public async Task LinearPositionsSwitchIsolatedAsync_ParametersAreValid_ShouldReturnLinearPositionsSwitchIsolatedBase(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchIsolatedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var isIsolated = false;

            var response = await instance.LinearPositionsSwitchIsolatedAsync(symbol, isIsolated, buyLeverage, sellLeverage);
            Assert.IsInstanceOf<LinearPositionsSwitchIsolatedBase>(response, "response is LinearPositionsSwitchIsolatedBase");
            Assert.IsNull(response.Result);
        }

        [Test]
        [TestCase(0, 0.5)]
        [TestCase(0.1, 0)]
        [TestCase(-1, 100)]
        [TestCase(100, -1)]
        public void LinearPositionsSwitchIsolatedAsync_ParametersAreInvalid_ShouldRaiseApiException(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchIsolatedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var isIsolated = false;

            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearPositionsSwitchIsolatedAsync(symbol, isIsolated, buyLeverage, sellLeverage);
            });

            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0.5, 0.5)]
        [TestCase(1, 1)]
        [TestCase(100, 100)]
        public async Task LinearPositionsSwitchIsolatedAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiExceptionOfLinearPositionsSwitchIsolatedBase(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchIsolatedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var isIsolated = false;

            var response = await instance.LinearPositionsSwitchIsolatedAsyncWithHttpInfo(symbol, isIsolated, buyLeverage, sellLeverage);
            Assert.IsInstanceOf<ApiResponse<LinearPositionsSwitchIsolatedBase>>(response, "response is ApiResponse<LinearPositionsSwitchIsolatedBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNull(response.Data.Result);
        }

        [Test]
        [TestCase(0, 0.5)]
        [TestCase(0.1, 0)]
        [TestCase(-1, 100)]
        [TestCase(100, -1)]
        public void LinearPositionsSwitchIsolatedAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(decimal buyLeverage, decimal sellLeverage)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchIsolatedJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var isIsolated = false;

            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearPositionsSwitchIsolatedAsyncWithHttpInfo(symbol, isIsolated, buyLeverage, sellLeverage);
            });

            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string linearPositionsSwitchModeJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""tp_sl_mode"": ""Partial""
    },
    ""time_now"": ""1598266294.610276"",
    ""rate_limit_status"": 72,
    ""rate_limit_reset_ms"": 1598266294607,
    ""rate_limit"": 75
}
";

        [Test]
        public void LinearPositionsSwitchMode_ParametersAreValid_ShouldReturnLinearPositionsSwitchModeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchModeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var tpSlMode = LinearTpSlModeType.Full;

            // Act
            var response = instance.LinearPositionsSwitchMode(symbol, tpSlMode);

            // Assert
            Assert.IsInstanceOf<LinearPositionsSwitchModeBase>(response, "response is LinearPositionsSwitchModeBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void LinearPositionsSwitchModeWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseLinearPositionsSwitchModeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchModeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var tpSlMode = LinearTpSlModeType.Full;

            // Act
            var response = instance.LinearPositionsSwitchModeWithHttpInfo(symbol, tpSlMode);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsSwitchModeBase>>(response, "response is ApiResponse<LinearPositionsSwitchModeBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task LinearPositionsSwitchModeAsync_ParametersAreValid_ShouldReturnLinearPositionsSwitchModeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchModeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var tpSlMode = LinearTpSlModeType.Full;

            // Act
            var response = await instance.LinearPositionsSwitchModeAsync(symbol, tpSlMode);

            // Assert
            Assert.IsInstanceOf<LinearPositionsSwitchModeBase>(response, "response is LinearPositionsSwitchModeBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task LinearPositionsSwitchModeAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseLinearPositionsSwitchModeBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsSwitchModeJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var tpSlMode = LinearTpSlModeType.Full;

            // Act
            var response = await instance.LinearPositionsSwitchModeAsyncWithHttpInfo(symbol, tpSlMode);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsSwitchModeBase>>(response, "response is ApiResponse<LinearPositionsSwitchModeBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string linearPositionsTradingStopJson = @"
{
  ""ret_code"": 0,
  ""ret_msg"": ""OK"",
  ""ext_code"": """",
  ""ext_info"": """",
  ""result"": null,
  ""time_now"": ""1586780408.193508"",
  ""rate_limit_status"": 73,
  ""rate_limit_reset_ms"": 1586780408191,
  ""rate_limit"": 75
}
";

        [Test]
        [TestCase(null, null, null)]
        [TestCase(0, null, null)]
        [TestCase(null, 0, null)]
        [TestCase(null, null, 0)]
        [TestCase(0.1, null, null)]
        [TestCase(null, 0.1, null)]
        [TestCase(null, null, 0.1)]
        [TestCase(1, null, null)]
        [TestCase(null, 1, null)]
        [TestCase(null, null, 1)]
        public void LinearPositionsTradingStop_ParametersAreValid_ShouldReturnLinearPositionsTradingStopBase(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            decimal? slSize = null;
            decimal? tpSize = null;

            // Act
            var response = instance.LinearPositionsTradingStop(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize);

            // Assert
            Assert.IsInstanceOf<LinearPositionsTradingStopBase>(response, "response is LinearPositionsTradingStopBase");
            Assert.IsNull(response.Result);
        }

        [Test]
        [TestCase(-0.1, null, null)]
        [TestCase(null, -0.1, null)]
        [TestCase(null, null, -0.1)]
        public void LinearPositionsTradingStop_ParametersAreInvalid_ShouldRaiseApiException(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            decimal? slSize = null;
            decimal? tpSize = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearPositionsTradingStop(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null, null, null)]
        [TestCase(0, null, null)]
        [TestCase(null, 0, null)]
        [TestCase(null, null, 0)]
        [TestCase(0.1, null, null)]
        [TestCase(null, 0.1, null)]
        [TestCase(null, null, 0.1)]
        [TestCase(1, null, null)]
        [TestCase(null, 1, null)]
        [TestCase(null, null, 1)]
        public void LinearPositionsTradingStopWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsTradingStopBase(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            decimal? slSize = null;
            decimal? tpSize = null;

            // Act
            var response = instance.LinearPositionsTradingStopWithHttpInfo(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsTradingStopBase>>(response, "response is ApiResponse<LinearPositionsTradingStopBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNull(response.Data.Result);
        }

        [Test]
        [TestCase(-0.1, null, null)]
        [TestCase(null, -0.1, null)]
        [TestCase(null, null, -0.1)]
        public void LinearPositionsTradingStopWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            decimal? slSize = null;
            decimal? tpSize = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.LinearPositionsTradingStopWithHttpInfo(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null, null, null)]
        [TestCase(0, null, null)]
        [TestCase(null, 0, null)]
        [TestCase(null, null, 0)]
        [TestCase(0.1, null, null)]
        [TestCase(null, 0.1, null)]
        [TestCase(null, null, 0.1)]
        [TestCase(1, null, null)]
        [TestCase(null, 1, null)]
        [TestCase(null, null, 1)]
        public async Task LinearPositionsTradingStopAsync_ParametersAreValid_ShouldReturnLinearPositionsTradingStopBase(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            decimal? slSize = null;
            decimal? tpSize = null;

            // Act
            var response = await instance.LinearPositionsTradingStopAsync(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize);

            // Assert
            Assert.IsInstanceOf<LinearPositionsTradingStopBase>(response, "response is LinearPositionsTradingStopBase");
            Assert.IsNull(response.Result);
        }

        [Test]
        [TestCase(-0.1, null, null)]
        [TestCase(null, -0.1, null)]
        [TestCase(null, null, -0.1)]
        public void LinearPositionsTradingStopAsync_ParametersAreInvalid_ShouldRaiseApiException(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            decimal? slSize = null;
            decimal? tpSize = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearPositionsTradingStopAsync(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null, null, null)]
        [TestCase(0, null, null)]
        [TestCase(null, 0, null)]
        [TestCase(null, null, 0)]
        [TestCase(0.1, null, null)]
        [TestCase(null, 0.1, null)]
        [TestCase(null, null, 0.1)]
        [TestCase(1, null, null)]
        [TestCase(null, 1, null)]
        [TestCase(null, null, 1)]
        public async Task LinearPositionsTradingStopAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfLinearPositionsTradingStopBase(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            decimal? slSize = null;
            decimal? tpSize = null;

            // Act
            var response = await instance.LinearPositionsTradingStopAsyncWithHttpInfo(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize);

            // Assert
            Assert.IsInstanceOf<ApiResponse<LinearPositionsTradingStopBase>>(response, "response is ApiResponse<LinearPositionsTradingStopBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNull(response.Data.Result);
        }

        [Test]
        [TestCase(-0.1, null, null)]
        [TestCase(null, -0.1, null)]
        [TestCase(null, null, -0.1)]
        public void LinearPositionsTradingStopAsyncWithHttpInfo_ParametersAreInvalid_ShouldRaiseApiException(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, linearPositionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = LinearSymbol.BCHUSDT;
            var side = LinearSide.Buy;
            LinearTriggerPriceType? tpTriggerBy = null;
            LinearTriggerPriceType? slTriggerBy = null;
            decimal? slSize = null;
            decimal? tpSize = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.LinearPositionsTradingStopAsyncWithHttpInfo(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize);
            });

            // Assert
            Assert.That(ex?.ErrorCode, Is.EqualTo(400));
        }
    }
}