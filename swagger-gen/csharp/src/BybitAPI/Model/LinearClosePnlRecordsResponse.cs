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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BybitAPI.Model
{
    /// <summary>
    /// Linear Positions Result Base
    /// </summary>
    [DataContract]
    public partial class LinearClosePnlRecordsResponse : IEquatable<LinearClosePnlRecordsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinearClosePnlRecordsResponse" /> class.
        /// </summary>
        /// <param name="retCode">retCode.</param>
        /// <param name="retMsg">retMsg.</param>
        /// <param name="extCode">extCode.</param>
        /// <param name="extInfo">extInfo.</param>
        /// <param name="result">result.</param>
        /// <param name="timeNow">timeNow.</param>
        public LinearClosePnlRecordsResponse(decimal? retCode = default, string retMsg = default, string extCode = default, string extInfo = default, List<LinearClosedPnlRecordResult> result = default, string timeNow = default)
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
        public List<LinearClosedPnlRecordResult> Result { get; set; }

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
            sb.Append("class LinearClosePnlRecordsResponse {\n");
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
            return Equals(input as LinearClosePnlRecordsResponse);
        }

        /// <summary>
        /// Returns true if LinearClosePnlRecordsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LinearClosePnlRecordsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinearClosePnlRecordsResponse input)
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
                    Result is not null &&
                    Result.SequenceEqual(input.Result)
                ) &&
                (
                    TimeNow == input.TimeNow ||
                    (TimeNow is not null &&
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

                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}