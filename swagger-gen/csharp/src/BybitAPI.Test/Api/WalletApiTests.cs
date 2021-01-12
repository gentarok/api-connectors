using BybitAPI.Model;
using BybitAPI.Test.Api.Factory;
using NUnit.Framework;
using System;
using System.Net;

namespace BybitAPI.Api.Test
{
    /// <summary>
    ///  Class for testing WalletApi
    /// </summary>
    [TestFixture]
    public class WalletApiTests
    {
        private static WalletApi Create()
        {
            var instance = new WalletApi();

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
        /// Test an instance of WalletApi
        /// </summary>
        [Test]
        public void Instance_ShouldBeCreated()
        {
            // Arrange

            // Act
            var instance = Create();

            // Assert
            Assert.IsInstanceOf<WalletApi>(instance, "instance is a WalletApi");
        }

        private static readonly string walletExchangeOrderJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": [
        {
            ""id"": 31,
            ""exchange_rate"": 40.57202774,
            ""from_coin"": ""BTC"",
            ""to_coin"": ""ETH"",
            ""to_amount"": 4.05720277,
            ""from_fee"": 0.0005,
            ""from_amount"": 0.1,
            ""created_at"": ""2020-06-15 03:32:52""
        },
        {
            ""id"": 30,
            ""exchange_rate"": 39.92359901,
            ""from_coin"": ""BTC"",
            ""to_coin"": ""ETH"",
            ""to_amount"": 39.923599,
            ""from_fee"": 0.0005,
            ""from_amount"": 1,
            ""created_at"": ""2020-06-12 08:27:51""
        }
    ],
    ""time_now"": ""1592554785.486414"",
    ""rate_limit_status"": 119,
    ""rate_limit_reset_ms"": 1592554785484,
    ""rate_limit"": 120
}
";

        [Test]
        [TestCase(null)]
        [TestCase(0)]
        [TestCase(50)]
        public void WalletExchangeOrder_ParametersAreValid_ShouldReturnWalletExchangeOrderBase(int? limit)
        {
            // Arrange
            var instance = Create();
            instance.Configuration.ApiClient.RestClient = MockRestClientFactory.Create(HttpStatusCode.OK, walletExchangeOrderJson);

            long? from = null;
            SearchDirection? direction = null;

            // Act
            var response = instance.WalletExchangeOrder(limit, from, direction);

            // Assert
            Assert.IsInstanceOf<WalletExchangeOrderBase>(response, "response is WalletExchangeOrderBase");
            Assert.That(response.Result?[0].CreatedAt, Is.EqualTo(DateTimeOffset.Parse("2020-06-15T03:32:52 +00:00")));
        }

