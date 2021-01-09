using System;
using System.Collections.Generic;

namespace BybitAPI.Model
{
    /// <summary>
    /// Base type of the response for the 'API Key Info' API method.
    /// </summary>
    public record APIKeyInfoBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo, IReadOnlyList<APIKeyInfoRes> Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'API Key Info' API method.
    /// </summary>
    public record APIKeyInfoRes(string ApiKey, long UserId, IReadOnlyList<string> Ips, string Note, IReadOnlyList<string> Permissions,
        DateTimeOffset CreatedAt, bool ReadOnly);

    /// <summary>
    /// Base type of the response for the 'Announcement' API method.
    /// </summary>
    public record AnnouncementBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo, IReadOnlyList<AnnouncementRes> Result,
        string TimeNow);

    /// <summary>
    /// Actual data type of the response for the 'Announcement' API method.
    /// </summary>
    public record AnnouncementRes(long Id, string Title, string Link, string Summary, DateTimeOffset CreatedAt);

    /// <summary>
    /// Base type of the response for the 'LCP Info' API method.
    /// </summary>
    public record LCPInfoBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo, LCPInfoListBase Result, string TimeNow);

    /// <summary>
    /// Collection type of the actual data type of the 'LCP Info' API method response.
    /// </summary>
    public record LCPInfoListBase(IReadOnlyList<LCPInfoRes> LcpList);

    /// <summary>
    /// Actual data type of the response for the 'LCP Info' API method.
    /// </summary>
    public record LCPInfoRes(string Date, decimal? SelfRatio, decimal? PlatformRatio, decimal? Score);

    /// <summary>
    /// Actual data type of the response for the 'Server Time' API method.
    /// </summary>
    public record ServerTimeRes(int RetCode, string RetMsg, string ExtCode, string ExtInfo, object Result, string TimeNow);

    /// <summary>
    /// Base type of the response for the 'Cancel Conditional Order' API method.
    /// </summary>
    public record ConditionalCancelBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo, ConditionalCancelRes Result,
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
    public record ConditionalCancelAllBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo,
        IReadOnlyList<ConditionalCancelAllRes> Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the 'Cancel Conditional Order' API method.
    /// </summary>
    /// <remarks>
    /// 'clOrdID' field is defined as a UUID, but as other UUID type fields may return an empty string and cannot be deserialized to GUID type, it is defined as a string type so that it can be treated like them.
    /// </remarks>
    public record ConditionalCancelAllRes(string ClOrdId, long UserId, Symbol Symbol, Side Side, OrderType OrderType, decimal Price,
        int Qty, TimeInForce TimeInForce, CreateType CreateType, CancelType CancelType, OrderStatus? OrderStatus, decimal? LeavesValue,
        DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, string CrossStatus, decimal? CrossSeq, string StopOrderType,
        TriggerPriceType TriggerBy, decimal? BasePrice, decimal? TrailValue, string ExpectedDirection);

    /// <summary>
    /// Base type of the response for the 'Get Conditional Order' API method.
    /// </summary>
    public record ConditionalGetOrdersResBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo,
        ConditionalGetOrdersListBase Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Collection type of the actual data type of the 'Get Conditional Order' API method response.
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
    public record ConditionalNewOrderBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo, ConditionalNewOrderRes Result,
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
    /// Base type of the response for the "Query Conditional Order (real-time)" API method.
    /// </summary>
    /// <remarks>
    /// "Query Conditional Order (real-time)" method of the API returns different types of responses depending on the parameters of the method, so define a generic type and deserialize it.
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
    /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/?console#2020-12-17"/>
    /// </remarks>
    /// <typeparam name="T">'Result' proterty data type.</typeparam>
    public record ConditionalQueryBase<T>(int RetCode, string RetMsg, string ExtCode, string ExtInfo, T Result, string TimeNow,
        int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    /// <summary>
    /// Actual data type of the response for the "Query Conditional Order (real-time)" API method.
    /// </summary>
    public record ConditionalQueryRes(long UserId, Symbol Symbol, Side Side, OrderType OrderType, decimal Price, int Qty, decimal StopPx,
        decimal BasePrice, TimeInForce TimeInForce, OrderStatus OrderStatus, ConditionalQuiryExtFields ExtFields,
        int LeavesQty, decimal LeavesValue, int? CumExecQty, decimal? CumExecValue, decimal? CumExecFee, string? RejectReason,
        CancelType? CancelType, string? OrderLinkId, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, string OrderId,
        TriggerPriceType? TriggerBy);

    /// <summary>
    /// Extra data for the <see cref="ConditionalQueryRes"/>
    /// </summary>
    /// <remarks>
    /// API response does not seem to contain the 'x_reqType' field, but it does documented and original generated code includedes it.
    /// The 'x_req_offset' field does not documented, but original generated code includes it.
    /// </remarks>
    public record ConditionalQuiryExtFields(long OReqNum, string? XreqType, decimal? XreqOffset);
}