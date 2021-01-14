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
    public interface IPositionsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Update margin.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-changemargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type which you want update its margin</param>
        /// <param name="margin">New margin you want set</param>
        /// <returns><see cref="PositionsChangeMarginBase"/></returns>
        PositionsChangeMarginBase PositionsChangeMargin(Symbol symbol, decimal margin);

        /// <summary>
        /// Update margin.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-changemargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type which you want update its margin</param>
        /// <param name="margin">New margin you want set</param>
        /// <returns>ApiResponse of PositionsChangeMarginBase</returns>
        ApiResponse<PositionsChangeMarginBase> PositionsChangeMarginWithHttpInfo(Symbol symbol, decimal margin);

        /// <summary>
        /// Get user&#39;s closed profit and loss records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        /// <param name="endTime">End timestamp point for result, in second (optional)</param>
        /// <param name="execType">Execution type (optional)</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        /// <returns><see cref="PositionsClosePnlBase"/></returns>
        PositionsClosePnlBase PositionsClosePnlRecords(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get user&#39;s closed profit and loss records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        /// <param name="endTime">End timestamp point for result, in second (optional)</param>
        /// <param name="execType">Execution type (optional)</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        /// <returns>ApiResponse of PositionsClosePnlBase</returns>
        ApiResponse<PositionsClosePnlBase> PositionsClosePnlRecordsWithHttpInfo(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type which you want update its margin.</param>
        /// <returns>PositionsMyPositionBase of PositionsMyPositionRes</returns>
        PositionsMyPositionBase<PositionsMyPositionRes> PositionsMyPosition(Symbol symbol);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type which you want update its margin.</param>
        /// <returns>ApiResponse of PositionsMyPositionBase (PositionsMyPositionRes)</returns>
        ApiResponse<PositionsMyPositionBase<PositionsMyPositionRes>> PositionsMyPositionWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>PositionsMyPositionBase of List (PositionsMyPositionResBase)</returns>
        PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>> PositionsMyPosition();

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PositionsMyPositionBase (List of PositionsMyPositionResBase))</returns>
        ApiResponse<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>> PositionsMyPositionWithHttpInfo();

        /// <summary>
        /// Change user leverage.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">A symbol which you want change its leverage</param>
        /// <param name="leverage">New leverage you want set</param>
        /// <returns><see cref="PositionsSaveLeverageBase"/></returns>
        PositionsSaveLeverageBase PositionsSaveLeverage(Symbol symbol, decimal leverage);

        /// <summary>
        /// Change user leverage.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">A symbol which you want change its leverage</param>
        /// <param name="leverage">New leverage you want set</param>
        /// <returns>ApiResponse of PositionsSaveLeverageBase</returns>
        ApiResponse<PositionsSaveLeverageBase> PositionsSaveLeverageWithHttpInfo(Symbol symbol, decimal leverage);

        /// <summary>
        /// Set Trading-Stop Condition.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-tradingstop"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <param name="takeProfit">Not less than 0, 0 means cancel TP (optional)</param>
        /// <param name="stopLoss">Not less than 0, 0 means cancel SL (optional)</param>
        /// <param name="trailingStop">Not less than 0, 0 means cancel TS (optional)</param>
        /// <param name="newTrailingActive">Trailing stop trigger price. Trailing stops are triggered only when the price reaches the specified price. Trailing stops are triggered immediately by default. (optional)</param>
        /// <returns><see cref="PositionsTradingStopBase"/></returns>
        PositionsTradingStopBase PositionsTradingStop(Symbol symbol, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, decimal? newTrailingActive = null);

        /// <summary>
        /// Set Trading-Stop Condition.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-tradingstop"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <param name="takeProfit">Not less than 0, 0 means cancel TP (optional)</param>
        /// <param name="stopLoss">Not less than 0, 0 means cancel SL (optional)</param>
        /// <param name="trailingStop">Not less than 0, 0 means cancel TS (optional)</param>
        /// <param name="newTrailingActive">Trailing stop trigger price. Trailing stops are triggered only when the price reaches the specified price. Trailing stops are triggered immediately by default. (optional)</param>
        /// <returns>ApiResponse of PositionsTradingStopBase</returns>
        ApiResponse<PositionsTradingStopBase> PositionsTradingStopWithHttpInfo(Symbol symbol, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, decimal? newTrailingActive = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Update margin.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-changemargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type which you want update its margin</param>
        /// <param name="margin">New margin you want set</param>
        /// <returns>Task of PositionsChangeMarginBase</returns>
        Task<PositionsChangeMarginBase> PositionsChangeMarginAsync(Symbol symbol, decimal margin);

        /// <summary>
        /// Update margin.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-changemargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type which you want update its margin</param>
        /// <param name="margin">New margin you want set</param>
        /// <returns>Task of ApiResponse (PositionsChangeMarginBase)</returns>
        Task<ApiResponse<PositionsChangeMarginBase>> PositionsChangeMarginAsyncWithHttpInfo(Symbol symbol, decimal margin);

        /// <summary>
        /// Get user&#39;s closed profit and loss records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        /// <param name="endTime">End timestamp point for result, in second (optional)</param>
        /// <param name="execType">Execution type (optional)</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        /// <returns>Task of PositionsClosePnlBase</returns>
        Task<PositionsClosePnlBase> PositionsClosePnlRecordsAsync(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get user&#39;s closed profit and loss records
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        /// <param name="endTime">End timestamp point for result, in second (optional)</param>
        /// <param name="execType">Execution type (optional)</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        /// <returns>Task of ApiResponse (PositionsClosePnlBase)</returns>
        Task<ApiResponse<PositionsClosePnlBase>> PositionsClosePnlRecordsAsyncWithHttpInfo(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type which you want update its margin.</param>
        /// <returns>Task of PositionsMyPositionRes</returns>
        Task<PositionsMyPositionBase<PositionsMyPositionRes>> PositionsMyPositionAsync(Symbol symbol);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type which you want update its margin.</param>
        /// <returns>Task of ApiResponse (PositionsMyPositionBase of PositionsMyPositionRes)</returns>
        Task<ApiResponse<PositionsMyPositionBase<PositionsMyPositionRes>>> PositionsMyPositionAsyncWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PositionsMyPositionBase (List of PositionsMyPositionResBase)</returns>
        Task<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>> PositionsMyPositionAsync();

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PositionsMyPositionBase of List (PositionsMyPositionResBase))</returns>
        Task<ApiResponse<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>>> PositionsMyPositionAsyncWithHttpInfo();

        /// <summary>
        /// Change user leverage.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">A symbol which you want change its leverage</param>
        /// <param name="leverage">New leverage you want set</param>
        /// <returns>Task of PositionsSaveLeverageBase</returns>
        Task<PositionsSaveLeverageBase> PositionsSaveLeverageAsync(Symbol symbol, decimal leverage);

        /// <summary>
        /// Change user leverage.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">A symbol which you want change its leverage</param>
        /// <param name="leverage">New leverage you want set</param>
        /// <returns>Task of ApiResponse (PositionsSaveLeverageBase)</returns>
        Task<ApiResponse<PositionsSaveLeverageBase>> PositionsSaveLeverageAsyncWithHttpInfo(Symbol symbol, decimal leverage);

        /// <summary>
        /// Set Trading-Stop Condition.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-tradingstop"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <param name="takeProfit">Not less than 0, 0 means cancel TP (optional)</param>
        /// <param name="stopLoss">Not less than 0, 0 means cancel SL (optional)</param>
        /// <param name="trailingStop">Not less than 0, 0 means cancel TS (optional)</param>
        /// <param name="newTrailingActive">Trailing stop trigger price. Trailing stops are triggered only when the price reaches the specified price. Trailing stops are triggered immediately by default. (optional)</param>
        /// <returns>Task of PositionsTradingStopBase</returns>
        Task<PositionsTradingStopBase> PositionsTradingStopAsync(Symbol symbol, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, decimal? newTrailingActive = null);

        /// <summary>
        /// Set Trading-Stop Condition.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-tradingstop"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <param name="takeProfit">Not less than 0, 0 means cancel TP (optional)</param>
        /// <param name="stopLoss">Not less than 0, 0 means cancel SL (optional)</param>
        /// <param name="trailingStop">Not less than 0, 0 means cancel TS (optional)</param>
        /// <param name="newTrailingActive">Trailing stop trigger price. Trailing stops are triggered only when the price reaches the specified price. Trailing stops are triggered immediately by default. (optional)</param>
        /// <returns>Task of ApiResponse (PositionsTradingStopRes)</returns>
        Task<ApiResponse<PositionsTradingStopBase>> PositionsTradingStopAsyncWithHttpInfo(Symbol symbol, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, decimal? newTrailingActive = null);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class PositionsApi : ApiBase, IPositionsApi
    {
        private const int PositionsClosePnlRecordsPageMaxValue = 50;
        private const int PositionsClosePnlRecordsLimitMaxValue = 50;

        public PositionsApi(string basePath) : base(basePath)
        {
        }

        public PositionsApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public PositionsChangeMarginBase PositionsChangeMargin(Symbol symbol, decimal margin)
            => PositionsChangeMarginWithHttpInfo(symbol, margin).Data;

        public ApiResponse<PositionsChangeMarginBase> PositionsChangeMarginWithHttpInfo(Symbol symbol, decimal margin)
        {
            var localVarPath = "/position/change-position-margin";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "margin", Configuration.ApiClient.ParameterToString(margin)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<PositionsChangeMarginBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<PositionsChangeMarginBase> PositionsChangeMarginAsync(Symbol symbol, decimal margin)
            => (await PositionsChangeMarginAsyncWithHttpInfo(symbol, margin)).Data;

        public Task<ApiResponse<PositionsChangeMarginBase>> PositionsChangeMarginAsyncWithHttpInfo(Symbol symbol, decimal margin)
        {
            var localVarPath = "/position/change-position-margin";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "margin", Configuration.ApiClient.ParameterToString(margin)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<PositionsChangeMarginBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public PositionsClosePnlBase PositionsClosePnlRecords(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null)
            => PositionsClosePnlRecordsWithHttpInfo(symbol, startTime, endTime, execType, page, limit).Data;

        public ApiResponse<PositionsClosePnlBase> PositionsClosePnlRecordsWithHttpInfo(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null)
        {
            // verify the parameter 'page'
            if (page is not null and < 0 or > PositionsClosePnlRecordsPageMaxValue)
            {
                throw new ApiException(400, "Validation error on 'page' parameter occured when calling PositionsApi->PositionsClosePnlRecords");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > PositionsClosePnlRecordsLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling PositionsApi->PositionsClosePnlRecords");
            }

            var localVarPath = "/v2/private/trade/closed-pnl/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (startTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime));
            }

            if (endTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime));
            }

            if (execType is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exec_type", execType));
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

            return CallApiWithHttpInfo<PositionsClosePnlBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<PositionsClosePnlBase> PositionsClosePnlRecordsAsync(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null)
            => (await PositionsClosePnlRecordsAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit)).Data;

        public Task<ApiResponse<PositionsClosePnlBase>> PositionsClosePnlRecordsAsyncWithHttpInfo(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null)
        {
            // verify the parameter 'page'
            if (page is not null and < 0 or > PositionsClosePnlRecordsPageMaxValue)
            {
                throw new ApiException(400, "Validation error on 'page' parameter occured when calling PositionsApi->PositionsClosePnlRecords");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > PositionsClosePnlRecordsLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling PositionsApi->PositionsClosePnlRecords");
            }

            var localVarPath = "/v2/private/trade/closed-pnl/list"; ;
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (startTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime));
            }

            if (endTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime));
            }

            if (execType is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exec_type", execType));
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

            return CallApiAsyncWithHttpInfo<PositionsClosePnlBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public PositionsMyPositionBase<PositionsMyPositionRes> PositionsMyPosition(Symbol symbol)
            => PositionsMyPositionWithHttpInfo(symbol).Data;

        public ApiResponse<PositionsMyPositionBase<PositionsMyPositionRes>> PositionsMyPositionWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/position/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<PositionsMyPositionBase<PositionsMyPositionRes>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<PositionsMyPositionBase<PositionsMyPositionRes>> PositionsMyPositionAsync(Symbol symbol)
            => (await PositionsMyPositionAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<PositionsMyPositionBase<PositionsMyPositionRes>>> PositionsMyPositionAsyncWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/position/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<PositionsMyPositionBase<PositionsMyPositionRes>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>> PositionsMyPosition()
            => PositionsMyPositionWithHttpInfo().Data;

        public ApiResponse<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>> PositionsMyPositionWithHttpInfo()
        {
            var localVarPath = "/v2/private/position/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>> PositionsMyPositionAsync()
            => (await PositionsMyPositionAsyncWithHttpInfo()).Data;

        public Task<ApiResponse<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>>> PositionsMyPositionAsyncWithHttpInfo()
        {
            var localVarPath = "/v2/private/position/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<PositionsMyPositionBase<IReadOnlyList<PositionsMyPositionResBase>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public PositionsSaveLeverageBase PositionsSaveLeverage(Symbol symbol, decimal leverage)
            => PositionsSaveLeverageWithHttpInfo(symbol, leverage).Data;

        public ApiResponse<PositionsSaveLeverageBase> PositionsSaveLeverageWithHttpInfo(Symbol symbol, decimal leverage)
        {
            var localVarPath = "/user/leverage/save";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "leverage", Configuration.ApiClient.ParameterToString(leverage)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<PositionsSaveLeverageBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<PositionsSaveLeverageBase> PositionsSaveLeverageAsync(Symbol symbol, decimal leverage)
            => (await PositionsSaveLeverageAsyncWithHttpInfo(symbol, leverage)).Data;

        public Task<ApiResponse<PositionsSaveLeverageBase>> PositionsSaveLeverageAsyncWithHttpInfo(Symbol symbol, decimal leverage)
        {
            var localVarPath = "/user/leverage/save";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "leverage", Configuration.ApiClient.ParameterToString(leverage)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<PositionsSaveLeverageBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public PositionsTradingStopBase PositionsTradingStop(Symbol symbol, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, decimal? newTrailingActive = null)
            => PositionsTradingStopWithHttpInfo(symbol, takeProfit, stopLoss, trailingStop, newTrailingActive).Data;

        public ApiResponse<PositionsTradingStopBase> PositionsTradingStopWithHttpInfo(Symbol symbol, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, decimal? newTrailingActive = null)
        {
            // verify the parameter 'takeProfit'
            if (takeProfit is not null and < 0)
            {
                throw new ApiException(400, "'takeProfit' (must be grater than 0): Validation error has occured when calling PositionsApi->PositionsTradingStop");
            }
            // verify the parameter 'stopLoss'
            if (stopLoss is not null and < 0)
            {
                throw new ApiException(400, "'stopLoss' (must be grater than 0): Validation error has occured when calling PositionsApi->PositionsTradingStop");
            }
            // verify the parameter 'trailingStop'
            if (trailingStop is not null and < 0)
            {
                throw new ApiException(400, "'trailingStop' (must be grater than 0): Validation error has occured when calling PositionsApi->PositionsTradingStop");
            }

            var localVarPath = "/open-api/position/trading-stop";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (takeProfit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "take_profit", Configuration.ApiClient.ParameterToString(takeProfit)));
            }

            if (stopLoss is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_loss", Configuration.ApiClient.ParameterToString(stopLoss)));
            }

            if (trailingStop is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "trailing_stop", Configuration.ApiClient.ParameterToString(trailingStop)));
            }

            if (newTrailingActive is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "new_trailing_active", Configuration.ApiClient.ParameterToString(newTrailingActive)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<PositionsTradingStopBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<PositionsTradingStopBase> PositionsTradingStopAsync(Symbol symbol, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, decimal? newTrailingActive = null)
            => (await PositionsTradingStopAsyncWithHttpInfo(symbol, takeProfit, stopLoss, trailingStop, newTrailingActive)).Data;

        public Task<ApiResponse<PositionsTradingStopBase>> PositionsTradingStopAsyncWithHttpInfo(Symbol symbol, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, decimal? newTrailingActive = null)
        {
            // verify the parameter 'takeProfit'
            if (takeProfit is not null and < 0)
            {
                throw new ApiException(400, "'takeProfit' (must be grater than 0): Validation error has occured when calling PositionsApi->PositionsTradingStop");
            }
            // verify the parameter 'stopLoss'
            if (stopLoss is not null and < 0)
            {
                throw new ApiException(400, "'stopLoss' (must be grater than 0): Validation error has occured when calling PositionsApi->PositionsTradingStop");
            }
            // verify the parameter 'trailingStop'
            if (trailingStop is not null and < 0)
            {
                throw new ApiException(400, "'trailingStop' (must be grater than 0): Validation error has occured when calling PositionsApi->PositionsTradingStop");
            }

            var localVarPath = "/open-api/position/trading-stop";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (takeProfit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "take_profit", Configuration.ApiClient.ParameterToString(takeProfit)));
            }

            if (stopLoss is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_loss", Configuration.ApiClient.ParameterToString(stopLoss)));
            }

            if (trailingStop is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "trailing_stop", Configuration.ApiClient.ParameterToString(trailingStop)));
            }

            if (newTrailingActive is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "new_trailing_active", Configuration.ApiClient.ParameterToString(newTrailingActive)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<PositionsTradingStopBase>(localVarPath, Method.POST, localVarQueryParams);
        }
    }
}