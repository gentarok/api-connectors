using System;
using System.Collections.Generic;

namespace BybitAPI.Model
{
    public record APIKeyBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo, IReadOnlyList<APIKeyInfo> Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    public record APIKeyInfo(string ApiKey, long UserId, IReadOnlyList<string> Ips, string Note, IReadOnlyList<string> Permissions, DateTimeOffset CreatedAt, bool ReadOnly);

    public record Announcement(int RetCode, string RetMsg, string ExtCode, string ExtInfo, IReadOnlyList<AnnouncementInfo> Result, string TimeNow);

    public record AnnouncementInfo(long Id, string Title, string Link, string Summary, DateTimeOffset CreatedAt);

    public record LCPInfoBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo, LCPInfoListBase Result, string TimeNow);

    public record LCPInfoListBase(IReadOnlyList<LCPInfo> LcpList);

    public record LCPInfo(string Date, decimal? SelfRatio, decimal? PlatformRatio, decimal? Score);

    public record ServerTime(int RetCode, string RetMsg, string ExtCode, string ExtInfo, object Result, string TimeNow);

    public record ConditionalCancelBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo, ConditionalCancelRes Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    public record ConditionalCancelRes(string OrderId);

    public record ConditionalCancelAllBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo, IReadOnlyList<ConditionalCancelAllRes> Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    public record ConditionalCancelAllRes(string ClOrdId, long UserId, string Symbol, string Side, string OrderType, decimal? Price, decimal? Qty, string TimeInForce, string CreateType, string CancelType, string OrderStatus, decimal? LeavesValue, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, string CrossStatus, decimal? CrossSeq, string StopOrderType, string TriggerBy, decimal? BasePrice, decimal? TrailValue, string ExpectedDirection);

    public record ConditionalGetOrdersResBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo, ConditionalGetOrdersListBase Result, string TimeNow, int RateLimitStatus, long RateLimitResetMs, int RateLimit);

    public record ConditionalGetOrdersListBase(IReadOnlyList<ConditionalGetOrdersRes> Data, string Cursor);

    public record ConditionalGetOrdersRes(long UserId, string StopOrderStatus, string Symbol, string Side, string OrderType, decimal? Price, decimal? Qty, string TimeInForce, string StopOrderType, string TriggerBy, decimal? BasePrice, string OrderLinkId, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, string StopPx, string StopOrderId);

    public record ConditionalNewOrderBase(int RetCode, string RetMsg, string ExtCode, string ExtInfo, ConditionalNewOrderRes Result, string TimeNow);

    public record ConditionalNewOrderRes(long UserId, string Symbol, string Side, string OrderType, decimal Price, decimal Qty, string TimeInForce, string TriggerBy, decimal? BasePrice, string Remark, string RejectReason, string StopPx, string StopOrderId, string OrderLinkId, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt);
}