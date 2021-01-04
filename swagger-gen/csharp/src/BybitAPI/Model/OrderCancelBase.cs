/*
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api.bybit.com]
 *
 * OpenAPI spec version: 0.2.10
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BybitAPI.Model
{
    /// <summary>
    /// cancel order response
    /// </summary>
    [DataContract]
    public partial class OrderCancelBase : IEquatable<OrderCancelBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCancelBase" /> class.
        /// </summary>
        /// <param name="retCode">retCode.</param>
        /// <param name="retMsg">retMsg.</param>
        /// <param name="extCode">extCode.</param>
        /// <param name="extInfo">extInfo.</param>
        /// <param name="result">result.</param>
        /// <param name="timeNow">timeNow.</param>
        public OrderCancelBase(decimal? retCode = default, string retMsg = default, string extCode = default, string extInfo = default, object result = default, string timeNow = default)
        {
            RetCode = retCode;
            RetMsg = retMsg;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Result = result;
            TimeNow = timeNow;
        }

        /// <summary>
        /// Gets or Sets RetCode
        /// </summary>
        [DataMember(Name = "ret_code", EmitDefaultValue = false)]
        public decimal? RetCode { get; set; }

        /// <summary>
        /// Gets or Sets RetMsg
        /// </summary>
        [DataMember(Name = "ret_msg", EmitDefaultValue = false)]
        public string RetMsg { get; set; }

        /// <summary>
        /// Gets or Sets ExtCode
        /// </summary>
        [DataMember(Name = "ext_code", EmitDefaultValue = false)]
        public string ExtCode { get; set; }

        /// <summary>
        /// Gets or Sets ExtInfo
        /// </summary>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public object Result { get; set; }

        /// <summary>
        /// Gets or Sets TimeNow
        /// </summary>
        [DataMember(Name = "time_now", EmitDefaultValue = false)]
        public string TimeNow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderCancelBase {\n");
            sb.Append("  RetCode: ").Append(RetCode).Append("\n");
            sb.Append("  RetMsg: ").Append(RetMsg).Append("\n");
            sb.Append("  ExtCode: ").Append(ExtCode).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  TimeNow: ").Append(TimeNow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as OrderCancelBase);
        }

        /// <summary>
        /// Returns true if OrderCancelBase instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderCancelBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderCancelBase input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    RetCode == input.RetCode ||
                    (RetCode != null &&
                    RetCode.Equals(input.RetCode))
                ) &&
                (
                    RetMsg == input.RetMsg ||
                    (RetMsg != null &&
                    RetMsg.Equals(input.RetMsg))
                ) &&
                (
                    ExtCode == input.ExtCode ||
                    (ExtCode != null &&
                    ExtCode.Equals(input.ExtCode))
                ) &&
                (
                    ExtInfo == input.ExtInfo ||
                    (ExtInfo != null &&
                    ExtInfo.Equals(input.ExtInfo))
                ) &&
                (
                    Result == input.Result ||
                    (Result != null &&
                    Result.Equals(input.Result))
                ) &&
                (
                    TimeNow == input.TimeNow ||
                    (TimeNow != null &&
                    TimeNow.Equals(input.TimeNow))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (RetCode != null)
                {
                    hashCode = hashCode * 59 + RetCode.GetHashCode();
                }

                if (RetMsg != null)
                {
                    hashCode = hashCode * 59 + RetMsg.GetHashCode();
                }

                if (ExtCode != null)
                {
                    hashCode = hashCode * 59 + ExtCode.GetHashCode();
                }

                if (ExtInfo != null)
                {
                    hashCode = hashCode * 59 + ExtInfo.GetHashCode();
                }

                if (Result != null)
                {
                    hashCode = hashCode * 59 + Result.GetHashCode();
                }

                if (TimeNow != null)
                {
                    hashCode = hashCode * 59 + TimeNow.GetHashCode();
                }

                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
