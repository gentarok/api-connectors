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
    public interface ILinearMarketApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get recent trades
        /// </summary>
        /// <remarks>
        /// This will get recent trades
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-publictradingrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="limit">Number of results. Default 500; max 1000. (optional)</param>
        /// <returns><see cref="LinearMarketTradingBase"/></returns>
        LinearMarketTradingBase LinearMarketTrading(LinearSymbol symbol, int? limit = null);

        /// <summary>
        /// Get recent trades
        /// </summary>
        /// <remarks>
        /// This will get recent trades
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-publictradingrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="limit">Number of results. Default 500; max 1000. (optional)</param>
        /// <returns>ApiResponse of LinearMarketTradingBase</returns>
        ApiResponse<LinearMarketTradingBase> LinearMarketTradingWithHttpInfo(LinearSymbol symbol, int? limit = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get recent trades
        /// </summary>
        /// <remarks>
        /// This will get recent trades
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-publictradingrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="limit">Number of results. Default 500; max 1000. (optional)</param>
        /// <returns>Task of LinearMarketTradingBase</returns>
        Task<LinearMarketTradingBase> LinearMarketTradingAsync(LinearSymbol symbol, int? limit = null);

        /// <summary>
        /// Get recent trades
        /// </summary>
        /// <remarks>
        /// This will get recent trades
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-publictradingrecords"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="limit">Number of results. Default 500; max 1000. (optional)</param>
        /// <returns>Task of ApiResponse (LinearMarketTradingBase)</returns>
        Task<ApiResponse<LinearMarketTradingBase>> LinearMarketTradingAsyncWithHttpInfo(LinearSymbol symbol, int? limit = null);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class LinearMarketApi : ApiBase, ILinearMarketApi
    {
        private const int LinearMarketTradingLimitMaxValue = 1000;

        public LinearMarketApi(string basePath) : base(basePath)
        {
        }

        public LinearMarketApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public LinearMarketTradingBase LinearMarketTrading(LinearSymbol symbol, int? limit = null)
            => LinearMarketTradingWithHttpInfo(symbol, limit).Data;

        public ApiResponse<LinearMarketTradingBase> LinearMarketTradingWithHttpInfo(LinearSymbol symbol, int? limit = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearMarketTradingLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearMarketApi->LinearMarketTrading");
            }

            var localVarPath = "/public/linear/recent-trading-records";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

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

            return CallApiWithHttpInfo<LinearMarketTradingBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearMarketTradingBase> LinearMarketTradingAsync(LinearSymbol symbol, int? limit = null)
            => (await LinearMarketTradingAsyncWithHttpInfo(symbol, limit)).Data;

        public Task<ApiResponse<LinearMarketTradingBase>> LinearMarketTradingAsyncWithHttpInfo(LinearSymbol symbol, int? limit = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearMarketTradingLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearMarketApi->LinearMarketTrading");
            }

            var localVarPath = "/public/linear/recent-trading-records";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

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

            return CallApiAsyncWithHttpInfo<LinearMarketTradingBase>(localVarPath, Method.GET, localVarQueryParams);
        }
    }
}