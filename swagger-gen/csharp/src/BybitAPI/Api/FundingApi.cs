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

    /// <inheritdoc/>
    public partial class FundingApi : ApiBase, IFundingApi
    {
        public FundingApi(string basePath) : base(basePath)
        {
        }

        public FundingApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public FundingMyLastFeeBase FundingMyLastFee(Symbol symbol)
            => FundingMyLastFeeWithHttpInfo(symbol).Data;

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

        public async Task<FundingMyLastFeeBase> FundingMyLastFeeAsync(Symbol symbol)
            => (await FundingMyLastFeeAsyncWithHttpInfo(symbol)).Data;

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

        public FundingPredictedBase FundingPredicted(Symbol symbol)
            => FundingPredictedWithHttpInfo(symbol).Data;

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

        public async Task<FundingPredictedBase> FundingPredictedAsync(Symbol symbol)
            => (await FundingPredictedAsyncWithHttpInfo(symbol)).Data;

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

        public FundingPrevRateBase FundingPrevRate(Symbol symbol)
             => FundingPrevRateWithHttpInfo(symbol).Data;

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

        public async Task<FundingPrevRateBase> FundingPrevRateAsync(Symbol symbol)
            => (await FundingPrevRateAsyncWithHttpInfo(symbol)).Data;

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