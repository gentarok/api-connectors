/* 
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api.bybit.com]  
 *
 * OpenAPI spec version: 0.2.10
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = BybitAPI.Client.SwaggerDateConverter;

namespace BybitAPI.Model
{
    /// <summary>
    /// Get the last funding Rate
    /// </summary>
    [DataContract]
    public partial class FundingRate :  IEquatable<FundingRate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundingRate" /> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="fundingRate">fundingRate.</param>
        /// <param name="fundingRateTimestamp">fundingRateTimestamp.</param>
        public FundingRate(string symbol = default(string), string fundingRate = default(string), decimal? fundingRateTimestamp = default(decimal?))
        {
            this.Symbol = symbol;
            this._FundingRate = fundingRate;
            this.FundingRateTimestamp = fundingRateTimestamp;
        }
        
        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets _FundingRate
        /// </summary>
        [DataMember(Name="funding_rate", EmitDefaultValue=false)]
        public string _FundingRate { get; set; }

        /// <summary>
        /// Gets or Sets FundingRateTimestamp
        /// </summary>
        [DataMember(Name="funding_rate_timestamp", EmitDefaultValue=false)]
        public decimal? FundingRateTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundingRate {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  _FundingRate: ").Append(_FundingRate).Append("\n");
            sb.Append("  FundingRateTimestamp: ").Append(FundingRateTimestamp).Append("\n");
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
            return this.Equals(input as FundingRate);
        }

        /// <summary>
        /// Returns true if FundingRate instances are equal
        /// </summary>
        /// <param name="input">Instance of FundingRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundingRate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this._FundingRate == input._FundingRate ||
                    (this._FundingRate != null &&
                    this._FundingRate.Equals(input._FundingRate))
                ) && 
                (
                    this.FundingRateTimestamp == input.FundingRateTimestamp ||
                    (this.FundingRateTimestamp != null &&
                    this.FundingRateTimestamp.Equals(input.FundingRateTimestamp))
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
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this._FundingRate != null)
                    hashCode = hashCode * 59 + this._FundingRate.GetHashCode();
                if (this.FundingRateTimestamp != null)
                    hashCode = hashCode * 59 + this.FundingRateTimestamp.GetHashCode();
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
