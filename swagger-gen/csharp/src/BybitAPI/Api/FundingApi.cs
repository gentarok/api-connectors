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
    public interface IFundingApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Funding settlement occurs every 8 hours at 00:00 UTC, 08:00 UTC and 16:00 UTC. The current interval&#39;s fund fee settlement is based on the previous interval&#39;s fund rate. For example, at 16:00, the settlement is based on the fund rate generated at 8:00. The fund rate generated at 16:00 will be used at 0:00 on the next day.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns><see cref="FundingMyLastFeeBase"/></returns>
        FundingMyLastFeeBase FundingMyLastFee(Symbol symbol);

        /// <summary>
        /// Funding settlement occurs every 8 hours at 00:00 UTC, 08:00 UTC and 16:00 UTC. The current interval&#39;s fund fee settlement is based on the previous interval&#39;s fund rate. For example, at 16:00, the settlement is based on the fund rate generated at 8:00. The fund rate generated at 16:00 will be used at 0:00 on the next day.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of FundingMyLastFeeBase</returns>
        ApiResponse<FundingMyLastFeeBase> FundingMyLastFeeWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns><see cref="FundingPredictedBase"/></returns>
        FundingPredictedBase FundingPredicted(Symbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of FundingPredictedBase</returns>
        ApiResponse<FundingPredictedBase> FundingPredictedWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns><see cref="FundingPrevRateBase"/></returns>
        FundingPrevRateBase FundingPrevRate(Symbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of FundingPrevRateBase</returns>
        ApiResponse<FundingPrevRateBase> FundingPrevRateWithHttpInfo(Symbol symbol);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Funding settlement occurs every 8 hours at 00:00 UTC, 08:00 UTC and 16:00 UTC. The current interval&#39;s fund fee settlement is based on the previous interval&#39;s fund rate. For example, at 16:00, the settlement is based on the fund rate generated at 8:00. The fund rate generated at 16:00 will be used at 0:00 on the next day.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of FundingMyLastFeeBase</returns>
        Task<FundingMyLastFeeBase> FundingMyLastFeeAsync(Symbol symbol);

        /// <summary>
        /// Funding settlement occurs every 8 hours at 00:00 UTC, 08:00 UTC and 16:00 UTC. The current interval&#39;s fund fee settlement is based on the previous interval&#39;s fund rate. For example, at 16:00, the settlement is based on the fund rate generated at 8:00. The fund rate generated at 16:00 will be used at 0:00 on the next day.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (FundingMyLastFeeBase)</returns>
        Task<ApiResponse<FundingMyLastFeeBase>> FundingMyLastFeeAsyncWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of FundingPredictedBase</returns>
        Task<FundingPredictedBase> FundingPredictedAsync(Symbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (FundingPredictedBase)</returns>
        Task<ApiResponse<FundingPredictedBase>> FundingPredictedAsyncWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of FundingPrevRateBase</returns>
        Task<FundingPrevRateBase> FundingPrevRateAsync(Symbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (FundingPrevRateBase)</returns>
        Task<ApiResponse<FundingPrevRateBase>> FundingPrevRateAsyncWithHttpInfo(Symbol symbol);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FundingApi : ApiBase, IFundingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FundingApi(string basePath) : base(basePath) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FundingApi(Configuration? configuration = null) : base(configuration) { }

        /// <summary>
        /// Funding settlement occurs every 8 hours at 00:00 UTC, 08:00 UTC and 16:00 UTC. The current interval&#39;s fund fee settlement is based on the previous interval&#39;s fund rate. For example, at 16:00, the settlement is based on the fund rate generated at 8:00. The fund rate generated at 16:00 will be used at 0:00 on the next day.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns><see cref="FundingMyLastFeeBase"/></returns>
        public FundingMyLastFeeBase FundingMyLastFee(Symbol symbol)
            => FundingMyLastFeeWithHttpInfo(symbol).Data;

        /// <summary>
        /// Funding settlement occurs every 8 hours at 00:00 UTC, 08:00 UTC and 16:00 UTC. The current interval&#39;s fund fee settlement is based on the previous interval&#39;s fund rate. For example, at 16:00, the settlement is based on the fund rate generated at 8:00. The fund rate generated at 16:00 will be used at 0:00 on the next day.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of FundingMyLastFeeBase</returns>
        public ApiResponse<FundingMyLastFeeBase> FundingMyLastFeeWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/open-api/funding/prev-funding";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<FundingMyLastFeeBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Funding settlement occurs every 8 hours at 00:00 UTC, 08:00 UTC and 16:00 UTC. The current interval&#39;s fund fee settlement is based on the previous interval&#39;s fund rate. For example, at 16:00, the settlement is based on the fund rate generated at 8:00. The fund rate generated at 16:00 will be used at 0:00 on the next day.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of FundingMyLastFeeBase</returns>
        public async Task<FundingMyLastFeeBase> FundingMyLastFeeAsync(Symbol symbol)
            => (await FundingMyLastFeeAsyncWithHttpInfo(symbol)).Data;

        /// <summary>
        /// Funding settlement occurs every 8 hours at 00:00 UTC, 08:00 UTC and 16:00 UTC. The current interval&#39;s fund fee settlement is based on the previous interval&#39;s fund rate. For example, at 16:00, the settlement is based on the fund rate generated at 8:00. The fund rate generated at 16:00 will be used at 0:00 on the next day.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (FundingMyLastFeeBase)</returns>
        public Task<ApiResponse<FundingMyLastFeeBase>> FundingMyLastFeeAsyncWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/open-api/funding/prev-funding";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<FundingMyLastFeeBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns><see cref="FundingPredictedBase"/></returns>
        public FundingPredictedBase FundingPredicted(Symbol symbol)
            => FundingPredictedWithHttpInfo(symbol).Data;

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of FundingPredictedBase</returns>
        public ApiResponse<FundingPredictedBase> FundingPredictedWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/open-api/funding/predicted-funding";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<FundingPredictedBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of FundingPredictedRes</returns>
        public async Task<FundingPredictedBase> FundingPredictedAsync(Symbol symbol)
            => (await FundingPredictedAsyncWithHttpInfo(symbol)).Data;

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (FundingPredictedBase)</returns>
        public Task<ApiResponse<FundingPredictedBase>> FundingPredictedAsyncWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/open-api/funding/predicted-funding";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<FundingPredictedBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns><see cref="FundingPrevRateBase"/></returns>
        public FundingPrevRateBase FundingPrevRate(Symbol symbol)
             => FundingPrevRateWithHttpInfo(symbol).Data;

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of FundingPrevRateBase</returns>
        public ApiResponse<FundingPrevRateBase> FundingPrevRateWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/open-api/funding/prev-funding-rate";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<FundingPrevRateBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of FundingPrevRateBase</returns>
        public async Task<FundingPrevRateBase> FundingPrevRateAsync(Symbol symbol)
            => (await FundingPrevRateAsyncWithHttpInfo(symbol)).Data;

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (FundingPrevRateBase)</returns>
        public Task<ApiResponse<FundingPrevRateBase>> FundingPrevRateAsyncWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/open-api/funding/prev-funding-rate";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<FundingPrevRateBase>(localVarPath, Method.GET, localVarQueryParams);
        }
    }
}