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
    /// Set risk limit.
    /// </summary>
    [DataContract]
    public partial class RiskIDRes : IEquatable<RiskIDRes>, IValidatableObject
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
        public RiskIDRes(decimal? id = default, string coin = default, decimal? limit = default, string maintainMargin = default, string startingMargin = default, string section = default, decimal? isLowestRisk = default, string createdAt = default, string updatedAt = default)
        {
            Id = id;
            Coin = coin;
            Limit = limit;
            MaintainMargin = maintainMargin;
            StartingMargin = startingMargin;
            Section = section;
            IsLowestRisk = isLowestRisk;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public decimal? Id { get; set; }

        /// <summary>
        /// Gets or Sets Coin
        /// </summary>
        [DataMember(Name = "coin", EmitDefaultValue = false)]
        public string Coin { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public decimal? Limit { get; set; }

        /// <summary>
        /// Gets or Sets MaintainMargin
        /// </summary>
        [DataMember(Name = "maintain_margin", EmitDefaultValue = false)]
        public string MaintainMargin { get; set; }

        /// <summary>
        /// Gets or Sets StartingMargin
        /// </summary>
        [DataMember(Name = "starting_margin", EmitDefaultValue = false)]
        public string StartingMargin { get; set; }

        /// <summary>
        /// Gets or Sets Section
        /// </summary>
        [DataMember(Name = "section", EmitDefaultValue = false)]
        public string Section { get; set; }

        /// <summary>
        /// Gets or Sets IsLowestRisk
        /// </summary>
        [DataMember(Name = "is_lowest_risk", EmitDefaultValue = false)]
        public decimal? IsLowestRisk { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
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
            return Equals(input as RiskIDRes);
        }

        /// <summary>
        /// Returns true if RiskIDRes instances are equal
        /// </summary>
        /// <param name="input">Instance of RiskIDRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskIDRes input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) &&
                (
                    Coin == input.Coin ||
                    (Coin != null &&
                    Coin.Equals(input.Coin))
                ) &&
                (
                    Limit == input.Limit ||
                    (Limit != null &&
                    Limit.Equals(input.Limit))
                ) &&
                (
                    MaintainMargin == input.MaintainMargin ||
                    (MaintainMargin != null &&
                    MaintainMargin.Equals(input.MaintainMargin))
                ) &&
                (
                    StartingMargin == input.StartingMargin ||
                    (StartingMargin != null &&
                    StartingMargin.Equals(input.StartingMargin))
                ) &&
                (
                    Section == input.Section ||
                    (Section != null &&
                    Section.Equals(input.Section))
                ) &&
                (
                    IsLowestRisk == input.IsLowestRisk ||
                    (IsLowestRisk != null &&
                    IsLowestRisk.Equals(input.IsLowestRisk))
                ) &&
                (
                    CreatedAt == input.CreatedAt ||
                    (CreatedAt != null &&
                    CreatedAt.Equals(input.CreatedAt))
                ) &&
                (
                    UpdatedAt == input.UpdatedAt ||
                    (UpdatedAt != null &&
                    UpdatedAt.Equals(input.UpdatedAt))
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
                if (Id != null)
                {
                    hashCode = hashCode * 59 + Id.GetHashCode();
                }

                if (Coin != null)
                {
                    hashCode = hashCode * 59 + Coin.GetHashCode();
                }

                if (Limit != null)
                {
                    hashCode = hashCode * 59 + Limit.GetHashCode();
                }

                if (MaintainMargin != null)
                {
                    hashCode = hashCode * 59 + MaintainMargin.GetHashCode();
                }

                if (StartingMargin != null)
                {
                    hashCode = hashCode * 59 + StartingMargin.GetHashCode();
                }

                if (Section != null)
                {
                    hashCode = hashCode * 59 + Section.GetHashCode();
                }

                if (IsLowestRisk != null)
                {
                    hashCode = hashCode * 59 + IsLowestRisk.GetHashCode();
                }

                if (CreatedAt != null)
                {
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                }

                if (UpdatedAt != null)
                {
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
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
