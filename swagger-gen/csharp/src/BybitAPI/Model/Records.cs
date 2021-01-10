using System;
using System.Collections.Generic;

namespace BybitAPI.Model
{
    /// <summary>
    /// Base type of the response for the 'API Key Info' API method.
    /// </summary>
    public record APIKeyInfoBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<APIKeyInfoRes>? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'API Key Info' API method.
    /// </summary>
    public record APIKeyInfoRes(string ApiKey, long UserId, IReadOnlyList<string> Ips, string Note, IReadOnlyList<string> Permissions,
        DateTimeOffset CreatedAt, bool ReadOnly);

    /// <summary>
    /// Base type of the response for the 'Announcement' API method.
    /// </summary>
    public record AnnouncementBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<AnnouncementRes>? Result,
        string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Announcement' API method.
    /// </summary>
    public record AnnouncementRes(long Id, string Title, string Link, string Summary, DateTimeOffset CreatedAt);

    /// <summary>
    /// Base type of the response for the 'LCP Info' API method.
    /// </summary>
    public record LCPInfoBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, LCPInfoListBase? Result, string TimeNow);

    /// <summary>
    /// Collection type for the actual data type of the 'LCP Info' API method response.
    /// </summary>
    public record LCPInfoListBase(IReadOnlyList<LCPInfoRes> LcpList);

    /// <summary>
    /// Actual data type of the response for the 'LCP Info' API method.
    /// </summary>
    public record LCPInfoRes(string Date, decimal? SelfRatio, decimal? PlatformRatio, decimal? Score);

    /// <summary>
    /// Actual data type of the response for the 'Server Time' API method.
    /// </summary>
    public record ServerTimeRes(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, object? Result, string TimeNow);

    /// <summary>
    /// Base type of the response for the 'Cancel Conditional Order' API method.
    /// </summary>
    public record ConditionalCancelBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, ConditionalCancelRes? Result,
        string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Cancel Conditional Order' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// </remarks>
    public record ConditionalCancelRes(string OrderId);

    /// <summary>
    /// Base type of the response for the 'Cancel All Conditional Orders' API method.
    /// </summary>
    public record ConditionalCancelAllBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        IReadOnlyList<ConditionalCancelAllRes>? Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Cancel Conditional Order' API method.
    /// </summary>
    /// <remarks>
    /// <para>
    /// 'clOrdID' field is defined as a UUID, but as other UUID type fields may return an empty string and cannot be deserialized to GUID type, it is defined as a string type so that it can be treated like them.
    /// </para>
    /// <para>
    /// 'trail_value' field is not defined in documentation, but actual API response returns it.
    /// </para>
    /// </remarks>
    public record ConditionalCancelAllRes(string Clordid, long UserId, Symbol Symbol, Side Side, OrderType OrderType, decimal Price,
        int Qty, TimeInForce TimeInForce, CreateType CreateType, CancelType CancelType, OrderStatus? OrderStatus, decimal? LeavesValue,
        DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, string CrossStatus, long? CrossSeq, string StopOrderType,
        TriggerPriceType TriggerBy, decimal? BasePrice, decimal? TrailValue, string ExpectedDirection);

    /// <summary>
    /// Base type of the response for the 'Get Conditional Order' API method.
    /// </summary>
    public record ConditionalGetOrdersResBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo,
        ConditionalGetOrdersListBase? Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Collection type for the actual data type of the 'Get Conditional Order' API method response.
    /// </summary>
    public record ConditionalGetOrdersListBase(IReadOnlyList<ConditionalGetOrdersRes> Data, string Cursor);

    /// <summary>
    /// Actual data type of the response for the 'Get Conditional Order' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// </remarks>
    public record ConditionalGetOrdersRes(long UserId, StopOrderStatus StopOrderStatus, Symbol Symbol, Side Side, OrderType OrderType,
        string StopOrderType, decimal Price, int Qty, TimeInForce TimeInForce, decimal? BasePrice, string OrderLinkId,
        DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, decimal? StopPx, string? StopOrderId);

    /// <summary>
    /// Base type of the response for the 'Place Conditional Order' API method.
    /// </summary>
    public record ConditionalNewOrderBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, ConditionalNewOrderRes? Result,
        string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Place Conditional Order' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// </remarks>
    public record ConditionalNewOrderRes(long UserId, Symbol Symbol, Side Side, OrderType OrderType, decimal Price, int Qty,
        TimeInForce TimeInForce, string Remark, int? LeavesQty, decimal? LeavesValue, decimal? StopPx, string? RejectReason,
        string? StopOrderId, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt);

    /// <summary>
    /// Base type of the response for the 'Query Conditional Order (real-time)' API method.
    /// </summary>
    /// <remarks>
    /// 'Query Conditional Order (real-time)' method of the API returns different types of responses depending on the parameters of the method, so define a generic type and deserialize it.
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
    /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/?console#2020-12-17"/>
    /// </remarks>
    /// <typeparam name="T">'Result' proterty data type.</typeparam>
    public record ConditionalQueryBase<T>(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, T? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Query Conditional Order (real-time)' API method.
    /// </summary>
    public record ConditionalQueryRes(long UserId, Symbol Symbol, Side Side, OrderType OrderType, decimal Price, int Qty, decimal StopPx,
        decimal BasePrice, TimeInForce TimeInForce, OrderStatus OrderStatus, ConditionalQuiryExtFields ExtFields,
        int LeavesQty, decimal LeavesValue, int? CumExecQty, decimal? CumExecValue, decimal? CumExecFee, string? RejectReason,
        CancelType CancelType, string OrderLinkId, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, string OrderId, TriggerPriceType? TriggerBy);

    /// <summary>
    /// Extra data for the <see cref="ConditionalQueryRes"/>
    /// </summary>
    /// <remarks>
    /// API response does not seem to contain the 'x_reqType' field, but it does documented and original generated code includedes it.
    /// The 'x_req_offset' field does not documented, but original generated code includes it.
    /// </remarks>
    public record ConditionalQuiryExtFields(long OReqNum, string? XreqType, decimal? XreqOffset);

    /// <summary>
    /// Base type of the response for the 'Replace Conditional Order' API method.
    /// </summary>
    /// <remarks>
    public record ConditionalReplaceBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, ConditionalReplaceRes? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Replace Conditional Order' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// </remarks>
    public record ConditionalReplaceRes(string OrderId);

    /// <summary>
    /// Base type of the response for the 'User Trade Records' API method.
    /// </summary>
    /// <remarks>
    public record ExecutionGetTradesBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, ExecutionGetTradesListBase? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Collection type for the actual data type of the 'User Trade Records' API method response.
    /// </summary>
    /// <remarks>
    /// ignore the 'orderi_id' field because it is marked as 'abandoned' in the documentation.
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-usertraderecords"/>
    /// </remarks>
    public record ExecutionGetTradesListBase(IList<ExecutionGetTradesRes> TradeList);

    /// <summary>
    /// Actual data type of the response for the 'User Trade Records' API method.
    /// </summary>
    /// <remarks>
    /// ignore the 'exec_time' field because it is marked as 'abandoned' in the documentation.
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-usertraderecords"/>
    /// </remarks>
    public record ExecutionGetTradesRes(decimal ClosedSize, long CrossSeq, decimal ExecFee, string ExecId, decimal ExecPrice, int ExecQty,
        ExecType ExecType, decimal ExecValue, decimal FeeRate, LiquidityType LastLiquidityInd, int LeavesQty, long NthFill, string OrderId,
        string OrderLinkId, decimal OrderPrice, int OrderQty, OrderType OrderType, Side Side, Symbol Symbol, int UserId, long TradeTimeMs);

    /// <summary>
    /// Base type of the response for the 'Closed Profit and Loss' API method.
    /// </summary>
    /// <remarks>
    public record PositionsClosePnlBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, PositionsClosePnlListBase? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Collection type for the actual data type of the 'Closed Profit and Loss' API method response.
    /// </summary>
    public record PositionsClosePnlListBase(int CurrentPage, IList<PositionsClosePnlRes> Data);

    /// <summary>
    /// Actual data type of the response for the 'Closed Profit and Loss' API method.
    /// </summary>
    /// <remarks>
    /// 'order_id' (also 'order_link_id' and 'stop_order_id') field looks like a UUID, but the property type could not be defined as GUID because the API may return an empty string. Since an empty string does not imply null, it cannot be defined as a nullable reference type either.
    /// </remarks>
    public record PositionsClosePnlRes(long Id, long UserId, Symbol Symbol, string OrderId, Side Side, int Qty, decimal OrderPrice, OrderType OrderType,
        ExecType ExecType, decimal? ClosedSize, decimal? CumEntryValue, decimal? AvgEntryPrice, decimal? CumExitValue, decimal? AvgExitPrice,
        decimal? ClosedPnl, int? FillCount, int? Leverage, DateTimeOffset CreatedAt);

    /// <summary>
    /// Base type of the response for the 'My Last Funding Fee' API method.
    /// </summary>
    /// <remarks>
    public record FundingMyLastFeeBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, FundingMyLastFeeRes? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'My Last Funding Fee' API method.
    /// </summary>
    public record FundingMyLastFeeRes(Symbol Symbol, Side Side, decimal Size, decimal FundingRate, decimal ExecFee, long ExecTimestamp);

    /// <summary>
    /// Base type of the response for the 'Predicted Funding Rate and My Funding Fee' API method.
    /// </summary>
    /// <remarks>
    public record FundingPredictedBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, FundingPredictedRes? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Predicted Funding Rate and My Funding Fee' API method.
    /// </summary>
    public record FundingPredictedRes(decimal PredictedFundingRate, decimal PredictedFundingFee);

    /// <summary>
    /// Base type of the response for the 'Get the Last Funding Rate' API method.
    /// </summary>
    /// <remarks>
    public record FundingPrevRateBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, FundingPrevRateRes? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Get the Last Funding Rate' API method.
    /// </summary>
    public record FundingPrevRateRes(Symbol Symbol, decimal FundingRate, long FundingRateTimestamp);

    /// <summary>
    /// Base type of the response for the 'Query Kline' API method.
    /// </summary>
    /// <remarks>
    public record KlineGetBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<KlineGetRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Query Kline' API method.
    /// </summary>
    public record KlineGetRes(Symbol Symbol, string Interval, long OpenTime, decimal Open, decimal High, decimal Low, decimal Close,
        decimal Volume, decimal Turnover);

    /// <summary>
    /// Base type of the response for the 'Query Mark Price Kline' API method.
    /// </summary>
    /// <remarks>
    public record KlineMarkPriceBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<KlineMarkPriceRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Query Mark Price Kline' API method.
    /// </summary>
    public record KlineMarkPriceRes(long Id, Symbol Symbol, string Period, long StartAt, decimal Open, decimal High, decimal Low, decimal Close);

    /// <summary>
    /// Base type of the response for the 'Long-Short Ratio' API method.
    /// </summary>
    /// <remarks>
    public record MarketAccountRatioBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<MarketAccountRatioRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Long-Short Ratio' API method.
    /// </summary>
    public record MarketAccountRatioRes(Symbol Symbol, decimal BuyRatio, decimal SellRatio, long Timestamp);

    /// <summary>
    /// Base type of the response for the 'Latest Big Deal' API method.
    /// </summary>
    /// <remarks>
    public record MarketBigDealBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<MarketBigDealRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Latest Big Deal' API method.
    /// </summary>
    public record MarketBigDealRes(Symbol Symbol, Side Side, long Timestamp, decimal Value);

    /// <summary>
    /// Base type of the response for the 'Liquidated Orders' API method.
    /// </summary>
    /// <remarks>
    public record MarketLiqRecordsBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<MarketLiqRecordsRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Liquidated Orders' API method.
    /// </summary>
    public record MarketLiqRecordsRes(long Id, int Qty, Side Side, long Time, Symbol Symbol, decimal Price);

    /// <summary>
    /// Base type of the response for the 'Open Interest' API method.
    /// </summary>
    /// <remarks>
    public record MarketOpenInterestBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<MarketOpenInterestRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Open Interest' API method.
    /// </summary>
    public record MarketOpenInterestRes(long OpenInterest, long Timestamp, Symbol Symbol);

    /// <summary>
    /// Base type of the response for the 'Open Interest' API method.
    /// </summary>
    /// <remarks>
    public record MarketOrderbookBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<MarketOrderbookRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Open Interest' API method.
    /// </summary>
    public record MarketOrderbookRes(Symbol Symbol, decimal Price, decimal Size, Side side);

    /// <summary>
    /// Base type of the response for the 'Latest Information for Symbol' API method.
    /// </summary>
    /// <remarks>
    public record MarketSymbolInfoBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<MarketSymbolInfokRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Latest Information for Symbol' API method.
    /// </summary>
    public record MarketSymbolInfokRes(Symbol Symbol, decimal BidPrice, decimal AskPrice, decimal LastPrice, TickDirectionType LastTickDirection,
        decimal PrevPrice24h, decimal Price24hPcnt, decimal HighPrice24h, decimal LowPrice24h, decimal PrevPrice1h, decimal Price1hPcnt,
        decimal MarkPrice, decimal IndexPrice, long OpenInterest, decimal OpenValue, decimal TotalTurnover, decimal Turnover24h, decimal TotalVolume, decimal Volume24h,
        decimal FundingRate, decimal PredictedFundingRate, DateTimeOffset NextFundingTime, int CountdownHour);

    /// <summary>
    /// Base type of the response for the 'Public Trading Records' API method.
    /// </summary>
    /// <remarks>
    public record MarketTradingRecordsBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<MarketTradingRecordsRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Public Trading Records' API method.
    /// </summary>
    public record MarketTradingRecordsRes(long Id, Symbol Symbol, decimal Price, int Qty, Side Side, DateTimeOffset Time);

    /// <summary>
    /// Base type of the response for the 'Cancel Active Order' API method.
    /// </summary>
    /// <remarks>
    public record OrderCancelBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, OrderCancelRes? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Cancel Active Order' API method.
    /// </summary>
    public record OrderCancelRes(long UserId, string OrderId, Symbol Symbol, Side Side, OrderType OrderType, decimal Price, int Qty, TimeInForce TimeInForce, OrderStatus OrderStatus,
        double LastExecTime, decimal LastExecPrice, int LeavesQty, int CumExecQty, decimal CumExecValue, decimal CumExecFee, string? RejectReason, string OrderLinkId,
        DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt);

    /// <summary>
    /// Base type of the response for the 'Cancel All Active Orders' API method.
    /// </summary>
    /// <remarks>
    public record OrderCancelAllBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<OrderCancelAllRes>? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Cancel All Active Orders' API method.
    /// </summary>
    /// <remarks>
    /// 'clOrdID' field is not consistent with the snake case naming policy, so it is named 'xxxid' when it should be named 'xxxId'.
    /// </remarks>
    public record OrderCancelAllRes(string Clordid, long UserId, Symbol Symbol, Side Side, OrderType OrderType, decimal Price, int Qty, TimeInForce TimeInForce,
        CreateType CreateType, CancelType CancelType, OrderStatus? OrderStatus, int LeavesQty, decimal LeavesValue, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt,
        string CrossStatus, long CrossSeq);

    /// <summary>
    /// Base type of the response for the 'Get Active Order' API method.
    /// </summary>
    /// <remarks>
    public record OrderGetOrdersBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, OrderGetOrdersListBase? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Collection type for the actual data type of the 'Get Active Order' API method response.
    /// </summary>
    public record OrderGetOrdersListBase(IReadOnlyList<OrderGetOrdersRes>? Data);

    /// <summary>
    /// Actual data type of the response for the 'Get Active Order' API method.
    /// </summary>
    public record OrderGetOrdersRes(long UserId, OrderStatus OrderStatus, Symbol Symbol, Side Side, OrderType OrderType, decimal Price, int Qty, TimeInForce TimeInForce,
        string OrderLinkId, string OrderId, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, int LeavesQty, decimal LeavesValue, decimal CumExecQty, decimal CumExecValue,
        decimal CumExecFee, string? RejectReason);

    /// <summary>
    /// Base type of the response for the 'Place Active Order' API method.
    /// </summary>
    /// <remarks>
    public record OrderNewBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, OrderNewRes? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Place Active Order' API method.
    /// </summary>
    public record OrderNewRes(long UserId, string OrderId, Symbol Symbol, Side Side, OrderType OrderType, decimal Price, int Qty, TimeInForce TimeInForce,
        OrderStatus OrderStatus, double LastExecTime, decimal LastExecPrice, int LeavesQty, int CumExecQty, decimal CumExecValue, decimal CumExecFee, string? RejectReason,
        string OrderLinkId, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt);

    /// <summary>
    /// Base type of the response for the 'Query Active Order (real-time)' API method.
    /// </summary>
    /// <remarks>
    /// 'Query Active Order (real-time)' method of the API returns different types of responses depending on the parameters of the method, so define a generic type and deserialize it.
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-queryactive"/>
    /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/?console#2020-12-17"/>
    /// </remarks>
    /// <typeparam name="T">'Result' proterty data type.</typeparam>
    public record OrderQueryBase<T>(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, T? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Query Active Order (real-time)' API method.
    /// </summary>
    public record OrderQueryRes(long UserId, Symbol Symbol, Side Side, OrderType OrderType, decimal Price, int Qty, TimeInForce TimeInForce, OrderStatus OrderStatus,
        OrderQueryExtFields ExtFields, double LastExecTime, int LeavesQty, decimal LeavesValue, int? CumExecQty, decimal? CumExecValue, decimal? CumExecFee,
        string? RejectReason, CancelType CancelType, string OrderLinkId, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, string OrderId);

    /// <summary>
    /// Extra data for the <see cref="OrderQueryRes"/>
    /// </summary>
    /// <remarks>
    /// API response does not seem to contain the 'x_reqType' field, but it does documented and original generated code includedes it.
    /// The 'x_req_offset' field does not documented, but original generated code includes it.
    /// </remarks>
    public record OrderQueryExtFields(long OReqNum, string? XreqType, decimal? XreqOffset);

    /// <summary>
    /// Base type of the response for the 'Replace Active Order' API method.
    /// </summary>
    /// <remarks>
    public record OrderReplaceBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, OrderReplaceRes? Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Replace Active Order' API method.
    /// </summary>
    public record OrderReplaceRes(string OrderId);

    //========================================
    //========================================
    //========================================
    //========================================
    //========================================
    //========================================
    /// <summary>
    /// Base type of the response for the 'Query Symbol' API method.
    /// </summary>
    /// <remarks>
    public record SymbolGetBase(int RetCode, string RetMsg, string ExtCode, string? ExtInfo, IReadOnlyList<SymbolGetRes>? Result, string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Query Symbol' API method.
    /// </summary>
    public record SymbolGetRes(string Name, string BaseCurrency, string QuoteCurrency, int PriceScale, decimal TakerFee, decimal MakerFee,
        LeverageFilterRes LeverageFilter, PriceFilterRes PriceFilter, LotSizeFilterRes LotSizeFilter);

    /// <summary>
    /// Extra data for the <see cref="MarketSymbolInfoRes"/>
    /// </summary>
    public record LeverageFilterRes(decimal MinLeverage, decimal MaxLeverage, decimal LeverageStep);

    /// <summary>
    /// Extra data for the <see cref="MarketSymbolInfoRes"/>
    /// </summary>
    public record PriceFilterRes(decimal MinPrice, decimal MaxPrice, decimal TickSize);

    /// <summary>
    /// Extra data for the <see cref="MarketSymbolInfoRes"/>
    /// </summary>
    public record LotSizeFilterRes(int MaxTradingQty, decimal MinTradingQty, int QtyStep);
}