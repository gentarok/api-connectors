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
    /// LeverageInfo
    /// </summary>
    [DataContract]
    public partial class LeverageInfo : IEquatable<LeverageInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeverageInfo" /> class.
        /// </summary>
        /// <param name="leverage">leverage.</param>
        public LeverageInfo(decimal? leverage = default)
        {
            Leverage = leverage;
        }

        /// <summary>
        /// Gets or Sets Leverage
        /// </summary>
        [DataMember(Name = "leverage", EmitDefaultValue = false)]
        public decimal? Leverage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeverageInfo {\n");
            sb.Append("  Leverage: ").Append(Leverage).Append("\n");
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
            return Equals(input as LeverageInfo);
        }

        /// <summary>
        /// Returns true if LeverageInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LeverageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeverageInfo input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Leverage == input.Leverage ||
                    (Leverage != null &&
                    Leverage.Equals(input.Leverage))
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
                if (Leverage != null)
                {
                    hashCode = hashCode * 59 + Leverage.GetHashCode();
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
