/*
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api.bybit.com]
 *
 * OpenAPI spec version: 0.2.10
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using BybitAPI.Client;

namespace BybitAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILinearExecutionApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// </remarks>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Object</returns>
        Object LinearExecutionGetTrades(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null);

        /// <summary>
        /// Get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// </remarks>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> LinearExecutionGetTradesWithHttpInfo(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// </remarks>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> LinearExecutionGetTradesAsync(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null);

        /// <summary>
        /// Get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// </remarks>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LinearExecutionGetTradesAsyncWithHttpInfo(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LinearExecutionApi : ILinearExecutionApi
    {
        private BybitAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearExecutionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LinearExecutionApi(String basePath)
        {
            this.Configuration = new BybitAPI.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BybitAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearExecutionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LinearExecutionApi(BybitAPI.Client.Configuration configuration = null)
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
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Object</returns>
        public Object LinearExecutionGetTrades(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null)
        {
            ApiResponse<Object> localVarResponse = LinearExecutionGetTradesWithHttpInfo(symbol, startTime, endTime, execType, page, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> LinearExecutionGetTradesWithHttpInfo(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null)
        {
            var localVarPath = "/private/linear/trade/execution/list";
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
            if (startTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
            if (execType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exec_type", execType)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
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
                Exception exception = ExceptionFactory("LinearExecutionGetTrades", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> LinearExecutionGetTradesAsync(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null)
        {
            ApiResponse<Object> localVarResponse = await LinearExecutionGetTradesAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <exception cref="BybitAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LinearExecutionGetTradesAsyncWithHttpInfo(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null)
        {
            var localVarPath = "/private/linear/trade/execution/list";
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
            if (startTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
            if (execType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exec_type", execType)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
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
                Exception exception = ExceptionFactory("LinearExecutionGetTrades", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }
    }
}