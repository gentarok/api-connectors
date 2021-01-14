using BybitAPI.Api.Util;
using BybitAPI.Client;
using BybitAPI.Model;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BybitAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IKlineApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Query historical kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns><see cref="KlineGetBase"/></returns>
        KlineGetBase KlineGet(Symbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Query historical kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>ApiResponse of KlineGetBase</returns>
        ApiResponse<KlineGetBase> KlineGetWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Query mark price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns><see cref="KlineMarkPriceBase"/></returns>
        KlineMarkPriceBase KlineMarkPrice(Symbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Query mark price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>ApiResponse of KlineMarkPriceBase</returns>
        ApiResponse<KlineMarkPriceBase> KlineMarkPriceWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Query historical kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>Task of KlineGetBase</returns>
        Task<KlineGetBase> KlineGetAsync(Symbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Query historical kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>Task of ApiResponse (KlineGetBase)</returns>
        Task<ApiResponse<KlineGetBase>> KlineGetAsyncWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Query mark price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>Task of KlineMarkPriceBase</returns>
        Task<KlineMarkPriceBase> KlineMarkPriceAsync(Symbol symbol, string interval, long from, int? limit = null);

        /// <summary>
        /// Query mark price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="interval">Data refresh interval</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>Task of ApiResponse (KlineMarkPriceBase)</returns>
        Task<ApiResponse<KlineMarkPriceBase>> KlineMarkPriceAsyncWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class KlineApi : ApiBase, IKlineApi
    {
        private const int KlineGetLimitMaxValue = 200;
        private const int KlineMarkPriceLimitMaxValue = 200;

        public KlineApi(string basePath) : base(basePath)
        {
        }

        public KlineApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public KlineGetBase KlineGet(Symbol symbol, string interval, long from, int? limit = null)
            => KlineGetWithHttpInfo(symbol, interval, from, limit).Data;

        public ApiResponse<KlineGetBase> KlineGetWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on parameter 'interval' occered when calling KlineApi->KlineGet");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > KlineGetLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling KlineApi->KlineGet");
            }

            var localVarPath = "/v2/public/kline/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiWithHttpInfo<KlineGetBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<KlineGetBase> KlineGetAsync(Symbol symbol, string interval, long from, int? limit = null)
            => (await KlineGetAsyncWithHttpInfo(symbol, interval, from, limit)).Data;

        public Task<ApiResponse<KlineGetBase>> KlineGetAsyncWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on parameter 'interval' occered when calling KlineApi->KlineGet");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > KlineGetLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling KlineApi->KlineGet");
            }

            var localVarPath = "/v2/public/kline/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiAsyncWithHttpInfo<KlineGetBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public KlineMarkPriceBase KlineMarkPrice(Symbol symbol, string interval, long from, int? limit = null)
            => KlineMarkPriceWithHttpInfo(symbol, interval, from, limit).Data;

        public ApiResponse<KlineMarkPriceBase> KlineMarkPriceWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on parameter 'interval' occered when calling KlineApi->KlineMarkPrice");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > KlineMarkPriceLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling KlineApi->KlineMarkPrice");
            }

            var localVarPath = "/v2/public/mark-price-kline";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiWithHttpInfo<KlineMarkPriceBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<KlineMarkPriceBase> KlineMarkPriceAsync(Symbol symbol, string interval, long from, int? limit = null)
            => (await KlineMarkPriceAsyncWithHttpInfo(symbol, interval, from, limit)).Data;

        public Task<ApiResponse<KlineMarkPriceBase>> KlineMarkPriceAsyncWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || ApiUtil.Intervals.Contains(interval) is false)
            {
                throw new ApiException(400, "Validation error on parameter 'interval' occered when calling KlineApi->KlineMarkPrice");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > KlineMarkPriceLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling KlineApi->KlineMarkPrice");
            }

            var localVarPath = "/v2/public/mark-price-kline";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval", interval));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "from", from));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            return CallApiAsyncWithHttpInfo<KlineMarkPriceBase>(localVarPath, Method.GET, localVarQueryParams);
        }
    }
}