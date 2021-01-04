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
    /// LotSizeFilter
    /// </summary>
    [DataContract]
    public partial class LotSizeFilter : IEquatable<LotSizeFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LotSizeFilter" /> class.
        /// </summary>
        /// <param name="minTradingQty">minTradingQty.</param>
        /// <param name="maxTradingQty">maxTradingQty.</param>
        /// <param name="qtyStep">qtyStep.</param>
        public LotSizeFilter(object minTradingQty = default, object maxTradingQty = default, object qtyStep = default)
        {
            MinTradingQty = minTradingQty;
            MaxTradingQty = maxTradingQty;
            QtyStep = qtyStep;
        }

        /// <summary>
        /// Gets or Sets MinTradingQty
        /// </summary>
        [DataMember(Name = "min_trading_qty", EmitDefaultValue = false)]
        public object MinTradingQty { get; set; }

        /// <summary>
        /// Gets or Sets MaxTradingQty
        /// </summary>
        [DataMember(Name = "max_trading_qty", EmitDefaultValue = false)]
        public object MaxTradingQty { get; set; }

        /// <summary>
        /// Gets or Sets QtyStep
        /// </summary>
        [DataMember(Name = "qty_step", EmitDefaultValue = false)]
        public object QtyStep { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LotSizeFilter {\n");
            sb.Append("  MinTradingQty: ").Append(MinTradingQty).Append("\n");
            sb.Append("  MaxTradingQty: ").Append(MaxTradingQty).Append("\n");
            sb.Append("  QtyStep: ").Append(QtyStep).Append("\n");
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
            return Equals(input as LotSizeFilter);
        }

        /// <summary>
        /// Returns true if LotSizeFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of LotSizeFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LotSizeFilter input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    MinTradingQty == input.MinTradingQty ||
                    (MinTradingQty != null &&
                    MinTradingQty.Equals(input.MinTradingQty))
                ) &&
                (
                    MaxTradingQty == input.MaxTradingQty ||
                    (MaxTradingQty != null &&
                    MaxTradingQty.Equals(input.MaxTradingQty))
                ) &&
                (
                    QtyStep == input.QtyStep ||
                    (QtyStep != null &&
                    QtyStep.Equals(input.QtyStep))
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
                if (MinTradingQty != null)
                {
                    hashCode = hashCode * 59 + MinTradingQty.GetHashCode();
                }

                if (MaxTradingQty != null)
                {
                    hashCode = hashCode * 59 + MaxTradingQty.GetHashCode();
                }

                if (QtyStep != null)
                {
                    hashCode = hashCode * 59 + QtyStep.GetHashCode();
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