        private static readonly string walletGetBalanceJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""OK"",
    ""ext_code"": """",
    ""ext_info"": """",
    ""result"": {
        ""BTC"": {
            ""equity"": 1002,
            ""available_balance"": 999.99987471,
            ""used_margin"": 0.00012529,
            ""order_margin"": 0.00012529,
            ""position_margin"": 0,
            ""occ_closing_fee"": 0,
            ""occ_funding_fee"": 0,
            ""wallet_balance"": 1000,
            ""realised_pnl"": 0,
            ""unrealised_pnl"": 2,
            ""cum_realised_pnl"": 0,
            ""given_cash"": 0,
            ""service_cash"": 0
        }
    },
    ""time_now"": ""1578284274.816029"",
    ""rate_limit_status"": 98,
    ""rate_limit_reset_ms"": 1580885703683,
    ""rate_limit"": 100
}
";

        [Test]
        public void WalletGetBalance_ParametersAreValid_ShouldReturnWalletGetBalanceBase()
        {
            // Arrange
            var instance = Create();
            instance.Configuration.ApiClient.RestClient = MockRestClientFactory.Create(HttpStatusCode.OK, walletGetBalanceJson);

            Currency? coin = null;

            // Act
            var response = instance.WalletGetBalance(coin);

            // Assert
            Assert.IsInstanceOf<WalletGetBalanceBase>(response, "response is WalletGetBalanceBase");
        }

        private static readonly string walletGetRecordsJson = @"
{
    ""ret_code"": 0,
    ""ret_msg"": ""ok"",
    ""ext_code"": """",
    ""result"": {
        ""data"": [
            {
                ""id"": 235853,
                ""user_id"": 1,
                ""coin"": ""BTC"",
                ""wallet_id"": 27913,
                ""type"": ""Realized P&L"",
                ""amount"": ""0.00000023"",
                ""tx_id"": """",
                ""address"": ""BTCUSD"",
                ""wallet_balance"": ""0.03000353"",
                ""exec_time"": ""2019-12-10T00:00:29.000Z"",
                ""cross_seq"": 0
            },
            {
                ""id"": 234467,
                ""user_id"": 1,
                ""coin"": ""BTC"",
                ""wallet_id"": 27913,
                ""type"": ""Realized P&L"",
                ""amount"": ""-0.00000006"",
                ""tx_id"": """",
                ""address"": ""BTCUSD"",
                ""wallet_balance"": ""0.03000330"",
                ""exec_time"": ""2019-12-09T00:00:25.000Z"",
                ""cross_seq"": 0
            }
        ]
    },
    ""ext_info"": null,
    ""time_now"": ""1577481867.115552"",
    ""rate_limit_status"": 119,
    ""rate_limit_reset_ms"": 1577481867122,
    ""rate_limit"": 120
}
";

        [Test]
        public void WalletGetRecords_ParametersAreValid_ShouldReturnWalletGetRecordsBase()
        {
            // Arrange
            var instance = Create();
            instance.Configuration.ApiClient.RestClient = MockRestClientFactory.Create(HttpStatusCode.OK, walletGetRecordsJson);

            DateTimeOffset? startDate = null;
            DateTimeOffset? endDate = null;
            Currency? coin = null;
            WalletFundType? walletFundType = null;
            int? page = null;
            int? limit = null;

            // Act
            var response = instance.WalletGetRecords(startDate, endDate, coin, walletFundType, page, limit);

            // Assert
            Assert.IsInstanceOf<WalletGetRecordsBase>(response, "response is WalletGetBalanceBase");
        }

        private static readonly string walletGetRiskLimitJson = @"
{
  ""ret_code"": 0,
  ""ret_msg"": ""ok"",
  ""ext_code"": """",
  ""result"": [
    {
      ""id"": 1,
      ""coin"": ""BTC"",
      ""limit"": 150,
      ""maintain_margin"": ""0.50"",
      ""starting_margin"": ""1.00"",
      ""section"": [
        ""1"",
        ""2"",
        ""3"",
        ""5"",
        ""10"",
        ""25"",
        ""50"",
        ""100""
      ],
      ""is_lowest_risk"": 1,
      ""created_at"": ""2018-11-09T13:53:04.000Z"",
      ""updated_at"": ""2018-11-09T13:53:04.000Z""
    },
    {
      ""id"": 11,
      ""coin"": ""ETH"",
      ""limit"": 3000,
      ""maintain_margin"": ""1.00"",
      ""starting_margin"": ""2.00"",
      ""section"": [
        ""1"",
        ""2"",
        ""3"",
        ""5"",
        ""15"",
        ""30"",
        ""40"",
        ""50""
      ],
      ""is_lowest_risk"": 1,
      ""created_at"": ""2019-01-25T08:31:54.000Z"",
      ""updated_at"": ""2019-01-25T08:31:54.000Z""
    }
  ],
  ""ext_info"": null,
  ""time_now"": ""1577587907.157396"",
  ""rate_limit_status"": 99,
  ""rate_limit_reset_ms"": 1577587907162,
  ""rate_limit"": 100
}
";

        [Test]
        public void WalletGetRiskLimit_NoConditions_ShouldReturnWalletGetRiskLimitBase()
        {
            // Arrange
            var instance = Create();
            instance.Configuration.ApiClient.RestClient = MockRestClientFactory.Create(HttpStatusCode.OK, walletGetRiskLimitJson);

            // Act
            var response = instance.WalletGetRiskLimit();

            // Assert
            Assert.IsInstanceOf<WalletGetRiskLimitBase>(response, "response is WalletGetRiskLimitBase");
        }

        private static readonly string walletSetRiskLimitJson = @"
{
  ""ret_code"": 0,
  ""ret_msg"": ""ok"",
  ""ext_code"": """",
  ""result"": {
    ""position"": {
      ""id"": 1,
      ""user_id"": 1,
      ""symbol"": ""BTCUSD"",
      ""side"": ""None"",
      ""size"": 0,
      ""position_value"": 0,
      ""entry_price"": 0,
      ""risk_id"": 2,
      ""auto_add_margin"": 0,
      ""leverage"": 1,
      ""position_margin"": 0,
      ""liq_price"": 0,
      ""bust_price"": 0,
      ""occ_closing_fee"": 0,
      ""occ_funding_fee"": 0,
      ""take_profit"": 0,
      ""stop_loss"": 0,
      ""trailing_stop"": 0,
      ""position_status"": ""Normal"",
      ""deleverage_indicator"": 0,
      ""oc_calc_data"": ""{\""blq\"":1,\""blv\"":\""0.000125\"",\""slq\"":0,\""bmp\"":8000,\""smp\"":0,\""fc\"":-0.00012529,\""bv2c\"":1.00225,\""sv2c\"":1.0007575}"",
      ""order_margin"": 0.00012529,
      ""wallet_balance"": 1000,
      ""realised_pnl"": 0,
      ""cum_realised_pnl"": 0,
      ""cum_commission"": 0,
      ""cross_seq"": 4376,
      ""position_seq"": 13689,
      ""created_at"": ""2019-08-13T06:51:29.000Z"",
      ""updated_at"": ""2019-12-29T03:11:08.000Z"",
      ""ext_fields"": {
        ""trailing_active"": ""9000"",
        ""v"": 4
      }
    },
    ""risk"": {
      ""id"": 2,
      ""coin"": ""BTC"",
      ""limit"": 300,
      ""maintain_margin"": ""1.00"",
      ""starting_margin"": ""1.50"",
      ""section"": ""[\""1\"",\""2\"",\""3\"",\""5\"",\""10\"",\""25\"",\""50\"",\""66\""]"",
      ""is_lowest_risk"": 0,
      ""created_at"": ""2019-06-26T05:46:45.000Z"",
      ""updated_at"": ""2019-06-26T05:46:55.000Z""
    }
  },
  ""ext_info"": null,
  ""time_now"": ""1577589068.435439"",
  ""rate_limit_status"": 71,
  ""rate_limit_reset_ms"": 1577589068546,
  ""rate_limit"": 75
}
";

        [Test]
        public void WalletSetRiskLimit_ParametersAreValid_ShouldReturnWalletSetRiskLimitBase()
        {
            // Arrange
            var instance = Create();
            instance.Configuration.ApiClient.RestClient = MockRestClientFactory.Create(HttpStatusCode.OK, walletSetRiskLimitJson);

            var symbol = Symbol.BTCUSD;
            var riskId = 0;

            // Act
            var response = instance.WalletSetRiskLimit(symbol, riskId);

            // Assert
            Assert.IsInstanceOf<WalletSetRiskLimitBase>(response, "response is WalletSetRiskLimitBase");
        }

        private static readonly string walletWithDrawJson = @"
{
  ""ret_code"": 0,
  ""ret_msg"": ""ok"",
  ""ext_code"": """",
  ""result"": {
      ""data"": [{
          ""id"": 137,
          ""user_id"": 1,
          ""coin"": ""XRP"",
          ""status"": ""Pending"",
          ""amount"": ""20.00000000"",
          ""fee"": ""0.25000000"",
          ""address"": ""rH7H595XYEVTEHU2FySYsWnmfACBnZS9zM"",
          ""tx_id"": """",
          ""submited_at"": ""2019-06-11T02:20:24.000Z"",
          ""updated_at"": ""2019-06-11T02:20:24.000Z""
      }],
      ""current_page"": 1,
      ""last_page"": 1
  },
  ""ext_info"": null,
  ""time_now"": ""1577482295.125488"",
  ""rate_limit_status"": 119,
  ""rate_limit_reset_ms"": 1577482295132,
  ""rate_limit"": 120
}
";

        [Test]
        public void WalletWithdraw_ParametersAreValid_ShouldReturnWalletWithdrawBase()
        {
            // Arrange
            var instance = Create();
            instance.Configuration.ApiClient.RestClient = MockRestClientFactory.Create(HttpStatusCode.OK, walletWithDrawJson);

            DateTimeOffset? startDate = null;
            DateTimeOffset? endDate = null;
            Currency? coin = null;
            WithdrawStatus? status = null;
            int? page = null;
            int? limit = null;

            // Act
            var response = instance.WalletWithdraw(startDate, endDate, coin, status, page, limit);

            // Assert
            Assert.IsInstanceOf<WalletWithdrawBase>(response, "response is WalletWithdrawBase");
        }
    }
}