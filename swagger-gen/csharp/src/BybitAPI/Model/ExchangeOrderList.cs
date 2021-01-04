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
    /// Asset Exchange Records
    /// </summary>
    [DataContract]
    public partial class ExchangeOrderList : IEquatable<ExchangeOrderList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeOrderList" /> class.
        /// </summary>
        /// <param name="fromCoin">fromCoin.</param>
        /// <param name="toCoin">toCoin.</param>
        /// <param name="fromAmount">fromAmount.</param>
        /// <param name="toAmount">toAmount.</param>
        /// <param name="exchangeRate">exchangeRate.</param>
        /// <param name="fromFee">fromFee.</param>
        /// <param name="createdAt">createdAt.</param>
        public ExchangeOrderList(string fromCoin = default, string toCoin = default, decimal? fromAmount = default, decimal? toAmount = default, decimal? exchangeRate = default, decimal? fromFee = default, string createdAt = default)
        {
            FromCoin = fromCoin;
            ToCoin = toCoin;
            FromAmount = fromAmount;
            ToAmount = toAmount;
            ExchangeRate = exchangeRate;
            FromFee = fromFee;
            CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets FromCoin
        /// </summary>
        [DataMember(Name = "from_coin", EmitDefaultValue = false)]
        public string FromCoin { get; set; }

        /// <summary>
        /// Gets or Sets ToCoin
        /// </summary>
        [DataMember(Name = "to_coin", EmitDefaultValue = false)]
        public string ToCoin { get; set; }

        /// <summary>
        /// Gets or Sets FromAmount
        /// </summary>
        [DataMember(Name = "from_amount", EmitDefaultValue = false)]
        public decimal? FromAmount { get; set; }

        /// <summary>
        /// Gets or Sets ToAmount
        /// </summary>
        [DataMember(Name = "to_amount", EmitDefaultValue = false)]
        public decimal? ToAmount { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRate
        /// </summary>
        [DataMember(Name = "exchange_rate", EmitDefaultValue = false)]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Gets or Sets FromFee
        /// </summary>
        [DataMember(Name = "from_fee", EmitDefaultValue = false)]
        public decimal? FromFee { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeOrderList {\n");
            sb.Append("  FromCoin: ").Append(FromCoin).Append("\n");
            sb.Append("  ToCoin: ").Append(ToCoin).Append("\n");
            sb.Append("  FromAmount: ").Append(FromAmount).Append("\n");
            sb.Append("  ToAmount: ").Append(ToAmount).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  FromFee: ").Append(FromFee).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return Equals(input as ExchangeOrderList);
        }

        /// <summary>
        /// Returns true if ExchangeOrderList instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeOrderList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeOrderList input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    FromCoin == input.FromCoin ||
                    (FromCoin != null &&
                    FromCoin.Equals(input.FromCoin))
                ) &&
                (
                    ToCoin == input.ToCoin ||
                    (ToCoin != null &&
                    ToCoin.Equals(input.ToCoin))
                ) &&
                (
                    FromAmount == input.FromAmount ||
                    (FromAmount != null &&
                    FromAmount.Equals(input.FromAmount))
                ) &&
                (
                    ToAmount == input.ToAmount ||
                    (ToAmount != null &&
                    ToAmount.Equals(input.ToAmount))
                ) &&
                (
                    ExchangeRate == input.ExchangeRate ||
                    (ExchangeRate != null &&
                    ExchangeRate.Equals(input.ExchangeRate))
                ) &&
                (
                    FromFee == input.FromFee ||
                    (FromFee != null &&
                    FromFee.Equals(input.FromFee))
                ) &&
                (
                    CreatedAt == input.CreatedAt ||
                    (CreatedAt != null &&
                    CreatedAt.Equals(input.CreatedAt))
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
                if (FromCoin != null)
                {
                    hashCode = hashCode * 59 + FromCoin.GetHashCode();
                }

                if (ToCoin != null)
                {
                    hashCode = hashCode * 59 + ToCoin.GetHashCode();
                }

                if (FromAmount != null)
                {
                    hashCode = hashCode * 59 + FromAmount.GetHashCode();
                }

                if (ToAmount != null)
                {
                    hashCode = hashCode * 59 + ToAmount.GetHashCode();
                }

                if (ExchangeRate != null)
                {
                    hashCode = hashCode * 59 + ExchangeRate.GetHashCode();
                }

                if (FromFee != null)
                {
                    hashCode = hashCode * 59 + FromFee.GetHashCode();
                }

                if (CreatedAt != null)
                {
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
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
