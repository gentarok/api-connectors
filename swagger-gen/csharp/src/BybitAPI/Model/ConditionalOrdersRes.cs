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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BybitAPI.Model
{
    /// <summary>
    /// Get order list response
    /// </summary>
    [DataContract]
    public partial class ConditionalOrdersRes : IEquatable<ConditionalOrdersRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalOrdersRes" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="cursor">cursor.</param>
        public ConditionalOrdersRes(List<V2ConditionalListRes> data = default, string cursor = default)
        {
            Data = data;
            Cursor = cursor;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<V2ConditionalListRes> Data { get; set; }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionalOrdersRes {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
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
        public override bool Equals(object input) => Equals(input as ConditionalOrdersRes);

        /// <summary>
        /// Returns true if ConditionalOrdersRes instances are equal
        /// </summary>
        /// <param name="input">Instance of ConditionalOrdersRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionalOrdersRes input)
        {
            if (input is null)
            {
                return false;
            }

            return
                (
                    Data == input.Data ||
                    Data is not null &&
                    Data.SequenceEqual(input.Data)
                ) &&
                (
                    Cursor == input.Cursor ||
                    (Cursor is not null &&
                    Cursor.Equals(input.Cursor))
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
                if (Data is not null)
                {
                    hashCode = hashCode * 59 + Data.GetHashCode();
                }

                if (Cursor is not null)
                {
                    hashCode = hashCode * 59 + Cursor.GetHashCode();
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