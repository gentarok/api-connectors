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
        /// <param name="symbol">Contract type.</param>
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
        /// <param name="symbol">Contract type.</param>
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
        /// <param name="symbol">Contract type.</param>
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
        /// <param name="symbol">Contract type.</param>
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
        /// <param name="symbol">Contract type.</param>
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
        /// <param name="symbol">Contract type.</param>
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
        /// <param name="symbol">Contract type.</param>
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
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Data refresh interval</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>Task of ApiResponse (KlineMarkPriceBase)</returns>
        Task<ApiResponse<KlineMarkPriceBase>> KlineMarkPriceAsyncWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class KlineApi : ApiBase, IKlineApi
    {
        private const int KlineGetLimitMaxValue = 200;
        private const int KlineMarkPriceLimitMaxValue = 200;
        private static readonly string[] Intervals = new[] { "1", "3", "5", "15", "30", "60", "120", "240", "360", "720", "D", "M", "W", };

        /// <summary>
        /// Initializes a new instance of the <see cref="KlineApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KlineApi(string basePath) : base(basePath) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="KlineApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public KlineApi(Configuration? configuration = null) : base(configuration) { }

        /// <summary>
        /// Query historical kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns><see cref="KlineGetBase"/></returns>
        public KlineGetBase KlineGet(Symbol symbol, string interval, long from, int? limit = null)
            => KlineGetWithHttpInfo(symbol, interval, from, limit).Data;

        /// <summary>
        /// Query historical kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>ApiResponse of KlineGetBase</returns>
        public ApiResponse<KlineGetBase> KlineGetWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || Intervals.Contains(interval) is false)
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

        /// <summary>
        /// Query historical kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>Task of KlineGetBase</returns>
        public async Task<KlineGetBase> KlineGetAsync(Symbol symbol, string interval, long from, int? limit = null)
            => (await KlineGetAsyncWithHttpInfo(symbol, interval, from, limit)).Data;

        /// <summary>
        /// Query historical kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querykline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Kline interval.</param>
        /// <param name="from">from timestamp.</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>Task of ApiResponse (KlineGetBase)</returns>
        public Task<ApiResponse<KlineGetBase>> KlineGetAsyncWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || Intervals.Contains(interval) is false)
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

        /// <summary>
        /// Query mark price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Data refresh interval</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns><see cref="KlineMarkPriceBase"/></returns>
        public KlineMarkPriceBase KlineMarkPrice(Symbol symbol, string interval, long from, int? limit = null)
            => KlineMarkPriceWithHttpInfo(symbol, interval, from, limit).Data;

        /// <summary>
        /// Query mark price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Data refresh interval</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>ApiResponse of KlineMarkPriceBase</returns>
        public ApiResponse<KlineMarkPriceBase> KlineMarkPriceWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || Intervals.Contains(interval) is false)
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

        /// <summary>
        /// Query mark price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Data refresh interval</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>Task of KlineMarkPriceBase</returns>
        public async Task<KlineMarkPriceBase> KlineMarkPriceAsync(Symbol symbol, string interval, long from, int? limit = null)
            => (await KlineMarkPriceAsyncWithHttpInfo(symbol, interval, from, limit)).Data;

        /// <summary>
        /// Query mark price kline.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-markpricekline"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="interval">Data refresh interval</param>
        /// <param name="from">From timestamp in seconds</param>
        /// <param name="limit">Limit for data size, max size is 200. Default size is 200 (optional)</param>
        /// <returns>Task of ApiResponse (KlineMarkPriceBase)</returns>
        public Task<ApiResponse<KlineMarkPriceBase>> KlineMarkPriceAsyncWithHttpInfo(Symbol symbol, string interval, long from, int? limit = null)
        {
            // verify the required parameter 'interval'
            //Note: 'interval' parameter is defined as an enum in the documentation and is used in both the parameter and the response,
            // but it cannot be serialized/deserialized to the Enum type in .NET because some name of the value starts with a number.
            // Therefore, it needs to be defined as a string type and validated when used as a parameter.
            if (interval is null || Intervals.Contains(interval) is false)
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