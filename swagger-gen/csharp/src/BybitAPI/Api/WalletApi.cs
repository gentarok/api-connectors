using BybitAPI.Client;
using BybitAPI.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BybitAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWalletApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Asset Exchange Records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-assetexchangerecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="from">Start ID. By default, returns the latest IDs (optional)</param>
        /// <param name="direction">Search direction. Prev: searches in ascending order from start ID, Next: searches in descending order from start ID. Defaults to Next (optional)</param>
        /// <returns><see cref="WalletExchangeOrderBase"/></returns>
        WalletExchangeOrderBase WalletExchangeOrder(int? limit = null, long? from = null, SearchDirection? direction = null);

        /// <summary>
        /// Asset Exchange Records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-assetexchangerecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="from">Start ID. By default, returns the latest IDs (optional)</param>
        /// <param name="direction">Search direction. Prev: searches in ascending order from start ID, Next: searches in descending order from start ID. Defaults to Next (optional)</param>
        /// <returns>ApiResponse of WalletExchangeOrderBase</returns>
        ApiResponse<WalletExchangeOrderBase> WalletExchangeOrderWithHttpInfo(int? limit = null, long? from = null, SearchDirection? direction = null);

        /// <summary>
        /// get wallet balance info
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-balance"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="coin">Coin.enum {BTC,EOS,XRP,ETH,USDT} (optional)</param>
        /// <returns><see cref="WalletGetBalanceBase"/></returns>
        WalletGetBalanceBase WalletGetBalance(Currency? coin = null);

        /// <summary>
        /// get wallet balance info
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-balance"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="coin">Coin.enum {BTC,EOS,XRP,ETH,USDT} (optional)</param>
        /// <returns>ApiResponse of WalletGetBalanceBase</returns>
        ApiResponse<WalletGetBalanceBase> WalletGetBalanceWithHttpInfo(Currency? coin = null);

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-walletrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency type (optional)</param>
        /// <param name="walletFundType">wallet fund type (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns><see cref="WalletGetRecordsBase"/></returns>
        WalletGetRecordsBase WalletGetRecords(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WalletFundType? walletFundType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-walletrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency type (optional)</param>
        /// <param name="walletFundType">wallet fund type (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>ApiResponse of WalletGetRecordsBase</returns>
        ApiResponse<WalletGetRecordsBase> WalletGetRecordsWithHttpInfo(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WalletFundType? walletFundType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns><see cref="WalletGetRiskLimitBase"/></returns>
        WalletGetRiskLimitBase WalletGetRiskLimit();

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WalletGetRiskLimitBase</returns>
        ApiResponse<WalletGetRiskLimitBase> WalletGetRiskLimitWithHttpInfo();

        /// <summary>
        /// Set risk limit
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-setrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="riskId">Risk ID. Can be found with the Get risk limit list endpoint.</param>
        /// <returns><see cref="WalletSetRiskLimitBase"/></returns>
        WalletSetRiskLimitBase WalletSetRiskLimit(Symbol symbol, long riskId);

        /// <summary>
        /// Set risk limit
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-setrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="riskId">Risk ID. Can be found with the Get risk limit list endpoint.</param>
        /// <returns>ApiResponse of WalletSetRiskLimitBase</returns>
        ApiResponse<WalletSetRiskLimitBase> WalletSetRiskLimitWithHttpInfo(Symbol symbol, long riskId);

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-withdrawrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency (optional)</param>
        /// <param name="status">Withdraw status (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns><see cref="WalletWithdrawBase"/></returns>
        WalletWithdrawBase WalletWithdraw(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WithdrawStatus? status = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-withdrawrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency (optional)</param>
        /// <param name="status">Withdraw status (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>ApiResponse of WalletWithdrawBase</returns>
        ApiResponse<WalletWithdrawBase> WalletWithdrawWithHttpInfo(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WithdrawStatus? status = null, int? page = null, int? limit = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Asset Exchange Records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-assetexchangerecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="from">Start ID. By default, returns the latest IDs (optional)</param>
        /// <param name="direction">Search direction. Prev: searches in ascending order from start ID, Next: searches in descending order from start ID. Defaults to Next (optional)</param>
        /// <returns>Task of WalletExchangeOrderBase</returns>
        Task<WalletExchangeOrderBase> WalletExchangeOrderAsync(int? limit = null, long? from = null, SearchDirection? direction = null);

        /// <summary>
        /// Asset Exchange Records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-assetexchangerecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="from">Start ID. By default, returns the latest IDs (optional)</param>
        /// <param name="direction">Search direction. Prev: searches in ascending order from start ID, Next: searches in descending order from start ID. Defaults to Next (optional)</param>
        /// <returns>Task of ApiResponse (WalletExchangeOrderBase)</returns>
        Task<ApiResponse<WalletExchangeOrderBase>> WalletExchangeOrderAsyncWithHttpInfo(int? limit = null, long? from = null, SearchDirection? direction = null);

        /// <summary>
        /// get wallet balance info
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-balance"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="coin">Coin.enum {BTC,EOS,XRP,ETH,USDT} (optional)</param>
        /// <returns>Task of Object</returns>
        Task<WalletGetBalanceBase> WalletGetBalanceAsync(Currency? coin = null);

        /// <summary>
        /// get wallet balance info
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-balance"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="coin">Coin.enum {BTC,EOS,XRP,ETH,USDT} (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<WalletGetBalanceBase>> WalletGetBalanceAsyncWithHttpInfo(Currency? coin = null);

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-walletrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency type (optional)</param>
        /// <param name="walletFundType">wallet fund type (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>Task of WalletGetRecordsBase</returns>
        Task<WalletGetRecordsBase> WalletGetRecordsAsync(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WalletFundType? walletFundType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-walletrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency type (optional)</param>
        /// <param name="walletFundType">wallet fund type (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>Task of ApiResponse (WalletGetRecordsBase)</returns>
        Task<ApiResponse<WalletGetRecordsBase>> WalletGetRecordsAsyncWithHttpInfo(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WalletFundType? walletFundType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WalletGetRiskLimitBase</returns>
        Task<WalletGetRiskLimitBase> WalletGetRiskLimitAsync();

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WalletGetRiskLimitBase)</returns>
        Task<ApiResponse<WalletGetRiskLimitBase>> WalletGetRiskLimitAsyncWithHttpInfo();

        /// <summary>
        /// Set risk limit
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-setrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="riskId">Risk ID. Can be found with the Get risk limit list endpoint.</param>
        /// <returns>Task of WalletSetRiskLimitBase</returns>
        Task<WalletSetRiskLimitBase> WalletSetRiskLimitAsync(Symbol symbol, long riskId);

        /// <summary>
        /// Set risk limit
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-setrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="riskId">Risk ID. Can be found with the Get risk limit list endpoint.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<WalletSetRiskLimitBase>> WalletSetRiskLimitAsyncWithHttpInfo(Symbol symbol, long riskId);

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-withdrawrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency (optional)</param>
        /// <param name="status">Withdraw status (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>Task of WalletWithdrawBase</returns>
        Task<WalletWithdrawBase> WalletWithdrawAsync(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WithdrawStatus? status = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-withdrawrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency (optional)</param>
        /// <param name="status">Withdraw status (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>Task of ApiResponse (WalletWithdrawBase)</returns>
        Task<ApiResponse<WalletWithdrawBase>> WalletWithdrawAsyncWithHttpInfo(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WithdrawStatus? status = null, int? page = null, int? limit = null);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WalletApi : ApiBase, IWalletApi
    {
        private const int WalletExchangeOrderWithHttpInfoMaxValue = 50;

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WalletApi(string basePath) : base(basePath) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WalletApi(Configuration? configuration = null) : base(configuration) { }

        /// <summary>
        /// Asset Exchange Records
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="from">Start ID. By default, returns the latest IDs (optional)</param>
        /// <param name="direction">Search direction. Prev: searches in ascending order from start ID, Next: searches in descending order from start ID. Defaults to Next (optional)</param>
        /// <returns><see cref="WalletExchangeOrderBase"/></returns>
        public WalletExchangeOrderBase WalletExchangeOrder(int? limit = null, long? from = null, SearchDirection? direction = null)
            => WalletExchangeOrderWithHttpInfo(limit, from, direction).Data;

        /// <summary>
        /// Asset Exchange Records
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="from">Start ID. By default, returns the latest IDs (optional)</param>
        /// <param name="direction">Search direction. Prev: searches in ascending order from start ID, Next: searches in descending order from start ID. Defaults to Next (optional)</param>
        /// <returns>ApiResponse of WalletExchangeOrderBase</returns>
        public ApiResponse<WalletExchangeOrderBase> WalletExchangeOrderWithHttpInfo(int? limit = null, long? from = null, SearchDirection? direction = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and >= 0 and <= WalletExchangeOrderWithHttpInfoMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling WalletApi->WalletExchangeOrderWithHttpInfo");
            }

            var localVarPath = "/v2/private/exchange-order/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            if (from is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));
            }

            if (direction is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "direction", direction));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<WalletExchangeOrderBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Asset Exchange Records
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="from">Start ID. By default, returns the latest IDs (optional)</param>
        /// <param name="direction">Search direction. Prev: searches in ascending order from start ID, Next: searches in descending order from start ID. Defaults to Next (optional)</param>
        /// <returns>Task of WalletExchangeOrderBase</returns>
        public async Task<WalletExchangeOrderBase> WalletExchangeOrderAsync(int? limit = null, long? from = null, SearchDirection? direction = null)
            => (await WalletExchangeOrderAsyncWithHttpInfo(limit, from, direction)).Data;

        /// <summary>
        /// Asset Exchange Records
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="from">Start ID. By default, returns the latest IDs (optional)</param>
        /// <param name="direction">Search direction. Prev: searches in ascending order from start ID, Next: searches in descending order from start ID. Defaults to Next (optional)</param>
        /// <returns>Task of ApiResponse (WalletExchangeOrderBase)</returns>
        public Task<ApiResponse<WalletExchangeOrderBase>> WalletExchangeOrderAsyncWithHttpInfo(int? limit = null, long? from = null, SearchDirection? direction = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and >= 0 and <= WalletExchangeOrderWithHttpInfoMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling WalletApi->WalletExchangeOrderWithHttpInfo");
            }

            var localVarPath = "/v2/private/exchange-order/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            if (from is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));
            }

            if (direction is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "direction", direction));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<WalletExchangeOrderBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// get wallet balance info
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-balance"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="coin">Coin.enum {BTC,EOS,XRP,ETH,USDT} (optional)</param>
        /// <returns><see cref="WalletGetBalanceBase"/></returns>
        public WalletGetBalanceBase WalletGetBalance(Currency? coin = null)
            => WalletGetBalanceWithHttpInfo(coin).Data;

        /// <summary>
        /// get wallet balance info
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-balance"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="coin">Coin.enum {BTC,EOS,XRP,ETH,USDT} (optional)</param>
        /// <returns>ApiResponse of WalletGetBalanceBase</returns>
        public ApiResponse<WalletGetBalanceBase> WalletGetBalanceWithHttpInfo(Currency? coin = null)
        {
            var localVarPath = "/v2/private/wallet/balance";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (coin is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "coin", coin));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<WalletGetBalanceBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// get wallet balance info
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-balance"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="coin">Coin.enum {BTC,EOS,XRP,ETH,USDT} (optional)</param>
        /// <returns>Task of WalletGetBalanceBase</returns>
        public async Task<WalletGetBalanceBase> WalletGetBalanceAsync(Currency? coin = null)
            => (await WalletGetBalanceAsyncWithHttpInfo(coin)).Data;

        /// <summary>
        /// get wallet balance info
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-balance"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="coin">Coin.enum {BTC,EOS,XRP,ETH,USDT} (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public Task<ApiResponse<WalletGetBalanceBase>> WalletGetBalanceAsyncWithHttpInfo(Currency? coin = null)
        {
            var localVarPath = "/v2/private/wallet/balance";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (coin is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "coin", coin));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<WalletGetBalanceBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-walletrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency type (optional)</param>
        /// <param name="walletFundType">wallet fund type (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns><see cref="WalletGetRecordsBase"/></returns>
        public WalletGetRecordsBase WalletGetRecords(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WalletFundType? walletFundType = null, int? page = null, int? limit = null)
            => WalletGetRecordsWithHttpInfo(startDate, endDate, coin, walletFundType, page, limit).Data;

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-walletrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency type (optional)</param>
        /// <param name="walletFundType">wallet fund type (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>ApiResponse of WalletGetRecordsBase</returns>
        public ApiResponse<WalletGetRecordsBase> WalletGetRecordsWithHttpInfo(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WalletFundType? walletFundType = null, int? page = null, int? limit = null)
        {
            var localVarPath = "/open-api/wallet/fund/records";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (startDate is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate.Value.UtcDateTime.ToString("yyyy-MM-dd")));
            }

            if (endDate is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate.Value.UtcDateTime.ToString("yyyy-MM-dd")));
            }

            if (coin is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "coin", coin));
            }

            if (walletFundType is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "wallet_fund_type", walletFundType));
            }

            if (page is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<WalletGetRecordsBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-walletrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency type (optional)</param>
        /// <param name="walletFundType">wallet fund type (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>Task of WalletGetRecordsBase</returns>
        public async Task<WalletGetRecordsBase> WalletGetRecordsAsync(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WalletFundType? walletFundType = null, int? page = null, int? limit = null)
            => (await WalletGetRecordsAsyncWithHttpInfo(startDate, endDate, coin, walletFundType, page, limit)).Data;

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-walletrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency type (optional)</param>
        /// <param name="walletFundType">wallet fund type (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>Task of ApiResponse (WalletGetRecordsBase)</returns>
        public Task<ApiResponse<WalletGetRecordsBase>> WalletGetRecordsAsyncWithHttpInfo(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WalletFundType? walletFundType = null, int? page = null, int? limit = null)
        {
            var localVarPath = "/open-api/wallet/fund/records";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (startDate is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate.Value.UtcDateTime.ToString("yyyy-MM-dd")));
            }

            if (endDate is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate.Value.UtcDateTime.ToString("yyyy-MM-dd")));
            }

            if (coin is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "coin", coin));
            }

            if (walletFundType is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "wallet_fund_type", walletFundType));
            }

            if (page is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<WalletGetRecordsBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns><see cref="WalletGetRiskLimitBase"/></returns>
        public WalletGetRiskLimitBase WalletGetRiskLimit()
            => WalletGetRiskLimitWithHttpInfo().Data;

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of WalletGetRiskLimitBase</returns>
        public ApiResponse<WalletGetRiskLimitBase> WalletGetRiskLimitWithHttpInfo()
        {
            var localVarPath = "/open-api/wallet/risk-limit/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<WalletGetRiskLimitBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of WalletGetRiskLimitBase</returns>
        public async Task<WalletGetRiskLimitBase> WalletGetRiskLimitAsync()
            => (await WalletGetRiskLimitAsyncWithHttpInfo()).Data;

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (WalletGetRiskLimitBase)</returns>
        public Task<ApiResponse<WalletGetRiskLimitBase>> WalletGetRiskLimitAsyncWithHttpInfo()
        {
            var localVarPath = "/open-api/wallet/risk-limit/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<WalletGetRiskLimitBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Set risk limit
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-setrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="riskId">Risk ID. Can be found with the Get risk limit list endpoint.</param>
        /// <returns><see cref="WalletSetRiskLimitBase"/></returns>
        public WalletSetRiskLimitBase WalletSetRiskLimit(Symbol symbol, long riskId)
            => WalletSetRiskLimitWithHttpInfo(symbol, riskId).Data;

        /// <summary>
        /// Set risk limit
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-setrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="riskId">Risk ID. Can be found with the Get risk limit list endpoint.</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<WalletSetRiskLimitBase> WalletSetRiskLimitWithHttpInfo(Symbol symbol, long riskId)
        {
            var localVarPath = "/open-api/wallet/risk-limit";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "risk_id", Configuration.ApiClient.ParameterToString(riskId)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<WalletSetRiskLimitBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Set risk limit
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-setrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="riskId">Risk ID. Can be found with the Get risk limit list endpoint.</param>
        /// <returns>Task of WalletSetRiskLimitBase</returns>
        public async Task<WalletSetRiskLimitBase> WalletSetRiskLimitAsync(Symbol symbol, long riskId)
            => (await WalletSetRiskLimitAsyncWithHttpInfo(symbol, riskId)).Data;

        /// <summary>
        /// Set risk limit
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-setrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="riskId">Risk ID. Can be found with the Get risk limit list endpoint.</param>
        /// <returns>Task of ApiResponse (WalletSetRiskLimitBase)</returns>
        public Task<ApiResponse<WalletSetRiskLimitBase>> WalletSetRiskLimitAsyncWithHttpInfo(Symbol symbol, long riskId)
        {
            var localVarPath = "/open-api/wallet/risk-limit"; ;
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "risk_id", Configuration.ApiClient.ParameterToString(riskId)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<WalletSetRiskLimitBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-withdrawrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency (optional)</param>
        /// <param name="status">Withdraw status (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns><see cref="WalletWithdrawBase"/></returns>
        public WalletWithdrawBase WalletWithdraw(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WithdrawStatus? status = null, int? page = null, int? limit = null)
            => WalletWithdrawWithHttpInfo(startDate, endDate, coin, status, page, limit).Data;

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-withdrawrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency (optional)</param>
        /// <param name="status">Withdraw status (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>ApiResponse of WalletWithdrawBase</returns>
        public ApiResponse<WalletWithdrawBase> WalletWithdrawWithHttpInfo(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WithdrawStatus? status = null, int? page = null, int? limit = null)
        {
            var localVarPath = "/open-api/wallet/withdraw/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (startDate is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate.Value.UtcDateTime.ToString("yyyy-MM-dd")));
            }

            if (endDate is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate.Value.UtcDateTime.ToString("yyyy-MM-dd")));
            }

            if (coin is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "coin", coin));
            }

            if (status is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status));
            }

            if (page is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<WalletWithdrawBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-withdrawrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency (optional)</param>
        /// <param name="status">Withdraw status (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>Task of WalletWithdrawBase</returns>
        public async Task<WalletWithdrawBase> WalletWithdrawAsync(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WithdrawStatus? status = null, int? page = null, int? limit = null)
             => (await WalletWithdrawAsyncWithHttpInfo(startDate, endDate, coin, status, page, limit)).Data;

        /// <summary>
        /// Get wallet fund records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-withdrawrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Start point for result (optional)</param>
        /// <param name="endDate">End point for result (optional)</param>
        /// <param name="coin">Currency (optional)</param>
        /// <param name="status">Withdraw status (optional)</param>
        /// <param name="page">Page. Default getting first page data (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <returns>Task of ApiResponse (WalletWithdrawBase)</returns>
        public Task<ApiResponse<WalletWithdrawBase>> WalletWithdrawAsyncWithHttpInfo(DateTimeOffset? startDate = null, DateTimeOffset? endDate = null, Currency? coin = null, WithdrawStatus? status = null, int? page = null, int? limit = null)
        {
            var localVarPath = "/open-api/wallet/withdraw/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (startDate is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate.Value.UtcDateTime.ToString("yyyy-MM-dd")));
            }

            if (endDate is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate.Value.UtcDateTime.ToString("yyyy-MM-dd")));
            }

            if (coin is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "coin", coin));
            }

            if (status is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status));
            }

            if (page is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<WalletWithdrawBase>(localVarPath, Method.POST, localVarQueryParams);
        }
    }
}