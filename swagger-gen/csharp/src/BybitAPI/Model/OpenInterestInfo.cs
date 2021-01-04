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
    /// OpenInterestInfo
    /// </summary>
    [DataContract]
    public partial class OpenInterestInfo : IEquatable<OpenInterestInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenInterestInfo" /> class.
        /// </summary>
        /// <param name="openInterest">openInterest.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="symbol">symbol.</param>
        public OpenInterestInfo(int? openInterest = default, int? timestamp = default, string symbol = default)
        {
            OpenInterest = openInterest;
            Timestamp = timestamp;
            Symbol = symbol;
        }

        /// <summary>
        /// Gets or Sets OpenInterest
        /// </summary>
        [DataMember(Name = "open_interest", EmitDefaultValue = false)]
        public int? OpenInterest { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public int? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenInterestInfo {\n");
            sb.Append("  OpenInterest: ").Append(OpenInterest).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
            return Equals(input as OpenInterestInfo);
        }

        /// <summary>
        /// Returns true if OpenInterestInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenInterestInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenInterestInfo input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    OpenInterest == input.OpenInterest ||
                    (OpenInterest != null &&
                    OpenInterest.Equals(input.OpenInterest))
                ) &&
                (
                    Timestamp == input.Timestamp ||
                    (Timestamp != null &&
                    Timestamp.Equals(input.Timestamp))
                ) &&
                (
                    Symbol == input.Symbol ||
                    (Symbol != null &&
                    Symbol.Equals(input.Symbol))
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
                if (OpenInterest != null)
                {
                    hashCode = hashCode * 59 + OpenInterest.GetHashCode();
                }

                if (Timestamp != null)
                {
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                }

                if (Symbol != null)
                {
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
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
