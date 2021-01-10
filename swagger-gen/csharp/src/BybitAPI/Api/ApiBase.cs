using BybitAPI.Api.Exceptions;
using BybitAPI.Api.Util;
using BybitAPI.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BybitAPI.Api
{
    public class ApiBase
    {
        private static readonly JsonSerializerOptions SerializerOptions = CreateSerializerOptions();

        private static JsonSerializerOptions CreateSerializerOptions()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = new SnakeCaseNamingPolicy(),
                NumberHandling = JsonNumberHandling.AllowReadingFromString,
            };
            foreach (var converter in ApiUtil.GetJsonConverters())
            {
                options.Converters.Add(converter);
            }
            return options;
        }

        public ApiBase(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        public ApiBase(Configuration? configuration = null)
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

        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        [MaybeNull]
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
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value) => Configuration.AddDefaultHeader(key, value);

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<string, string> DefaultHeader() => new ReadOnlyDictionary<string, string>(Configuration.DefaultHeader);

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            if (Configuration.ApiClient.RestClient.BaseUrl is null)
            {
                throw new NullReferenceException();
            }
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

        protected ApiResponse<T> CallApiWithHttpInfo<T>(string localVarPath, Method method, List<KeyValuePair<string, string>>? localVarQueryParams = default, [CallerMemberName] string callerName = default)
        {
            var localVarPathParams = new Dictionary<string, string>();
            var localVarFormParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object? localVarPostBody = null;

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

            if (localVarQueryParams is null)
            {
                localVarQueryParams = new List<KeyValuePair<string, string>>();
            }

            if (localVarQueryParams.Count > 0)
            {
                var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
                var secret = Configuration.GetApiKeyWithPrefix("api_secret");
                var sign = ApiUtil.CreateSignature(secret, param);
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                method, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory(callerName, localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            System.Diagnostics.Trace.TraceInformation($"CallApiWithHttpInfo called from ${callerName}, deserializing json value is:\n{localVarResponse.Content}");

            return new ApiResponse<T>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(
                    x => x.Name ?? throw new NullReferenceException("x.Name"),
                    x => x.Value is not null ? x.Value.ToString() : throw new NullReferenceException("x.Value")),
                JsonSerializer.Deserialize<T>(localVarResponse.Content, SerializerOptions) ?? throw new ResponseContentNullException());
        }

        protected async Task<ApiResponse<T>> CallApiAsyncWithHttpInfo<T>(string localVarPath, Method method, List<KeyValuePair<string, string>>? localVarQueryParams = default, [CallerMemberName] string callerName = default)
        {
            var localVarPathParams = new Dictionary<string, string>();
            var localVarFormParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object? localVarPostBody = null;

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

            if (localVarQueryParams is null)
            {
                localVarQueryParams = new List<KeyValuePair<string, string>>();
            }

            if (localVarQueryParams.Count > 0)
            {
                var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
                var secret = Configuration.GetApiKeyWithPrefix("api_secret");
                var sign = ApiUtil.CreateSignature(secret, param);
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                method, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            if (localVarResponse is null)
            {
                throw new ResponseNullException();
            }

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory(callerName, localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            System.Diagnostics.Trace.TraceInformation($"CallApiAsyncWithHttpInfo called from ${callerName}, deserializing json value is:\n{localVarResponse.Content}");

            return new ApiResponse<T>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(
                    x => x.Name ?? throw new NullReferenceException("x.Name"),
                    x => x.Value is not null ? x.Value.ToString() : throw new NullReferenceException("x.Value")),
                JsonSerializer.Deserialize<T>(localVarResponse.Content, SerializerOptions) ?? throw new ResponseContentNullException());
        }
    }
}