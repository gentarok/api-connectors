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
    public interface ILinearConditionalApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Cancel Active Order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="symbol"> (optional)</param>
        /// <returns><see cref="LinearConditionalCancelBase"/></returns>
        LinearConditionalCancelBase LinearConditionalCancel(string? stopOrderId = null, string? orderLinkId = null, LinearSymbol? symbol = null);

        /// <summary>
        /// Cancel Active Order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="symbol"> (optional)</param>
        /// <returns>ApiResponse of LinearConditionalCancelBase</returns>
        ApiResponse<LinearConditionalCancelBase> LinearConditionalCancelWithHttpInfo(string? stopOrderId = null, string? orderLinkId = null, LinearSymbol? symbol = null);

        /// <summary>
        /// Cancel all stop orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns><see cref="LinearConditionalCancelAllBase"/></returns>
        LinearConditionalCancelAllBase LinearConditionalCancelAll(LinearSymbol symbol);

        /// <summary>
        /// Cancel all stop orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of LinearConditionalCancelAllBase</returns>
        ApiResponse<LinearConditionalCancelAllBase> LinearConditionalCancelAllWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Get linear Stop Orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (requaired)</param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="stopOrderStatus"> (optional)</param>
        /// <returns><see cref="LinearConditionalGetOrdersBase"/></returns>
        LinearConditionalGetOrdersBase LinearConditionalGetOrders(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearStopOrderStatus? stopOrderStatus = null);

        /// <summary>
        /// Get linear Stop Orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (requaired)</param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="stopOrderStatus"> (optional)</param>
        /// <returns>ApiResponse of LinearConditionalGetOrdersBase</returns>
        ApiResponse<LinearConditionalGetOrdersBase> LinearConditionalGetOrdersWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearStopOrderStatus? stopOrderStatus = null);

        /// <summary>
        /// Create linear stop Order
        /// </summary>
        /// <remarks>
        /// This will create linear stop order
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (required)</param>
        /// <param name="symbol"> (required)</param>
        /// <param name="orderType"> (required)</param>
        /// <param name="qty"> (required)</param>
        /// <param name="price"> (required)</param>
        /// <param name="basePrice"> (required)</param>
        /// <param name="stopPx"> (required)</param>
        /// <param name="timeInForce"> (required)</param>
        /// <param name="triggerBy"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <returns><see cref="LinearConditionalNewOrderBase"/></returns>
        LinearConditionalNewOrderBase LinearConditionalNew(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, decimal qty, decimal basePrice, decimal stopPx, LinearTimeInForce timeInForce, decimal? price = null, LinearTriggerPriceType? triggerBy = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null, decimal? takeProfit = null, decimal? stopLoss = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null);

        /// <summary>
        /// Create linear stop Order
        /// </summary>
        /// <remarks>
        /// This will create linear stop order
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (required)</param>
        /// <param name="symbol"> (required)</param>
        /// <param name="orderType"> (required)</param>
        /// <param name="qty"> (required)</param>
        /// <param name="price"> (required)</param>
        /// <param name="basePrice"> (required)</param>
        /// <param name="stopPx"> (required)</param>
        /// <param name="timeInForce"> (required)</param>
        /// <param name="triggerBy"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <returns>ApiResponse of LinearConditionalNewOrderBase</returns>
        ApiResponse<LinearConditionalNewOrderBase> LinearConditionalNewWithHttpInfo(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, decimal qty, decimal basePrice, decimal stopPx, LinearTimeInForce timeInForce, decimal? price = null, LinearTriggerPriceType? triggerBy = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null, decimal? takeProfit = null, decimal? stopLoss = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null);

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>LinearConditionalQueryBase of LinearConditionalQueryRes</returns>
        LinearConditionalQueryBase<LinearConditionalQueryRes> LinearConditionalQuery(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>ApiResponse of LinearConditionalQueryBase (LinearConditionalQueryRes)</returns>
        ApiResponse<LinearConditionalQueryBase<LinearConditionalQueryRes>> LinearConditionalQueryWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <returns>LinearConditionalQueryBase of List (LinearConditionalQueryRes)</returns>
        LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>> LinearConditionalQuery(LinearSymbol symbol);

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">)</param>
        /// <returns>ApiResponse of LinearConditionalQueryBase (List of LinearConditionalQueryRes)</returns>
        ApiResponse<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>> LinearConditionalQueryWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Replace conditional order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <param name="pRTriggerPrice"> (optional)</param>
        /// <returns><see cref="LinearConditionalReplaceBase"/></returns>
        LinearConditionalReplaceBase LinearConditionalReplace(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null);

        /// <summary>
        /// Replace conditional order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <param name="pRTriggerPrice"> (optional)</param>
        /// <returns>ApiResponse of LinearConditionalReplaceBase</returns>
        ApiResponse<LinearConditionalReplaceBase> LinearConditionalReplaceWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Cancel Active Order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="symbol"> (optional)</param>
        /// <returns>Task of LinearConditionalCancelBase</returns>
        Task<LinearConditionalCancelBase> LinearConditionalCancelAsync(string? stopOrderId = null, string? orderLinkId = null, LinearSymbol? symbol = null);

        /// <summary>
        /// Cancel Active Order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="symbol"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearConditionalCancelBase)</returns>
        Task<ApiResponse<LinearConditionalCancelBase>> LinearConditionalCancelAsyncWithHttpInfo(string? stopOrderId = null, string? orderLinkId = null, LinearSymbol? symbol = null);

        /// <summary>
        /// Cancel all stop orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of LinearConditionalCancelAllBase</returns>
        Task<LinearConditionalCancelAllBase> LinearConditionalCancelAllAsync(LinearSymbol symbol);

        /// <summary>
        /// Cancel all stop orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (LinearConditionalCancelAllBase)</returns>
        Task<ApiResponse<LinearConditionalCancelAllBase>> LinearConditionalCancelAllAsyncWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Get linear Stop Orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (requaired)</param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="stopOrderStatus"> (optional)</param>
        /// <returns>Task of LinearConditionalGetOrdersBase</returns>
        Task<LinearConditionalGetOrdersBase> LinearConditionalGetOrdersAsync(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearStopOrderStatus? stopOrderStatus = null);

        /// <summary>
        /// Get linear Stop Orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (requaired)</param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="stopOrderStatus"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearConditionalGetOrdersBase)</returns>
        Task<ApiResponse<LinearConditionalGetOrdersBase>> LinearConditionalGetOrdersAsyncWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearStopOrderStatus? stopOrderStatus = null);

        /// <summary>
        /// Create linear stop Order
        /// </summary>
        /// <remarks>
        /// This will create linear stop order
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (required)</param>
        /// <param name="symbol"> (required)</param>
        /// <param name="orderType"> (required)</param>
        /// <param name="qty"> (required)</param>
        /// <param name="price"> (required)</param>
        /// <param name="basePrice"> (required)</param>
        /// <param name="stopPx"> (required)</param>
        /// <param name="timeInForce"> (required)</param>
        /// <param name="triggerBy"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <returns>Task of LinearConditionalNewOrderBase</returns>
        Task<LinearConditionalNewOrderBase> LinearConditionalNewAsync(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, decimal qty, decimal basePrice, decimal stopPx, LinearTimeInForce timeInForce, decimal? price = null, LinearTriggerPriceType? triggerBy = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null, decimal? takeProfit = null, decimal? stopLoss = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null);

        /// <summary>
        /// Create linear stop Order
        /// </summary>
        /// <remarks>
        /// This will create linear stop order
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (required)</param>
        /// <param name="symbol"> (required)</param>
        /// <param name="orderType"> (required)</param>
        /// <param name="qty"> (required)</param>
        /// <param name="price"> (required)</param>
        /// <param name="basePrice"> (required)</param>
        /// <param name="stopPx"> (required)</param>
        /// <param name="timeInForce"> (required)</param>
        /// <param name="triggerBy"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearConditionalNewOrderBase)</returns>
        Task<ApiResponse<LinearConditionalNewOrderBase>> LinearConditionalNewAsyncWithHttpInfo(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, decimal qty, decimal basePrice, decimal stopPx, LinearTimeInForce timeInForce, decimal? price = null, LinearTriggerPriceType? triggerBy = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null, decimal? takeProfit = null, decimal? stopLoss = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null);

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>Task of LinearConditionalQueryBase (LinearConditionalQueryRes)</returns>
        Task<LinearConditionalQueryBase<LinearConditionalQueryRes>> LinearConditionalQueryAsync(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearConditionalQueryBase of LinearConditionalQueryRes)</returns>
        Task<ApiResponse<LinearConditionalQueryBase<LinearConditionalQueryRes>>> LinearConditionalQueryAsyncWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null);

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <returns>Task of LinearConditionalQueryBase (List of LinearConditionalQueryRes)</returns>
        Task<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>> LinearConditionalQueryAsync(LinearSymbol symbol);

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <returns>Task of ApiResponse (LinearConditionalQueryBase of List (LinearConditionalQueryRes))</returns>
        Task<ApiResponse<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>>> LinearConditionalQueryAsyncWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Replace conditional order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <param name="pRTriggerPrice"> (optional)</param>
        /// <returns>Task of LinearConditionalReplaceBase</returns>
        Task<LinearConditionalReplaceBase> LinearConditionalReplaceAsync(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null);

        /// <summary>
        /// Replace conditional order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <param name="pRTriggerPrice"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearConditionalReplaceBase)</returns>
        Task<ApiResponse<LinearConditionalReplaceBase>> LinearConditionalReplaceAsyncWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LinearConditionalApi : ApiBase, ILinearConditionalApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinearConditionalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LinearConditionalApi(string basePath) : base(basePath) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinearConditionalApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LinearConditionalApi(Configuration? configuration = null) : base(configuration) { }

        /// <summary>
        /// Cancel Active Order This will cancel linear active order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="symbol"> (optional)</param>
        /// <returns><see cref="LinearConditionalCancelBase"/></returns>
        public LinearConditionalCancelBase LinearConditionalCancel(string? stopOrderId = null, string? orderLinkId = null, LinearSymbol? symbol = null)
            => LinearConditionalCancelWithHttpInfo(stopOrderId, orderLinkId, symbol).Data;

        /// <summary>
        /// Cancel Active Order This will cancel linear active order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="symbol"> (optional)</param>
        /// <returns>ApiResponse of LinearConditionalCancelBase</returns>
        public ApiResponse<LinearConditionalCancelBase> LinearConditionalCancelWithHttpInfo(string? stopOrderId = null, string? orderLinkId = null, LinearSymbol? symbol = null)
        {
            // Note : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            // see: https://bybit-exchange.github.io/docs/linear/#t-cancelcond
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling ConditionalApi->ConditionalCancel");
            }

            var localVarPath = "/private/linear/stop-order/cancel";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (stopOrderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_id", Configuration.ApiClient.ParameterToString(stopOrderId)));
            }

            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", Configuration.ApiClient.ParameterToString(orderLinkId)));
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearConditionalCancelBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Cancel Active Order This will cancel linear active order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="symbol"> (optional)</param>
        /// <returns>Task of LinearConditionalCancelBase</returns>
        public async Task<LinearConditionalCancelBase> LinearConditionalCancelAsync(string? stopOrderId = null, string? orderLinkId = null, LinearSymbol? symbol = null)
            => (await LinearConditionalCancelAsyncWithHttpInfo(stopOrderId, orderLinkId, symbol)).Data;

        /// <summary>
        /// Cancel Active Order This will cancel linear active order
        /// </summary>
        /// <remarks>
        /// This will cancel linear active order
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="symbol"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearConditionalCancelBase)</returns>
        public Task<ApiResponse<LinearConditionalCancelBase>> LinearConditionalCancelAsyncWithHttpInfo(string? stopOrderId = null, string? orderLinkId = null, LinearSymbol? symbol = null)
        {
            // Note : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            // see: https://bybit-exchange.github.io/docs/linear/#t-cancelcond
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling ConditionalApi->ConditionalCancel");
            }

            var localVarPath = "/private/linear/stop-order/cancel";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            if (stopOrderId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_id", Configuration.ApiClient.ParameterToString(stopOrderId)));
            }

            if (orderLinkId is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_link_id", Configuration.ApiClient.ParameterToString(orderLinkId)));
            }

            if (symbol is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearConditionalCancelBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Cancel all stop orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns><see cref="LinearConditionalCancelAllBase"/></returns>
        public LinearConditionalCancelAllBase LinearConditionalCancelAll(LinearSymbol symbol)
            => LinearConditionalCancelAllWithHttpInfo(symbol).Data;

        /// <summary>
        /// Cancel all stop orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>ApiResponse of LinearConditionalCancelAllBase</returns>
        public ApiResponse<LinearConditionalCancelAllBase> LinearConditionalCancelAllWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/stop-order/cancel-all";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearConditionalCancelAllBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Cancel all stop orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of LinearConditionalCancelAllBase</returns>
        public async Task<LinearConditionalCancelAllBase> LinearConditionalCancelAllAsync(LinearSymbol symbol)
            => (await LinearConditionalCancelAllAsyncWithHttpInfo(symbol)).Data;

        /// <summary>
        /// Cancel all stop orders.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-cancelallcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Contract type.</param>
        /// <returns>Task of ApiResponse (LinearConditionalCancelAllBase)</returns>
        public Task<ApiResponse<LinearConditionalCancelAllBase>> LinearConditionalCancelAllAsyncWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/stop-order/cancel-all";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearConditionalCancelAllBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Get linear Stop Orders This will get linear active orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (requaired)</param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="stopOrderStatus"> (optional)</param>
        /// <returns><see cref="LinearConditionalGetOrdersBase"/></returns>
        public LinearConditionalGetOrdersBase LinearConditionalGetOrders(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearStopOrderStatus? stopOrderStatus = null)
            => LinearConditionalGetOrdersWithHttpInfo(symbol, stopOrderId, orderLinkId, order, page, limit, stopOrderStatus).Data;

        /// <summary>
        /// Get linear Stop Orders This will get linear active orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (required)</param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="stopOrderStatus"> (optional)</param>
        /// <returns>ApiResponse of LinearConditionalGetOrdersBase</returns>
        public ApiResponse<LinearConditionalGetOrdersBase> LinearConditionalGetOrdersWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearStopOrderStatus? stopOrderStatus = null)
        {
            var localVarPath = "/private/linear/stop-order/list";
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

            if (stopOrderStatus is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_status", stopOrderStatus));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearConditionalGetOrdersBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get linear Stop Orders This will get linear active orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (required)</param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="stopOrderStatus"> (optional)</param>
        /// <returns>Task of LinearConditionalGetOrdersBase</returns>
        public async Task<LinearConditionalGetOrdersBase> LinearConditionalGetOrdersAsync(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearStopOrderStatus? stopOrderStatus = null)
            => (await LinearConditionalGetOrdersAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId, order, page, limit, stopOrderStatus)).Data;

        /// <summary>
        /// Get linear Stop Orders This will get linear active orders
        /// </summary>
        /// <remarks>
        /// This will get linear active orders
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-getcond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"> (required)</param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="order"> (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="stopOrderStatus"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearConditionalGetOrdersBase)</returns>
        public Task<ApiResponse<LinearConditionalGetOrdersBase>> LinearConditionalGetOrdersAsyncWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, LinearOrder? order = null, int? page = null, int? limit = null, LinearStopOrderStatus? stopOrderStatus = null)
        {
            var localVarPath = "/private/linear/stop-order/list";
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

            if (stopOrderStatus is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_order_status", stopOrderStatus));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearConditionalGetOrdersBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Create linear stop Order This will create linear stop order
        /// </summary>
        /// <remarks>
        /// This will create linear stop order
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (required)</param>
        /// <param name="symbol"> (required)</param>
        /// <param name="orderType"> (required)</param>
        /// <param name="qty"> (required)</param>
        /// <param name="price"> (required)</param>
        /// <param name="basePrice"> (required)</param>
        /// <param name="stopPx"> (required)</param>
        /// <param name="timeInForce"> (required)</param>
        /// <param name="triggerBy"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <returns><see cref="LinearConditionalNewOrderBase"/></returns>
        public LinearConditionalNewOrderBase LinearConditionalNew(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, decimal qty, decimal basePrice, decimal stopPx, LinearTimeInForce timeInForce, decimal? price = null, LinearTriggerPriceType? triggerBy = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null, decimal? takeProfit = null, decimal? stopLoss = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null)
            => LinearConditionalNewWithHttpInfo(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, reduceOnly, closeOnTrigger, orderLinkId, takeProfit, stopLoss, tpTriggerBy, slTriggerBy).Data;

        /// <summary>
        /// Create linear stop Order This will create linear stop order
        /// </summary>
        /// <remarks>
        /// This will create linear stop order
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (required)</param>
        /// <param name="symbol"> (required)</param>
        /// <param name="orderType"> (required)</param>
        /// <param name="qty"> (required)</param>
        /// <param name="price"> (required)</param>
        /// <param name="basePrice"> (required)</param>
        /// <param name="stopPx"> (required)</param>
        /// <param name="timeInForce"> (required)</param>
        /// <param name="triggerBy"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <returns>ApiResponse of LinearConditionalNewOrderBase</returns>
        public ApiResponse<LinearConditionalNewOrderBase> LinearConditionalNewWithHttpInfo(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, decimal qty, decimal basePrice, decimal stopPx, LinearTimeInForce timeInForce, decimal? price = null, LinearTriggerPriceType? triggerBy = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null, decimal? takeProfit = null, decimal? stopLoss = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null)
        {
            var localVarPath = "/private/linear/stop-order/create";
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

            if (takeProfit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "take_profit", Configuration.ApiClient.ParameterToString(takeProfit)));
            }

            if (stopLoss is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_loss", Configuration.ApiClient.ParameterToString(stopLoss)));
            }

            if (tpTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_trigger_by", Configuration.ApiClient.ParameterToString(tpTriggerBy)));
            }

            if (slTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_trigger_by", Configuration.ApiClient.ParameterToString(slTriggerBy)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearConditionalNewOrderBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Create linear stop Order This will create linear stop order
        /// </summary>
        /// <remarks>
        /// This will create linear stop order
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (required)</param>
        /// <param name="symbol"> (required)</param>
        /// <param name="orderType"> (required)</param>
        /// <param name="qty"> (required)</param>
        /// <param name="price"> (required)</param>
        /// <param name="basePrice"> (required)</param>
        /// <param name="stopPx"> (required)</param>
        /// <param name="timeInForce"> (required)</param>
        /// <param name="triggerBy"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <returns>Task of LinearConditionalNewOrderBase</returns>
        public async Task<LinearConditionalNewOrderBase> LinearConditionalNewAsync(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, decimal qty, decimal basePrice, decimal stopPx, LinearTimeInForce timeInForce, decimal? price = null, LinearTriggerPriceType? triggerBy = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null, decimal? takeProfit = null, decimal? stopLoss = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null)
            => (await LinearConditionalNewAsyncWithHttpInfo(side, symbol, orderType, qty, basePrice, stopPx, timeInForce, price, triggerBy, reduceOnly, closeOnTrigger, orderLinkId, takeProfit, stopLoss, tpTriggerBy, slTriggerBy)).Data;

        /// <summary>
        /// Create linear stop Order This will create linear stop order
        /// </summary>
        /// <remarks>
        /// This will create linear stop order
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-placecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="side"> (required)</param>
        /// <param name="symbol"> (required)</param>
        /// <param name="orderType"> (required)</param>
        /// <param name="qty"> (required)</param>
        /// <param name="price"> (required)</param>
        /// <param name="basePrice"> (required)</param>
        /// <param name="stopPx"> (required)</param>
        /// <param name="timeInForce"> (required)</param>
        /// <param name="triggerBy"> (optional)</param>
        /// <param name="reduceOnly"> (optional)</param>
        /// <param name="closeOnTrigger"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="takeProfit"> (optional)</param>
        /// <param name="stopLoss"> (optional)</param>
        /// <param name="tpTriggerBy"> (optional)</param>
        /// <param name="slTriggerBy"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearConditionalNewOrderBase)</returns>
        public Task<ApiResponse<LinearConditionalNewOrderBase>> LinearConditionalNewAsyncWithHttpInfo(LinearSide side, LinearSymbol symbol, LinearOrderType orderType, decimal qty, decimal basePrice, decimal stopPx, LinearTimeInForce timeInForce, decimal? price = null, LinearTriggerPriceType? triggerBy = null, bool? reduceOnly = null, bool? closeOnTrigger = null, string? orderLinkId = null, decimal? takeProfit = null, decimal? stopLoss = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null)
        {
            var localVarPath = "/private/linear/stop-order/create";
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

            if (takeProfit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "take_profit", Configuration.ApiClient.ParameterToString(takeProfit)));
            }

            if (stopLoss is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_loss", Configuration.ApiClient.ParameterToString(stopLoss)));
            }

            if (tpTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_trigger_by", Configuration.ApiClient.ParameterToString(tpTriggerBy)));
            }

            if (slTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_trigger_by", Configuration.ApiClient.ParameterToString(slTriggerBy)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearConditionalNewOrderBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Get Stop Orders(real-time) This will get linear stop orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">)</param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>LinearConditionalQueryBase of LinearConditionalQueryRes</returns>
        public LinearConditionalQueryBase<LinearConditionalQueryRes> LinearConditionalQuery(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null)
            => LinearConditionalQueryWithHttpInfo(symbol, stopOrderId, orderLinkId).Data;

        /// <summary>
        /// Get Stop Orders(real-time) This will get linear stop orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>ApiResponse of LinearConditionalQueryBase (LinearConditionalQueryRes)</returns>
        public ApiResponse<LinearConditionalQueryBase<LinearConditionalQueryRes>> LinearConditionalQueryWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null)
        {
            // Note : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling LinearConditionalApi->LinearConditionalQuery");
            }

            var localVarPath = "/private/linear/stop-order/search";
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

            return CallApiWithHttpInfo<LinearConditionalQueryBase<LinearConditionalQueryRes>>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get Stop Orders(real-time) This will get linear stop orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>Task of LinearConditionalQueryBase (LinearConditionalQueryRes)</returns>
        public async Task<LinearConditionalQueryBase<LinearConditionalQueryRes>> LinearConditionalQueryAsync(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null)
            => (await LinearConditionalQueryAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId)).Data;

        /// <summary>
        /// Get Stop Orders(real-time) This will get linear stop orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearConditionalQueryBase of LinearConditionalQueryRes)</returns>
        public Task<ApiResponse<LinearConditionalQueryBase<LinearConditionalQueryRes>>> LinearConditionalQueryAsyncWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null)
        {
            // Note : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling LinearConditionalApi->LinearConditionalQuery");
            }

            var localVarPath = "/private/linear/stop-order/search";
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

            return CallApiAsyncWithHttpInfo<LinearConditionalQueryBase<LinearConditionalQueryRes>>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <returns>LinearConditionalQueryBase of List (LinearConditionalQueryRes)</returns>
        public LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>> LinearConditionalQuery(LinearSymbol symbol)
            => LinearConditionalQueryWithHttpInfo(symbol).Data;

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">)</param>
        /// <returns>ApiResponse of LinearConditionalQueryBase (List of LinearConditionalQueryRes)</returns>
        public ApiResponse<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>> LinearConditionalQueryWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/stop-order/search";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <returns>Task of LinearConditionalQueryBase (List of LinearConditionalQueryRes)</returns>
        public async Task<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>> LinearConditionalQueryAsync(LinearSymbol symbol)
            => (await LinearConditionalQueryAsyncWithHttpInfo(symbol)).Data;

        /// <summary>
        /// Get Stop Orders(real-time)
        /// </summary>
        /// <remarks>
        /// This will get linear stop orders(real-time)
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <returns>Task of ApiResponse (LinearConditionalQueryBase of List (LinearConditionalQueryRes))</returns>
        public Task<ApiResponse<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>>> LinearConditionalQueryAsyncWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/stop-order/search";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearConditionalQueryBase<IReadOnlyList<LinearConditionalQueryRes>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        /// <summary>
        /// Replace conditional order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <param name="pRTriggerPrice"> (optional)</param>
        /// <returns><see cref="LinearConditionalReplaceBase"/></returns>
        public LinearConditionalReplaceBase LinearConditionalReplace(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null)
            => LinearConditionalReplaceWithHttpInfo(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice).Data;

        /// <summary>
        /// Replace conditional order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <param name="pRTriggerPrice"> (optional)</param>
        /// <returns>ApiResponse of LinearConditionalReplaceBase</returns>
        public ApiResponse<LinearConditionalReplaceBase> LinearConditionalReplaceWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null)
        {
            // Note : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling LinearConditionalApi->LinearConditionalReplace");
            }

            var localVarPath = "/private/linear/stop-order/replace";
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

            return CallApiWithHttpInfo<LinearConditionalReplaceBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        /// <summary>
        /// Replace conditional order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <param name="pRTriggerPrice"> (optional)</param>
        /// <returns>Task of LinearConditionalReplaceBase</returns>
        public async Task<LinearConditionalReplaceBase> LinearConditionalReplaceAsync(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null)
            => (await LinearConditionalReplaceAsyncWithHttpInfo(symbol, stopOrderId, orderLinkId, pRQty, pRPrice, pRTriggerPrice)).Data;

        /// <summary>
        /// Replace conditional order
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-replacecond"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"></param>
        /// <param name="stopOrderId"> (optional)</param>
        /// <param name="orderLinkId"> (optional)</param>
        /// <param name="pRQty"> (optional)</param>
        /// <param name="pRPrice"> (optional)</param>
        /// <param name="pRTriggerPrice"> (optional)</param>
        /// <returns>Task of ApiResponse (LinearConditionalReplaceBase)</returns>
        public Task<ApiResponse<LinearConditionalReplaceBase>> LinearConditionalReplaceAsyncWithHttpInfo(LinearSymbol symbol, string? stopOrderId = null, string? orderLinkId = null, decimal? pRQty = null, decimal? pRPrice = null, decimal? pRTriggerPrice = null)
        {
            // Note : According to the document, 'stopOrderId' or 'orderLinkId' is required.
            if (stopOrderId is null && orderLinkId is null)
            {
                throw new ApiException(400, "Missing required parameter 'stopOrderId' or 'orderLinkId' when calling LinearConditionalApi->LinearConditionalReplace");
            }

            var localVarPath = "/private/linear/stop-order/replace";
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

            return CallApiAsyncWithHttpInfo<LinearConditionalReplaceBase>(localVarPath, Method.POST, localVarQueryParams);
        }
    }
}