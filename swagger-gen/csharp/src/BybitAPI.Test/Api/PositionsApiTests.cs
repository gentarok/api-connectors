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
    ///  Class for testing PositionsApi
    /// </summary>
    [TestFixture]
    public class PositionsApiTests
    {
        private static PositionsApi Create()
        {
            var instance = new PositionsApi();

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
            Assert.IsInstanceOf<PositionsApi>(instance, "instance is a PositionsApi");
        }

        private static readonly string positionsChangeMarginJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": 9.996e-05,
    ""ext_info"": null,
    ""time_now"": ""1577480720.003444"",
    ""rate_limit_status"": 74,
    ""rate_limit_reset_ms"": 1577480720011,
    ""rate_limit"": 75
}
";

        [Test]
        public void PositionsChangeMargin_ParametersAreValid_ShouldReturnPositionsChangeMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsChangeMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var margin = 0m;

            // Act
            var response = instance.PositionsChangeMargin(symbol, margin);

            // Assert
            Assert.IsInstanceOf<PositionsChangeMarginBase>(response, "response is PositionsChangeMarginBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void PositionsChangeMarginWithHttpInfo_ParametersAreValid_ShouldReturnPositionsChangeMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsChangeMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var margin = 0m;

            // Act
            var response = instance.PositionsChangeMarginWithHttpInfo(symbol, margin);

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsChangeMarginBase>>(response, "response is ApiResponse<PositionsChangeMarginBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task PositionsChangeMarginAsync_ParametersAreValid_ShouldReturnPositionsChangeMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsChangeMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var margin = 0m;

            // Act
            var response = await instance.PositionsChangeMarginAsync(symbol, margin);

            // Assert
            Assert.IsInstanceOf<PositionsChangeMarginBase>(response, "response is PositionsChangeMarginBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task PositionsChangeMarginAsyncWithHttpInfo_ParametersAreValid_ShouldReturnPositionsChangeMarginBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsChangeMarginJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var margin = 0m;

            // Act
            var response = await instance.PositionsChangeMarginAsyncWithHttpInfo(symbol, margin);

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsChangeMarginBase>>(response, "response is ApiResponse<PositionsChangeMarginBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string positionsClosePnlJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""current_page"": 1,
        ""data"": [
            {
                ""id"": 9982,
                ""user_id"": 160320,
                ""symbol"": ""BTCUSD"",
                ""order_id"": ""e976ac13-10e7-4883-a7ba-13b0e93659f1"",
                ""side"": ""Sell"",
                ""qty"": 226,
                ""order_price"": 1600,
                ""order_type"": ""Limit"",
                ""exec_type"": ""Trade"",
                ""closed_size"": 113,
                ""cum_entry_value"": 0.07062500000000001,
                ""avg_entry_price"": 1600,
                ""cum_exit_value"": 0.066198,
                ""avg_exit_price"": 1707,
                ""closed_pnl"": 0.0043950000000000005,
                ""fill_count"": 1,
                ""leverage"": 100,
                ""created_at"": 1591155741
            }
        ]
    },
    ""time_now"": ""1591173153.876047"",
    ""rate_limit_status"": 119,
    ""rate_limit_reset_ms"": 1591173153852,
    ""rate_limit"": 120
}
";

        [Test]
        [TestCase(null, null)]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 50)]
        public void PositionsClosePnlRecords_ParametersAreValid_ShouldReturnPositionsClosePnlBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsClosePnlJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? startTime = null;
            long? endTime = null;
            ExecType? execType = null;

            // Act
            var response = instance.PositionsClosePnlRecords(symbol, startTime, endTime, execType, page, limit);

            // Assert
            Assert.IsInstanceOf<PositionsClosePnlBase>(response, "response is PositionsClosePnlBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 51)]
        public void PositionsClosePnlRecords_ParametersAreValid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsClosePnlJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? startTime = null;
            long? endTime = null;
            ExecType? execType = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.PositionsClosePnlRecords(symbol, startTime, endTime, execType, page, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null, null)]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 50)]
        [TestCase(0, 0)]
        [TestCase(50, 50)]
        public void PositionsClosePnlRecordsWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfPositionsClosePnlBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsClosePnlJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? startTime = null;
            long? endTime = null;
            ExecType? execType = null;

            // Act
            var response = instance.PositionsClosePnlRecordsWithHttpInfo(symbol, startTime, endTime, execType, page, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsClosePnlBase>>(response, "response is ApiResponse<PositionsClosePnlBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 51)]
        public void PositionsClosePnlRecordsWithHttpInfo_ParametersAreValid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsClosePnlJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? startTime = null;
            long? endTime = null;
            ExecType? execType = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.PositionsClosePnlRecordsWithHttpInfo(symbol, startTime, endTime, execType, page, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null, null)]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 50)]
        public async Task PositionsClosePnlRecordsAsync_ParametersAreValid_ShouldReturnPositionsClosePnlBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsClosePnlJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? startTime = null;
            long? endTime = null;
            ExecType? execType = null;

            // Act
            var response = await instance.PositionsClosePnlRecordsAsync(symbol, startTime, endTime, execType, page, limit);

            // Assert
            Assert.IsInstanceOf<PositionsClosePnlBase>(response, "response is PositionsClosePnlBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 51)]
        public void PositionsClosePnlRecordsAsync_ParametersAreValid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsClosePnlJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? startTime = null;
            long? endTime = null;
            ExecType? execType = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.PositionsClosePnlRecordsAsync(symbol, startTime, endTime, execType, page, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(null, null)]
        [TestCase(0, null)]
        [TestCase(50, null)]
        [TestCase(null, 0)]
        [TestCase(null, 50)]
        [TestCase(0, 0)]
        [TestCase(50, 50)]
        public async Task PositionsClosePnlRecordsAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfPositionsClosePnlBase(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsClosePnlJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? startTime = null;
            long? endTime = null;
            ExecType? execType = null;

            // Act
            var response = await instance.PositionsClosePnlRecordsAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit);

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsClosePnlBase>>(response, "response is ApiResponse<PositionsClosePnlBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-1, null)]
        [TestCase(51, null)]
        [TestCase(null, -1)]
        [TestCase(null, 51)]
        public void PositionsClosePnlRecordsAsyncWithHttpInfo_ParametersAreValid_ShouldRaiseApiException(int? page, int? limit)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsClosePnlJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            long? startTime = null;
            long? endTime = null;
            ExecType? execType = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.PositionsClosePnlRecordsAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        private static readonly string positionsMyPositionBySymbolJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""id"": 27913,
        ""user_id"": 1,
        ""risk_id"": 1,
        ""symbol"": ""BTCUSD"",
        ""side"": ""Buy"",
        ""size"": 5,
        ""position_value"": ""0.0006947"",
        ""entry_price"": ""7197.35137469"",
        ""is_isolated"":true,
        ""auto_add_margin"": 0,
        ""leverage"": ""1"",
        ""effective_leverage"": ""1"",
        ""position_margin"": ""0.0006947"",
        ""liq_price"": ""3608"",
        ""bust_price"": ""3599"",
        ""occ_closing_fee"": ""0.00000105"",
        ""occ_funding_fee"": ""0"",
        ""take_profit"": ""0"",
        ""stop_loss"": ""0"",
        ""trailing_stop"": ""0"",
        ""position_status"": ""Normal"",
        ""deleverage_indicator"": 4,
        ""oc_calc_data"": ""{\""blq\"":2,\""blv\"":\""0.0002941\"",\""slq\"":0,\""bmp\"":6800.408,\""smp\"":0,\""fq\"":-5,\""fc\"":-0.00029477,\""bv2c\"":1.00225,\""sv2c\"":1.0007575}"",
        ""order_margin"": ""0.00029477"",
        ""wallet_balance"": ""0.03000227"",
        ""realised_pnl"": ""-0.00000126"",
        ""unrealised_pnl"": 0,
        ""cum_realised_pnl"": ""-0.00001306"",
        ""cross_seq"": 444081383,
        ""position_seq"": 287141589,
        ""created_at"": ""2019-10-19T17:04:55Z"",
        ""updated_at"": ""2019-12-27T20:25:45.158767Z""
    },
    ""time_now"": ""1577480599.097287"",
    ""rate_limit_status"": 119,
    ""rate_limit_reset_ms"": 1580885703683,
    ""rate_limit"": 120
}
";

        [Test]
        public void PositionsMyPosition_ParametersAreValid_ShouldReturnPositionsMyPositionBaseOfPositionsMyPositionRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsMyPositionBySymbolJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.PositionsMyPosition(symbol);

            // Assert
            Assert.IsInstanceOf<PositionsMyPositionBase<PositionsMyPositionRes>>(response, "response is PositionsMyPositionBase<PositionsMyPositionRes>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void PositionsMyPositionWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfPositionsMyPositionBaseOfPositionsMyPositionRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsMyPositionBySymbolJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = instance.PositionsMyPositionWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsMyPositionBase<PositionsMyPositionRes>>>(response, "response is ApiResponse<PositionsMyPositionBase<PositionsMyPositionRes>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task PositionsMyPositionAsync_ParametersAreValid_ShouldReturnPositionsMyPositionBaseOfPositionsMyPositionRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsMyPositionBySymbolJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.PositionsMyPositionAsync(symbol);

            // Assert
            Assert.IsInstanceOf<PositionsMyPositionBase<PositionsMyPositionRes>>(response, "response is PositionsMyPositionBase<PositionsMyPositionRes>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task PositionsMyPositionAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfPositionsMyPositionBaseOfPositionsMyPositionRes()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsMyPositionBySymbolJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            // Act
            var response = await instance.PositionsMyPositionAsyncWithHttpInfo(symbol);

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsMyPositionBase<PositionsMyPositionRes>>>(response, "response is ApiResponse<PositionsMyPositionBase<PositionsMyPositionRes>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string positionsMyPositionJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        {
            ""is_valid"": true,
            ""data"": {
                ""id"": 0,
                ""user_id"": 118921,
                ""risk_id"": 1,
                ""symbol"": ""BTCUSD"",
                ""side"": ""Buy"",
                ""size"": 10,
                ""position_value"": ""0.00076448"",
                ""entry_price"": ""13080.78694014"",
                ""is_isolated"": false,
                ""auto_add_margin"": 1,
                ""leverage"": ""100"",
                ""effective_leverage"": ""0.01"",
                ""position_margin"": ""0.40111704"",
                ""liq_price"": ""25"",
                ""bust_price"": ""25"",
                ""occ_closing_fee"": ""0.0003"",
                ""occ_funding_fee"": ""0"",
                ""take_profit"": ""0"",
                ""stop_loss"": ""0"",
                ""trailing_stop"": ""0"",
                ""position_status"": ""Normal"",
                ""deleverage_indicator"": 1,
                ""oc_calc_data"": ""{\""blq\"":0,\""slq\"":0,\""bmp\"":0,\""smp\"":0,\""fq\"":-10,\""bv2c\"":0.0115075,\""sv2c\"":0.0114925}"",
                ""order_margin"": ""0"",
                ""wallet_balance"": ""0.40141704"",
                ""realised_pnl"": ""-0.00000008"",
                ""unrealised_pnl"": 0.00003797,
                ""cum_realised_pnl"": ""-0.090626"",
                ""cross_seq"": 764786721,
                ""position_seq"": 581513847,
                ""created_at"": ""2020-08-10T07:04:32Z"",
                ""updated_at"": ""2020-11-02T00:00:11.943371457Z""
            }
},
        {
            ""is_valid"": true,
            ""data"": {
                ""id"": 0,
                ""user_id"": 118921,
                ""risk_id"": 35,
                ""symbol"": ""XRPUSD"",
                ""side"": ""None"",
                ""size"": 0,
                ""position_value"": ""0"",
                ""entry_price"": ""0"",
                ""is_isolated"": false,
                ""auto_add_margin"": 1,
                ""leverage"": ""16.67"",
                ""effective_leverage"": ""16.67"",
                ""position_margin"": ""0"",
                ""liq_price"": ""0"",
                ""bust_price"": ""0"",
                ""occ_closing_fee"": ""0"",
                ""occ_funding_fee"": ""0"",
                ""take_profit"": ""0"",
                ""stop_loss"": ""0"",
                ""trailing_stop"": ""0"",
                ""position_status"": ""Normal"",
                ""deleverage_indicator"": 0,
                ""oc_calc_data"": ""{\""blq\"":0,\""slq\"":0,\""bmp\"":0,\""smp\"":0,\""bv2c\"":0.06153301,\""sv2c\"":0.06144302}"",
                ""order_margin"": ""0"",
                ""wallet_balance"": ""0"",
                ""realised_pnl"": ""0"",
                ""unrealised_pnl"": 0,
                ""cum_realised_pnl"": ""0"",
                ""cross_seq"": -1,
                ""position_seq"": 352149441,
                ""created_at"": ""2020-08-10T07:04:32Z"",
                ""updated_at"": ""2020-08-22T08:06:32Z""
            }
}
    ],
    ""time_now"": ""1604302124.031104"",
    ""rate_limit_status"": 118,
    ""rate_limit_reset_ms"": 1604302124020,
    ""rate_limit"": 120
}
";

        [Test]
        public void PositionsMyPosition_NoParameters_ShouldReturnPositionsMyPositionBaseOfListForPositionsMyPositionResBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsMyPositionJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = instance.PositionsMyPosition();

            // Assert
            Assert.IsInstanceOf<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>>(response, "response is PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void PositionsMyPositionWithHttpInfo_NoParameters_ShouldReturnApiResponseOfPositionsMyPositionBaseOfListForPositionsMyPositionResBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsMyPositionJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = instance.PositionsMyPositionWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>>>(response, "response is ApiResponse<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task PositionsMyPositionAsync_NoParameters_ShouldReturnPositionsMyPositionBaseOfListForPositionsMyPositionResBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsMyPositionJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = await instance.PositionsMyPositionAsync();

            // Assert
            Assert.IsInstanceOf<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>>(response, "response is PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task PositionsMyPositionAsyncWithHttpInfo_NoParameters_ShouldReturnApiResponseOfPositionsMyPositionBaseOfListForPositionsMyPositionResBase()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsMyPositionJson);
            instance.Configuration.ApiClient.RestClient = client;

            // Act
            var response = await instance.PositionsMyPositionAsyncWithHttpInfo();

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>>>(response, "response is ApiResponse<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string positionsSaveLeveraguJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": 2,
    ""ext_info"": null,
    ""time_now"": ""1577477968.175013"",
    ""rate_limit_status"": 74,
    ""rate_limit_reset_ms"": 1577477968183,
    ""rate_limit"": 75
}
";

        [Test]
        public void PositionsSaveLeverage_ParametersAreValid_ShouldReturnPositionsSaveLeverage()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsSaveLeveraguJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var leverage = 0m;

            // Act
            var response = instance.PositionsSaveLeverage(symbol, leverage);

            // Assert
            Assert.IsInstanceOf<PositionsSaveLeverageBase>(response, "response is PositionsSaveLeverage");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public void PositionsSaveLeverageWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfPositionsSaveLeverage()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsSaveLeveraguJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var leverage = 0m;

            // Act
            var response = instance.PositionsSaveLeverageWithHttpInfo(symbol, leverage);

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsSaveLeverageBase>>(response, "response is ApiResponse<PositionsSaveLeverageBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        public async Task PositionsSaveLeverageAsync_ParametersAreValid_ShouldReturnPositionsSaveLeverage()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsSaveLeveraguJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var leverage = 0m;

            // Act
            var response = await instance.PositionsSaveLeverageAsync(symbol, leverage);

            // Assert
            Assert.IsInstanceOf<PositionsSaveLeverageBase>(response, "response is PositionsSaveLeverage");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        public async Task PositionsSaveLeverageAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfPositionsSaveLeverage()
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsSaveLeveraguJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            var leverage = 0m;

            // Act
            var response = await instance.PositionsSaveLeverageAsyncWithHttpInfo(symbol, leverage);

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsSaveLeverageBase>>(response, "response is ApiResponse<PositionsSaveLeverageBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        private static readonly string positionsTradingStopJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
        ""id"": 27913,
        ""user_id"": 1,
        ""symbol"": ""BTCUSD"",
        ""side"": ""Buy"",
        ""size"": 5,
        ""position_value"": 0.0006947,
        ""entry_price"": 7197.35137469,
        ""risk_id"": 1,
        ""auto_add_margin"": 0,
        ""leverage"": 6.95,
        ""position_margin"": 9.996e-05,
        ""liq_price"": 6320,
        ""bust_price"": 6292.5,
        ""occ_closing_fee"": 6e-07,
        ""occ_funding_fee"": 0,
        ""take_profit"": 0,
        ""stop_loss"": 7000,
        ""trailing_stop"": 0,
        ""position_status"": ""Normal"",
        ""deleverage_indicator"": 5,
        ""oc_calc_data"": ""{\""blq\"":2,\""blv\"":\""0.0002941\"",\""slq\"":0,\""bmp\"":6800.408,\""smp\"":0,\""fq\"":-5,\""fc\"":-0.00004279,\""bv2c\"":0.14549282,\""sv2c\"":0.14527699}"",
        ""order_margin"": 4.279e-05,
        ""wallet_balance"": 0.03000227,
        ""realised_pnl"": -1.26e-06,
        ""cum_realised_pnl"": -1.306e-05,
        ""cum_commission"": 0,
        ""cross_seq"": 444081383,
        ""position_seq"": 287176872,
        ""created_at"": ""2019-10-19T17:04:55.000Z"",
        ""updated_at"": ""2019-12-27T21:17:27.000Z"",
        ""ext_fields"": {
            ""trailing_active"":""9000"",
            ""sl_trigger_by"": ""LastPrice"",
            ""v"": 221,
            ""mm"": 0
        }
    },
    ""ext_info"": null,
    ""time_now"": ""1577481447.436689"",
    ""rate_limit_status"": 73,
    ""rate_limit_reset_ms"": 1577481447443,
    ""rate_limit"": 75
}
";

        [Test]
        [TestCase(0, null, null)]
        [TestCase(0.1, null, null)]
        [TestCase(1, null, null)]
        [TestCase(2, null, null)]
        [TestCase(null, 0, null)]
        [TestCase(null, 0.1, null)]
        [TestCase(null, 1, null)]
        [TestCase(null, 2, null)]
        [TestCase(null, null, 0)]
        [TestCase(null, null, 0.1)]
        [TestCase(null, null, 1)]
        [TestCase(null, null, 2)]
        public void PositionsTradingStop_ParametersAreValid_ShouldReturnPositionsTradingStopBase(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            decimal? newTrailingActive = null;

            // Act
            var response = instance.PositionsTradingStop(symbol, takeProfit, stopLoss, trailingStop, newTrailingActive);

            // Assert
            Assert.IsInstanceOf<PositionsTradingStopBase>(response, "response is PositionsTradingStopBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-0.1, null, null)]
        [TestCase(null, -0.1, null)]
        [TestCase(null, null, -0.1)]
        public void PositionsTradingStop_ParametersAreInValid_ShouldRaiseApiException(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            decimal? newTrailingActive = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.PositionsTradingStop(symbol, takeProfit, stopLoss, trailingStop, newTrailingActive);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0, null, null)]
        [TestCase(0.1, null, null)]
        [TestCase(1, null, null)]
        [TestCase(2, null, null)]
        [TestCase(null, 0, null)]
        [TestCase(null, 0.1, null)]
        [TestCase(null, 1, null)]
        [TestCase(null, 2, null)]
        [TestCase(null, null, 0)]
        [TestCase(null, null, 0.1)]
        [TestCase(null, null, 1)]
        [TestCase(null, null, 2)]
        public void PositionsTradingStopWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfPositionsTradingStopBase(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            decimal? newTrailingActive = null;

            // Act
            var response = instance.PositionsTradingStopWithHttpInfo(symbol, takeProfit, stopLoss, trailingStop, newTrailingActive);

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsTradingStopBase>>(response, "response is ApiResponse<PositionsTradingStopBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-0.1, null, null)]
        [TestCase(null, -0.1, null)]
        [TestCase(null, null, -0.1)]
        public void PositionsTradingStopWithHttpInfo_ParametersAreInValid_ShouldReturnApiResponseOfPositionsTradingStopBase(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            decimal? newTrailingActive = null;

            // Act
            var ex = Assert.Throws<ApiException>(() =>
            {
                var response = instance.PositionsTradingStopWithHttpInfo(symbol, takeProfit, stopLoss, trailingStop, newTrailingActive);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0, null, null)]
        [TestCase(0.1, null, null)]
        [TestCase(1, null, null)]
        [TestCase(2, null, null)]
        [TestCase(null, 0, null)]
        [TestCase(null, 0.1, null)]
        [TestCase(null, 1, null)]
        [TestCase(null, 2, null)]
        [TestCase(null, null, 0)]
        [TestCase(null, null, 0.1)]
        [TestCase(null, null, 1)]
        [TestCase(null, null, 2)]
        public async Task PositionsTradingStopAsync_ParametersAreValid_ShouldReturnPositionsTradingStopBase(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            decimal? newTrailingActive = null;

            // Act
            var response = await instance.PositionsTradingStopAsync(symbol, takeProfit, stopLoss, trailingStop, newTrailingActive);

            // Assert
            Assert.IsInstanceOf<PositionsTradingStopBase>(response, "response is PositionsTradingStopBase");
            Assert.IsNotNull(response.Result);
        }

        [Test]
        [TestCase(-0.1, null, null)]
        [TestCase(null, -0.1, null)]
        [TestCase(null, null, -0.1)]
        public void PositionsTradingStopAsync_ParametersAreInValid_ShouldRaiseApiException(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            decimal? newTrailingActive = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.PositionsTradingStopAsync(symbol, takeProfit, stopLoss, trailingStop, newTrailingActive);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }

        [Test]
        [TestCase(0, null, null)]
        [TestCase(0.1, null, null)]
        [TestCase(1, null, null)]
        [TestCase(2, null, null)]
        [TestCase(null, 0, null)]
        [TestCase(null, 0.1, null)]
        [TestCase(null, 1, null)]
        [TestCase(null, 2, null)]
        [TestCase(null, null, 0)]
        [TestCase(null, null, 0.1)]
        [TestCase(null, null, 1)]
        [TestCase(null, null, 2)]
        public async Task PositionsTradingStopAsyncWithHttpInfo_ParametersAreValid_ShouldReturnApiResponseOfPositionsTradingStopBase(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;
            decimal? newTrailingActive = null;

            // Act
            var response = await instance.PositionsTradingStopAsyncWithHttpInfo(symbol, takeProfit, stopLoss, trailingStop, newTrailingActive);

            // Assert
            Assert.IsInstanceOf<ApiResponse<PositionsTradingStopBase>>(response, "response is ApiResponse<PositionsTradingStopBase>");
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.Result);
        }

        [Test]
        [TestCase(-0.1, null, null)]
        [TestCase(null, -0.1, null)]
        [TestCase(null, null, -0.1)]
        public void PositionsTradingStopAsyncWithHttpInfo_ParametersAreInValid_ShouldReturnApiResponseOfPositionsTradingStopBase(decimal? takeProfit, decimal? stopLoss, decimal? trailingStop)
        {
            // Arrange
            var instance = Create();
            var client = MockRestClientFactory.Create(HttpStatusCode.OK, positionsTradingStopJson);
            instance.Configuration.ApiClient.RestClient = client;

            var symbol = Symbol.BTCUSD;

            decimal? newTrailingActive = null;

            // Act
            var ex = Assert.ThrowsAsync<ApiException>(async () =>
            {
                var response = await instance.PositionsTradingStopAsyncWithHttpInfo(symbol, takeProfit, stopLoss, trailingStop, newTrailingActive);
            });

            // Assert
            Assert.That(ex.ErrorCode, Is.EqualTo(400));
        }
    }
}