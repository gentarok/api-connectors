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
    public interface ILinearFundingApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get prev funding
        /// </summary>
        /// <remarks>
        /// This will get prev funding
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns><see cref="LinearFundingMyLastFeeBase"/></returns>
        LinearFundingMyLastFeeBase LinearFundingMyLastFee(LinearSymbol symbol);

        /// <summary>
        /// Get prev funding
        /// </summary>
        /// <remarks>
        /// This will get prev funding
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>ApiResponse of LinearFundingMyLastFeeBase</returns>
        ApiResponse<LinearFundingMyLastFeeBase> LinearFundingMyLastFeeWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns><see cref="LinearFundingPredictedBase"/></returns>
        LinearFundingPredictedBase LinearFundingPredicted(LinearSymbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>ApiResponse of LinearFundingPredictedBase</returns>
        ApiResponse<LinearFundingPredictedBase> LinearFundingPredictedWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Get prev funding
        /// </summary>
        /// <remarks>
        /// This will get prev funding rate
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns><see cref="LinearFundingPrevRateBase"/></returns>
        LinearFundingPrevRateBase LinearFundingPrevRate(LinearSymbol symbol);

        /// <summary>
        /// Get prev funding
        /// </summary>
        /// <remarks>
        /// This will get prev funding rate
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>ApiResponse of LinearFundingPrevRateBase</returns>
        ApiResponse<LinearFundingPrevRateBase> LinearFundingPrevRateWithHttpInfo(LinearSymbol symbol);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get prev funding
        /// </summary>
        /// <remarks>
        /// This will get prev funding
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of LinearFundingMyLastFeeBase</returns>
        Task<LinearFundingMyLastFeeBase> LinearFundingMyLastFeeAsync(LinearSymbol symbol);

        /// <summary>
        /// Get prev funding
        /// </summary>
        /// <remarks>
        /// This will get prev funding
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-mylastfundingfee"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of ApiResponse (LinearFundingMyLastFeeBase)</returns>
        Task<ApiResponse<LinearFundingMyLastFeeBase>> LinearFundingMyLastFeeAsyncWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of LinearFundingPredictedBase</returns>
        Task<LinearFundingPredictedBase> LinearFundingPredictedAsync(LinearSymbol symbol);

        /// <summary>
        /// Get predicted funding rate and funding fee.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-predictedfunding"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of ApiResponse (LinearFundingPredictedBase)</returns>
        Task<ApiResponse<LinearFundingPredictedBase>> LinearFundingPredictedAsyncWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Get prev funding
        /// </summary>
        /// <remarks>
        /// This will get prev funding rate
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of LinearFundingPrevRateBase</returns>
        Task<LinearFundingPrevRateBase> LinearFundingPrevRateAsync(LinearSymbol symbol);

        /// <summary>
        /// Get prev funding
        /// </summary>
        /// <remarks>
        /// This will get prev funding rate
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-fundingrate"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of ApiResponse (LinearFundingPrevRateBase)</returns>
        Task<ApiResponse<LinearFundingPrevRateBase>> LinearFundingPrevRateAsyncWithHttpInfo(LinearSymbol symbol);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class LinearFundingApi : ApiBase, ILinearFundingApi
    {
        public LinearFundingApi(string basePath) : base(basePath)
        {
        }

        public LinearFundingApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public LinearFundingMyLastFeeBase LinearFundingMyLastFee(LinearSymbol symbol)
            => LinearFundingMyLastFeeWithHttpInfo(symbol).Data;

        public ApiResponse<LinearFundingMyLastFeeBase> LinearFundingMyLastFeeWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/funding/prev-funding";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearFundingMyLastFeeBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearFundingMyLastFeeBase> LinearFundingMyLastFeeAsync(LinearSymbol symbol)
            => (await LinearFundingMyLastFeeAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<LinearFundingMyLastFeeBase>> LinearFundingMyLastFeeAsyncWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/funding/prev-funding";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearFundingMyLastFeeBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public LinearFundingPredictedBase LinearFundingPredicted(LinearSymbol symbol)
            => LinearFundingPredictedWithHttpInfo(symbol).Data;

        public ApiResponse<LinearFundingPredictedBase> LinearFundingPredictedWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/funding/predicted-funding";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearFundingPredictedBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearFundingPredictedBase> LinearFundingPredictedAsync(LinearSymbol symbol)
            => (await LinearFundingPredictedAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<LinearFundingPredictedBase>> LinearFundingPredictedAsyncWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/funding/predicted-funding";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearFundingPredictedBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public LinearFundingPrevRateBase LinearFundingPrevRate(LinearSymbol symbol)
            => LinearFundingPrevRateWithHttpInfo(symbol).Data;

        public ApiResponse<LinearFundingPrevRateBase> LinearFundingPrevRateWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/public/linear/funding/prev-funding-rate";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearFundingPrevRateBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearFundingPrevRateBase> LinearFundingPrevRateAsync(LinearSymbol symbol)
            => (await LinearFundingPrevRateAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<LinearFundingPrevRateBase>> LinearFundingPrevRateAsyncWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/public/linear/funding/prev-funding-rate";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearFundingPrevRateBase>(localVarPath, Method.GET, localVarQueryParams);
        }
    }
}