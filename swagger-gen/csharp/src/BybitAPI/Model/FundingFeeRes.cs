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
    /// Get the last funding fee
    /// </summary>
    [DataContract]
    public partial class FundingFeeRes : IEquatable<FundingFeeRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundingFeeRes" /> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="side">side.</param>
        /// <param name="size">size.</param>
        /// <param name="fundingRate">fundingRate.</param>
        /// <param name="execFee">execFee.</param>
        /// <param name="execTimestamp">execTimestamp.</param>
        public FundingFeeRes(string symbol = default, string side = default, decimal? size = default, string fundingRate = default, double? execFee = default, decimal? execTimestamp = default)
        {
            Symbol = symbol;
            Side = side;
            Size = size;
            FundingRate = fundingRate;
            ExecFee = execFee;
            ExecTimestamp = execTimestamp;
        }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [DataMember(Name = "side", EmitDefaultValue = false)]
        public string Side { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// Gets or Sets FundingRate
        /// </summary>
        [DataMember(Name = "funding_rate", EmitDefaultValue = false)]
        public string FundingRate { get; set; }

        /// <summary>
        /// Gets or Sets ExecFee
        /// </summary>
        [DataMember(Name = "exec_fee", EmitDefaultValue = false)]
        public double? ExecFee { get; set; }

        /// <summary>
        /// Gets or Sets ExecTimestamp
        /// </summary>
        [DataMember(Name = "exec_timestamp", EmitDefaultValue = false)]
        public decimal? ExecTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundingFeeRes {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  FundingRate: ").Append(FundingRate).Append("\n");
            sb.Append("  ExecFee: ").Append(ExecFee).Append("\n");
            sb.Append("  ExecTimestamp: ").Append(ExecTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input) => Equals(input as FundingFeeRes);

        /// <summary>
        /// Returns true if FundingFeeRes instances are equal
        /// </summary>
        /// <param name="input">Instance of FundingFeeRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundingFeeRes input)
        {
            if (input is null)
            {
                return false;
            }

            return
                (
                    Symbol == input.Symbol ||
                    (Symbol is not null &&
                    Symbol.Equals(input.Symbol))
                ) &&
                (
                    Side == input.Side ||
                    (Side is not null &&
                    Side.Equals(input.Side))
                ) &&
                (
                    Size == input.Size ||
                    (Size is not null &&
                    Size.Equals(input.Size))
                ) &&
                (
                    FundingRate == input.FundingRate ||
                    (FundingRate is not null &&
                    FundingRate.Equals(input.FundingRate))
                ) &&
                (
                    ExecFee == input.ExecFee ||
                    (ExecFee is not null &&
                    ExecFee.Equals(input.ExecFee))
                ) &&
                (
                    ExecTimestamp == input.ExecTimestamp ||
                    (ExecTimestamp is not null &&
                    ExecTimestamp.Equals(input.ExecTimestamp))
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
                if (Symbol is not null)
                {
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
                }

                if (Side is not null)
                {
                    hashCode = hashCode * 59 + Side.GetHashCode();
                }

                if (Size is not null)
                {
                    hashCode = hashCode * 59 + Size.GetHashCode();
                }

                if (FundingRate is not null)
                {
                    hashCode = hashCode * 59 + FundingRate.GetHashCode();
                }

                if (ExecFee is not null)
                {
                    hashCode = hashCode * 59 + ExecFee.GetHashCode();
                }

                if (ExecTimestamp is not null)
                {
                    hashCode = hashCode * 59 + ExecTimestamp.GetHashCode();
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
