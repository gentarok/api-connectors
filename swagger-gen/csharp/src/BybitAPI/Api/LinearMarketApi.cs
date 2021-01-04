/*
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api.bybit.com]
 *
 * OpenAPI spec version: 0.2.10
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using BybitAPI.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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
        /// </remarks>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>Object</returns>
        Object LinearMarketTrading(string symbol, string limit = null);

        /// <summary>
        /// Get recent trades
        /// </summary>
        /// <remarks>
        /// This will get recent trades
        /// </remarks>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> LinearMarketTradingWithHttpInfo(string symbol, string limit = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get recent trades
        /// </summary>
        /// <remarks>
        /// This will get recent trades
        /// </remarks>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> LinearMarketTradingAsync(string symbol, string limit = null);

        /// <summary>
        /// Get recent trades
        /// </summary>
        /// <remarks>
        /// This will get recent trades
        /// </remarks>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LinearMarketTradingAsyncWithHttpInfo(string symbol, string limit = null);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LinearMarketApi : ILinearMarketApi
    {
        private BybitAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearMarketApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LinearMarketApi(String basePath)
        {
            this.Configuration = new BybitAPI.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BybitAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearMarketApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LinearMarketApi(BybitAPI.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = BybitAPI.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = BybitAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public BybitAPI.Client.Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public BybitAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get recent trades This will get recent trades
        /// </summary>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>Object</returns>
        public Object LinearMarketTrading(string symbol, string limit = null)
        {
            ApiResponse<Object> localVarResponse = LinearMarketTradingWithHttpInfo(symbol, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent trades This will get recent trades
        /// </summary>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> LinearMarketTradingWithHttpInfo(string symbol, string limit = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling LinearMarketApi->LinearMarketTrading");

            var localVarPath = "/public/linear/recent-trading-records";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (symbol != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (apiSignature) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("sign")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", this.Configuration.GetApiKeyWithPrefix("sign")));
            }
            // authentication (timestamp) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", this.Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LinearMarketTrading", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Get recent trades This will get recent trades
        /// </summary>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> LinearMarketTradingAsync(string symbol, string limit = null)
        {
            ApiResponse<Object> localVarResponse = await LinearMarketTradingAsyncWithHttpInfo(symbol, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get recent trades This will get recent trades
        /// </summary>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="limit">Contract type. (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LinearMarketTradingAsyncWithHttpInfo(string symbol, string limit = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling LinearMarketApi->LinearMarketTrading");

            var localVarPath = "/public/linear/recent-trading-records";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json",
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (symbol != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (apiSignature) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("sign")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", this.Configuration.GetApiKeyWithPrefix("sign")));
            }
            // authentication (timestamp) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", this.Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LinearMarketTrading", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }
    }
}