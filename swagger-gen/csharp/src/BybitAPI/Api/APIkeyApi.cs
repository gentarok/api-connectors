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
using BybitAPI.Model;
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
    public interface IAPIkeyApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns><see cref="APIKeyBase"/></returns>
        APIKeyBase APIkeyInfo();

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of APIKeyBase</returns>
        ApiResponse<APIKeyBase> APIkeyInfoWithHttpInfo();

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of APIKeyBase</returns>
        Task<APIKeyBase> APIkeyInfoAsync();

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (APIKeyBase)</returns>
        Task<ApiResponse<APIKeyBase>> APIkeyInfoAsyncWithHttpInfo();

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class APIkeyApi : IAPIkeyApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="APIkeyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public APIkeyApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIkeyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public APIkeyApi(Configuration configuration = null)
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
        /// Get account api-key information.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        public APIKeyBase APIkeyInfo()
        {
            var localVarResponse = APIkeyInfoWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<APIKeyBase> APIkeyInfoWithHttpInfo()
        {
            var localVarPath = "/open-api/api-key";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new SortedDictionary<string, string>();
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

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (apiSignature) required
            //if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("sign")))
            //{
            //    localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", Configuration.GetApiKeyWithPrefix("sign")));
            //}
            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }
            localVarFormParams.Add("timestamp", Configuration.GetApiKeyWithPrefix("timestamp"));

            localVarFormParams.Add("api_key", Configuration.GetApiKeyWithPrefix("api_key"));
            var queryString = Util.ApiUtil.GetQueryString(localVarFormParams);
            var sign = Util.ApiUtil.CreateSignature(queryString);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                //Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, new Dictionary<string, string>(), localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("APIkeyInfo", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<APIKeyBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (APIKeyBase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(APIKeyBase)));
        }

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Object</returns>
        public async Task<APIKeyBase> APIkeyInfoAsync()
        {
            var localVarResponse = await APIkeyInfoAsyncWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account api-key information.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async Task<ApiResponse<APIKeyBase>> APIkeyInfoAsyncWithHttpInfo()
        {
            var localVarPath = "/open-api/api-key";
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
                var exception = ExceptionFactory("APIkeyInfo", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<APIKeyBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (APIKeyBase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(APIKeyBase)));
        }
    }
}