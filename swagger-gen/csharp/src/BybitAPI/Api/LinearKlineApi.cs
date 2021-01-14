using BybitAPI.Api.Util;
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
    public interface ILinearKlineApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get kline
        /// </summary>
        /// <remarks>
        /// This will get kline
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns><see cref="LinearKlineGetBase"/></returns>
        LinearKlineGetBase LinearKlineGet(LinearSymbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Get kline
        /// </summary>
        /// <remarks>
        /// This will get kline
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>ApiResponse of LinearKlineGetBase</returns>
        ApiResponse<LinearKlineGetBase> LinearKlineGetWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Get kline
        /// </summary>
        /// <remarks>
        /// This will get mark price kline
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns><see cref="LinearKlineMarkPriceBase"/></returns>
        LinearKlineMarkPriceBase LinearKlineMarkPrice(LinearSymbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Get kline
        /// </summary>
        /// <remarks>
        /// This will get mark price kline
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>ApiResponse of LinearKlineMarkPriceBase</returns>
        ApiResponse<LinearKlineMarkPriceBase> LinearKlineMarkPriceWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get kline
        /// </summary>
        /// <remarks>
        /// This will get kline
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>Task of LinearKlineGetBase</returns>
        Task<LinearKlineGetBase> LinearKlineGetAsync(LinearSymbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Get kline
        /// </summary>
        /// <remarks>
        /// This will get kline
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>Task of ApiResponse (LinearKlineGetBase)</returns>
        Task<ApiResponse<LinearKlineGetBase>> LinearKlineGetAsyncWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Get kline
        /// </summary>
        /// <remarks>
        /// This will get mark price kline
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>Task of LinearKlineMarkPriceBase</returns>
        Task<LinearKlineMarkPriceBase> LinearKlineMarkPriceAsync(LinearSymbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Get kline
        /// </summary>
        /// <remarks>
        /// This will get mark price kline
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>Task of ApiResponse (LinearKlineMarkPriceBase)</returns>
        Task<ApiResponse<LinearKlineMarkPriceBase>> LinearKlineMarkPriceAsyncWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit = null);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class LinearKlineApi : ApiBase, ILinearKlineApi
    {
        private const int LinearKlineGetLimitMaxValue = 200;
        private const int LinearKlineMarkPriceLimitMaxValue = 200;

        public LinearKlineApi(string basePath) : base(basePath)
        {
        }

        public LinearKlineApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public LinearKlineGetBase LinearKlineGet(LinearSymbol symbol, string interval, long from, int? limit = null)
            => LinearKlineGetWithHttpInfo(symbol, interval, from, limit).Data;

        public ApiResponse<LinearKlineGetBase> LinearKlineGetWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit = null)
        {
            // verify the parameter 'interval'
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on 'interval' parameter occured when calling LinearKlineApi->LinearKlineGet");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearKlineGetLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearKlineApi->LinearKlineGet");
            }

            var localVarPath = "/public/linear/kline";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (interval is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
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

            return CallApiWithHttpInfo<LinearKlineGetBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearKlineGetBase> LinearKlineGetAsync(LinearSymbol symbol, string interval, long from, int? limit = null)
            => (await LinearKlineGetAsyncWithHttpInfo(symbol, interval, from, limit)).Data;

        public Task<ApiResponse<LinearKlineGetBase>> LinearKlineGetAsyncWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit = null)
        {
            // verify the parameter 'interval'
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on 'interval' parameter occured when calling LinearKlineApi->LinearKlineGet");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearKlineGetLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearKlineApi->LinearKlineGet");
            }

            var localVarPath = "/public/linear/kline";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (interval is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
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

            return CallApiAsyncWithHttpInfo<LinearKlineGetBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public LinearKlineMarkPriceBase LinearKlineMarkPrice(LinearSymbol symbol, string interval, long from, int? limit = null)
            => LinearKlineMarkPriceWithHttpInfo(symbol, interval, from, limit).Data;

        public ApiResponse<LinearKlineMarkPriceBase> LinearKlineMarkPriceWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit = null)
        {
            // verify the parameter 'interval'
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearKlineApi->LinearKlineMarkPrice");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearKlineMarkPriceLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearKlineApi->LinearKlineMarkPrice");
            }

            var localVarPath = "/public/linear/mark-price-kline";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (interval is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
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

            return CallApiWithHttpInfo<LinearKlineMarkPriceBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearKlineMarkPriceBase> LinearKlineMarkPriceAsync(LinearSymbol symbol, string interval, long from, int? limit = null)
            => (await LinearKlineMarkPriceAsyncWithHttpInfo(symbol, interval, from, limit)).Data;

        public Task<ApiResponse<LinearKlineMarkPriceBase>> LinearKlineMarkPriceAsyncWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit = null)
        {
            // verify the parameter 'interval'
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearKlineApi->LinearKlineMarkPrice");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearKlineMarkPriceLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearKlineApi->LinearKlineMarkPrice");
            }

            var localVarPath = "/public/linear/mark-price-kline";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (interval is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
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

            return CallApiAsyncWithHttpInfo<LinearKlineMarkPriceBase>(localVarPath, Method.GET, localVarQueryParams);
        }
    }
}