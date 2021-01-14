using BybitAPI.Client;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
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
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Object</returns>
        object LinearWalletGetRiskLimit();

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// This will get risk limit.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<object> LinearWalletGetRiskLimitWithHttpInfo();

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// This will get risk limit.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Object</returns>
        Task<object> LinearWalletGetRiskLimitAsync();

        /// <summary>
        /// Get risk limit.
        /// </summary>
        /// <remarks>
        /// This will get risk limit.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<object>> LinearWalletGetRiskLimitAsyncWithHttpInfo();

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

        public object LinearWalletGetRiskLimit()
        {
            var localVarResponse = LinearWalletGetRiskLimitWithHttpInfo();
            return localVarResponse.Data;
        }

        public ApiResponse<object> LinearWalletGetRiskLimitWithHttpInfo()
        {
            var localVarPath = "/public/linear/risk-limit";
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

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearWalletGetRiskLimit", localVarResponse);
                if (exception is not null)
                {
                    throw exception;
                }
            }

            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                Configuration.ApiClient.Deserialize(localVarResponse, typeof(object)));
        }

        public async Task<object> LinearWalletGetRiskLimitAsync()
        {
            var localVarResponse = await LinearWalletGetRiskLimitAsyncWithHttpInfo();
            return localVarResponse.Data;
        }

        public async Task<ApiResponse<object>> LinearWalletGetRiskLimitAsyncWithHttpInfo()
        {
            var localVarPath = "/public/linear/risk-limit";
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

            // authentication (timestamp) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("timestamp")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", Configuration.GetApiKeyWithPrefix("timestamp")));
            }

            var param = new SortedDictionary<string, string>(localVarQueryParams.ToDictionary(x => x.Key, x => x.Value));
            var secret = Configuration.GetApiKeyWithPrefix("api_secret");
            var sign = Util.ApiUtil.CreateSignature(secret, param);
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sign", sign));

            // make the HTTP request
            var localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory is not null)
            {
                var exception = ExceptionFactory("LinearWalletGetRiskLimit", localVarResponse);
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