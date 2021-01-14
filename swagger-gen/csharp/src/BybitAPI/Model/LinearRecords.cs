using System;
using System.Collections.Generic;

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
        decimal ExecFee, decimal ExecValue, decimal LeavesQty, decimal ClosedSize, LinearLiquidityType LastLiquidityInd, long TradeTimeMs);

    /// <summary>
    /// Base type of the response for the 'My Last Funding Fee' API method.
    /// </summary>
    /// <remarks>
    public record LinearFundingMyLastFeeBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LinearFundingMyLastFeeRes? Result,
        string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'My Last Funding Fee' API method.
    /// </summary>
    public record LinearFundingMyLastFeeRes(LinearSymbol Symbol, LinearSide Side, decimal Size, decimal FundingRate, decimal ExecFee,
        DateTimeOffset ExecTime);

    /// <summary>
    /// Base type of the response for the 'Predicted Funding Rate and My Funding Fee' API method.
    /// </summary>
    public record LinearFundingPredictedBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LinearFundingPredictedRes? Result,
        string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Predicted Funding Rate and My Funding Fee' API method.
    /// </summary>
    public record LinearFundingPredictedRes(decimal PredictedFundingRate, decimal PredictedFundingFee);

    /// <summary>
    /// Base type of the response for the 'Get the Last Funding Rate' API method.
    /// </summary>
    public record LinearFundingPrevRateBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LinearFundingPrevRateRes? Result,
        string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Get the Last Funding Rate' API method.
    /// </summary>
    public record LinearFundingPrevRateRes(LinearSymbol Symbol, decimal FundingRate, DateTimeOffset FundingRateTimestamp);

    /// <summary>
    /// Base type of the response for the 'Query Kline' API method.
    /// </summary>
    public record LinearKlineGetBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<LinearKlineGetRes>? Result,
        string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Query Kline' API method.
    /// </summary>
    /// <remarks>
    /// <para>
    /// ignore the 'start_at', 'open' field because it is marked as 'abandoned' in the documentation.
    /// </para>
    /// <para>
    /// 'open' field is marked as 'abandoned', but we leave it as no alternative field definition has been added.
    /// </para>
    /// <para>
    /// Caution!<br/>
    /// The description in the documentation of the 'period' and 'interval' fields is strange and contains the same definition. However, they both return the same value as the parameter 'interval'.
    /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-querykline"/>
    /// </para>
    /// </remarks>
    public record LinearKlineGetRes(long Id, LinearSymbol Symbol, string Period, string Interval, long OpenTime, decimal Volume,
        decimal Open, decimal High, decimal Low, decimal Close, decimal Turnover);

    /// <summary>
    /// Base type of the response for the 'Query Mark Price Kline' API method.
    /// </summary>
    public record LinearKlineMarkPriceBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        IReadOnlyList<LinearKlineMarkPriceRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Query Mark Price Kline' API method.
    /// </summary>
    public record LinearKlineMarkPriceRes(long Id, LinearSymbol Symbol, string Period, long StartAt, decimal Volume, decimal Open, decimal High,
        decimal Low, decimal Close);

    /// <summary>
    /// Base type of the response for the 'Public Trading Records' API method.
    /// </summary>
    /// <remarks>
    public record LinearMarketTradingBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        IReadOnlyList<LinearMarketTradingRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Public Trading Records' API method.
    /// </summary>
    /// <remarks>
    /// ignore the 'time', 'open' field because it is marked as 'abandoned' in the documentation.
    /// </remarks>
    public record LinearMarketTradingRes(long Id, LinearSymbol Symbol, decimal Price, decimal Qty, LinearSide Side, long TradeTimeMs);

    /// <summary>
    /// Base type of the response for the 'Cancel Active Order' API method.
    /// </summary>
    /// <remarks>
    public record LinearOrderCancelBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LinearOrderCancelRes? Result,
        string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Cancel Active Order' API method.
    /// </summary>
    public record LinearOrderCancelRes(string OrderId);

    /// <summary>
    /// Base type of the response for the 'Cancel All Active Orders' API method.
    /// </summary>
    public record LinearOrderCancelAllBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        IReadOnlyList<string>? Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Base type of the response for the 'Get Active Order' API method.
    /// </summary>
    public record LinearOrderGetOrdersBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        LinearOrderGetOrdersListBase? Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Collection type for the actual data type of the 'Get Active Order' API method response.
    /// </summary>
    public record LinearOrderGetOrdersListBase(IReadOnlyList<LinearOrderGetOrdersRes> Data, int CurrentPage, int LastPage);

    /// <summary>
    /// Actual data type of the response for the 'Get Active Order' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// </remarks>
    public record LinearOrderGetOrdersRes(string OrderId, long UserId, LinearSymbol Symbol, LinearSide Side, LinearOrderType OrderType,
        decimal Price, decimal Qty, LinearTimeInForce TimeInForce, LinearOrderStatus OrderStatus, decimal LastExecPrice,
        decimal CumExecQty, decimal CumExecValue, decimal CumExecFee, string OrderLinkId, bool ReduceOnly, bool CloseOnTrigger,
        DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt);

    /// <summary>
    /// Base type of the response for the 'Place Active Order' API method.
    /// </summary>
    public record LinearOrderNewBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LinearOrderNewRes? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Place Active Order' API method.
    /// </summary>
    public record LinearOrderNewRes(string OrderId, long UserId, LinearSymbol Symbol, LinearSide Side, LinearOrderType OrderType,
        decimal Price, decimal Qty, LinearTimeInForce TimeInForce, LinearOrderStatus OrderStatus, decimal LastExecPrice,
        decimal CumExecQty, decimal CumExecValue, decimal CumExecFee, string OrderLinkId, bool ReduceOnly, bool CloseOnTrigger,
        DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt);

    /// <summary>
    /// Base type of the response for the 'Query Active Order (real-time)' API method.
    /// </summary>
    /// <remarks>
    /// 'Query Active Order (real-time)' method of the API returns different types of responses depending on the parameters of the method, so define a generic type and deserialize it.
    /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-queryactive"/>
    /// <seealso cref="https://bybit-exchange.github.io/docs/linear/#2020-12-03"/>
    /// </remarks>
    /// <typeparam name="T">'Result' proterty data type.</typeparam>
    public record LinearOrderQueryBase<T>(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, T? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Query Active Order (real-time)' API method.
    /// </summary>
    public record LinearOrderQueryRes(string OrderId, long UserId, LinearSymbol Symbol, LinearSide Side, LinearOrderType OrderType,
        decimal Price, decimal Qty, LinearTimeInForce TimeInForce, LinearOrderStatus OrderStatus, decimal LastExecPrice,
        decimal CumExecQty, decimal CumExecValue, decimal CumExecFee, string OrderLinkId, bool ReduceOnly, bool CloseOnTrigger,
        DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, decimal TakeProfit, decimal StopLoss, LinearTriggerPriceType TpTriggerBy,
        LinearTriggerPriceType SlTriggerBy);

    /// <summary>
    /// Base type of the response for the 'Replace Active Order' API method.
    /// </summary>
    public record LinearOrderReplaceBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LinearOrderReplaceRes? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Replace Active Order' API method.
    /// </summary>
    public record LinearOrderReplaceRes(string OrderId);

    /// <summary>
    /// Base type of the response for the 'Change Margin' API method.
    /// </summary>
    public record LinearPositionsChangeMarginBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LinearPositionsChangeMarginResBase? Result,
        string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Wrapper data type of the response for the Change Margin' API method.
    /// </summary>
    public record LinearPositionsChangeMarginResBase(LinearPositionsChangeMarginRes PositionsListResult, decimal WalletBalance, decimal AvailableBalance);

    /// <summary>
    /// Actual data type of the response for the 'Change Margin' API method.
    /// </summary>
    public record LinearPositionsChangeMarginRes(long UserId, LinearSymbol Symbol, LinearSide Side, decimal Size, decimal PositionValue, decimal EntryPrice,
        decimal LiqPrice, decimal BustPrice, decimal Leverage, decimal PositionMargin, decimal OccClosingFee, decimal RealisedPnl, decimal CumRealizedPnl,
        decimal FreeQty);

    /// <summary>
    /// Base type of the response for the 'Closed Profit and Loss' API method.
    /// </summary>
    public record LinearPositionsClosePnlRecordsBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        LinearPositionsClosePnlRecordsListBase? Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Collection type for the actual data type of the 'Closed Profit and Loss' API method response.
    /// </summary>
    public record LinearPositionsClosePnlRecordsListBase(int CurrentPage, IList<LinearPositionsClosePnlRecordsRes> Data);

    /// <summary>
    /// Actual data type of the response for the 'Closed Profit and Loss' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// 'created_at' is a UNIX timestamp in seconds. not a datetime string. omg. Inconsistent naming!
    /// </remarks>
    public record LinearPositionsClosePnlRecordsRes(long Id, long UserId, LinearSymbol Symbol, string OrderId, LinearSide Side, decimal Qty, decimal OrderPrice,
        LinearOrderType OrderType, LinearExecType ExecType, decimal ClosedSize, decimal CumEntryValue, decimal AvgEntryPrice, decimal CumExitValue,
        decimal AvgExitPrice, decimal ClosedPnl, int FillCount, decimal Leverage, long CreatedAt);

    /// <summary>
    /// Base type of the response for the 'My Position' API method.
    /// </summary>
    public record LinearPositionsMyPositionBase<T>(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, T? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Wrapper data type of the response for the 'My Position' API method.
    /// </summary>
    public record LinearPositionsMyPositionResBase(LinearPositionsMyPositionRes? Data, bool IsValid);

    /// <summary>
    /// Actual data type of the response for the 'My Position' API method.
    /// </summary>
    public record LinearPositionsMyPositionRes(long UserId, LinearSymbol Symbol, LinearSide Side, decimal Size, decimal PositionValue, decimal EntryPrice,
        decimal LiqPrice, decimal BustPrice, decimal Leverage, bool IsIsolated, decimal AutoAddMargin, decimal PositionMargin, decimal OccClosingFee,
        decimal RealisedPnl, decimal CumRealisedPnl, decimal FreeQty, LinearTpSlModeType TpSlMode, decimal UnrealisedPnl, int DeleverageIndicator);

    /// <summary>
    /// Base type of the response for the 'Set Leverage' API method.
    /// </summary>
    public record LinearPositionsSaveLeverageBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, object? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Base type of the response for the 'Set Auto Add Margin' API method.
    /// </summary>
    public record LinearPositionsSetAutoAddMarginBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, object? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Base type of the response for the 'Cross/Isolated Margin Switch' API method.
    /// </summary>
    public record LinearPositionsSwitchIsolatedBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, object? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Base type of the response for the 'Full/Partial Position SL/TP Switch' API method.
    /// </summary>
    public record LinearPositionsSwitchModeBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LinearPositionsSwitchModeRes? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual type of the response for the 'Full/Partial Position SL/TP Switch' API method.
    /// </summary>
    public record LinearPositionsSwitchModeRes(LinearTpSlModeType TpSlMode);

    /// <summary>
    /// Base type of the response for the 'Set Trading-Stop' API method.
    /// </summary>
    public record LinearPositionsTradingStopBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, object? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Base type of the response for the 'Get Risk Limit' API method.
    /// </summary>
    public record LinearWalletGetRiskLimitBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        IReadOnlyList<LinearWalletGetRiskLimitRes>? Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Get Risk Limit' API method.
    /// </summary>
    /// <remarks>
    /// 'is_lowest_risk' field is a numeric type and, despite its name, is not a bool. '0' represents 'No' and '1' represents 'Yes'. Terrible.
    /// </remarks>
    public record LinearWalletGetRiskLimitRes(long Id, LinearSymbol Symbol, decimal Limit, decimal MaintainMargin, decimal StartingMargin,
        IEnumerable<int> Section, int IsLowestRisk, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt);

    /// <summary>
    /// Base type of the response for the 'Query Index Price Kline' API method.
    /// </summary>
    public record LinearKlineIndexPriceBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        IReadOnlyList<LinearKlineIndexPriceRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Query Index Price Kline' API method.
    /// </summary>
    public record LinearKlineIndexPriceRes(long Id, LinearSymbol Symbol, string Period, long StartAt, decimal Open, decimal High, decimal Low,
        decimal Close);

    /// <summary>
    /// Base type of the response for the 'Query Premium Index Price Kline' API method.
    /// </summary>
    public record LinearKlinePremiumIndexPriceBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        IReadOnlyList<LinearKlinePremiumIndexPriceRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Query Premium Index Price Kline' API method.
    /// </summary>
    public record LinearKlinePremiumIndexPriceRes(long Id, LinearSymbol Symbol, string Period, long StartAt, decimal Open, decimal High, decimal Low,
        decimal Close);
}