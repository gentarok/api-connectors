using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BybitAPI.Model
{
    [DataContract]
    public partial class ConditionalCancelBase : IEquatable<ConditionalCancelBase>, IValidatableObject
    {
        public ConditionalCancelBase(decimal? retCode = default, string retMsg = default, string extCode = default, string extInfo = default, OrderIdRes result = default, string timeNow = default, int? rateLimitStatus = default, long? rateLimitResetMs = default, int? rateLimit = default)
        {
            RetCode = retCode;
            RetMsg = retMsg;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Result = result;
            TimeNow = timeNow;
            RateLimitStatus = rateLimitStatus;
            RateLimitResetMs = rateLimitResetMs;
            RateLimit = rateLimit;
        }

        [DataMember(Name = "ret_code", EmitDefaultValue = false)]
        public decimal? RetCode { get; set; }

        [DataMember(Name = "ret_msg", EmitDefaultValue = false)]
        public string RetMsg { get; set; }

        [DataMember(Name = "ext_code", EmitDefaultValue = false)]
        public string ExtCode { get; set; }

        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        [DataMember(Name = "result", EmitDefaultValue = false)]
        public OrderIdRes Result { get; set; }

        [DataMember(Name = "time_now", EmitDefaultValue = false)]
        public string TimeNow { get; set; }

        [DataMember(Name = "rate_limit_status", EmitDefaultValue = false)]
        public int? RateLimitStatus { get; set; }

        [DataMember(Name = "rate_limit_reset_ms", EmitDefaultValue = false)]
        public long? RateLimitResetMs { get; set; }

        [DataMember(Name = "rate_limit", EmitDefaultValue = false)]
        public int? RateLimit { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionalCancelBase {\n");
            sb.Append("  RetCode: ").Append(RetCode).Append("\n");
            sb.Append("  RetMsg: ").Append(RetMsg).Append("\n");
            sb.Append("  ExtCode: ").Append(ExtCode).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  TimeNow: ").Append(TimeNow).Append("\n");
            sb.Append("  RateLimitStatus: ").Append(RateLimitStatus).Append("\n");
            sb.Append("  RateLimitResetMs: ").Append(RateLimitResetMs).Append("\n");
            sb.Append("  RateLimit: ").Append(RateLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public override bool Equals(object input)
        {
            return Equals(input as ConditionalCancelBase);
        }

        public bool Equals(ConditionalCancelBase input)
        {
            if (input is null)
            {
                return false;
            }

            return
                (
                    RetCode == input.RetCode ||
                    (RetCode is not null &&
                    RetCode.Equals(input.RetCode))
                ) &&
                (
                    RetMsg == input.RetMsg ||
                    (RetMsg is not null &&
                    RetMsg.Equals(input.RetMsg))
                ) &&
                (
                    ExtCode == input.ExtCode ||
                    (ExtCode is not null &&
                    ExtCode.Equals(input.ExtCode))
                ) &&
                (
                    ExtInfo == input.ExtInfo ||
                    (ExtInfo is not null &&
                    ExtInfo.Equals(input.ExtInfo))
                ) &&
                (
                    Result == input.Result ||
                    (Result is not null &&
                    Result.Equals(input.Result))
                ) &&
                (
                    TimeNow == input.TimeNow ||
                    (TimeNow is not null &&
                    TimeNow.Equals(input.TimeNow))
                ) &&
                (
                    RateLimitStatus == input.RateLimitStatus ||
                    (RateLimitStatus is not null &&
                    RateLimitStatus.Equals(input.RateLimitStatus))
                ) &&
                (
                    RateLimitResetMs == input.RateLimitResetMs ||
                    (RateLimitResetMs is not null &&
                    RateLimitResetMs.Equals(input.RateLimitResetMs))
                ) &&
                (
                    RateLimit == input.RateLimit ||
                    (RateLimit is not null &&
                    RateLimit.Equals(input.RateLimit))
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (RetCode is not null)
                {
                    hashCode = hashCode * 59 + RetCode.GetHashCode();
                }

                if (RetMsg is not null)
                {
                    hashCode = hashCode * 59 + RetMsg.GetHashCode();
                }

                if (ExtCode is not null)
                {
                    hashCode = hashCode * 59 + ExtCode.GetHashCode();
                }

                if (ExtInfo is not null)
                {
                    hashCode = hashCode * 59 + ExtInfo.GetHashCode();
                }

                if (Result is not null)
                {
                    hashCode = hashCode * 59 + Result.GetHashCode();
                }

                if (TimeNow is not null)
                {
                    hashCode = hashCode * 59 + TimeNow.GetHashCode();
                }

                if (RateLimitStatus is not null)
                {
                    hashCode = hashCode * 59 + RateLimitStatus.GetHashCode();
                }

                if (RateLimitResetMs is not null)
                {
                    hashCode = hashCode * 59 + RateLimitResetMs.GetHashCode();
                }

                if (RateLimit is not null)
                {
                    hashCode = hashCode * 59 + RateLimit.GetHashCode();
                }

                return hashCode;
            }
        }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}