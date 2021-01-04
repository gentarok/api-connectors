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
using System.Threading.Tasks;

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
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Object</returns>
        object LinearExecutionGetTrades(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null);

        /// <summary>
        /// Get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<object> LinearExecutionGetTradesWithHttpInfo(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of Object</returns>
        Task<object> LinearExecutionGetTradesAsync(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null);

        /// <summary>
        /// Get user&#39;s trading records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s trading records.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<object>> LinearExecutionGetTradesAsyncWithHttpInfo(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LinearExecutionApi : ILinearExecutionApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearExecutionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LinearExecutionApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearExecutionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LinearExecutionApi(Configuration configuration = null)
        {
            if (configuration is null) // use the default one in Configuration
            {
                Configuration = Configuration.Default;
            }
            else
            {
                Configuration = configuration;
            }

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory is not null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set => _exceptionFactory = value;
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<string, string> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(Configuration.DefaultHeader);
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
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Object</returns>
        public object LinearExecutionGetTrades(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null)
        {
            var localVarResponse = LinearExecutionGetTradesWithHttpInfo(symbol, startTime, endTime, execType, page, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<object> LinearExecutionGetTradesWithHttpInfo(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null)
        {
            var localVarPath = "/private/linear/trade/execution/list";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/json",
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol)); // query parameter
            }

            if (startTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            }

            if (endTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
            }

            if (execType is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exec_type", execType)); // query parameter
            }

            if (page is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (apiSignature) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("sign")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", Configuration.GetApiKeyWithPrefix("sign")));
            }
            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearExecutionGetTrades", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        /// <summary>
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async Task<object> LinearExecutionGetTradesAsync(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null)
        {
            var localVarResponse = await LinearExecutionGetTradesAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user&#39;s trading records. This will get user&#39;s trading records.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="execType"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async Task<ApiResponse<object>> LinearExecutionGetTradesAsyncWithHttpInfo(string symbol = null, long? startTime = null, long? endTime = null, string execType = null, long? page = null, long? limit = null)
        {
            var localVarPath = "/private/linear/trade/execution/list";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new string[] {
                "application/json",
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept is not null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol)); // query parameter
            }

            if (startTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            }

            if (endTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
            }

            if (execType is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exec_type", execType)); // query parameter
            }

            if (page is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (apiSignature) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("sign")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", Configuration.GetApiKeyWithPrefix("sign")));
            }
            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearExecutionGetTrades", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }
    }
}