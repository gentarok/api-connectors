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
    public interface ILinearExecutionApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (required)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns><see cref="LinearExecutionGetTradesBase"/></returns>
        LinearExecutionGetTradesBase LinearExecutionGetTrades(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (required)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>ApiResponse of LinearExecutionGetTradesBase</returns>
        ApiResponse<LinearExecutionGetTradesBase> LinearExecutionGetTradesWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (required)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of LinearExecutionGetTradesBase</returns>
        Task<LinearExecutionGetTradesBase> LinearExecutionGetTradesAsync(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (required)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearExecutionGetTradesBase)</returns>
        Task<ApiResponse<LinearExecutionGetTradesBase>> LinearExecutionGetTradesAsyncWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LinearExecutionApi : ApiBase, ILinearExecutionApi
    {
        private const int LinearExecutionGetTradesLimitMaxValue = 200;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearExecutionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LinearExecutionApi(string basePath) : base(basePath) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearExecutionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LinearExecutionApi(Configuration? configuration = null) : base(configuration) { }

        /// <summary>
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (required)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns><see cref="LinearExecutionGetTradesBase"/></returns>
        public LinearExecutionGetTradesBase LinearExecutionGetTrades(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
            => LinearExecutionGetTradesWithHttpInfo(symbol, startTime, endTime, execType, page, limit).Data;

        /// <summary>
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (required)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>ApiResponse of LinearExecutionGetTradesBase</returns>
        public ApiResponse<LinearExecutionGetTradesBase> LinearExecutionGetTradesWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearExecutionGetTradesLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearExecutionApi->LinearExecutionGetTrades");
            }

            var localVarPath = "/private/linear/trade/execution/list";
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

            return CallApiWithHttpInfo<LinearExecutionGetTradesBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (required)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of LinearExecutionGetTradesBase</returns>
        public async Task<LinearExecutionGetTradesBase> LinearExecutionGetTradesAsync(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
            => (await LinearExecutionGetTradesAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit)).Data;

        /// <summary>
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-usertraderecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (required)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearExecutionGetTradesBase)</returns>
        public Task<ApiResponse<LinearExecutionGetTradesBase>> LinearExecutionGetTradesAsyncWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearExecutionGetTradesLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearExecutionApi->LinearExecutionGetTrades");
            }

            var localVarPath = "/private/linear/trade/execution/list";
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

            return CallApiAsyncWithHttpInfo<LinearExecutionGetTradesBase>(localVarPath, Method.GET, localVarQueryParams);
        }
    }
}