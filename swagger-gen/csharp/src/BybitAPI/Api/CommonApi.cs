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
    public interface ICommonApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get Bybit OpenAPI announcements in the last 30 days in reverse order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-announcement"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns><see cref="AnnouncementRes"/></returns>
        AnnouncementBase CommonAnnouncements();

        /// <summary>
        /// Get Bybit OpenAPI announcements in the last 30 days in reverse order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-announcement"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AnnouncementBase</returns>
        ApiResponse<AnnouncementBase> CommonAnnouncementsWithHttpInfo();

        /// <summary>
        /// Query LCP info.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-lcp"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <returns><see cref="LCPInfoBase"/></returns>
        LCPInfoBase CommonGetLcp(Symbol symbol);

        /// <summary>
        /// Query LCP info.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-lcp"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <returns>ApiResponse of LCPInfoBase</returns>
        ApiResponse<LCPInfoBase> CommonGetLcpWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get bybit server time.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-servertime"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns><see cref="ServerTime"/></returns>
        ServerTimeRes CommonGetTime();

        /// <summary>
        /// Get bybit server time.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-servertime"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ServerTimeRes</returns>
        ApiResponse<ServerTimeRes> CommonGetTimeWithHttpInfo();

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get Bybit OpenAPI announcements in the last 30 days in reverse order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-announcement"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AnnouncementBase</returns>
        Task<AnnouncementBase> CommonAnnouncementsAsync();

        /// <summary>
        /// Get Bybit OpenAPI announcements in the last 30 days in reverse order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-announcement"/>///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AnnouncementBase)</returns>
        Task<ApiResponse<AnnouncementBase>> CommonAnnouncementsAsyncWithHttpInfo();

        /// <summary>
        /// Query LCP info.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-lcp"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <returns>Task of LCPInfoBase</returns>
        Task<LCPInfoBase> CommonGetLcpAsync(Symbol symbol);

        /// <summary>
        /// Query LCP info.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-lcp"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <returns>Task of ApiResponse (LCPInfoBase)</returns>
        Task<ApiResponse<LCPInfoBase>> CommonGetLcpAsyncWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get bybit server time.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-servertime"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ServerTimeRes</returns>
        Task<ServerTimeRes> CommonGetTimeAsync();

        /// <summary>
        /// Get bybit server time.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-servertime"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ServerTimeRes)</returns>
        Task<ApiResponse<ServerTimeRes>> CommonGetTimeAsyncWithHttpInfo();

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CommonApi : ApiBase, ICommonApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CommonApi(string basePath) : base(basePath) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CommonApi(Configuration? configuration = null) : base(configuration) { }

        /// <summary>
        /// Get Bybit OpenAPI announcements in the last 30 days in reverse order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-announcement"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns><see cref="AnnouncementRes"/></returns>
        public AnnouncementBase CommonAnnouncements() => CommonAnnouncementsWithHttpInfo().Data;

        /// <summary>
        /// Get Bybit OpenAPI announcements in the last 30 days in reverse order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-announcement"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AnnouncementBase</returns>
        public ApiResponse<AnnouncementBase> CommonAnnouncementsWithHttpInfo()
        {
            var localVarPath = "/v2/public/announcement";
            return CallApiWithHttpInfo<AnnouncementBase>(localVarPath, Method.GET);
        }

        /// <summary>
        /// Get Bybit OpenAPI announcements in the last 30 days in reverse order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-announcement"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of AnnouncementBase</returns>
        public async Task<AnnouncementBase> CommonAnnouncementsAsync() => (await CommonAnnouncementsAsyncWithHttpInfo()).Data;

        /// <summary>
        /// Get Bybit OpenAPI announcements in the last 30 days in reverse order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-announcement"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (AnnouncementBase)</returns>
        public Task<ApiResponse<AnnouncementBase>> CommonAnnouncementsAsyncWithHttpInfo()
        {
            var localVarPath = "/v2/public/announcement";
            return CallApiAsyncWithHttpInfo<AnnouncementBase>(localVarPath, Method.GET);
        }

        /// <summary>
        /// Query LCP info.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-lcp"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <returns><see cref="LCPInfoBase"/></returns>
        public LCPInfoBase CommonGetLcp(Symbol symbol) => CommonGetLcpWithHttpInfo(symbol).Data;

        /// <summary>
        /// Query LCP info.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-lcp"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <returns>ApiResponse of LCPInfoBase</returns>
        public ApiResponse<LCPInfoBase> CommonGetLcpWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/account/lcp";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LCPInfoBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Query LCP info.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-lcp"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <returns>Task of LCPInfoBase</returns>
        public async Task<LCPInfoBase> CommonGetLcpAsync(Symbol symbol) => (await CommonGetLcpAsyncWithHttpInfo(symbol)).Data;

        /// <summary>
        /// Query LCP info.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-lcp"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type</param>
        /// <returns>Task of ApiResponse (LCPInfoBase)</returns>
        public Task<ApiResponse<LCPInfoBase>> CommonGetLcpAsyncWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/account/lcp";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LCPInfoBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get bybit server time.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-servertime"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns><see cref="ServerTime"/></returns>
        public ServerTimeRes CommonGetTime() => CommonGetTimeWithHttpInfo().Data;

        /// <summary>
        /// Get bybit server time.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-servertime"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ServerTimeRes</returns>
        public ApiResponse<ServerTimeRes> CommonGetTimeWithHttpInfo()
        {
            var localVarPath = "/v2/public/time";
            return CallApiWithHttpInfo<ServerTimeRes>(localVarPath, Method.GET);
        }

        /// <summary>
        /// Get bybit server time.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-servertime"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ServerTimeRes</returns>
        public async Task<ServerTimeRes> CommonGetTimeAsync() => (await CommonGetTimeAsyncWithHttpInfo()).Data;

        /// <summary>
        /// Get bybit server time.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-servertime"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ServerTimeRes)</returns>
        public Task<ApiResponse<ServerTimeRes>> CommonGetTimeAsyncWithHttpInfo()
        {
            var localVarPath = "/v2/public/time";
            return CallApiAsyncWithHttpInfo<ServerTimeRes>(localVarPath, Method.GET);
        }
    }
}