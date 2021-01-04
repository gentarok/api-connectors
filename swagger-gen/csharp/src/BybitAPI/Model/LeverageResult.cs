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
        public LeverageResult(Object bTCUSD = default(Object), Object eOSUSD = default(Object), Object eTHUSD = default(Object), Object xRPUSD = default(Object))
        {
            this.BTCUSD = bTCUSD;
            this.EOSUSD = eOSUSD;
            this.ETHUSD = eTHUSD;
            this.XRPUSD = xRPUSD;
        }

        /// <summary>
        /// Gets or Sets BTCUSD
        /// </summary>
        [DataMember(Name = "BTCUSD", EmitDefaultValue = false)]
        public Object BTCUSD { get; set; }

        /// <summary>
        /// Gets or Sets EOSUSD
        /// </summary>
        [DataMember(Name = "EOSUSD", EmitDefaultValue = false)]
        public Object EOSUSD { get; set; }

        /// <summary>
        /// Gets or Sets ETHUSD
        /// </summary>
        [DataMember(Name = "ETHUSD", EmitDefaultValue = false)]
        public Object ETHUSD { get; set; }

        /// <summary>
        /// Gets or Sets XRPUSD
        /// </summary>
        [DataMember(Name = "XRPUSD", EmitDefaultValue = false)]
        public Object XRPUSD { get; set; }

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
            return this.Equals(input as LeverageResult);
        }

        /// <summary>
        /// Returns true if LeverageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LeverageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeverageResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BTCUSD == input.BTCUSD ||
                    (this.BTCUSD != null &&
                    this.BTCUSD.Equals(input.BTCUSD))
                ) &&
                (
                    this.EOSUSD == input.EOSUSD ||
                    (this.EOSUSD != null &&
                    this.EOSUSD.Equals(input.EOSUSD))
                ) &&
                (
                    this.ETHUSD == input.ETHUSD ||
                    (this.ETHUSD != null &&
                    this.ETHUSD.Equals(input.ETHUSD))
                ) &&
                (
                    this.XRPUSD == input.XRPUSD ||
                    (this.XRPUSD != null &&
                    this.XRPUSD.Equals(input.XRPUSD))
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
                int hashCode = 41;
                if (this.BTCUSD != null)
                    hashCode = hashCode * 59 + this.BTCUSD.GetHashCode();
                if (this.EOSUSD != null)
                    hashCode = hashCode * 59 + this.EOSUSD.GetHashCode();
                if (this.ETHUSD != null)
                    hashCode = hashCode * 59 + this.ETHUSD.GetHashCode();
                if (this.XRPUSD != null)
                    hashCode = hashCode * 59 + this.XRPUSD.GetHashCode();
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