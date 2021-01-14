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
    public interface ILinearPositionsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Add/Reduce Margin
        /// </summary>
        /// <remarks>
        /// This will Add/Reduce Margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-addmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Symbol</param>
        /// <param name="side">Side</param>
        /// <param name="margin">Add/Remove how much margin: Increase 10; decrease -10, supports 4 decimal places</param>
        /// <returns><see cref="LinearPositionsChangeMarginBase"/></returns>
        LinearPositionsChangeMarginBase LinearPositionsChangeMargin(LinearSymbol symbol, LinearSide side, decimal margin);

        /// <summary>
        /// Add/Reduce Margin
        /// </summary>
        /// <remarks>
        /// This will Add/Reduce Margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-addmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Symbol</param>
        /// <param name="side">Side</param>
        /// <param name="margin">Add/Remove how much margin: Increase 10; decrease -10, supports 4 decimal places</param>
        /// <returns>ApiResponse of LinearPositionsChangeMarginBase</returns>
        ApiResponse<LinearPositionsChangeMarginBase> LinearPositionsChangeMarginWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal margin);

        /// <summary>
        /// Get user&#39;s closed profit and loss records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s closed profit and loss records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Symbol</param>
        /// <param name="startTime">Start timestamp point for result, in seconds</param>
        /// <param name="endTime">End timestamp point for result, in seconds</param>
        /// <param name="execType">Execution type</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page.</param>
        /// <returns><see cref="LinearPositionsClosePnlRecordsBase"/></returns>
        LinearPositionsClosePnlRecordsBase LinearPositionsClosePnlRecords(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get user&#39;s closed profit and loss records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s closed profit and loss records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Symbol</param>
        /// <param name="startTime">Start timestamp point for result, in seconds</param>
        /// <param name="endTime">End timestamp point for result, in seconds</param>
        /// <param name="execType">Execution type</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page.</param>
        /// <returns>ApiResponse of LinearPositionsClosePnlRecordsBase</returns>
        ApiResponse<LinearPositionsClosePnlRecordsBase> LinearPositionsClosePnlRecordsWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <returns>Object</returns>
        object LinearPositionsMyPosition(string symbol = null);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<object> LinearPositionsMyPositionWithHttpInfo(string symbol = null);

        /// <summary>
        /// Set leverage
        /// </summary>
        /// <remarks>
        /// This will Set Leverage
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="buyLeverage"> (optional)</param>
        /// <param name="sellLeverage"> (optional)</param>
        /// <returns>Object</returns>
        object LinearPositionsSaveLeverage(string symbol = null, double? buyLeverage = null, double? sellLeverage = null);

        /// <summary>
        /// Set leverage
        /// </summary>
        /// <remarks>
        /// This will Set Leverage
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="buyLeverage"> (optional)</param>
        /// <param name="sellLeverage"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<object> LinearPositionsSaveLeverageWithHttpInfo(string symbol = null, double? buyLeverage = null, double? sellLeverage = null);

        /// <summary>
        /// Set auto add margin
        /// </summary>
        /// <remarks>
        /// This will Set auto add margin
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="side"> (optional)</param>
        /// <param name="autoAddMargin"> (optional)</param>
        /// <returns>Object</returns>
        object LinearPositionsSetAutoAddMargin(string symbol = null, string side = null, bool? autoAddMargin = null);

        /// <summary>
        /// Set auto add margin
        /// </summary>
        /// <remarks>
        /// This will Set auto add margin
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="side"> (optional)</param>
        /// <param name="autoAddMargin"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<object> LinearPositionsSetAutoAddMarginWithHttpInfo(string symbol = null, string side = null, bool? autoAddMargin = null);

        /// <summary>
        /// Switch isolated
        /// </summary>
        /// <remarks>
        /// This will switch isolated
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="isIsolated"> (optional)</param>
        /// <param name="buyLeverage"> (optional)</param>
        /// <param name="sellLeverage"> (optional)</param>
        /// <returns>Object</returns>
        object LinearPositionsSwitchIsolated(string symbol = null, bool? isIsolated = null, double? buyLeverage = null, double? sellLeverage = null);

        /// <summary>
        /// Switch isolated
        /// </summary>
        /// <remarks>
        /// This will switch isolated
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="isIsolated"> (optional)</param>
        /// <param name="buyLeverage"> (optional)</param>
        /// <param name="sellLeverage"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<object> LinearPositionsSwitchIsolatedWithHttpInfo(string symbol = null, bool? isIsolated = null, double? buyLeverage = null, double? sellLeverage = null);

        /// <summary>
        /// Switch Mode
        /// </summary>
        /// <remarks>
        /// This will Switch TP/SL Mode
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="tpSlMode"> (optional)</param>
        /// <returns>Object</returns>
        object LinearPositionsSwitchMode(string symbol = null, string tpSlMode = null);

        /// <summary>
        /// Switch Mode
        /// </summary>
        /// <remarks>
        /// This will Switch TP/SL Mode
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="tpSlMode"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<object> LinearPositionsSwitchModeWithHttpInfo(string symbol = null, string tpSlMode = null);

        /// <summary>
        /// Set tradingStop
        /// </summary>
        /// <remarks>
        /// This will set tradingStop
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="side"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="trailingStop"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <param name="slSize"> (optional)</param>
        /// <param name="tpSize"> (optional)</param>
        /// <returns>Object</returns>
        object LinearPositionsTradingStop(string symbol = null, string side = null, double? takeProfit = null, double? stopLoss = null, double? trailingStop = null, string tpTriggerBy = null, string slTriggerBy = null, double? slSize = null, double? tpSize = null);

        /// <summary>
        /// Set tradingStop
        /// </summary>
        /// <remarks>
        /// This will set tradingStop
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="side"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="trailingStop"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <param name="slSize"> (optional)</param>
        /// <param name="tpSize"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<object> LinearPositionsTradingStopWithHttpInfo(string symbol = null, string side = null, double? takeProfit = null, double? stopLoss = null, double? trailingStop = null, string tpTriggerBy = null, string slTriggerBy = null, double? slSize = null, double? tpSize = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Add/Reduce Margin
        /// </summary>
        /// <remarks>
        /// This will Add/Reduce Margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-addmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Symbol</param>
        /// <param name="side">Side</param>
        /// <param name="margin">Add/Remove how much margin: Increase 10; decrease -10, supports 4 decimal places</param>
        /// <returns>Task of LinearPositionsChangeMarginBase</returns>
        Task<LinearPositionsChangeMarginBase> LinearPositionsChangeMarginAsync(LinearSymbol symbol, LinearSide side, decimal margin);

        /// <summary>
        /// Add/Reduce Margin
        /// </summary>
        /// <remarks>
        /// This will Add/Reduce Margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-addmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Symbol</param>
        /// <param name="side">Side</param>
        /// <param name="margin">Add/Remove how much margin: Increase 10; decrease -10, supports 4 decimal places</param>
        /// <returns>Task of ApiResponse (LinearPositionsChangeMarginBase)</returns>
        Task<ApiResponse<LinearPositionsChangeMarginBase>> LinearPositionsChangeMarginAsyncWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal margin);

        /// <summary>
        /// Get user&#39;s closed profit and loss records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s closed profit and loss records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Symbol</param>
        /// <param name="startTime">Start timestamp point for result, in seconds</param>
        /// <param name="endTime">End timestamp point for result, in seconds</param>
        /// <param name="execType">Execution type</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page.</param>
        /// <returns>Task of LinearPositionsClosePnlRecordsBase</returns>
        Task<LinearPositionsClosePnlRecordsBase> LinearPositionsClosePnlRecordsAsync(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get user&#39;s closed profit and loss records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s closed profit and loss records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Symbol</param>
        /// <param name="startTime">Start timestamp point for result, in seconds</param>
        /// <param name="endTime">End timestamp point for result, in seconds</param>
        /// <param name="execType">Execution type</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page.</param>
        /// <returns>Task of ApiResponse (LinearPositionsClosePnlRecordsBase)</returns>
        Task<ApiResponse<LinearPositionsClosePnlRecordsBase>> LinearPositionsClosePnlRecordsAsyncWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <returns>Task of Object</returns>
        Task<object> LinearPositionsMyPositionAsync(string symbol = null);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<object>> LinearPositionsMyPositionAsyncWithHttpInfo(string symbol = null);

        /// <summary>
        /// Set leverage
        /// </summary>
        /// <remarks>
        /// This will Set Leverage
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="buyLeverage"> (optional)</param>
        /// <param name="sellLeverage"> (optional)</param>
        /// <returns>Task of Object</returns>
        Task<object> LinearPositionsSaveLeverageAsync(string symbol = null, double? buyLeverage = null, double? sellLeverage = null);

        /// <summary>
        /// Set leverage
        /// </summary>
        /// <remarks>
        /// This will Set Leverage
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="buyLeverage"> (optional)</param>
        /// <param name="sellLeverage"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<object>> LinearPositionsSaveLeverageAsyncWithHttpInfo(string symbol = null, double? buyLeverage = null, double? sellLeverage = null);

        /// <summary>
        /// Set auto add margin
        /// </summary>
        /// <remarks>
        /// This will Set auto add margin
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="side"> (optional)</param>
        /// <param name="autoAddMargin"> (optional)</param>
        /// <returns>Task of Object</returns>
        Task<object> LinearPositionsSetAutoAddMarginAsync(string symbol = null, string side = null, bool? autoAddMargin = null);

        /// <summary>
        /// Set auto add margin
        /// </summary>
        /// <remarks>
        /// This will Set auto add margin
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="side"> (optional)</param>
        /// <param name="autoAddMargin"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<object>> LinearPositionsSetAutoAddMarginAsyncWithHttpInfo(string symbol = null, string side = null, bool? autoAddMargin = null);

        /// <summary>
        /// Switch isolated
        /// </summary>
        /// <remarks>
        /// This will switch isolated
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="isIsolated"> (optional)</param>
        /// <param name="buyLeverage"> (optional)</param>
        /// <param name="sellLeverage"> (optional)</param>
        /// <returns>Task of Object</returns>
        Task<object> LinearPositionsSwitchIsolatedAsync(string symbol = null, bool? isIsolated = null, double? buyLeverage = null, double? sellLeverage = null);

        /// <summary>
        /// Switch isolated
        /// </summary>
        /// <remarks>
        /// This will switch isolated
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="isIsolated"> (optional)</param>
        /// <param name="buyLeverage"> (optional)</param>
        /// <param name="sellLeverage"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<object>> LinearPositionsSwitchIsolatedAsyncWithHttpInfo(string symbol = null, bool? isIsolated = null, double? buyLeverage = null, double? sellLeverage = null);

        /// <summary>
        /// Switch Mode
        /// </summary>
        /// <remarks>
        /// This will Switch TP/SL Mode
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="tpSlMode"> (optional)</param>
        /// <returns>Task of Object</returns>
        Task<object> LinearPositionsSwitchModeAsync(string symbol = null, string tpSlMode = null);

        /// <summary>
        /// Switch Mode
        /// </summary>
        /// <remarks>
        /// This will Switch TP/SL Mode
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="tpSlMode"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<object>> LinearPositionsSwitchModeAsyncWithHttpInfo(string symbol = null, string tpSlMode = null);

        /// <summary>
        /// Set tradingStop
        /// </summary>
        /// <remarks>
        /// This will set tradingStop
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="side"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="trailingStop"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <param name="slSize"> (optional)</param>
        /// <param name="tpSize"> (optional)</param>
        /// <returns>Task of Object</returns>
        Task<object> LinearPositionsTradingStopAsync(string symbol = null, string side = null, double? takeProfit = null, double? stopLoss = null, double? trailingStop = null, string tpTriggerBy = null, string slTriggerBy = null, double? slSize = null, double? tpSize = null);

        /// <summary>
        /// Set tradingStop
        /// </summary>
        /// <remarks>
        /// This will set tradingStop
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="side"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="trailingStop"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <param name="slSize"> (optional)</param>
        /// <param name="tpSize"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<object>> LinearPositionsTradingStopAsyncWithHttpInfo(string symbol = null, string side = null, double? takeProfit = null, double? stopLoss = null, double? trailingStop = null, string tpTriggerBy = null, string slTriggerBy = null, double? slSize = null, double? tpSize = null);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class LinearPositionsApi : ApiBase, ILinearPositionsApi
    {
        public LinearPositionsApi(string basePath) : base(basePath)
        {
        }

        public LinearPositionsApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public LinearPositionsChangeMarginBase LinearPositionsChangeMargin(LinearSymbol symbol, LinearSide side, decimal margin)
            => LinearPositionsChangeMarginWithHttpInfo(symbol, side, margin).Data;

        public ApiResponse<LinearPositionsChangeMarginBase> LinearPositionsChangeMarginWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal margin)
        {
            var localVarPath = "/private/linear/position/add-margin";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "margin", Configuration.ApiClient.ParameterToString(margin)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearPositionsChangeMarginBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<LinearPositionsChangeMarginBase> LinearPositionsChangeMarginAsync(LinearSymbol symbol, LinearSide side, decimal margin)
            => (await LinearPositionsChangeMarginAsyncWithHttpInfo(symbol, side, margin)).Data;

        public Task<ApiResponse<LinearPositionsChangeMarginBase>> LinearPositionsChangeMarginAsyncWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal margin)
        {
            var localVarPath = "/private/linear/position/add-margin";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "margin", Configuration.ApiClient.ParameterToString(margin)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearPositionsChangeMarginBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public LinearPositionsClosePnlRecordsBase LinearPositionsClosePnlRecords(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
            => LinearPositionsClosePnlRecordsWithHttpInfo(symbol, startTime, endTime, execType, page, limit).Data;

        public ApiResponse<LinearPositionsClosePnlRecordsBase> LinearPositionsClosePnlRecordsWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
        {
            var localVarPath = "/private/linear/trade/closed-pnl/list";
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

            return CallApiWithHttpInfo<LinearPositionsClosePnlRecordsBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearPositionsClosePnlRecordsBase> LinearPositionsClosePnlRecordsAsync(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
            => (await LinearPositionsClosePnlRecordsAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit)).Data;

        public Task<ApiResponse<LinearPositionsClosePnlRecordsBase>> LinearPositionsClosePnlRecordsAsyncWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
        {
            var localVarPath = "/private/linear/trade/closed-pnl/list";
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

            return CallApiAsyncWithHttpInfo<LinearPositionsClosePnlRecordsBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public object LinearPositionsMyPosition(string symbol = null)
            => LinearPositionsMyPositionWithHttpInfo(symbol).Data;

        public ApiResponse<object> LinearPositionsMyPositionWithHttpInfo(string symbol = null)
        {
            var localVarPath = "/private/linear/position/list";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/json",
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsMyPosition", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public async Task<object> LinearPositionsMyPositionAsync(string symbol = null)
            => (await LinearPositionsMyPositionAsyncWithHttpInfo(symbol)).Data;

        public async Task<ApiResponse<object>> LinearPositionsMyPositionAsyncWithHttpInfo(string symbol = null)
        {
            var localVarPath = "/private/linear/position/list";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/json",
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsMyPosition", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public object LinearPositionsSaveLeverage(string symbol = null, double? buyLeverage = null, double? sellLeverage = null)
            => LinearPositionsSaveLeverageWithHttpInfo(symbol, buyLeverage, sellLeverage).Data;

        public ApiResponse<object> LinearPositionsSaveLeverageWithHttpInfo(string symbol = null, double? buyLeverage = null, double? sellLeverage = null)
        {
            var localVarPath = "/private/linear/position/set-leverage";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            if (buyLeverage is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buy_leverage", Configuration.ApiClient.ParameterToString(buyLeverage)));
            }

            if (sellLeverage is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sell_leverage", Configuration.ApiClient.ParameterToString(sellLeverage)));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsSaveLeverage", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public async Task<object> LinearPositionsSaveLeverageAsync(string symbol = null, double? buyLeverage = null, double? sellLeverage = null)
            => (await LinearPositionsSaveLeverageAsyncWithHttpInfo(symbol, buyLeverage, sellLeverage)).Data;

        public async Task<ApiResponse<object>> LinearPositionsSaveLeverageAsyncWithHttpInfo(string symbol = null, double? buyLeverage = null, double? sellLeverage = null)
        {
            var localVarPath = "/private/linear/position/set-leverage";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            if (buyLeverage is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buy_leverage", Configuration.ApiClient.ParameterToString(buyLeverage)));
            }

            if (sellLeverage is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sell_leverage", Configuration.ApiClient.ParameterToString(sellLeverage)));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsSaveLeverage", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public object LinearPositionsSetAutoAddMargin(string symbol = null, string side = null, bool? autoAddMargin = null)
            => LinearPositionsSetAutoAddMarginWithHttpInfo(symbol, side, autoAddMargin).Data;

        public ApiResponse<object> LinearPositionsSetAutoAddMarginWithHttpInfo(string symbol = null, string side = null, bool? autoAddMargin = null)
        {
            var localVarPath = "/private/linear/position/set-auto-add-margin";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            if (side is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            }

            if (autoAddMargin is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "auto_add_margin", Configuration.ApiClient.ParameterToString(autoAddMargin)));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsSetAutoAddMargin", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public async Task<object> LinearPositionsSetAutoAddMarginAsync(string symbol = null, string side = null, bool? autoAddMargin = null)
            => (await LinearPositionsSetAutoAddMarginAsyncWithHttpInfo(symbol, side, autoAddMargin)).Data;

        public async Task<ApiResponse<object>> LinearPositionsSetAutoAddMarginAsyncWithHttpInfo(string symbol = null, string side = null, bool? autoAddMargin = null)
        {
            var localVarPath = "/private/linear/position/set-auto-add-margin";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            if (side is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            }

            if (autoAddMargin is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "auto_add_margin", Configuration.ApiClient.ParameterToString(autoAddMargin)));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsSetAutoAddMargin", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public object LinearPositionsSwitchIsolated(string symbol = null, bool? isIsolated = null, double? buyLeverage = null, double? sellLeverage = null)
            => LinearPositionsSwitchIsolatedWithHttpInfo(symbol, isIsolated, buyLeverage, sellLeverage).Data;

        public ApiResponse<object> LinearPositionsSwitchIsolatedWithHttpInfo(string symbol = null, bool? isIsolated = null, double? buyLeverage = null, double? sellLeverage = null)
        {
            var localVarPath = "/private/linear/position/switch-isolated";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            if (isIsolated is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_isolated", Configuration.ApiClient.ParameterToString(isIsolated)));
            }

            if (buyLeverage is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buy_leverage", Configuration.ApiClient.ParameterToString(buyLeverage)));
            }

            if (sellLeverage is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sell_leverage", Configuration.ApiClient.ParameterToString(sellLeverage)));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsSwitchIsolated", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public async Task<object> LinearPositionsSwitchIsolatedAsync(string symbol = null, bool? isIsolated = null, double? buyLeverage = null, double? sellLeverage = null)
            => (await LinearPositionsSwitchIsolatedAsyncWithHttpInfo(symbol, isIsolated, buyLeverage, sellLeverage)).Data;

        public async Task<ApiResponse<object>> LinearPositionsSwitchIsolatedAsyncWithHttpInfo(string symbol = null, bool? isIsolated = null, double? buyLeverage = null, double? sellLeverage = null)
        {
            var localVarPath = "/private/linear/position/switch-isolated";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            if (isIsolated is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_isolated", Configuration.ApiClient.ParameterToString(isIsolated)));
            }

            if (buyLeverage is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buy_leverage", Configuration.ApiClient.ParameterToString(buyLeverage)));
            }

            if (sellLeverage is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sell_leverage", Configuration.ApiClient.ParameterToString(sellLeverage)));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsSwitchIsolated", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public object LinearPositionsSwitchMode(string symbol = null, string tpSlMode = null)
            => LinearPositionsSwitchModeWithHttpInfo(symbol, tpSlMode).Data;

        public ApiResponse<object> LinearPositionsSwitchModeWithHttpInfo(string symbol = null, string tpSlMode = null)
        {
            var localVarPath = "/private/linear/tpsl/switch-mode";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            if (tpSlMode is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_sl_mode", Configuration.ApiClient.ParameterToString(tpSlMode)));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsSwitchMode", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public async Task<object> LinearPositionsSwitchModeAsync(string symbol = null, string tpSlMode = null)
            => (await LinearPositionsSwitchModeAsyncWithHttpInfo(symbol, tpSlMode)).Data;

        public async Task<ApiResponse<object>> LinearPositionsSwitchModeAsyncWithHttpInfo(string symbol = null, string tpSlMode = null)
        {
            var localVarPath = "/private/linear/tpsl/switch-mode";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            if (tpSlMode is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_sl_mode", Configuration.ApiClient.ParameterToString(tpSlMode)));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsSwitchMode", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public object LinearPositionsTradingStop(string symbol = null, string side = null, double? takeProfit = null, double? stopLoss = null, double? trailingStop = null, string tpTriggerBy = null, string slTriggerBy = null, double? slSize = null, double? tpSize = null)
            => LinearPositionsTradingStopWithHttpInfo(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize).Data;

        public ApiResponse<object> LinearPositionsTradingStopWithHttpInfo(string symbol = null, string side = null, double? takeProfit = null, double? stopLoss = null, double? trailingStop = null, string tpTriggerBy = null, string slTriggerBy = null, double? slSize = null, double? tpSize = null)
        {
            var localVarPath = "/private/linear/position/trading-stop";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            if (side is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            }

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

            if (tpTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_trigger_by", Configuration.ApiClient.ParameterToString(tpTriggerBy)));
            }

            if (slTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_trigger_by", Configuration.ApiClient.ParameterToString(slTriggerBy)));
            }

            if (slSize is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_size", Configuration.ApiClient.ParameterToString(slSize)));
            }

            if (tpSize is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_size", Configuration.ApiClient.ParameterToString(tpSize)));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsTradingStop", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public async Task<object> LinearPositionsTradingStopAsync(string symbol = null, string side = null, double? takeProfit = null, double? stopLoss = null, double? trailingStop = null, string tpTriggerBy = null, string slTriggerBy = null, double? slSize = null, double? tpSize = null)
            => (await LinearPositionsTradingStopAsyncWithHttpInfo(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize)).Data;

        public async Task<ApiResponse<object>> LinearPositionsTradingStopAsyncWithHttpInfo(string symbol = null, string side = null, double? takeProfit = null, double? stopLoss = null, double? trailingStop = null, string tpTriggerBy = null, string slTriggerBy = null, double? slSize = null, double? tpSize = null)
        {
            var localVarPath = "/private/linear/position/trading-stop";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            if (side is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            }

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

            if (tpTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_trigger_by", Configuration.ApiClient.ParameterToString(tpTriggerBy)));
            }

            if (slTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_trigger_by", Configuration.ApiClient.ParameterToString(slTriggerBy)));
            }

            if (slSize is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_size", Configuration.ApiClient.ParameterToString(slSize)));
            }

            if (tpSize is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_size", Configuration.ApiClient.ParameterToString(tpSize)));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearPositionsTradingStop", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }
    }
}