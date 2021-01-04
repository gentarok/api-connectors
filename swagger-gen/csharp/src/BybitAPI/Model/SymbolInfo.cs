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
    /// SymbolInfo
    /// </summary>
    [DataContract]
    public partial class SymbolInfo : IEquatable<SymbolInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SymbolInfo" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="baseCurrency">baseCurrency.</param>
        /// <param name="quoteCurrency">quoteCurrency.</param>
        /// <param name="priceScale">priceScale.</param>
        /// <param name="priceFilter">priceFilter.</param>
        /// <param name="lotSizeFilter">lotSizeFilter.</param>
        public SymbolInfo(string name = default(string), string baseCurrency = default(string), string quoteCurrency = default(string), decimal? priceScale = default(decimal?), Object priceFilter = default(Object), Object lotSizeFilter = default(Object))
        {
            this.Name = name;
            this.BaseCurrency = baseCurrency;
            this.QuoteCurrency = quoteCurrency;
            this.PriceScale = priceScale;
            this.PriceFilter = priceFilter;
            this.LotSizeFilter = lotSizeFilter;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets BaseCurrency
        /// </summary>
        [DataMember(Name = "base_currency", EmitDefaultValue = false)]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// Gets or Sets QuoteCurrency
        /// </summary>
        [DataMember(Name = "quote_currency", EmitDefaultValue = false)]
        public string QuoteCurrency { get; set; }

        /// <summary>
        /// Gets or Sets PriceScale
        /// </summary>
        [DataMember(Name = "price_scale", EmitDefaultValue = false)]
        public decimal? PriceScale { get; set; }

        /// <summary>
        /// Gets or Sets PriceFilter
        /// </summary>
        [DataMember(Name = "price_filter", EmitDefaultValue = false)]
        public Object PriceFilter { get; set; }

        /// <summary>
        /// Gets or Sets LotSizeFilter
        /// </summary>
        [DataMember(Name = "lot_size_filter", EmitDefaultValue = false)]
        public Object LotSizeFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SymbolInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append("\n");
            sb.Append("  QuoteCurrency: ").Append(QuoteCurrency).Append("\n");
            sb.Append("  PriceScale: ").Append(PriceScale).Append("\n");
            sb.Append("  PriceFilter: ").Append(PriceFilter).Append("\n");
            sb.Append("  LotSizeFilter: ").Append(LotSizeFilter).Append("\n");
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
            return this.Equals(input as SymbolInfo);
        }

        /// <summary>
        /// Returns true if SymbolInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SymbolInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SymbolInfo input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.BaseCurrency == input.BaseCurrency ||
                    (this.BaseCurrency != null &&
                    this.BaseCurrency.Equals(input.BaseCurrency))
                ) &&
                (
                    this.QuoteCurrency == input.QuoteCurrency ||
                    (this.QuoteCurrency != null &&
                    this.QuoteCurrency.Equals(input.QuoteCurrency))
                ) &&
                (
                    this.PriceScale == input.PriceScale ||
                    (this.PriceScale != null &&
                    this.PriceScale.Equals(input.PriceScale))
                ) &&
                (
                    this.PriceFilter == input.PriceFilter ||
                    (this.PriceFilter != null &&
                    this.PriceFilter.Equals(input.PriceFilter))
                ) &&
                (
                    this.LotSizeFilter == input.LotSizeFilter ||
                    (this.LotSizeFilter != null &&
                    this.LotSizeFilter.Equals(input.LotSizeFilter))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BaseCurrency != null)
                    hashCode = hashCode * 59 + this.BaseCurrency.GetHashCode();
                if (this.QuoteCurrency != null)
                    hashCode = hashCode * 59 + this.QuoteCurrency.GetHashCode();
                if (this.PriceScale != null)
                    hashCode = hashCode * 59 + this.PriceScale.GetHashCode();
                if (this.PriceFilter != null)
                    hashCode = hashCode * 59 + this.PriceFilter.GetHashCode();
                if (this.LotSizeFilter != null)
                    hashCode = hashCode * 59 + this.LotSizeFilter.GetHashCode();
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