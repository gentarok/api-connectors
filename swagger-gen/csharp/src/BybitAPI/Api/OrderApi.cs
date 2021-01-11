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
    public interface IOrderApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID (optional)</param>
        /// <param name="orderLinkId">Order link id. (optional)</param>
        /// <returns><see cref="OrderCancelBase"/></returns>
        OrderCancelBase OrderCancel(Symbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID (optional)</param>
        /// <param name="orderLinkId">Order link id. (optional)</param>
        /// <returns>ApiResponse of OrderCancelBase</returns>
        ApiResponse<OrderCancelBase> OrderCancelWithHttpInfo(Symbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns><see cref="OrderCancelAllBase"/></returns>
        OrderCancelAllBase OrderCancelAll(Symbol symbol);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of OrderCancelAllBase</returns>
        ApiResponse<OrderCancelAllBase> OrderCancelAllWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type. Default BTCUSD</param>
        /// <param name="limit">TLimit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="orderStatus">Query your orders for all statuses if &#39;order_status&#39; is empty. If you want to query orders with specific statuses , you can pass the order_status split by (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns><see cref="OrderGetOrdersBase"/></returns>
        OrderGetOrdersBase OrderGetOrders(Symbol symbol, int? limit = null, OrderStatus? orderStatus = null, SearchDirection? direction = null, string? cursor = null);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type. Default BTCUSD</param>
        /// <param name="limit">TLimit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="orderStatus">Query your orders for all statuses if &#39;order_status&#39; is empty. If you want to query orders with specific statuses , you can pass the order_status split by (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns>ApiResponse of OrderGetOrdersBase</returns>
        ApiResponse<OrderGetOrdersBase> OrderGetOrdersWithHttpInfo(Symbol symbol, int? limit = null, OrderStatus? orderStatus = null, SearchDirection? direction = null, string? cursor = null);

        /// <summary>
        /// Place active order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side</param>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderType">Active order type</param>
        /// <param name="qty"></param>
        /// <param name="timeInForce">Time in force</param>
        /// <param name="price">Order price. (optional)</param>
        /// <param name="takeProfit">take profit price (optional)</param>
        /// <param name="stopLoss">stop loss price (optional)</param>
        /// <param name="reduceOnly">reduce only (optional)</param>
        /// <param name="closeOnTrigger">close on trigger (optional)</param>
        /// <param name="orderLinkId">TCustomized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique. (optional)</param>
        /// <returns><see cref="OrderNewBase"/></returns>
        OrderNewBase OrderNew(Side side, Symbol symbol, OrderType orderType, int qty, TimeInForce timeInForce, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Place active order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side</param>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderType">Active order type</param>
        /// <param name="qty"></param>
        /// <param name="timeInForce">Time in force</param>
        /// <param name="price">Order price. (optional)</param>
        /// <param name="takeProfit">take profit price (optional)</param>
        /// <param name="stopLoss">stop loss price (optional)</param>
        /// <param name="reduceOnly">reduce only (optional)</param>
        /// <param name="closeOnTrigger">close on trigger (optional)</param>
        /// <param name="orderLinkId">TCustomized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique. (optional)</param>
        /// <returns>ApiResponse of OrderNewBase</returns>
        ApiResponse<OrderNewBase> OrderNewWithHttpInfo(Side side, Symbol symbol, OrderType orderType, int qty, TimeInForce timeInForce, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID.</param>
        /// <returns>OrderQueryBase of OrderQueryRes</returns>
        OrderQueryBase<OrderQueryRes> OrderQuery(Symbol symbol, string orderId);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID.</param>
        /// <returns>ApiResponse of OrderQueryBase (OrderQueryRes)</returns>
        ApiResponse<OrderQueryBase<OrderQueryRes>> OrderQueryWithHttpInfo(Symbol symbol, string orderId);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>OrderQueryBase of List (OrderQueryRes)</returns>
        OrderQueryBase<IReadOnlyList<OrderQueryRes>> OrderQuery(Symbol symbol);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of OrderQueryBase (List of OrderQueryRes)</returns>
        ApiResponse<OrderQueryBase<IReadOnlyList<OrderQueryRes>>> OrderQueryWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Replace active order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <returns><see cref="OrderReplaceBase"/></returns>
        OrderReplaceBase OrderReplace(Symbol Symbol, string? orderId = null, string? orderLinkId = null, string? pRQty = null, string? pRPrice = null);

        /// <summary>
        /// Replace active order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <returns>ApiResponse of OrderReplaceBase</returns>
        ApiResponse<OrderReplaceBase> OrderReplaceWithHttpInfo(Symbol Symbol, string? orderId = null, string? orderLinkId = null, string? pRQty = null, string? pRPrice = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID (optional)</param>
        /// <param name="orderLinkId">Order link id. (optional)</param>
        /// <returns>Task of OrderCancelBase</returns>
        Task<OrderCancelBase> OrderCancelAsync(Symbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID (optional)</param>
        /// <param name="orderLinkId">Order link id. (optional)</param>
        /// <returns>Task of ApiResponse (OrderCancelBase)</returns>
        Task<ApiResponse<OrderCancelBase>> OrderCancelAsyncWithHttpInfo(Symbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of OrderCancelAllBase</returns>
        Task<OrderCancelAllBase> OrderCancelAllAsync(Symbol symbol);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (OrderCancelAllBase)</returns>
        Task<ApiResponse<OrderCancelAllBase>> OrderCancelAllAsyncWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type. Default BTCUSD</param>
        /// <param name="limit">TLimit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="orderStatus">Query your orders for all statuses if &#39;order_status&#39; is empty. If you want to query orders with specific statuses , you can pass the order_status split by (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns>Task of OrderGetOrdersBase</returns>
        Task<OrderGetOrdersBase> OrderGetOrdersAsync(Symbol symbol, int? limit = null, OrderStatus? orderStatus = null, SearchDirection? direction = null, string? cursor = null);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type. Default BTCUSD</param>
        /// <param name="limit">TLimit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="orderStatus">Query your orders for all statuses if &#39;order_status&#39; is empty. If you want to query orders with specific statuses , you can pass the order_status split by (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns>Task of ApiResponse (OrderGetOrdersBase)</returns>
        Task<ApiResponse<OrderGetOrdersBase>> OrderGetOrdersAsyncWithHttpInfo(Symbol symbol, int? limit = null, OrderStatus? orderStatus = null, SearchDirection? direction = null, string? cursor = null);

        /// <summary>
        /// Place active order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side</param>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderType">Active order type</param>
        /// <param name="qty"></param>
        /// <param name="timeInForce">Time in force</param>
        /// <param name="price">Order price. (optional)</param>
        /// <param name="takeProfit">take profit price (optional)</param>
        /// <param name="stopLoss">stop loss price (optional)</param>
        /// <param name="reduceOnly">reduce only (optional)</param>
        /// <param name="closeOnTrigger">close on trigger (optional)</param>
        /// <param name="orderLinkId">TCustomized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique. (optional)</param>
        /// <returns>Task of OrderNewBase</returns>
        Task<OrderNewBase> OrderNewAsync(Side side, Symbol symbol, OrderType orderType, int qty, TimeInForce timeInForce, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Place active order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side</param>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderType">Active order type</param>
        /// <param name="qty"></param>
        /// <param name="timeInForce">Time in force</param>
        /// <param name="price">Order price. (optional)</param>
        /// <param name="takeProfit">take profit price (optional)</param>
        /// <param name="stopLoss">stop loss price (optional)</param>
        /// <param name="reduceOnly">reduce only (optional)</param>
        /// <param name="closeOnTrigger">close on trigger (optional)</param>
        /// <param name="orderLinkId">TCustomized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique. (optional)</param>
        /// <returns>Task of ApiResponse (OrderNewBase)</returns>
        Task<ApiResponse<OrderNewBase>> OrderNewAsyncWithHttpInfo(Side side, Symbol symbol, OrderType orderType, int qty, TimeInForce timeInForce, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID.</param>
        /// <returns>Task of OrderQueryBase (OrderQueryRes)</returns>
        Task<OrderQueryBase<OrderQueryRes>> OrderQueryAsync(Symbol symbol, string orderId);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID.</param>
        /// <returns>Task of ApiResponse (OrderQueryBase of OrderQueryRes))</returns>
        Task<ApiResponse<OrderQueryBase<OrderQueryRes>>> OrderQueryAsyncWithHttpInfo(Symbol symbol, string orderId);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of OrderQueryBase (OrderQueryRes)</returns>
        Task<OrderQueryBase<IReadOnlyList<OrderQueryRes>>> OrderQueryAsync(Symbol symbol);

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (OrderQueryBase of List (OrderQueryRes)))</returns>
        Task<ApiResponse<OrderQueryBase<IReadOnlyList<OrderQueryRes>>>> OrderQueryAsyncWithHttpInfo(Symbol symbol);

        /// <summary>
        /// Replace active order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <returns>Task of OrderReplaceBase</returns>
        Task<OrderReplaceBase> OrderReplaceAsync(Symbol Symbol, string? orderId = null, string? orderLinkId = null, string? pRQty = null, string? pRPrice = null);

        /// <summary>
        /// Replace active order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <returns>Task of ApiResponse (OrderReplaceBase)</returns>
        Task<ApiResponse<OrderReplaceBase>> OrderReplaceAsyncWithHttpInfo(Symbol Symbol, string? orderId = null, string? orderLinkId = null, string? pRQty = null, string? pRPrice = null);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrderApi : ApiBase, IOrderApi
    {
        private const int OrderGetOrdersLimitMaxValue = 50;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderApi(string basePath) : base(basePath) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrderApi(Configuration? configuration = null) : base(configuration) { }

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID (optional)</param>
        /// <param name="orderLinkId">Order link id. (optional)</param>
        /// <returns><see cref="OrderCancelBase"/></returns>
        public OrderCancelBase OrderCancel(Symbol symbol, string? orderId = null, string? orderLinkId = null)
            => OrderCancelWithHttpInfo(symbol, orderId, orderLinkId).Data;

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID (optional)</param>
        /// <param name="orderLinkId">Order link id. (optional)</param>
        /// <returns>ApiResponse of OrderCancelBase</returns>
        public ApiResponse<OrderCancelBase> OrderCancelWithHttpInfo(Symbol symbol, string? orderId = null, string? orderLinkId = null)
        {
            // Note : According to the document, 'orderId' or 'orderLinkId' is required.
            // see: https://bybit-exchange.github.io/docs/inverse/#t-cancelactive
            if (orderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'orderId' or 'orderLinkId' when calling OrderApi->OrderCancel");
            }

            var localVarPath = "/v2/private/order/cancel";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", Configuration.ApiClient.ParameterToString(orderId)));
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

            return CallApiWithHttpInfo<OrderCancelBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID (optional)</param>
        /// <param name="orderLinkId">Order link id. (optional)</param>
        /// <returns>Task of OrderCancelBase</returns>
        public async Task<OrderCancelBase> OrderCancelAsync(Symbol symbol, string? orderId = null, string? orderLinkId = null)
            => (await OrderCancelAsyncWithHttpInfo(symbol, orderId, orderLinkId)).Data;

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID (optional)</param>
        /// <param name="orderLinkId">Order link id. (optional)</param>
        /// <returns>Task of ApiResponse (OrderCancelBase)</returns>
        public Task<ApiResponse<OrderCancelBase>> OrderCancelAsyncWithHttpInfo(Symbol symbol, string? orderId = null, string? orderLinkId = null)
        {
            // Note : According to the document, 'orderId' or 'orderLinkId' is required.
            // see: https://bybit-exchange.github.io/docs/inverse/#t-cancelactive
            if (orderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'orderId' or 'orderLinkId' when calling OrderApi->OrderCancel");
            }

            var localVarPath = "/v2/private/order/cancel";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", Configuration.ApiClient.ParameterToString(orderId)));
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

            return CallApiAsyncWithHttpInfo<OrderCancelBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns><see cref="OrderCancelAllBase"/></returns>
        public OrderCancelAllBase OrderCancelAll(Symbol symbol)
            => OrderCancelAllWithHttpInfo(symbol).Data;

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of OrderCancelAllBase</returns>
        public ApiResponse<OrderCancelAllBase> OrderCancelAllWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/order/cancelAll";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<OrderCancelAllBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of OrderCancelAllBase</returns>
        public async Task<OrderCancelAllBase> OrderCancelAllAsync(Symbol symbol)
            => (await OrderCancelAllAsyncWithHttpInfo(symbol)).Data;

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (OrderCancelAllBase)</returns>
        public Task<ApiResponse<OrderCancelAllBase>> OrderCancelAllAsyncWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/order/cancelAll";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<OrderCancelAllBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type. Default BTCUSD</param>
        /// <param name="limit">TLimit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="orderStatus">Query your orders for all statuses if &#39;order_status&#39; is empty. If you want to query orders with specific statuses , you can pass the order_status split by (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns><see cref="OrderGetOrdersBase"/></returns>
        public OrderGetOrdersBase OrderGetOrders(Symbol symbol, int? limit = null, OrderStatus? orderStatus = null, SearchDirection? direction = null, string? cursor = null)
            => OrderGetOrdersWithHttpInfo(symbol, limit, orderStatus, direction, cursor).Data;

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type. Default BTCUSD</param>
        /// <param name="limit">TLimit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="orderStatus">Query your orders for all statuses if &#39;order_status&#39; is empty. If you want to query orders with specific statuses , you can pass the order_status split by (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns>ApiResponse of OrderGetOrdersBase</returns>
        public ApiResponse<OrderGetOrdersBase> OrderGetOrdersWithHttpInfo(Symbol symbol, int? limit = null, OrderStatus? orderStatus = null, SearchDirection? direction = null, string? cursor = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and <= OrderGetOrdersLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling OrderApi->OrderGetOrders");
            }

            var localVarPath = "/v2/private/order/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            if (orderStatus is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_status", orderStatus));
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

            return CallApiWithHttpInfo<OrderGetOrdersBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type. Default BTCUSD</param>
        /// <param name="limit">TLimit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="orderStatus">Query your orders for all statuses if &#39;order_status&#39; is empty. If you want to query orders with specific statuses , you can pass the order_status split by (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns>Task of OrderGetOrdersBase</returns>
        public async Task<OrderGetOrdersBase> OrderGetOrdersAsync(Symbol symbol, int? limit = null, OrderStatus? orderStatus = null, SearchDirection? direction = null, string? cursor = null)
            => (await OrderGetOrdersAsyncWithHttpInfo(symbol, limit, orderStatus, direction, cursor)).Data;

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type. Default BTCUSD</param>
        /// <param name="limit">TLimit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)</param>
        /// <param name="orderStatus">Query your orders for all statuses if &#39;order_status&#39; is empty. If you want to query orders with specific statuses , you can pass the order_status split by (optional)</param>
        /// <param name="direction">Search direction. prev: prev page, next: next page. Defaults to next (optional)</param>
        /// <param name="cursor">Page turning mark，Use return cursor,Sign use origin data, in request please urlencode (optional)</param>
        /// <returns>Task of ApiResponse (OrderGetOrdersBase)</returns>
        public Task<ApiResponse<OrderGetOrdersBase>> OrderGetOrdersAsyncWithHttpInfo(Symbol symbol, int? limit = null, OrderStatus? orderStatus = null, SearchDirection? direction = null, string? cursor = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and <= OrderGetOrdersLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling OrderApi->OrderGetOrders");
            }

            var localVarPath = "/v2/private/order/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            if (orderStatus is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_status", orderStatus));
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

            return CallApiAsyncWithHttpInfo<OrderGetOrdersBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Place active order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side</param>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderType">Active order type</param>
        /// <param name="qty"></param>
        /// <param name="timeInForce">Time in force</param>
        /// <param name="price">Order price. (optional)</param>
        /// <param name="takeProfit">take profit price (optional)</param>
        /// <param name="stopLoss">stop loss price (optional)</param>
        /// <param name="reduceOnly">reduce only (optional)</param>
        /// <param name="closeOnTrigger">close on trigger (optional)</param>
        /// <param name="orderLinkId">TCustomized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique. (optional)</param>
        /// <returns><see cref="OrderNewBase"/></returns>
        public OrderNewBase OrderNew(Side side, Symbol symbol, OrderType orderType, int qty, TimeInForce timeInForce, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null)
            => OrderNewWithHttpInfo(side, symbol, orderType, qty, timeInForce, price, takeProfit, stopLoss, reduceOnly, closeOnTrigger, orderLinkId).Data;

        /// <summary>
        /// Place active order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side</param>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderType">Active order type</param>
        /// <param name="qty"></param>
        /// <param name="timeInForce">Time in force</param>
        /// <param name="price">Order price. (optional)</param>
        /// <param name="takeProfit">take profit price (optional)</param>
        /// <param name="stopLoss">stop loss price (optional)</param>
        /// <param name="reduceOnly">reduce only (optional)</param>
        /// <param name="closeOnTrigger">close on trigger (optional)</param>
        /// <param name="orderLinkId">TCustomized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique. (optional)</param>
        /// <returns>ApiResponse of OrderNewBase</returns>
        public ApiResponse<OrderNewBase> OrderNewWithHttpInfo(Side side, Symbol symbol, OrderType orderType, int qty, TimeInForce timeInForce, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null)
        {
            var localVarPath = "/v2/private/order/create";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_type", Configuration.ApiClient.ParameterToString(orderType)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "qty", Configuration.ApiClient.ParameterToString(qty)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "time_in_force", Configuration.ApiClient.ParameterToString(timeInForce)));

            if (price is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price", Configuration.ApiClient.ParameterToString(price)));
            }
            if (takeProfit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "take_profit", Configuration.ApiClient.ParameterToString(takeProfit)));
            }

            if (stopLoss is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_loss", Configuration.ApiClient.ParameterToString(stopLoss)));
            }

            if (reduceOnly is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "reduce_only", Configuration.ApiClient.ParameterToString(reduceOnly)));
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

            return CallApiWithHttpInfo<OrderNewBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Place active order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side</param>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderType">Active order type</param>
        /// <param name="qty"></param>
        /// <param name="timeInForce">Time in force</param>
        /// <param name="price">Order price. (optional)</param>
        /// <param name="takeProfit">take profit price (optional)</param>
        /// <param name="stopLoss">stop loss price (optional)</param>
        /// <param name="reduceOnly">reduce only (optional)</param>
        /// <param name="closeOnTrigger">close on trigger (optional)</param>
        /// <param name="orderLinkId">TCustomized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique. (optional)</param>
        /// <returns>Task of OrderNewBase</returns>
        public async Task<OrderNewBase> OrderNewAsync(Side side, Symbol symbol, OrderType orderType, int qty, TimeInForce timeInForce, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null)
            => (await OrderNewAsyncWithHttpInfo(side, symbol, orderType, qty, timeInForce, price, takeProfit, stopLoss, reduceOnly, closeOnTrigger, orderLinkId)).Data;

        /// <summary>
        /// Place active order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side">Side</param>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderType">Active order type</param>
        /// <param name="qty"></param>
        /// <param name="timeInForce">Time in force</param>
        /// <param name="price">Order price. (optional)</param>
        /// <param name="takeProfit">take profit price (optional)</param>
        /// <param name="stopLoss">stop loss price (optional)</param>
        /// <param name="reduceOnly">reduce only (optional)</param>
        /// <param name="closeOnTrigger">close on trigger (optional)</param>
        /// <param name="orderLinkId">TCustomized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique. (optional)</param>
        /// <returns>Task of ApiResponse (OrderNewBase)</returns>
        public Task<ApiResponse<OrderNewBase>> OrderNewAsyncWithHttpInfo(Side side, Symbol symbol, OrderType orderType, int qty, TimeInForce timeInForce, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null)
        {
            var localVarPath = "/v2/private/order/create";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_type", Configuration.ApiClient.ParameterToString(orderType)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "qty", Configuration.ApiClient.ParameterToString(qty)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "time_in_force", Configuration.ApiClient.ParameterToString(timeInForce)));

            if (price is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price", Configuration.ApiClient.ParameterToString(price)));
            }
            if (takeProfit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "take_profit", Configuration.ApiClient.ParameterToString(takeProfit)));
            }

            if (stopLoss is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_loss", Configuration.ApiClient.ParameterToString(stopLoss)));
            }

            if (reduceOnly is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "reduce_only", Configuration.ApiClient.ParameterToString(reduceOnly)));
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

            return CallApiAsyncWithHttpInfo<OrderNewBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID.</param>
        /// <returns>OrderQueryBase of OrderQueryRes</returns>
        public OrderQueryBase<OrderQueryRes> OrderQuery(Symbol symbol, string orderId)
            => OrderQueryWithHttpInfo(symbol, orderId).Data;

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID.</param>
        /// <returns>ApiResponse of OrderQueryBase (OrderQueryRes)</returns>
        public ApiResponse<OrderQueryBase<OrderQueryRes>> OrderQueryWithHttpInfo(Symbol symbol, string orderId)
        {
            var localVarPath = "/v2/private/order";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", orderId));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<OrderQueryBase<OrderQueryRes>>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID.</param>
        /// <returns>Task of OrderQueryBase (OrderQueryRes)</returns>
        public async Task<OrderQueryBase<OrderQueryRes>> OrderQueryAsync(Symbol symbol, string orderId)
            => (await OrderQueryAsyncWithHttpInfo(symbol, orderId)).Data;

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID.</param>
        /// <returns>Task of ApiResponse (OrderQueryBase of OrderQueryRes))</returns>
        public Task<ApiResponse<OrderQueryBase<OrderQueryRes>>> OrderQueryAsyncWithHttpInfo(Symbol symbol, string orderId)
        {
            var localVarPath = "/v2/private/order";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", orderId));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<OrderQueryBase<OrderQueryRes>>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>OrderQueryBase of List (OrderQueryRes)</returns>
        public OrderQueryBase<IReadOnlyList<OrderQueryRes>> OrderQuery(Symbol symbol)
            => OrderQueryWithHttpInfo(symbol).Data;

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of OrderQueryBase (List of OrderQueryRes)</returns>
        public ApiResponse<OrderQueryBase<IReadOnlyList<OrderQueryRes>>> OrderQueryWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/order";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<OrderQueryBase<IReadOnlyList<OrderQueryRes>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of OrderQueryBase (OrderQueryRes)</returns>
        public async Task<OrderQueryBase<IReadOnlyList<OrderQueryRes>>> OrderQueryAsync(Symbol symbol)
            => (await OrderQueryAsyncWithHttpInfo(symbol)).Data;

        /// <summary>
        /// Get my active order list.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (OrderQueryBase of List (OrderQueryRes)))</returns>
        public Task<ApiResponse<OrderQueryBase<IReadOnlyList<OrderQueryRes>>>> OrderQueryAsyncWithHttpInfo(Symbol symbol)
        {
            var localVarPath = "/v2/private/order";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<OrderQueryBase<IReadOnlyList<OrderQueryRes>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Replace active order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <returns><see cref="OrderReplaceBase"/></returns>
        public OrderReplaceBase OrderReplace(Symbol symbol, string? orderId = null, string? orderLinkId = null, string? pRQty = null, string? pRPrice = null)
            => OrderReplaceWithHttpInfo(symbol, orderId, orderLinkId, pRQty, pRPrice).Data;

        /// <summary>
        /// Replace active order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <returns>ApiResponse of OrderReplaceBase</returns>
        public ApiResponse<OrderReplaceBase> OrderReplaceWithHttpInfo(Symbol symbol, string? orderId = null, string? orderLinkId = null, string? pRQty = null, string? pRPrice = null)
        {
            // FIXED : According to the document, 'orderId' or 'orderLinkId' is required.
            if (orderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'orderId' or 'orderLinkId' when calling OrderApi->OrderReplace");
            }

            var localVarPath = "/v2/private/order/replace";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", Configuration.ApiClient.ParameterToString(orderId)));
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

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<OrderReplaceBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Replace active order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <returns>Task of OrderReplaceBase</returns>
        public async Task<OrderReplaceBase> OrderReplaceAsync(Symbol symbol, string? orderId = null, string? orderLinkId = null, string? pRQty = null, string? pRPrice = null)
            => (await OrderReplaceAsyncWithHttpInfo(symbol, orderId, orderLinkId, pRQty, pRPrice)).Data;

        /// <summary>
        /// Replace active order. Only incomplete orders can be modified.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <param name="orderId">Order ID. (optional)</param>
        /// <param name="orderLinkId">Order Link ID. (optional)</param>
        /// <param name="pRQty">Order quantity. (optional)</param>
        /// <param name="pRPrice">Order price. (optional)</param>
        /// <returns>Task of ApiResponse (OrderReplaceBase)</returns>
        public Task<ApiResponse<OrderReplaceBase>> OrderReplaceAsyncWithHttpInfo(Symbol symbol, string? orderId = null, string? orderLinkId = null, string? pRQty = null, string? pRPrice = null)
        {
            // FIXED : According to the document, 'orderId' or 'orderLinkId' is required.
            if (orderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'orderId' or 'orderLinkId' when calling OrderApi->OrderReplace");
            }

            var localVarPath = "/v2/private/order/replace";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", Configuration.ApiClient.ParameterToString(orderId)));
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

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<OrderReplaceBase>(localVarPath, Method.POST, localVarQueryParams);
        }
    }
}