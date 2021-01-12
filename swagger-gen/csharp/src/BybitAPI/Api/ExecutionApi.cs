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
    public interface IExecutionApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get user’s trade records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">OrderID. If not provided, will return user’s trading records. (optional)</param>
        /// <param name="startTime">Start timestamp point for result. (optional)</param>
        /// <param name="page">Page. Default getting first page data. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 200. Default as showing 50 pieces of data per page. (optional)</param>
        /// <param name="order">Sort orders by creation date. (optional)</param>
        /// <returns><see cref="ExecutionGetTradesBase"/></returns>
        ExecutionGetTradesBase ExecutionGetTrades(Symbol symbol, string? orderId = null, long? startTime = null, int? page = null, int? limit = null, Order? order = null);

        /// <summary>
        /// Get user’s trade records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">OrderID. If not provided, will return user’s trading records. (optional)</param>
        /// <param name="startTime">Start timestamp point for result. (optional)</param>
        /// <param name="page">Page. Default getting first page data. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 200. Default as showing 50 pieces of data per page. (optional)</param>
        /// <param name="order">Sort orders by creation date. (optional)</param>
        /// <returns>ApiResponse of ExecutionGetTradesBase</returns>
        ApiResponse<ExecutionGetTradesBase> ExecutionGetTradesWithHttpInfo(Symbol symbol, string? orderId = null, long? startTime = null, int? page = null, int? limit = null, Order? order = null);

        ///// <summary>
        ///// Get user&#39;s closed profit and loss records
        ///// </summary>
        ///// <remarks>
        ///// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        ///// </remarks>
        ///// <exception cref="ApiException">Thrown when fails to make API call</exception>
        ///// <param name="symbol">Contract type</param>
        ///// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        ///// <param name="endTime">End timestamp point for result, in second (optional)</param>
        ///// <param name="execType">Execution type (optional)</param>
        ///// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        ///// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        ///// <returns>Object</returns>
        //PositionsClosePnlBase PositionsClosePnlRecords(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null);

        ///// <summary>
        ///// Get user&#39;s closed profit and loss records
        ///// </summary>
        ///// <remarks>
        ///// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        ///// </remarks>
        ///// <exception cref="ApiException">Thrown when fails to make API call</exception>
        ///// <param name="symbol">Contract type</param>
        ///// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        ///// <param name="endTime">End timestamp point for result, in second (optional)</param>
        ///// <param name="execType">Execution type (optional)</param>
        ///// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        ///// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        ///// <returns>ApiResponse of Object</returns>
        //ApiResponse<PositionsClosePnlBase> PositionsClosePnlRecordsWithHttpInfo(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get user’s trade records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">OrderID. If not provided, will return user’s trading records. (optional)</param>
        /// <param name="startTime">Start timestamp point for result. (optional)</param>
        /// <param name="page">Page. Default getting first page data. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 200. Default as showing 50 pieces of data per page. (optional)</param>
        /// <param name="order">Sort orders by creation date. (optional)</param>
        /// <returns>Task of ExecutionGetTradesBase</returns>
        Task<ExecutionGetTradesBase> ExecutionGetTradesAsync(Symbol symbol, string? orderId = null, long? startTime = null, int? page = null, int? limit = null, Order? order = null);

        /// <summary>
        /// Get user’s trade records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">OrderID. If not provided, will return user’s trading records. (optional)</param>
        /// <param name="startTime">Start timestamp point for result. (optional)</param>
        /// <param name="page">Page. Default getting first page data. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 200. Default as showing 50 pieces of data per page. (optional)</param>
        /// <param name="order">Sort orders by creation date. (optional)</param>
        /// <returns>Task of ApiResponse (ExecutionGetTradesBase)</returns>
        Task<ApiResponse<ExecutionGetTradesBase>> ExecutionGetTradesAsyncWithHttpInfo(Symbol symbol, string? orderId = null, long? startTime = null, int? page = null, int? limit = null, Order? order = null);

        ///// <summary>
        ///// Get user&#39;s closed profit and loss records
        ///// </summary>
        ///// <remarks>
        ///// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        ///// </remarks>
        ///// <exception cref="ApiException">Thrown when fails to make API call</exception>
        ///// <param name="symbol">Contract type</param>
        ///// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        ///// <param name="endTime">End timestamp point for result, in second (optional)</param>
        ///// <param name="execType">Execution type (optional)</param>
        ///// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        ///// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        ///// <returns>Task of Object</returns>
        //Task<PositionsClosePnlBase> PositionsClosePnlRecordsAsync(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null);

        ///// <summary>
        ///// Get user&#39;s closed profit and loss records
        ///// </summary>
        ///// <remarks>
        ///// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        ///// </remarks>
        ///// <exception cref="ApiException">Thrown when fails to make API call</exception>
        ///// <param name="symbol">Contract type</param>
        ///// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        ///// <param name="endTime">End timestamp point for result, in second (optional)</param>
        ///// <param name="execType">Execution type (optional)</param>
        ///// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        ///// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        ///// <returns>Task of ApiResponse (Object)</returns>
        //Task<ApiResponse<PositionsClosePnlBase>> PositionsClosePnlRecordsAsyncWithHttpInfo(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExecutionApi : ApiBase, IExecutionApi
    {
        private const int ExecutionGetTradesPageMaxValue = 50;
        private const int ExecutionGetTradesLimitMaxValue = 200;
        //private const int PositionsClosePnlRecordsPageMaxValue = 50;
        //private const int PositionsClosePnlRecordsLimitMaxValue = 50;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExecutionApi(string basePath) : base(basePath) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExecutionApi(Configuration? configuration = null) : base(configuration) { }

        /// <summary>
        /// Get user’s trade records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">OrderID. If not provided, will return user’s trading records. (optional)</param>
        /// <param name="startTime">Start timestamp point for result. (optional)</param>
        /// <param name="page">Page. Default getting first page data. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 200. Default as showing 50 pieces of data per page. (optional)</param>
        /// <param name="order">Sort orders by creation date. (optional)</param>
        /// <returns><see cref="ExecutionGetTradesBase"/></returns>
        public ExecutionGetTradesBase ExecutionGetTrades(Symbol symbol, string? orderId = null, long? startTime = null, int? page = null, int? limit = null, Order? order = null)
            => ExecutionGetTradesWithHttpInfo(symbol, orderId, startTime, page, limit, order).Data;

        /// <summary>
        /// Get user’s trade records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">OrderID. If not provided, will return user’s trading records. (optional)</param>
        /// <param name="startTime">Start timestamp point for result. (optional)</param>
        /// <param name="page">Page. Default getting first page data. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 200. Default as showing 50 pieces of data per page. (optional)</param>
        /// <param name="order">Sort orders by creation date. (optional)</param>
        /// <returns>ApiResponse of ExecutionGetTradesBase</returns>
        public ApiResponse<ExecutionGetTradesBase> ExecutionGetTradesWithHttpInfo(Symbol symbol, string? orderId = null, long? startTime = null, int? page = null, int? limit = null, Order? order = null)
        {
            // verify the parameter 'page'
            if (page is not null and < 0 or > ExecutionGetTradesPageMaxValue)
            {
                throw new ApiException(400, "Validation error on 'page' parameter occured when calling ExecutionApi->ExecutionGetTrades");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > ExecutionGetTradesLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling ExecutionApi->ExecutionGetTrades");
            }

            var localVarPath = "/v2/private/execution/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", orderId));
            }

            if (startTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime));
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

            return CallApiWithHttpInfo<ExecutionGetTradesBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get user’s trade records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">OrderID. If not provided, will return user’s trading records. (optional)</param>
        /// <param name="startTime">Start timestamp point for result. (optional)</param>
        /// <param name="page">Page. Default getting first page data. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 200. Default as showing 50 pieces of data per page. (optional)</param>
        /// <param name="order">Sort orders by creation date. (optional)</param>
        /// <returns>Task of ExecutionGetTradesBase</returns>
        public async Task<ExecutionGetTradesBase> ExecutionGetTradesAsync(Symbol symbol, string? orderId = null, long? startTime = null, int? page = null, int? limit = null, Order? order = null)
            => (await ExecutionGetTradesAsyncWithHttpInfo(symbol, orderId, startTime, page, limit, order)).Data;

        /// <summary>
        /// Get user’s trade records.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">OrderID. If not provided, will return user’s trading records. (optional)</param>
        /// <param name="startTime">Start timestamp point for result. (optional)</param>
        /// <param name="page">Page. Default getting first page data. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 200. Default as showing 50 pieces of data per page. (optional)</param>
        /// <param name="order">Sort orders by creation date. (optional)</param>
        /// <returns>Task of ApiResponse (ExecutionGetTradesBase)</returns>
        public Task<ApiResponse<ExecutionGetTradesBase>> ExecutionGetTradesAsyncWithHttpInfo(Symbol symbol, string? orderId = null, long? startTime = null, int? page = null, int? limit = null, Order? order = null)
        {
            // verify the parameter 'page'
            if (page is not null and < 0 or > ExecutionGetTradesPageMaxValue)
            {
                throw new ApiException(400, "Validation error on 'page' parameter occured when calling ExecutionApi->ExecutionGetTrades");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > ExecutionGetTradesLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling ExecutionApi->ExecutionGetTrades");
            }

            var localVarPath = "/v2/private/execution/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", orderId));
            }

            if (startTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime));
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

            return CallApiAsyncWithHttpInfo<ExecutionGetTradesBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        ///// <summary>
        ///// Get user&#39;s closed profit and loss records
        ///// </summary>
        ///// <remarks>
        ///// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        ///// </remarks>
        ///// <exception cref="ApiException">Thrown when fails to make API call</exception>
        ///// <param name="symbol">Contract type</param>
        ///// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        ///// <param name="endTime">End timestamp point for result, in second (optional)</param>
        ///// <param name="execType">Execution type (optional)</param>
        ///// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        ///// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        ///// <returns><see cref="PositionsClosePnlBase"/></returns>
        //public PositionsClosePnlBase PositionsClosePnlRecords(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null)
        //    => PositionsClosePnlRecordsWithHttpInfo(symbol, startTime, endTime, execType, page, limit).Data;

        ///// <summary>
        ///// Get user&#39;s closed profit and loss records
        ///// </summary>
        ///// <remarks>
        ///// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        ///// </remarks>
        ///// <exception cref="ApiException">Thrown when fails to make API call</exception>
        ///// <param name="symbol">Contract type</param>
        ///// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        ///// <param name="endTime">End timestamp point for result, in second (optional)</param>
        ///// <param name="execType">Execution type (optional)</param>
        ///// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        ///// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        ///// <returns>ApiResponse of PositionsClosePnlBase</returns>
        //public ApiResponse<PositionsClosePnlBase> PositionsClosePnlRecordsWithHttpInfo(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null)
        //{
        //    // verify the parameter 'page'
        //    if (page is not null and < 0 or > PositionsClosePnlRecordsPageMaxValue)
        //    {
        //        throw new ApiException(400, "Validation error on 'page' parameter occured when calling ExecutionApi->PositionsClosePnlRecords");
        //    }
        //    // verify the parameter 'limit'
        //    if (limit is not null and < 0 or > PositionsClosePnlRecordsLimitMaxValue)
        //    {
        //        throw new ApiException(400, "Validation error on 'limit' parameter occured when calling ExecutionApi->PositionsClosePnlRecords");
        //    }

        //    var localVarPath = "/v2/private/trade/closed-pnl/list";
        //    var localVarQueryParams = new List<KeyValuePair<string, string>>();

        //    localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

        //    if (startTime is not null)
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime));
        //    }

        //    if (endTime is not null)
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime));
        //    }

        //    if (execType is not null)
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exec_type", execType));
        //    }

        //    if (page is not null)
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page));
        //    }

        //    if (limit is not null)
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
        //    }

        //    // authentication (timestamp) required
        //    localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

        //    // authentication (apiKey) required
        //    if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
        //    }

        //    return CallApiWithHttpInfo<PositionsClosePnlBase>(localVarPath, Method.GET, localVarQueryParams);
        //}

        ///// <summary>
        ///// Get user&#39;s closed profit and loss records
        ///// </summary>
        ///// <remarks>
        ///// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        ///// </remarks>
        ///// <exception cref="ApiException">Thrown when fails to make API call</exception>
        ///// <param name="symbol">Contract type</param>
        ///// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        ///// <param name="endTime">End timestamp point for result, in second (optional)</param>
        ///// <param name="execType">Execution type (optional)</param>
        ///// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        ///// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        ///// <returns>Task of PositionsClosePnlBase</returns>
        //public async Task<PositionsClosePnlBase> PositionsClosePnlRecordsAsync(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null)
        //    => (await PositionsClosePnlRecordsAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit)).Data;

        ///// <summary>
        ///// Get user&#39;s closed profit and loss records
        ///// </summary>
        ///// <remarks>
        ///// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-closedprofitandloss"/>
        ///// </remarks>
        ///// <exception cref="ApiException">Thrown when fails to make API call</exception>
        ///// <param name="symbol">Contract type</param>
        ///// <param name="startTime">Start timestamp point for result, in second (optional)</param>
        ///// <param name="endTime">End timestamp point for result, in second (optional)</param>
        ///// <param name="execType">Execution type (optional)</param>
        ///// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages (optional)</param>
        ///// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        ///// <returns>Task of ApiResponse (PositionsClosePnlBase)</returns>
        //public Task<ApiResponse<PositionsClosePnlBase>> PositionsClosePnlRecordsAsyncWithHttpInfo(Symbol symbol, long? startTime = null, long? endTime = null, ExecType? execType = null, int? page = null, int? limit = null)
        //{
        //    // verify the parameter 'page'
        //    if (page is not null and < 0 or > PositionsClosePnlRecordsPageMaxValue)
        //    {
        //        throw new ApiException(400, "Validation error on 'page' parameter occured when calling ExecutionApi->PositionsClosePnlRecords");
        //    }
        //    // verify the parameter 'limit'
        //    if (limit is not null and < 0 or > PositionsClosePnlRecordsLimitMaxValue)
        //    {
        //        throw new ApiException(400, "Validation error on 'limit' parameter occured when calling ExecutionApi->PositionsClosePnlRecords");
        //    }

        //    var localVarPath = "/v2/private/trade/closed-pnl/list"; ;
        //    var localVarQueryParams = new List<KeyValuePair<string, string>>();

        //    localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

        //    if (startTime is not null)
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime));
        //    }

        //    if (endTime is not null)
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime));
        //    }

        //    if (execType is not null)
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exec_type", execType));
        //    }

        //    if (page is not null)
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page));
        //    }

        //    if (limit is not null)
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
        //    }

        //    // authentication (timestamp) required
        //    localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

        //    // authentication (apiKey) required
        //    if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
        //    {
        //        localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
        //    }

        //    return CallApiAsyncWithHttpInfo<PositionsClosePnlBase>(localVarPath, Method.GET, localVarQueryParams);
        //}
    }
}