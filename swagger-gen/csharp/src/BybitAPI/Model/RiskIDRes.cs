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
    /// Set risk limit.
    /// </summary>
    [DataContract]
    public partial class RiskIDRes :  IEquatable<RiskIDRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskIDRes" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="coin">coin.</param>
        /// <param name="limit">limit.</param>
        /// <param name="maintainMargin">maintainMargin.</param>
        /// <param name="startingMargin">startingMargin.</param>
        /// <param name="section">section.</param>
        /// <param name="isLowestRisk">isLowestRisk.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public RiskIDRes(decimal? id = default(decimal?), string coin = default(string), decimal? limit = default(decimal?), string maintainMargin = default(string), string startingMargin = default(string), string section = default(string), decimal? isLowestRisk = default(decimal?), string createdAt = default(string), string updatedAt = default(string))
        {
            this.Id = id;
            this.Coin = coin;
            this.Limit = limit;
            this.MaintainMargin = maintainMargin;
            this.StartingMargin = startingMargin;
            this.Section = section;
            this.IsLowestRisk = isLowestRisk;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public decimal? Id { get; set; }

        /// <summary>
        /// Gets or Sets Coin
        /// </summary>
        [DataMember(Name="coin", EmitDefaultValue=false)]
        public string Coin { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public decimal? Limit { get; set; }

        /// <summary>
        /// Gets or Sets MaintainMargin
        /// </summary>
        [DataMember(Name="maintain_margin", EmitDefaultValue=false)]
        public string MaintainMargin { get; set; }

        /// <summary>
        /// Gets or Sets StartingMargin
        /// </summary>
        [DataMember(Name="starting_margin", EmitDefaultValue=false)]
        public string StartingMargin { get; set; }

        /// <summary>
        /// Gets or Sets Section
        /// </summary>
        [DataMember(Name="section", EmitDefaultValue=false)]
        public string Section { get; set; }

        /// <summary>
        /// Gets or Sets IsLowestRisk
        /// </summary>
        [DataMember(Name="is_lowest_risk", EmitDefaultValue=false)]
        public decimal? IsLowestRisk { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskIDRes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Coin: ").Append(Coin).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  MaintainMargin: ").Append(MaintainMargin).Append("\n");
            sb.Append("  StartingMargin: ").Append(StartingMargin).Append("\n");
            sb.Append("  Section: ").Append(Section).Append("\n");
            sb.Append("  IsLowestRisk: ").Append(IsLowestRisk).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as RiskIDRes);
        }

        /// <summary>
        /// Returns true if RiskIDRes instances are equal
        /// </summary>
        /// <param name="input">Instance of RiskIDRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskIDRes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Coin == input.Coin ||
                    (this.Coin != null &&
                    this.Coin.Equals(input.Coin))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.MaintainMargin == input.MaintainMargin ||
                    (this.MaintainMargin != null &&
                    this.MaintainMargin.Equals(input.MaintainMargin))
                ) && 
                (
                    this.StartingMargin == input.StartingMargin ||
                    (this.StartingMargin != null &&
                    this.StartingMargin.Equals(input.StartingMargin))
                ) && 
                (
                    this.Section == input.Section ||
                    (this.Section != null &&
                    this.Section.Equals(input.Section))
                ) && 
                (
                    this.IsLowestRisk == input.IsLowestRisk ||
                    (this.IsLowestRisk != null &&
                    this.IsLowestRisk.Equals(input.IsLowestRisk))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Coin != null)
                    hashCode = hashCode * 59 + this.Coin.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.MaintainMargin != null)
                    hashCode = hashCode * 59 + this.MaintainMargin.GetHashCode();
                if (this.StartingMargin != null)
                    hashCode = hashCode * 59 + this.StartingMargin.GetHashCode();
                if (this.Section != null)
                    hashCode = hashCode * 59 + this.Section.GetHashCode();
                if (this.IsLowestRisk != null)
                    hashCode = hashCode * 59 + this.IsLowestRisk.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
