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
    /// LeverageResult
    /// </summary>
    [DataContract]
    public partial class LeverageResult : IEquatable<LeverageResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeverageResult" /> class.
        /// </summary>
        /// <param name="bTCUSD">bTCUSD.</param>
        /// <param name="eOSUSD">eOSUSD.</param>
        /// <param name="eTHUSD">eTHUSD.</param>
        /// <param name="xRPUSD">xRPUSD.</param>
        public LeverageResult(object bTCUSD = default, object eOSUSD = default, object eTHUSD = default, object xRPUSD = default)
        {
            BTCUSD = bTCUSD;
            EOSUSD = eOSUSD;
            ETHUSD = eTHUSD;
            XRPUSD = xRPUSD;
        }

        /// <summary>
        /// Gets or Sets BTCUSD
        /// </summary>
        [DataMember(Name = "BTCUSD", EmitDefaultValue = false)]
        public object BTCUSD { get; set; }

        /// <summary>
        /// Gets or Sets EOSUSD
        /// </summary>
        [DataMember(Name = "EOSUSD", EmitDefaultValue = false)]
        public object EOSUSD { get; set; }

        /// <summary>
        /// Gets or Sets ETHUSD
        /// </summary>
        [DataMember(Name = "ETHUSD", EmitDefaultValue = false)]
        public object ETHUSD { get; set; }

        /// <summary>
        /// Gets or Sets XRPUSD
        /// </summary>
        [DataMember(Name = "XRPUSD", EmitDefaultValue = false)]
        public object XRPUSD { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeverageResult {\n");
            sb.Append("  BTCUSD: ").Append(BTCUSD).Append("\n");
            sb.Append("  EOSUSD: ").Append(EOSUSD).Append("\n");
            sb.Append("  ETHUSD: ").Append(ETHUSD).Append("\n");
            sb.Append("  XRPUSD: ").Append(XRPUSD).Append("\n");
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
            return Equals(input as LeverageResult);
        }

        /// <summary>
        /// Returns true if LeverageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LeverageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeverageResult input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    BTCUSD == input.BTCUSD ||
                    (BTCUSD != null &&
                    BTCUSD.Equals(input.BTCUSD))
                ) &&
                (
                    EOSUSD == input.EOSUSD ||
                    (EOSUSD != null &&
                    EOSUSD.Equals(input.EOSUSD))
                ) &&
                (
                    ETHUSD == input.ETHUSD ||
                    (ETHUSD != null &&
                    ETHUSD.Equals(input.ETHUSD))
                ) &&
                (
                    XRPUSD == input.XRPUSD ||
                    (XRPUSD != null &&
                    XRPUSD.Equals(input.XRPUSD))
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
                if (BTCUSD != null)
                {
                    hashCode = hashCode * 59 + BTCUSD.GetHashCode();
                }

                if (EOSUSD != null)
                {
                    hashCode = hashCode * 59 + EOSUSD.GetHashCode();
                }

                if (ETHUSD != null)
                {
                    hashCode = hashCode * 59 + ETHUSD.GetHashCode();
                }

                if (XRPUSD != null)
                {
                    hashCode = hashCode * 59 + XRPUSD.GetHashCode();
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
