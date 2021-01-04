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
    /// BigDealInfo
    /// </summary>
    [DataContract]
    public partial class BigDealInfo : IEquatable<BigDealInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BigDealInfo" /> class.
        /// </summary>
        /// <param name="side">side.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="value">value.</param>
        public BigDealInfo(string side = default, int? timestamp = default, string symbol = default, int? value = default)
        {
            Side = side;
            Timestamp = timestamp;
            Symbol = symbol;
            Value = value;
        }

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [DataMember(Name = "side", EmitDefaultValue = false)]
        public string Side { get; set; }

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
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public int? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BigDealInfo {\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(input as BigDealInfo);
        }

        /// <summary>
        /// Returns true if BigDealInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BigDealInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BigDealInfo input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Side == input.Side ||
                    (Side != null &&
                    Side.Equals(input.Side))
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
                ) &&
                (
                    Value == input.Value ||
                    (Value != null &&
                    Value.Equals(input.Value))
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
                if (Side != null)
                {
                    hashCode = hashCode * 59 + Side.GetHashCode();
                }

                if (Timestamp != null)
                {
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                }

                if (Symbol != null)
                {
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
                }

                if (Value != null)
                {
                    hashCode = hashCode * 59 + Value.GetHashCode();
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
