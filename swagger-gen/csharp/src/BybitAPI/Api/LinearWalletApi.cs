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
    public interface ILinearWalletApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// This will get risk limit.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns><see cref="LinearWalletGetRiskLimitBase"/></returns>
        LinearWalletGetRiskLimitBase LinearWalletGetRiskLimit(LinearSymbol symbol);

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// This will get risk limit.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>ApiResponse of LinearWalletGetRiskLimitBase</returns>
        ApiResponse<LinearWalletGetRiskLimitBase> LinearWalletGetRiskLimitWithHttpInfo(LinearSymbol symbol);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// This will get risk limit.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of LinearWalletGetRiskLimitBase</returns>
        Task<LinearWalletGetRiskLimitBase> LinearWalletGetRiskLimitAsync(LinearSymbol symbol);

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// This will get risk limit.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getrisklimit"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of ApiResponse (LinearWalletGetRiskLimitBase)</returns>
        Task<ApiResponse<LinearWalletGetRiskLimitBase>> LinearWalletGetRiskLimitAsyncWithHttpInfo(LinearSymbol symbol);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class LinearWalletApi : ApiBase, ILinearWalletApi
    {
        public LinearWalletApi(string basePath) : base(basePath)
        {
        }

        public LinearWalletApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public LinearWalletGetRiskLimitBase LinearWalletGetRiskLimit(LinearSymbol symbol)
            => LinearWalletGetRiskLimitWithHttpInfo(symbol).Data;

        public ApiResponse<LinearWalletGetRiskLimitBase> LinearWalletGetRiskLimitWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/public/linear/risk-limit";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearWalletGetRiskLimitBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearWalletGetRiskLimitBase> LinearWalletGetRiskLimitAsync(LinearSymbol symbol)
            => (await LinearWalletGetRiskLimitAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<LinearWalletGetRiskLimitBase>> LinearWalletGetRiskLimitAsyncWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/public/linear/risk-limit";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearWalletGetRiskLimitBase>(localVarPath, Method.GET, localVarQueryParams);
        }
    }
}