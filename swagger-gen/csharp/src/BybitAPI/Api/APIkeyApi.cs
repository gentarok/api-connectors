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
    public interface IAPIkeyApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-key"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns><see cref="APIKeyInfoBase"/></returns>
        APIKeyInfoBase APIkeyInfo();

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-key"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of APIKeyInfoBase</returns>
        ApiResponse<APIKeyInfoBase> APIkeyInfoWithHttpInfo();

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-key"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of APIKeyInfoBase</returns>
        Task<APIKeyInfoBase> APIkeyInfoAsync();

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-key"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (APIKeyInfoBase)</returns>
        Task<ApiResponse<APIKeyInfoBase>> APIkeyInfoAsyncWithHttpInfo();

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class APIkeyApi : ApiBase, IAPIkeyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIkeyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public APIkeyApi(string basePath) : base(basePath) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIkeyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public APIkeyApi(Configuration? configuration = null) : base(configuration) { }

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-key"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        public APIKeyInfoBase APIkeyInfo() => APIkeyInfoWithHttpInfo().Data;

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-key"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<APIKeyInfoBase> APIkeyInfoWithHttpInfo()
        {
            var localVarPath = "/open-api/api-key";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<APIKeyInfoBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-key"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Object</returns>
        public async Task<APIKeyInfoBase> APIkeyInfoAsync() => (await APIkeyInfoAsyncWithHttpInfo()).Data;

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-key"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Object)</returns>
        public Task<ApiResponse<APIKeyInfoBase>> APIkeyInfoAsyncWithHttpInfo()
        {
            var localVarPath = "/open-api/api-key";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<APIKeyInfoBase>(localVarPath, Method.GET, localVarQueryParams);
        }
    }
}