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
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
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
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
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
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
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
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>ApiResponse of LinearKlineMarkPriceBase</returns>
        ApiResponse<LinearKlineMarkPriceBase> LinearKlineMarkPriceWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Query index price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-indexpricekline"/>
        /// </remarks>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval. Enum : 1 3 5 15 30 60 120 240 360 720 "D" "M" "W" "Y"</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default as showing 200 pieces of data</param>
        /// <returns><see cref="LinearKlineIndexPriceBase"/></returns>
        LinearKlineIndexPriceBase LinearKlineIndexPrice(LinearSymbol symbol, string interval, long from, int? limit);

        /// <summary>
        /// Query index price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-indexpricekline"/>
        /// </remarks>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval. Enum : 1 3 5 15 30 60 120 240 360 720 "D" "M" "W" "Y"</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default as showing 200 pieces of data</param>
        /// <returns>ApiResponse of LinearKlineIndexPriceBase</returns>
        ApiResponse<LinearKlineIndexPriceBase> LinearKlineIndexPriceWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit);

        /// <summary>
        /// Query premium index kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-premiumindiceskline"/>
        /// </remarks>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval. Enum : 1 3 5 15 30 60 120 240 360 720 "D" "M" "W" "Y"</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default as showing 200 pieces of data</param>
        /// <returns><see cref="LinearKlinePremiumIndexPriceBase"/></returns>
        LinearKlinePremiumIndexPriceBase LinearKlinePremiumIndexPrice(LinearSymbol symbol, string interval, long from, int? limit);

        /// <summary>
        /// Query premium index kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-premiumindiceskline"/>
        /// </remarks>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval. Enum : 1 3 5 15 30 60 120 240 360 720 "D" "M" "W" "Y"</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default as showing 200 pieces of data</param>
        /// <returns>ApiResponse of LinearKlinePremiumIndexPriceBase</returns>
        ApiResponse<LinearKlinePremiumIndexPriceBase> LinearKlinePremiumIndexPriceWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit);

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
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
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
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
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
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
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
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>Task of ApiResponse (LinearKlineMarkPriceBase)</returns>
        Task<ApiResponse<LinearKlineMarkPriceBase>> LinearKlineMarkPriceAsyncWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Query index price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-indexpricekline"/>
        /// </remarks>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval. Enum : 1 3 5 15 30 60 120 240 360 720 "D" "M" "W" "Y"</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default as showing 200 pieces of data</param>
        /// <returns>Task of LinearKlineIndexPriceBase"</returns>
        Task<LinearKlineIndexPriceBase> LinearKlineIndexPriceAsync(LinearSymbol symbol, string interval, long from, int? limit);

        /// <summary>
        /// Query index price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-indexpricekline"/>
        /// </remarks>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval. Enum : 1 3 5 15 30 60 120 240 360 720 "D" "M" "W" "Y"</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default as showing 200 pieces of data</param>
        /// <returns>Task of ApiResponse (LinearKlineIndexPriceBase)</returns>
        Task<ApiResponse<LinearKlineIndexPriceBase>> LinearKlineIndexPriceAsyncWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit);

        /// <summary>
        /// Query premium index kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-premiumindiceskline"/>
        /// </remarks>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval. Enum : 1 3 5 15 30 60 120 240 360 720 "D" "M" "W" "Y"</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default as showing 200 pieces of data</param>
        /// <returns>Task of LinearKlinePremiumIndexPriceBase</returns>
        Task<LinearKlinePremiumIndexPriceBase> LinearKlinePremiumIndexPriceAsync(LinearSymbol symbol, string interval, long from, int? limit);

        /// <summary>
        /// Query premium index kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-premiumindiceskline"/>
        /// </remarks>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval. Enum : 1 3 5 15 30 60 120 240 360 720 "D" "M" "W" "Y"</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default as showing 200 pieces of data</param>
        /// <returns>Task of ApiResponse (LinearKlinePremiumIndexPriceBase)</returns>
        Task<ApiResponse<LinearKlinePremiumIndexPriceBase>> LinearKlinePremiumIndexPriceAsyncWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class LinearKlineApi : ApiBase, ILinearKlineApi
    {
        private const int LinearKlineGetLimitMaxValue = 200;
        private const int LinearKlineMarkPriceLimitMaxValue = 200;
        private const int LinearKlineIndexPriceLimitMaxValue = 200;
        private const int LinearKlinePremiumIndexPriceLimitMaxValue = 200;

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

        public LinearKlineIndexPriceBase LinearKlineIndexPrice(LinearSymbol symbol, string interval, long from, int? limit)
            => LinearKlineIndexPriceWithHttpInfo(symbol, interval, from, limit).Data;

        public ApiResponse<LinearKlineIndexPriceBase> LinearKlineIndexPriceWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on parameter 'interval' occered when calling LinearKlineApi->LinearKlineIndexPrice");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearKlineIndexPriceLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearKlineApi->LinearKlineIndexPrice");
            }

            var localVarPath = "/public/linear/index-price-kline";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiWithHttpInfo<LinearKlineIndexPriceBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearKlineIndexPriceBase> LinearKlineIndexPriceAsync(LinearSymbol symbol, string interval, long from, int? limit)
            => (await LinearKlineIndexPriceAsyncWithHttpInfo(symbol, interval, from, limit)).Data;

        public Task<ApiResponse<LinearKlineIndexPriceBase>> LinearKlineIndexPriceAsyncWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on parameter 'interval' occered when calling LinearKlineApi->LinearKlineIndexPrice");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearKlineIndexPriceLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearKlineApi->LinearKlineIndexPrice");
            }

            var localVarPath = "/public/linear/index-price-kline";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiAsyncWithHttpInfo<LinearKlineIndexPriceBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public LinearKlinePremiumIndexPriceBase LinearKlinePremiumIndexPrice(LinearSymbol symbol, string interval, long from, int? limit)
            => LinearKlinePremiumIndexPriceWithHttpInfo(symbol, interval, from, limit).Data;

        public ApiResponse<LinearKlinePremiumIndexPriceBase> LinearKlinePremiumIndexPriceWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on parameter 'interval' occered when calling LinearKlineApi->LinearKlinePremiumIndexPrice");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearKlinePremiumIndexPriceLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearKlineApi->LinearKlinePremiumIndexPrice");
            }

            var localVarPath = "/public/linear/premium-index-kline";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiWithHttpInfo<LinearKlinePremiumIndexPriceBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearKlinePremiumIndexPriceBase> LinearKlinePremiumIndexPriceAsync(LinearSymbol symbol, string interval, long from, int? limit)
            => (await LinearKlinePremiumIndexPriceAsyncWithHttpInfo(symbol, interval, from, limit)).Data;

        public Task<ApiResponse<LinearKlinePremiumIndexPriceBase>> LinearKlinePremiumIndexPriceAsyncWithHttpInfo(LinearSymbol symbol, string interval, long from, int? limit)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on parameter 'interval' occered when calling LinearKlineApi->LinearKlinePremiumIndexPrice");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearKlinePremiumIndexPriceLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearKlineApi->LinearKlinePremiumIndexPrice");
            }

            var localVarPath = "/public/linear/premium-index-kline";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiAsyncWithHttpInfo<LinearKlinePremiumIndexPriceBase>(localVarPath, Method.GET, localVarQueryParams);
        }
    }
}