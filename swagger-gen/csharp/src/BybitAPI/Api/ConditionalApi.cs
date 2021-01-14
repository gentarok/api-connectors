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
    public interface IConditionalApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Cancel conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Order ID of conditional order. (optional)</param>
        /// <param name="orderLinkId">Agency customized order ID. (optional)</param>
        /// <returns><see cref="ConditionalCancelBase"/></returns>
        ConditionalCancelBase ConditionalCancel(Symbol symbol, string stopOrderId = null, string orderLinkId = null);

        /// <summary>
        /// Cancel conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Order ID of conditional order. (optional)</param>
        /// <param name="orderLinkId">Agency customized order ID. (optional)</param>
        /// <returns>ApiResponse of ConditionalCancelBase</returns>
        ApiResponse<ConditionalCancelBase> ConditionalCancelWithHttpInfo(Symbol symbol, string stopOrderId = null, string orderLinkId = null);

        /// <summary>
        /// Cancel conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns><see cref="ConditionalCancelAllBase"/></returns>
        ConditionalCancelAllBase ConditionalCancelAll(Symbol symbol);

        /// <summary>
        /// Cancel conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns>ApiResponse of ConditionalCancelAllBase</returns>
        ApiResponse<ConditionalCancelAllBase> ConditionalCancelAllWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get my conditional order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-getcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderStatus">Stop order status. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns><see cref="ConditionalGetOrdersBase"/></returns>
        ConditionalGetOrdersBase ConditionalGetOrders(Symbol symbol, StopOrderStatus? stopOrderStatus = null, int? limit = null, SearchDirection? direction = null, string? cursor = null);

        /// <summary>
        /// Get my conditional order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-getcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderStatus">Stop order status. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns>ApiResponse of ConditionalGetOrdersBase</returns>
        ApiResponse<ConditionalGetOrdersBase> ConditionalGetOrdersWithHttpInfo(Symbol symbol, StopOrderStatus? stopOrderStatus = null, int? limit = null, SearchDirection? direction = null, string? cursor = null);

        /// <summary>
        /// Place a new conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side.</param>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="orderType">Conditional order type.</param>
        /// <param name="qty">Order quantity.</param>
        /// <param name="basePrice">Send current market price. It will be used to compare with the value of &#39;stop_px&#39;, to decide whether your conditional order will be triggered by crossing trigger price from upper side or lower side. Mainly used to identify the expected direction of the current conditional order..</param>
        /// <param name="stopPx">Trigger price.</param>
        /// <param name="timeInForce">Time in force.</param>
        /// <param name="price">Execution price for conditional order (optional)</param>
        /// <param name="triggerBy">Trigger price type. Default LastPrice. (optional)</param>
        /// <param name="closeOnTrigger">close on trigger. (optional)</param>
        /// <param name="orderLinkId">Customized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique.. (optional)</param>
        /// <returns><see cref="ConditionalNewOrderBase"/></returns>
        ConditionalNewOrderBase ConditionalNew(Side side, Symbol symbol, OrderType orderType, decimal qty, decimal basePrice, decimal stopPx, TimeInForce timeInForce, decimal? price = null, TriggerPriceType? triggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Place a new conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side.</param>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="orderType">Conditional order type.</param>
        /// <param name="qty">Order quantity.</param>
        /// <param name="basePrice">Send current market price. It will be used to compare with the value of &#39;stop_px&#39;, to decide whether your conditional order will be triggered by crossing trigger price from upper side or lower side. Mainly used to identify the expected direction of the current conditional order..</param>
        /// <param name="stopPx">Trigger price.</param>
        /// <param name="timeInForce">Time in force.</param>
        /// <param name="price">Execution price for conditional order (optional)</param>
        /// <param name="triggerBy">Trigger price type. Default LastPrice. (optional)</param>
        /// <param name="closeOnTrigger">close on trigger. (optional)</param>
        /// <param name="orderLinkId">Customized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique.. (optional)</param>
        /// <returns>ApiResponse of ConditionalNewOrderBase</returns>
        ApiResponse<ConditionalNewOrderBase> ConditionalNewWithHttpInfo(Side side, Symbol symbol, OrderType orderType, decimal qty, decimal basePrice, decimal stopPx, TimeInForce timeInForce, decimal? price = null, TriggerPriceType? triggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Query real-time stop order information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Order ID of conditional order. (optional)</param>
        /// <param name="orderLinkId">Agency customized order ID. (optional)</param>
        /// <returns>ConditionalQueryBase of ConditionalQueryRes</returns>
        ConditionalQueryBase<ConditionalQueryRes> ConditionalQuery(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null);

        /// <summary>
        /// Query real-time stop order information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Order ID of conditional order. (optional)</param>
        /// <param name="orderLinkId">Agency customized order ID. (optional)</param>
        /// <returns>ApiResponse of ConditionalQueryBase (ConditionalQueryRes)</returns>
        ApiResponse<ConditionalQueryBase<ConditionalQueryRes>> ConditionalQueryWithHttpInfo(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null);

        /// <summary>
        /// Query real-time stop order information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns>ConditionalQueryBase of IReadOnlyList (ConditionalQueryRes)</returns>
        ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>> ConditionalQuery(Symbol symbol);

        /// <summary>
        /// Query real-time stop order information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns>ApiResponse of ConditionalQueryBase (IReadOnlyList of ConditionalQueryRes)</returns>
        ApiResponse<ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>>> ConditionalQueryWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Replace conditional order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Stop order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <param name="pRTriggerPrice">Trigger price. (optional)</param>
        /// <returns><see cref="ConditionalReplaceBase"/></returns>
        ConditionalReplaceBase ConditionalReplace(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null);

        /// <summary>
        /// Replace conditional order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Stop order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <param name="pRTriggerPrice">Trigger price. (optional)</param>
        /// <returns>ApiResponse of ConditionalReplaceBase</returns>
        ApiResponse<ConditionalReplaceBase> ConditionalReplaceWithHttpInfo(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Cancel conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Order ID of conditional order. (optional)</param>
        /// <param name="orderLinkId">Agency customized order ID. (optional)</param>
        /// <returns>Task of ConditionalCancelBase</returns>
        Task<ConditionalCancelBase> ConditionalCancelAsync(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null);

        /// <summary>
        /// Cancel conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Order ID of conditional order. (optional)</param>
        /// <param name="orderLinkId">Agency customized order ID. (optional)</param>
        /// <returns>Task of ApiResponse (ConditionalCancelBase)</returns>
        Task<ApiResponse<ConditionalCancelBase>> ConditionalCancelAsyncWithHttpInfo(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null);

        /// <summary>
        /// Cancel conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns>Task of ConditionalCancelAllBase</returns>
        Task<ConditionalCancelAllBase> ConditionalCancelAllAsync(Symbol symbol);

        /// <summary>
        /// Cancel conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns>Task of ApiResponse (ConditionalCancelAllBase))</returns>
        Task<ApiResponse<ConditionalCancelAllBase>> ConditionalCancelAllAsyncWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get my conditional order list.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderStatus">Stop order status. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns>Task of ConditionalGetOrdersBase</returns>
        Task<ConditionalGetOrdersBase> ConditionalGetOrdersAsync(Symbol symbol, StopOrderStatus? stopOrderStatus = null, int? limit = null, SearchDirection? direction = null, string? cursor = null);

        /// <summary>
        /// Get my conditional order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-getcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderStatus">Stop order status. (optional)</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page. (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns>Task of ApiResponse (ConditionalGetOrdersBase)</returns>
        Task<ApiResponse<ConditionalGetOrdersBase>> ConditionalGetOrdersAsyncWithHttpInfo(Symbol symbol, StopOrderStatus? stopOrderStatus = null, int? limit = null, SearchDirection? direction = null, string? cursor = null);

        /// <summary>
        /// Place a new conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side.</param>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="orderType">Conditional order type.</param>
        /// <param name="qty">Order quantity.</param>
        /// <param name="basePrice">Send current market price. It will be used to compare with the value of &#39;stop_px&#39;, to decide whether your conditional order will be triggered by crossing trigger price from upper side or lower side. Mainly used to identify the expected direction of the current conditional order..</param>
        /// <param name="stopPx">Trigger price.</param>
        /// <param name="timeInForce">Time in force.</param>
        /// <param name="price">Execution price for conditional order (optional)</param>
        /// <param name="triggerBy">Trigger price type. Default LastPrice. (optional)</param>
        /// <param name="closeOnTrigger">close on trigger. (optional)</param>
        /// <param name="orderLinkId">Customized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique.. (optional)</param>
        /// <returns>Task of ConditionalNewOrderBase</returns>
        Task<ConditionalNewOrderBase> ConditionalNewAsync(Side side, Symbol symbol, OrderType orderType, decimal qty, decimal basePrice, decimal stopPx, TimeInForce timeInForce, decimal? price = null, TriggerPriceType? triggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Place a new conditional order.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side.</param>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="orderType">Conditional order type.</param>
        /// <param name="qty">Order quantity.</param>
        /// <param name="basePrice">Send current market price. It will be used to compare with the value of &#39;stop_px&#39;, to decide whether your conditional order will be triggered by crossing trigger price from upper side or lower side. Mainly used to identify the expected direction of the current conditional order..</param>
        /// <param name="stopPx">Trigger price.</param>
        /// <param name="timeInForce">Time in force.</param>
        /// <param name="price">Execution price for conditional order (optional)</param>
        /// <param name="triggerBy">Trigger price type. Default LastPrice. (optional)</param>
        /// <param name="closeOnTrigger">close on trigger. (optional)</param>
        /// <param name="orderLinkId">Customized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique.. (optional)</param>
        /// <returns>Task of ApiResponse (ConditionalNewOrderBase)</returns>
        Task<ApiResponse<ConditionalNewOrderBase>> ConditionalNewAsyncWithHttpInfo(Side side, Symbol symbol, OrderType orderType, decimal qty, decimal basePrice, decimal stopPx, TimeInForce timeInForce, decimal? price = null, TriggerPriceType? triggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Query real-time stop order information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Order ID of conditional order. (optional)</param>
        /// <param name="orderLinkId">Agency customized order ID. (optional)</param>
        /// <returns>Task of ConditionalQueryBase (ConditionalQueryRes)</returns>
        Task<ConditionalQueryBase<ConditionalQueryRes>> ConditionalQueryAsync(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null);

        /// <summary>
        /// Query real-time stop order information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Order ID of conditional order. (optional)</param>
        /// <param name="orderLinkId">Agency customized order ID. (optional)</param>
        /// <returns>Task of ApiResponse (ConditionalQueryBase of ConditionalQueryRes)</returns>
        Task<ApiResponse<ConditionalQueryBase<ConditionalQueryRes>>> ConditionalQueryAsyncWithHttpInfo(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null);

        /// <summary>
        /// Query real-time stop order information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns>Task of ConditionalQueryBase (IReadOnlyList of ConditionalQueryRes)</returns>
        Task<ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>>> ConditionalQueryAsync(Symbol symbol);

        /// <summary>
        /// Query real-time stop order information.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <returns>Task of ApiResponse (ConditionalQueryBase of IReadOnlyList (ConditionalQueryRes))</returns>
        Task<ApiResponse<ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>>>> ConditionalQueryAsyncWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Replace conditional order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Stop order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <param name="pRTriggerPrice">Trigger price. (optional)</param>
        /// <returns>Task of ConditionalReplaceBase</returns>
        Task<ConditionalReplaceBase> ConditionalReplaceAsync(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null);

        /// <summary>
        /// Replace conditional order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="Symbol"/></param>
        /// <param name="stopOrderId">Stop order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <param name="pRTriggerPrice">Trigger price. (optional)</param>
        /// <returns>Task of ApiResponse (ConditionalReplaceBase)</returns>
        Task<ApiResponse<ConditionalReplaceBase>> ConditionalReplaceAsyncWithHttpInfo(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class ConditionalApi : ApiBase, IConditionalApi
    {
        private const int ConditionalGetOrdersMaxValue = 50;

        public ConditionalApi(string basePath) : base(basePath)
        {
        }

        public ConditionalApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public ConditionalCancelBase ConditionalCancel(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null)
            => ConditionalCancelWithHttpInfo(symbol, stopOrderId, orderLinkId).Data;

        public ApiResponse<ConditionalCancelBase> ConditionalCancelWithHttpInfo(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null)
        {
            // Note : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            // see: https://bybit-exchange.github.io/docs/inverse/?console#t-cancelcond
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling ConditionalApi->ConditionalCancel");
            }

            var localVarPath = "/v2/private/stop-order/cancel";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (stopOrderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_id", Configuration.ApiClient.ParameterToString(stopOrderId)));
            }
            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", Configuration.ApiClient.ParameterToString(orderLinkId)));
            }

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<ConditionalCancelBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<ConditionalCancelBase> ConditionalCancelAsync(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null)
            => (await ConditionalCancelAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId)).Data;

        public Task<ApiResponse<ConditionalCancelBase>> ConditionalCancelAsyncWithHttpInfo(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null)
        {
            // Note : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            // see: https://bybit-exchange.github.io/docs/inverse/?console#t-cancelcond
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling ConditionalApi->ConditionalCancel");
            }

            var localVarPath = "/v2/private/stop-order/cancel";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (stopOrderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_id", Configuration.ApiClient.ParameterToString(stopOrderId)));
            }
            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", Configuration.ApiClient.ParameterToString(orderLinkId)));
            }

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<ConditionalCancelBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public ConditionalCancelAllBase ConditionalCancelAll(Symbol symbol)
            => ConditionalCancelAllWithHttpInfo(symbol).Data;

        public ApiResponse<ConditionalCancelAllBase> ConditionalCancelAllWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/stop-order/cancelAll";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<ConditionalCancelAllBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<ConditionalCancelAllBase> ConditionalCancelAllAsync(Symbol symbol) => (await ConditionalCancelAllAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<ConditionalCancelAllBase>> ConditionalCancelAllAsyncWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/stop-order/cancelAll";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<ConditionalCancelAllBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public ConditionalGetOrdersBase ConditionalGetOrders(Symbol symbol, StopOrderStatus? stopOrderStatus = null, int? limit = null, SearchDirection? direction = null, string? cursor = null)
            => ConditionalGetOrdersWithHttpInfo(symbol, stopOrderStatus, limit, direction, cursor).Data;

        public ApiResponse<ConditionalGetOrdersBase> ConditionalGetOrdersWithHttpInfo(Symbol symbol, StopOrderStatus? stopOrderStatus = null, int? limit = null, SearchDirection? direction = null, string? cursor = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > ConditionalGetOrdersMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling ConditionalApi->ConditionalGetOrders");
            }

            var localVarPath = "/v2/private/stop-order/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (stopOrderStatus is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_status", stopOrderStatus));
            }
            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }
            if (direction is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "direction", direction));
            }
            if (cursor is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "cursor", cursor));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<ConditionalGetOrdersBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<ConditionalGetOrdersBase> ConditionalGetOrdersAsync(Symbol symbol, StopOrderStatus? stopOrderStatus = null, int? limit = null, SearchDirection? direction = null, string? cursor = null)
            => (await ConditionalGetOrdersAsyncWithHttpInfo(symbol, stopOrderStatus, limit, direction, cursor)).Data;

        public Task<ApiResponse<ConditionalGetOrdersBase>> ConditionalGetOrdersAsyncWithHttpInfo(Symbol symbol, StopOrderStatus? stopOrderStatus = null, int? limit = null, SearchDirection? direction = null, string? cursor = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > ConditionalGetOrdersMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling ConditionalApi->ConditionalGetOrders");
            }

            var localVarPath = "/v2/private/stop-order/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (stopOrderStatus is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_status", stopOrderStatus));
            }
            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }
            if (direction is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "direction", direction));
            }
            if (cursor is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "cursor", cursor));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<ConditionalGetOrdersBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public ConditionalNewOrderBase ConditionalNew(Side side, Symbol symbol, OrderType orderType, decimal qty, decimal basePrice, decimal stopPx, TimeInForce timeInForce, decimal? price = null, TriggerPriceType? triggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null)
            => ConditionalNewWithHttpInfo(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, closeOnTrigger, orderLinkId).Data;

        public ApiResponse<ConditionalNewOrderBase> ConditionalNewWithHttpInfo(Side side, Symbol symbol, OrderType orderType, decimal qty, decimal basePrice, decimal stopPx, TimeInForce timeInForce, decimal? price = null, TriggerPriceType? triggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null)
        {
            var localVarPath = "/v2/private/stop-order/create";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_type", Configuration.ApiClient.ParameterToString(orderType)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "qty", Configuration.ApiClient.ParameterToString(qty)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "base_price", Configuration.ApiClient.ParameterToString(basePrice)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_px", Configuration.ApiClient.ParameterToString(stopPx)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "time_in_force", Configuration.ApiClient.ParameterToString(timeInForce)));

            if (price is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price", Configuration.ApiClient.ParameterToString(price)));
            }
            if (triggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "trigger_by", Configuration.ApiClient.ParameterToString(triggerBy)));
            }
            if (closeOnTrigger is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "close_on_trigger", Configuration.ApiClient.ParameterToString(closeOnTrigger)));
            }
            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", Configuration.ApiClient.ParameterToString(orderLinkId)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<ConditionalNewOrderBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<ConditionalNewOrderBase> ConditionalNewAsync(Side side, Symbol symbol, OrderType orderType, decimal qty, decimal basePrice, decimal stopPx, TimeInForce timeInForce, decimal? price = null, TriggerPriceType? triggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null)
            => (await ConditionalNewAsyncWithHttpInfo(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, closeOnTrigger, orderLinkId)).Data;

        public Task<ApiResponse<ConditionalNewOrderBase>> ConditionalNewAsyncWithHttpInfo(Side side, Symbol symbol, OrderType orderType, decimal qty, decimal basePrice, decimal stopPx, TimeInForce timeInForce, decimal? price = null, TriggerPriceType? triggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null)
        {
            var localVarPath = "/v2/private/stop-order/create";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_type", Configuration.ApiClient.ParameterToString(orderType)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "qty", Configuration.ApiClient.ParameterToString(qty)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "base_price", Configuration.ApiClient.ParameterToString(basePrice)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_px", Configuration.ApiClient.ParameterToString(stopPx)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "time_in_force", Configuration.ApiClient.ParameterToString(timeInForce)));

            if (price is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price", Configuration.ApiClient.ParameterToString(price)));
            }
            if (triggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "trigger_by", Configuration.ApiClient.ParameterToString(triggerBy)));
            }
            if (closeOnTrigger is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "close_on_trigger", Configuration.ApiClient.ParameterToString(closeOnTrigger)));
            }
            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", Configuration.ApiClient.ParameterToString(orderLinkId)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<ConditionalNewOrderBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public ConditionalQueryBase<ConditionalQueryRes> ConditionalQuery(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null)
            => ConditionalQueryWithHttpInfo(symbol, stopOrderId, orderLinkId).Data;

        public ApiResponse<ConditionalQueryBase<ConditionalQueryRes>> ConditionalQueryWithHttpInfo(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null)
        {
            // Note : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling ConditionalApi->ConditionalQuery");
            }

            var localVarPath = "/v2/private/stop-order";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (stopOrderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_id", stopOrderId));
            }
            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", orderLinkId));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<ConditionalQueryBase<ConditionalQueryRes>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<ConditionalQueryBase<ConditionalQueryRes>> ConditionalQueryAsync(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null)
            => (await ConditionalQueryAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId)).Data;

        public Task<ApiResponse<ConditionalQueryBase<ConditionalQueryRes>>> ConditionalQueryAsyncWithHttpInfo(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null)
        {
            // FIXED : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling ConditionalApi->ConditionalQuery");
            }

            var localVarPath = "/v2/private/stop-order";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (stopOrderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_id", stopOrderId));
            }
            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", orderLinkId));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<ConditionalQueryBase<ConditionalQueryRes>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>> ConditionalQuery(Symbol symbol)
            => ConditionalQueryWithHttpInfo(symbol).Data;

        public ApiResponse<ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>>> ConditionalQueryWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/stop-order";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>>> ConditionalQueryAsync(Symbol symbol)
            => (await ConditionalQueryAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>>>> ConditionalQueryAsyncWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/stop-order";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<ConditionalQueryBase<IReadOnlyList<ConditionalQueryRes>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public ConditionalReplaceBase ConditionalReplace(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null)
            => ConditionalReplaceWithHttpInfo(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice).Data;

        public ApiResponse<ConditionalReplaceBase> ConditionalReplaceWithHttpInfo(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null)
        {
            // FIXED : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling ConditionalApi->ConditionalReplace");
            }

            var localVarPath = "/v2/private/stop-order/replace";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (stopOrderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_id", Configuration.ApiClient.ParameterToString(stopOrderId)));
            }
            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", Configuration.ApiClient.ParameterToString(orderLinkId)));
            }
            if (pRQty is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "p_r_qty", Configuration.ApiClient.ParameterToString(pRQty)));
            }
            if (pRPrice is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "p_r_price", Configuration.ApiClient.ParameterToString(pRPrice)));
            }
            if (pRTriggerPrice is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "p_r_trigger_price", Configuration.ApiClient.ParameterToString(pRTriggerPrice)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<ConditionalReplaceBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<ConditionalReplaceBase> ConditionalReplaceAsync(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null)
            => (await ConditionalReplaceAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice)).Data;

        public Task<ApiResponse<ConditionalReplaceBase>> ConditionalReplaceAsyncWithHttpInfo(Symbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null)
        {
            // FIXED : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling ConditionalApi->ConditionalReplace");
            }

            var localVarPath = "/v2/private/stop-order/replace";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (stopOrderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_id", Configuration.ApiClient.ParameterToString(stopOrderId)));
            }
            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", Configuration.ApiClient.ParameterToString(orderLinkId)));
            }
            if (pRQty is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "p_r_qty", Configuration.ApiClient.ParameterToString(pRQty)));
            }
            if (pRPrice is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "p_r_price", Configuration.ApiClient.ParameterToString(pRPrice)));
            }
            if (pRTriggerPrice is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "p_r_trigger_price", Configuration.ApiClient.ParameterToString(pRTriggerPrice)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<ConditionalReplaceBase>(localVarPath, Method.POST, localVarQueryParams);
        }
    }
}