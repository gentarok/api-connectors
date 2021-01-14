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
    public interface ILinearOrderApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Cancel Active Order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns><see cref="LinearOrderCancelBase"/></returns>
        LinearOrderCancelBase LinearOrderCancel(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Cancel Active Order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>ApiResponse of LinearOrderCancelBase</returns>
        ApiResponse<LinearOrderCancelBase> LinearOrderCancelWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Cancel all active orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns><see cref="LinearOrderCancelAllBase"/></returns>
        LinearOrderCancelAllBase LinearOrderCancelAll(LinearSymbol symbol);

        /// <summary>
        /// Cancel all active orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>ApiResponse of LinearOrderCancelAllBase</returns>
        ApiResponse<LinearOrderCancelAllBase> LinearOrderCancelAllWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Get linear Active Orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="orderStatus"> (optional)</param>
        /// <returns><see cref="LinearOrderGetOrdersBase"/></returns>
        LinearOrderGetOrdersBase LinearOrderGetOrders(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearOrderStatus? orderStatus = null);

        /// <summary>
        /// Get linear Active Orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="orderStatus"> (optional)</param>
        /// <returns>ApiResponse of LinearOrderGetOrdersBase</returns>
        ApiResponse<LinearOrderGetOrdersBase> LinearOrderGetOrdersWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearOrderStatus? orderStatus = null);

        /// <summary>
        /// Create Active Order
        /// </summary>
        /// <remarks>
        /// This will create linear order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (reqired)</param>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderType"> (optional)</param>
        /// <param name="timeInForce"> (optional)</param>
        /// <param name="qty"> (optional)</param>
        /// <param name="price"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns><see cref="LinearOrderNewBase"/></returns>
        LinearOrderNewBase LinearOrderNew(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, LinearTimeInForce timeInForce, decimal qty, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Create Active Order
        /// </summary>
        /// <remarks>
        /// This will create linear order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (reqired)</param>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderType"> (optional)</param>
        /// <param name="timeInForce"> (optional)</param>
        /// <param name="qty"> (optional)</param>
        /// <param name="price"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>ApiResponse of LinearOrderNewBase</returns>
        ApiResponse<LinearOrderNewBase> LinearOrderNewWithHttpInfo(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, LinearTimeInForce timeInForce, decimal qty, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Get Active Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear active orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>LinearOrderQueryBase of LinearOrderQueryRes</returns>
        LinearOrderQueryBase<LinearOrderQueryRes> LinearOrderQuery(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get Active Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear active orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>ApiResponse of LinearOrderQueryBase (LinearOrderQueryRes)</returns>
        ApiResponse<LinearOrderQueryBase<LinearOrderQueryRes>> LinearOrderQueryWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get Active Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear active orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>LinearOrderQueryBase of List (LinearOrderQueryRes)</returns>
        LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>> LinearOrderQuery(LinearSymbol symbol);

        /// <summary>
        /// Get Active Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear active orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>ApiResponse of LinearOrderQueryBase (List of LinearOrderQueryRes)</returns>
        ApiResponse<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>> LinearOrderQueryWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Replace Active Order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <returns><see cref="LinearOrderReplaceBase"/></returns>
        LinearOrderReplaceBase LinearOrderReplace(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null);

        /// <summary>
        /// Replace Active Order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <returns>ApiResponse of LinearOrderReplaceBase</returns>
        ApiResponse<LinearOrderReplaceBase> LinearOrderReplaceWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Cancel Active Order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>Task of LinearOrderCancelBase</returns>
        Task<LinearOrderCancelBase> LinearOrderCancelAsync(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Cancel Active Order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearOrderCancelBase)</returns>
        Task<ApiResponse<LinearOrderCancelBase>> LinearOrderCancelAsyncWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Cancel all active orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of LinearOrderCancelAllBase</returns>
        Task<LinearOrderCancelAllBase> LinearOrderCancelAllAsync(LinearSymbol symbol);

        /// <summary>
        /// Cancel all active orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of ApiResponse (LinearOrderCancelAllBase)</returns>
        Task<ApiResponse<LinearOrderCancelAllBase>> LinearOrderCancelAllAsyncWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Get linear Active Orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="orderStatus"> (optional)</param>
        /// <returns>Task of LinearOrderGetOrdersBase</returns>
        Task<LinearOrderGetOrdersBase> LinearOrderGetOrdersAsync(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearOrderStatus? orderStatus = null);

        /// <summary>
        /// Get linear Active Orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="orderStatus"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearOrderGetOrdersBase)</returns>
        Task<ApiResponse<LinearOrderGetOrdersBase>> LinearOrderGetOrdersAsyncWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearOrderStatus? orderStatus = null);

        /// <summary>
        /// Create Active Order
        /// </summary>
        /// <remarks>
        /// This will create linear order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (required)</param>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderType"> (optional)</param>
        /// <param name="timeInForce"> (optional)</param>
        /// <param name="qty"> (optional)</param>
        /// <param name="price"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>Task of LinearOrderNewBase</returns>
        Task<LinearOrderNewBase> LinearOrderNewAsync(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, LinearTimeInForce timeInForce, decimal qty, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Create Active Order
        /// </summary>
        /// <remarks>
        /// This will create linear order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-placeactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (required)</param>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderType"> (optional)</param>
        /// <param name="timeInForce"> (optional)</param>
        /// <param name="qty"> (optional)</param>
        /// <param name="price"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearOrderNewBase)</returns>
        Task<ApiResponse<LinearOrderNewBase>> LinearOrderNewAsyncWithHttpInfo(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, LinearTimeInForce timeInForce, decimal qty, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null);

        /// <summary>
        /// Get Active Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear active orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>Task of LinearOrderQueryBase (LinearOrderQueryRes)</returns>
        Task<LinearOrderQueryBase<LinearOrderQueryRes>> LinearOrderQueryAsync(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get Active Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear active orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearOrderQueryBase of LinearOrderQueryRes)</returns>
        Task<ApiResponse<LinearOrderQueryBase<LinearOrderQueryRes>>> LinearOrderQueryAsyncWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get Active Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear active orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of LinearOrderQueryBase (List of LinearOrderQueryRes)</returns>
        Task<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>> LinearOrderQueryAsync(LinearSymbol symbol);

        /// <summary>
        /// Get Active Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear active orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-queryactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearOrderQueryBase of List (LinearOrderQueryRes))</returns>
        Task<ApiResponse<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>>> LinearOrderQueryAsyncWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Replace Active Order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <returns>Task of LinearOrderReplaceBase</returns>
        Task<LinearOrderReplaceBase> LinearOrderReplaceAsync(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null);

        /// <summary>
        /// Replace Active Order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replaceactive"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="orderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearOrderReplaceBase)</returns>
        Task<ApiResponse<LinearOrderReplaceBase>> LinearOrderReplaceAsyncWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class LinearOrderApi : ApiBase, ILinearOrderApi
    {
        private const int LinearOrderGetOrdersLimitMaxValue = 50;

        public LinearOrderApi(string basePath) : base(basePath)
        {
        }

        public LinearOrderApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public LinearOrderCancelBase LinearOrderCancel(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null)
            => LinearOrderCancelWithHttpInfo(symbol, orderId, orderLinkId).Data;

        public ApiResponse<LinearOrderCancelBase> LinearOrderCancelWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null)
        {
            // Note : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            // see: https://bybit-exchange.github.io/docs/linear/#t-cancelactive
            if (orderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling LinearOrderApi->LinearOrderCancel");
            }

            var localVarPath = "/private/linear/order/cancel";
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

            return CallApiWithHttpInfo<LinearOrderCancelBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<LinearOrderCancelBase> LinearOrderCancelAsync(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null)
            => (await LinearOrderCancelAsyncWithHttpInfo(symbol, orderId, orderLinkId)).Data;

        public Task<ApiResponse<LinearOrderCancelBase>> LinearOrderCancelAsyncWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null)
        {
            // Note : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            // see: https://bybit-exchange.github.io/docs/linear/#t-cancelactive
            if (orderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling LinearOrderApi->LinearOrderCancel");
            }

            var localVarPath = "/private/linear/order/cancel";
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

            return CallApiAsyncWithHttpInfo<LinearOrderCancelBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public LinearOrderCancelAllBase LinearOrderCancelAll(LinearSymbol symbol)
            => LinearOrderCancelAllWithHttpInfo(symbol).Data;

        public ApiResponse<LinearOrderCancelAllBase> LinearOrderCancelAllWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/order/cancel-all";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearOrderCancelAllBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<LinearOrderCancelAllBase> LinearOrderCancelAllAsync(LinearSymbol symbol)
            => (await LinearOrderCancelAllAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<LinearOrderCancelAllBase>> LinearOrderCancelAllAsyncWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/order/cancel-all";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearOrderCancelAllBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public LinearOrderGetOrdersBase LinearOrderGetOrders(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearOrderStatus? orderStatus = null)
            => LinearOrderGetOrdersWithHttpInfo(symbol, orderId, orderLinkId, order, page, limit, orderStatus).Data;

        public ApiResponse<LinearOrderGetOrdersBase> LinearOrderGetOrdersWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearOrderStatus? orderStatus = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearOrderGetOrdersLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearOrderApi->LinearOrderGetOrders");
            }

            var localVarPath = "/private/linear/order/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", orderId));
            }

            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", orderLinkId));
            }

            if (order is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order));
            }

            if (page is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            if (orderStatus is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_status", orderStatus));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearOrderGetOrdersBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearOrderGetOrdersBase> LinearOrderGetOrdersAsync(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearOrderStatus? orderStatus = null)
            => (await LinearOrderGetOrdersAsyncWithHttpInfo(symbol, orderId, orderLinkId, order, page, limit, orderStatus)).Data;

        public Task<ApiResponse<LinearOrderGetOrdersBase>> LinearOrderGetOrdersAsyncWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearOrderStatus? orderStatus = null)
        {
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearOrderGetOrdersLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearOrderApi->LinearOrderGetOrders");
            }

            var localVarPath = "/private/linear/order/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", orderId));
            }

            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", orderLinkId));
            }

            if (order is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order));
            }

            if (page is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            if (orderStatus is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_status", orderStatus));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearOrderGetOrdersBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public LinearOrderNewBase LinearOrderNew(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, LinearTimeInForce timeInForce, decimal qty, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null)
            => LinearOrderNewWithHttpInfo(side, symbol, orderType, timeInForce, qty, price, takeProfit, stopLoss, reduceOnly, tpTriggerBy, slTriggerBy, closeOnTrigger, orderLinkId).Data;

        public ApiResponse<LinearOrderNewBase> LinearOrderNewWithHttpInfo(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, LinearTimeInForce timeInForce, decimal qty, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null)
        {
            //// verify the parameter 'qty'
            //if (qty % 0.5m is not 0)
            //{
            //    throw new ApiException(400, "Validation error on 'qty' parameter occured when calling LinearOrderApi->LinearOrderNew");
            //}
            // verify the parameter 'price'
            if (orderType is LinearOrderType.Limit && price is null)
            {
                throw new ApiException(400, "Validation error on 'price' parameter occured when calling LinearOrderApi->LinearOrderNew");
            }

            var localVarPath = "/private/linear/order/create";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_type", Configuration.ApiClient.ParameterToString(orderType)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "time_in_force", Configuration.ApiClient.ParameterToString(timeInForce)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "qty", Configuration.ApiClient.ParameterToString(qty)));

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

            if (tpTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_trigger_by", Configuration.ApiClient.ParameterToString(tpTriggerBy)));
            }

            if (slTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_trigger_by", Configuration.ApiClient.ParameterToString(slTriggerBy)));
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

            return CallApiWithHttpInfo<LinearOrderNewBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<LinearOrderNewBase> LinearOrderNewAsync(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, LinearTimeInForce timeInForce, decimal qty, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null)
            => (await LinearOrderNewAsyncWithHttpInfo(side, symbol, orderType, timeInForce, qty, price, takeProfit, stopLoss, reduceOnly, tpTriggerBy, slTriggerBy, closeOnTrigger, orderLinkId)).Data;

        public Task<ApiResponse<LinearOrderNewBase>> LinearOrderNewAsyncWithHttpInfo(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, LinearTimeInForce timeInForce, decimal qty, decimal? price = null, decimal? takeProfit = null, decimal? stopLoss = null, bool? reduceOnly = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, bool? closeOnTrigger = null, string? orderLinkId = null)
        {
            // verify the parameter 'price'
            if (orderType is LinearOrderType.Limit && price is null)
            {
                throw new ApiException(400, "Validation error on 'pric' parameter occured when calling LinearOrderApi->LinearOrderNew");
            }

            var localVarPath = "/private/linear/order/create";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_type", Configuration.ApiClient.ParameterToString(orderType)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "time_in_force", Configuration.ApiClient.ParameterToString(timeInForce)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "qty", Configuration.ApiClient.ParameterToString(qty)));

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

            if (tpTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_trigger_by", Configuration.ApiClient.ParameterToString(tpTriggerBy)));
            }

            if (slTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_trigger_by", Configuration.ApiClient.ParameterToString(slTriggerBy)));
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

            return CallApiAsyncWithHttpInfo<LinearOrderNewBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public LinearOrderQueryBase<LinearOrderQueryRes> LinearOrderQuery(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null)
            => LinearOrderQueryWithHttpInfo(symbol, orderId, orderLinkId).Data;

        public ApiResponse<LinearOrderQueryBase<LinearOrderQueryRes>> LinearOrderQueryWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null)
        {
            var localVarPath = "/private/linear/order/search";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", orderId));
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

            return CallApiWithHttpInfo<LinearOrderQueryBase<LinearOrderQueryRes>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearOrderQueryBase<LinearOrderQueryRes>> LinearOrderQueryAsync(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null)
            => (await LinearOrderQueryAsyncWithHttpInfo(symbol, orderId, orderLinkId)).Data;

        public Task<ApiResponse<LinearOrderQueryBase<LinearOrderQueryRes>>> LinearOrderQueryAsyncWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null)
        {
            var localVarPath = "/private/linear/order/search";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            if (orderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_id", orderId));
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

            return CallApiAsyncWithHttpInfo<LinearOrderQueryBase<LinearOrderQueryRes>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>> LinearOrderQuery(LinearSymbol symbol)
            => LinearOrderQueryWithHttpInfo(symbol).Data;

        public ApiResponse<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>> LinearOrderQueryWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/order/search";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>> LinearOrderQueryAsync(LinearSymbol symbol)
            => (await LinearOrderQueryAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>>> LinearOrderQueryAsyncWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/order/search";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearOrderQueryBase<IReadOnlyList<LinearOrderQueryRes>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public LinearOrderReplaceBase LinearOrderReplace(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null)
            => LinearOrderReplaceWithHttpInfo(symbol, orderId, orderLinkId, pRQty, pRPrice).Data;

        public ApiResponse<LinearOrderReplaceBase> LinearOrderReplaceWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null)
        {
            var localVarPath = "/private/linear/order/replace";
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

            return CallApiWithHttpInfo<LinearOrderReplaceBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<LinearOrderReplaceBase> LinearOrderReplaceAsync(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null)
            => (await LinearOrderReplaceAsyncWithHttpInfo(symbol, orderId, orderLinkId, pRQty, pRPrice)).Data;

        public Task<ApiResponse<LinearOrderReplaceBase>> LinearOrderReplaceAsyncWithHttpInfo(LinearSymbol symbol, string? orderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null)
        {
            var localVarPath = "/private/linear/order/replace";
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

            return CallApiAsyncWithHttpInfo<LinearOrderReplaceBase>(localVarPath, Method.POST, localVarQueryParams);
        }
    }
}