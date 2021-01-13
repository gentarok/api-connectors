using System;
using System.Collections.Generic;
using System.Text;

namespace BybitAPI.Model
{
    /// <summary>
    /// Base type of the response for the 'Cancel Conditional Order' API method.
    /// </summary>
    public record LinearConditionalCancelBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LinearConditionalCancelRes? Result,
        string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Cancel Conditional Order' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// </remarks>
    public record LinearConditionalCancelRes(string StopOrderId);

    /// <summary>
    /// Base type of the response for the 'Cancel All Conditional Orders' API method.
    /// </summary>
    public record LinearConditionalCancelAllBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        IReadOnlyList<string>? Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    ///// <summary>
    ///// Actual data type of the response for the 'Cancel Conditional Order' API method.
    ///// </summary>
    ///// <remarks>
    ///// <para>
    ///// 'clOrdID' field is defined as a UUID, but as other UUID type fields may return an empty string and cannot be deserialized to GUID type, it is defined as a string type so that it can be treated like them.
    ///// </para>
    ///// <para>
    ///// 'trail_value' field is not defined in documentation, but actual API response returns it.
    ///// </para>
    ///// </remarks>
    //public record LinearConditionalCancelAllRes(string Clordid, long UserId, Symbol Symbol, Side Side, OrderType OrderType,
    //    decimal Price, decimal Qty, TimeInForce TimeInForce, CreateType CreateType, CancelType CancelType, OrderStatus? OrderStatus,
    //    decimal? LeavesValue, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, string CrossStatus, long CrossSeq,
    //    string StopOrderType, TriggerPriceType TriggerBy, decimal? BasePrice, decimal? TrailValue, string ExpectedDirection);

    /// <summary>
    /// Base type of the response for the 'Get Conditional Order' API method.
    /// </summary>
    public record LinearConditionalGetOrdersBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        LinearConditionalGetOrdersListBase? Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Collection type for the actual data type of the 'Get Conditional Order' API method response.
    /// </summary>
    public record LinearConditionalGetOrdersListBase(IReadOnlyList<LinearConditionalGetOrdersRes> Data, int CurrentPage, int LastPage);

    /// <summary>
    /// Actual data type of the response for the 'Get Conditional Order' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// </remarks>
    public record LinearConditionalGetOrdersRes(string StopOrderId, long UserId, LinearSymbol Symbol, LinearSide Side, LinearOrderType OrderType,
        decimal Price, decimal Qty, LinearTimeInForce TimeInForce, LinearStopOrderStatus StopOrderStatus, decimal TriggerPrice, string OrderLinkId,
        DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, decimal TakeProfit, decimal StopLoss, LinearTriggerPriceType TpTriggerBy, LinearTriggerPriceType SlTriggerBy,
        decimal BasePrice, LinearTriggerPriceType TriggerBy);

    /// <summary>
    /// Base type of the response for the 'Place Conditional Order' API method.
    /// </summary>
    public record LinearConditionalNewOrderBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        LinearConditionalNewOrderRes? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Place Conditional Order' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// </remarks>
    public record LinearConditionalNewOrderRes(string StopOrderId, long UserId, LinearSymbol Symbol, LinearSide Side, LinearOrderType OrderType,
        decimal Price, decimal Qty, LinearTimeInForce TimeInForce, LinearOrderStatus OrderStatus, decimal BasePrice, LinearTriggerPriceType TriggerBy,
        decimal TriggerPrice, string OrderLinkId, bool ReduceOnly, bool CloseOnTrigger, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt,
        LinearTriggerPriceType TpTriggerBy, LinearTriggerPriceType SlTriggerBy);

    /// <summary>
    /// Base type of the response for the 'Query Conditional Order (real-time)' API method.
    /// </summary>
    /// <remarks>
    /// 'Query Conditional Order (real-time)' method of the API returns different types of responses depending on the parameters of the method, so define a generic type and deserialize it.
    /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querycond"/>
    /// <seealso cref="https://bybit-exchange.github.io/docs/linear/#2020-12-03"/>
    /// </remarks>
    /// <typeparam name="T">'Result' proterty data type.</typeparam>
    public record LinearConditionalQueryBase<T>(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, T? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Query Conditional Order (real-time)' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// </remarks>
    public record LinearConditionalQueryRes(string StopOrderId, long UserId, LinearSymbol Symbol, LinearSide Side, LinearOrderType OrderType,
        decimal Price, decimal Qty, LinearTimeInForce TimeInForce, LinearOrderStatus OrderStatus, decimal TriggerPrice, string OrderLinkId,
        DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, decimal TakeProfit, decimal StopLoss, LinearTriggerPriceType TpTriggerBy,
        LinearTriggerPriceType SlTriggerBy, decimal BasePrice, LinearTriggerPriceType TriggerBy, bool ReduceOnly, bool CloseOnTrigger);

    /// <summary>
    /// Base type of the response for the 'Replace Conditional Order' API method.
    /// </summary>
    public record LinearConditionalReplaceBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LinearConditionalReplaceRes? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Replace Conditional Order' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// </remarks>
    public record LinearConditionalReplaceRes(string OrderId);

    /// <summary>
    /// Base type of the response for the 'User Trade Records' API method.
    /// </summary>
    public record LinearExecutionGetTradesBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LinearExecutionGetTradesListBase? Result,
        string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Collection type for the actual data type of the 'User Trade Records' API method response.
    /// </summary>
    public record LinearExecutionGetTradesListBase(int CurrentPage, IList<LinearExecutionGetTradesRes> Data);

    /// <summary>
    /// Actual data type of the response for the 'User Trade Records' API method.
    /// </summary>
    /// <remarks>
    /// ignore the 'price', 'trade_time' field because it is marked as 'abandoned' in the documentation.
    /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-usertraderecords"/>
    /// </remarks>
    public record LinearExecutionGetTradesRes(string OrderId, string OrderLinkId, LinearSide Side, string ExecId, decimal OrderPrice,
        decimal OrderQty, LinearOrderType OrderType, decimal FeeRate, decimal ExecPrice, LinearExecType ExecType, decimal ExecQty,
        decimal ExecFee, decimal ExecValue, decimal LeavesQty, decimal ClozedSize, LinearLiquidityType LastLiquidityInd, long TradeTimeMs);
}