using BybitAPI.Client;
using BybitAPI.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BybitAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMarketApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Query Account Long Short Ratio
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-marketaccountratio"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="period">Data recording period. 5min, 15min, 30min, 1h, 4h, 1d</param>
        /// <param name="limit">Limit for data size, max size is 500. Default size is 50 (optional)</param>
        /// <returns><see cref="MarketAccountRatioBase"/></returns>
        MarketAccountRatioBase MarketAccountRatio(Symbol symbol, string period, int? limit = null);

        /// <summary>
        /// Query Account Long Short Ratio
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-marketaccountratio"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="period">Data recording period. 5min, 15min, 30min, 1h, 4h, 1d</param>
        /// <param name="limit">Limit for data size, max size is 500. Default size is 50 (optional)</param>
        /// <returns>ApiResponse of MarketAccountRatioBase</returns>
        ApiResponse<MarketAccountRatioBase> MarketAccountRatioWithHttpInfo(Symbol symbol, string period, int? limit = null);

        /// <summary>
        /// Query Big Deal
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-marketbigdeal"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="limit">Limit for data size, max size is 1000. Default size is 500 (optional)</param>
        /// <returns><see cref="MarketBigDealBase"/></returns>
        MarketBigDealBase MarketBigDeal(Symbol symbol, int? limit = null);

        /// <summary>
        /// Query Big Deal
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-marketbigdeal"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="limit">Limit for data size, max size is 1000. Default size is 500 (optional)</param>
        /// <returns>ApiResponse of MarketBigDealBase</returns>
        ApiResponse<MarketBigDealBase> MarketBigDealWithHttpInfo(Symbol symbol, int? limit = null);

        /// <summary>
        /// Query liq records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-query_liqrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="from">From ID. Default: return latest data (optional)</param>
        /// <param name="limit">Limit for data size, max size is 1000. Default size is 500 (optional)</param>
        /// <param name="startTime">Start timestamp point for result, in millisecond (optional)</param>
        /// <param name="endTime">End timestamp point for result, in millisecond (optional)</param>
        /// <returns><see cref="MarketLiqRecordsBase"/></returns>
        MarketLiqRecordsBase MarketLiqRecords(Symbol symbol, long? from = null, int? limit = null, long? startTime = null, long? endTime = null);

        /// <summary>
        /// Query liq records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-query_liqrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="from">From ID. Default: return latest data (optional)</param>
        /// <param name="limit">Limit for data size, max size is 1000. Default size is 500 (optional)</param>
        /// <param name="startTime">Start timestamp point for result, in millisecond (optional)</param>
        /// <param name="endTime">End timestamp point for result, in millisecond (optional)</param>
        /// <returns>ApiResponse of MarketLiqRecordsBase</returns>
        ApiResponse<MarketLiqRecordsBase> MarketLiqRecordsWithHttpInfo(Symbol symbol, long? from = null, int? limit = null, long? startTime = null, long? endTime = null);

        /// <summary>
        /// Query Open Interest
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-marketopeninterest"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="period">Data recording period. 5min, 15min, 30min, 1h, 4h, 1d</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 50 (optional)</param>
        /// <returns><see cref="MarketOpenInterestBase"/></returns>
        MarketOpenInterestBase MarketOpenInterest(Symbol symbol, string period, int? limit = null);

        /// <summary>
        /// Query Open Interest
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-marketopeninterest"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="period">Data recording period. 5min, 15min, 30min, 1h, 4h, 1d</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 50 (optional)</param>
        /// <returns>ApiResponse of MarketOpenInterestBase</returns>
        ApiResponse<MarketOpenInterestBase> MarketOpenInterestWithHttpInfo(Symbol symbol, string period, int? limit = null);

        /// <summary>
        /// Get the orderbook.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-orderbook"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns><see cref="MarketOrderbookBase"/></returns>
        MarketOrderbookBase MarketOrderbook(Symbol symbol);

        /// <summary>
        /// Get the orderbook.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-orderbook"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns>ApiResponse of MarketOrderbookBase</returns>
        ApiResponse<MarketOrderbookBase> MarketOrderbookWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get the latest information for symbol.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-latestsymbolinfo"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/> (optional)</param>
        /// <returns><see cref="MarketSymbolInfoBase"/></returns>
        MarketSymbolInfoBase MarketSymbolInfo(Symbol? symbol = null);

        /// <summary>
        /// Get the latest information for symbol.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-latestsymbolinfo"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/> (optional)</param>
        /// <returns>ApiResponse of MarketSymbolInfoBase</returns>
        ApiResponse<MarketSymbolInfoBase> MarketSymbolInfoWithHttpInfo(Symbol? symbol = null);

        /// <summary>
        /// Get recent trades
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-publictradingrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="from">From ID. Default: return latest data (optional)</param>
        /// <param name="limit">Number of results. Default 500; max 1000 (optional)</param>
        /// <returns><see cref="MarketTradingRecordsBase"/></returns>
        MarketTradingRecordsBase MarketTradingRecords(Symbol symbol, long? from = null, int? limit = null);

        /// <summary>
        /// Get recent trades
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-publictradingrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="from">From ID. Default: return latest data (optional)</param>
        /// <param name="limit">Number of results. Default 500; max 1000 (optional)</param>
        /// <returns>ApiResponse of MarketTradingRecordsBase</returns>
        ApiResponse<MarketTradingRecordsBase> MarketTradingRecordsWithHttpInfo(Symbol symbol, long? from = null, int? limit = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Query Account Long Short Ratio
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-marketaccountratio"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="period">Data recording period. 5min, 15min, 30min, 1h, 4h, 1d</param>
        /// <param name="limit">Limit for data size, max size is 500. Default size is 50 (optional)</param>
        /// <returns>Task of MarketAccountRatioBase</returns>
        Task<MarketAccountRatioBase> MarketAccountRatioAsync(Symbol symbol, string period, int? limit = null);

        /// <summary>
        /// Query Account Long Short Ratio
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-marketaccountratio"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="period">Data recording period. 5min, 15min, 30min, 1h, 4h, 1d</param>
        /// <param name="limit">Limit for data size, max size is 500. Default size is 50 (optional)</param>
        /// <returns>Task of ApiResponse (MarketAccountRatioBase)</returns>
        Task<ApiResponse<MarketAccountRatioBase>> MarketAccountRatioAsyncWithHttpInfo(Symbol symbol, string period, int? limit = null);

        /// <summary>
        /// Query Big Deal
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-marketbigdeal"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="limit">Limit for data size, max size is 1000. Default size is 500 (optional)</param>
        /// <returns>Task of MarketBigDealBase</returns>
        Task<MarketBigDealBase> MarketBigDealAsync(Symbol symbol, int? limit = null);

        /// <summary>
        /// Query Big Deal
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-marketbigdeal"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="limit">Limit for data size, max size is 1000. Default size is 500 (optional)</param>
        /// <returns>Task of ApiResponse (MarketBigDealBase)</returns>
        Task<ApiResponse<MarketBigDealBase>> MarketBigDealAsyncWithHttpInfo(Symbol symbol, int? limit = null);

        /// <summary>
        /// Query liq records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-query_liqrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="from">From ID. Default: return latest data (optional)</param>
        /// <param name="limit">Limit for data size, max size is 1000. Default size is 500 (optional)</param>
        /// <param name="startTime">Start timestamp point for result, in millisecond (optional)</param>
        /// <param name="endTime">End timestamp point for result, in millisecond (optional)</param>
        /// <returns>Task of MarketLiqRecordsBase</returns>
        Task<MarketLiqRecordsBase> MarketLiqRecordsAsync(Symbol symbol, long? from = null, int? limit = null, long? startTime = null, long? endTime = null);

        /// <summary>
        /// Query liq records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-query_liqrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="from">From ID. Default: return latest data (optional)</param>
        /// <param name="limit">Limit for data size, max size is 1000. Default size is 500 (optional)</param>
        /// <param name="startTime">Start timestamp point for result, in millisecond (optional)</param>
        /// <param name="endTime">End timestamp point for result, in millisecond (optional)</param>
        /// <returns>Task of ApiResponse (MarketLiqRecordsBase)</returns>
        Task<ApiResponse<MarketLiqRecordsBase>> MarketLiqRecordsAsyncWithHttpInfo(Symbol symbol, long? from = null, int? limit = null, long? startTime = null, long? endTime = null);

        /// <summary>
        /// Query Open Interest
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-marketopeninterest"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="period">Data recording period. 5min, 15min, 30min, 1h, 4h, 1d</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 50 (optional)</param>
        /// <returns>Task of MarketOpenInterestBase</returns>
        Task<MarketOpenInterestBase> MarketOpenInterestAsync(Symbol symbol, string period, int? limit = null);

        /// <summary>
        /// Query Open Interest
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-marketopeninterest"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="period">Data recording period. 5min, 15min, 30min, 1h, 4h, 1d</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 50 (optional)</param>
        /// <returns>Task of ApiResponse (MarketOpenInterestBase)</returns>
        Task<ApiResponse<MarketOpenInterestBase>> MarketOpenInterestAsyncWithHttpInfo(Symbol symbol, string period, int? limit = null);

        /// <summary>
        /// Get the orderbook.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-orderbook"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns>Task of Object</returns>
        Task<MarketOrderbookBase> MarketOrderbookAsync(Symbol symbol);

        /// <summary>
        /// Get the orderbook.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-orderbook"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns>Task of ApiResponse (MarketOrderbookBase)</returns>
        Task<ApiResponse<MarketOrderbookBase>> MarketOrderbookAsyncWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get the latest information for symbol.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-latestsymbolinfo"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/> (optional)</param>
        /// <returns>Task of MarketSymbolInfoBase</returns>
        Task<MarketSymbolInfoBase> MarketSymbolInfoAsync(Symbol? symbol = null);

        /// <summary>
        /// Get the latest information for symbol.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-latestsymbolinfo"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/> (optional)</param>
        /// <returns>Task of ApiResponse (MarketSymbolInfoBase)</returns>
        Task<ApiResponse<MarketSymbolInfoBase>> MarketSymbolInfoAsyncWithHttpInfo(Symbol? symbol = null);

        /// <summary>
        /// Get recent trades
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-publictradingrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="from">From ID. Default: return latest data (optional)</param>
        /// <param name="limit">Number of results. Default 500; max 1000 (optional)</param>
        /// <returns>Task of MarketTradingRecordsBase</returns>
        Task<MarketTradingRecordsBase> MarketTradingRecordsAsync(Symbol symbol, long? from = null, int? limit = null);

        /// <summary>
        /// Get recent trades
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-publictradingrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="from">From ID. Default: return latest data (optional)</param>
        /// <param name="limit">Number of results. Default 500; max 1000 (optional)</param>
        /// <returns>Task of ApiResponse (MarketTradingRecordsBase)</returns>
        Task<ApiResponse<MarketTradingRecordsBase>> MarketTradingRecordsAsyncWithHttpInfo(Symbol symbol, long? from = null, int? limit = null);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class MarketApi : ApiBase, IMarketApi
    {
        private const int MarketAccountRatioLimitMaxValue = 500;
        private const int MarketBigDealLimitMaxValue = 1000;
        private const int MarketLiqRecordsLimitMaxValue = 1000;
        private const int MarketOpenInterestLimitMaxValue = 200;
        private const int MarketTradingRecordsLimitMaxValue = 1000;
        private static readonly string[] Periods = new[] { "5min", "15min", "30min", "1h", "4h", "1d" };

        public MarketApi(string basePath) : base(basePath)
        {
        }

        public MarketApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public MarketAccountRatioBase MarketAccountRatio(Symbol symbol, string period, int? limit = null)
            => MarketAccountRatioWithHttpInfo(symbol, period, limit).Data;

        public ApiResponse<MarketAccountRatioBase> MarketAccountRatioWithHttpInfo(Symbol symbol, string period, int? limit = null)
        {
            // verify the required parameter 'period'
            //Note: 'period' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (period is null || Periods.Contains(period) is false)
            {
                throw new ApiException(400, "Validation error on 'period' parameter occured when calling MarketApi->MarketAccountRatio");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > MarketAccountRatioLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling MarketApi->MarketAccountRatio");
            }

            var localVarPath = "/v2/public/account-ratio";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (period is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiWithHttpInfo<MarketAccountRatioBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<MarketAccountRatioBase> MarketAccountRatioAsync(Symbol symbol, string period, int? limit = null)
            => (await MarketAccountRatioAsyncWithHttpInfo(symbol, period, limit)).Data;

        public Task<ApiResponse<MarketAccountRatioBase>> MarketAccountRatioAsyncWithHttpInfo(Symbol symbol, string period, int? limit = null)
        {
            // verify the required parameter 'period'
            //Note: 'period' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (period is null || Periods.Contains(period) is false)
            {
                throw new ApiException(400, "Validation error on 'period' parameter occured when calling MarketApi->MarketAccountRatio");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > MarketAccountRatioLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling MarketApi->MarketAccountRatio");
            }

            var localVarPath = "/v2/public/account-ratio";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (period is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiAsyncWithHttpInfo<MarketAccountRatioBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public MarketBigDealBase MarketBigDeal(Symbol symbol, int? limit = null)
            => MarketBigDealWithHttpInfo(symbol, limit).Data;

        public ApiResponse<MarketBigDealBase> MarketBigDealWithHttpInfo(Symbol symbol, int? limit = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > MarketBigDealLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling MarketApi->MarketBigDeal");
            }

            var localVarPath = "/v2/public/big-deal";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiWithHttpInfo<MarketBigDealBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<MarketBigDealBase> MarketBigDealAsync(Symbol symbol, int? limit = null)
            => (await MarketBigDealAsyncWithHttpInfo(symbol, limit)).Data;

        public Task<ApiResponse<MarketBigDealBase>> MarketBigDealAsyncWithHttpInfo(Symbol symbol, int? limit = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > MarketBigDealLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling MarketApi->MarketBigDeal");
            }

            var localVarPath = "/v2/public/big-deal";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiAsyncWithHttpInfo<MarketBigDealBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public MarketLiqRecordsBase MarketLiqRecords(Symbol symbol, long? from = null, int? limit = null, long? startTime = null, long? endTime = null)
            => MarketLiqRecordsWithHttpInfo(symbol, from, limit, startTime, endTime).Data;

        public ApiResponse<MarketLiqRecordsBase> MarketLiqRecordsWithHttpInfo(Symbol symbol, long? from = null, int? limit = null, long? startTime = null, long? endTime = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > MarketLiqRecordsLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling MarketApi->MarketLiqRecords");
            }

            var localVarPath = "/v2/public/liq-records";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (from is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            if (startTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime));
            }

            if (endTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime));
            }

            return CallApiWithHttpInfo<MarketLiqRecordsBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<MarketLiqRecordsBase> MarketLiqRecordsAsync(Symbol symbol, long? from = null, int? limit = null, long? startTime = null, long? endTime = null)
            => (await MarketLiqRecordsAsyncWithHttpInfo(symbol, from, limit, startTime, endTime)).Data;

        public Task<ApiResponse<MarketLiqRecordsBase>> MarketLiqRecordsAsyncWithHttpInfo(Symbol symbol, long? from = null, int? limit = null, long? startTime = null, long? endTime = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > MarketLiqRecordsLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling MarketApi->MarketLiqRecords");
            }

            var localVarPath = "/v2/public/liq-records";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (from is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            if (startTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime));
            }

            if (endTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime));
            }

            return CallApiAsyncWithHttpInfo<MarketLiqRecordsBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public MarketOpenInterestBase MarketOpenInterest(Symbol symbol, string period, int? limit = null)
            => MarketOpenInterestWithHttpInfo(symbol, period, limit).Data;

        public ApiResponse<MarketOpenInterestBase> MarketOpenInterestWithHttpInfo(Symbol symbol, string period, int? limit = null)
        {
            // verify the required parameter 'period'
            //Note: 'period' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (period is null || Periods.Contains(period) is false)
            {
                throw new ApiException(400, "Validation error on 'period' parameter occured when calling MarketApi->MarketOpenInterest");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > MarketOpenInterestLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling MarketApi->MarketOpenInterest");
            }

            var localVarPath = "/v2/public/open-interest";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            if (period is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period));
            }

            return CallApiWithHttpInfo<MarketOpenInterestBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<MarketOpenInterestBase> MarketOpenInterestAsync(Symbol symbol, string period, int? limit = null)
            => (await MarketOpenInterestAsyncWithHttpInfo(symbol, period, limit)).Data;

        public Task<ApiResponse<MarketOpenInterestBase>> MarketOpenInterestAsyncWithHttpInfo(Symbol symbol, string period, int? limit = null)
        {
            // verify the required parameter 'period'
            //Note: 'period' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (period is null || Periods.Contains(period) is false)
            {
                throw new ApiException(400, "Validation error on 'period' parameter occured when calling MarketApi->MarketOpenInterest");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > MarketOpenInterestLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling MarketApi->MarketOpenInterest");
            }

            var localVarPath = "/v2/public/open-interest";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            if (period is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period));
            }

            return CallApiAsyncWithHttpInfo<MarketOpenInterestBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public MarketOrderbookBase MarketOrderbook(Symbol symbol)
            => MarketOrderbookWithHttpInfo(symbol).Data;

        public ApiResponse<MarketOrderbookBase> MarketOrderbookWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/public/orderBook/L2";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            return CallApiWithHttpInfo<MarketOrderbookBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<MarketOrderbookBase> MarketOrderbookAsync(Symbol symbol)
            => (await MarketOrderbookAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<MarketOrderbookBase>> MarketOrderbookAsyncWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/public/orderBook/L2";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            return CallApiAsyncWithHttpInfo<MarketOrderbookBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public MarketSymbolInfoBase MarketSymbolInfo(Symbol? symbol = null)
            => MarketSymbolInfoWithHttpInfo(symbol).Data;

        public ApiResponse<MarketSymbolInfoBase> MarketSymbolInfoWithHttpInfo(Symbol? symbol = null)
        {
            var localVarPath = "/v2/public/tickers";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            }

            return CallApiWithHttpInfo<MarketSymbolInfoBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<MarketSymbolInfoBase> MarketSymbolInfoAsync(Symbol? symbol = null)
            => (await MarketSymbolInfoAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<MarketSymbolInfoBase>> MarketSymbolInfoAsyncWithHttpInfo(Symbol? symbol = null)
        {
            var localVarPath = "/v2/public/tickers";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            }

            return CallApiAsyncWithHttpInfo<MarketSymbolInfoBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public MarketTradingRecordsBase MarketTradingRecords(Symbol symbol, long? from = null, int? limit = null)
            => MarketTradingRecordsWithHttpInfo(symbol, from, limit).Data;

        public ApiResponse<MarketTradingRecordsBase> MarketTradingRecordsWithHttpInfo(Symbol symbol, long? from = null, int? limit = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > MarketTradingRecordsLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling MarketApi->MarketOpenInterest");
            }

            var localVarPath = "/v2/public/trading-records";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (from is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiWithHttpInfo<MarketTradingRecordsBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<MarketTradingRecordsBase> MarketTradingRecordsAsync(Symbol symbol, long? from = null, int? limit = null)
            => (await MarketTradingRecordsAsyncWithHttpInfo(symbol, from, limit)).Data;

        public Task<ApiResponse<MarketTradingRecordsBase>> MarketTradingRecordsAsyncWithHttpInfo(Symbol symbol, long? from = null, int? limit = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > MarketTradingRecordsLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling MarketApi->MarketOpenInterest");
            }

            var localVarPath = "/v2/public/trading-records";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (from is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiAsyncWithHttpInfo<MarketTradingRecordsBase>(localVarPath, Method.GET, localVarQueryParams);
        }
    }
}