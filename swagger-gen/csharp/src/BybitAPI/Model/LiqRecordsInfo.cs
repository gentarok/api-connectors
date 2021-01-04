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
    /// LiqRecordsInfo
    /// </summary>
    [DataContract]
    public partial class LiqRecordsInfo : IEquatable<LiqRecordsInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiqRecordsInfo" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="qty">qty.</param>
        /// <param name="side">side.</param>
        /// <param name="time">time.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="price">price.</param>
        public LiqRecordsInfo(int? id = default, int? qty = default, string side = default, int? time = default, string symbol = default, int? price = default)
        {
            Id = id;
            Qty = qty;
            Side = side;
            Time = time;
            Symbol = symbol;
            Price = price;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name = "qty", EmitDefaultValue = false)]
        public int? Qty { get; set; }

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [DataMember(Name = "side", EmitDefaultValue = false)]
        public string Side { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public int? Time { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public int? Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiqRecordsInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
            return Equals(input as LiqRecordsInfo);
        }

        /// <summary>
        /// Returns true if LiqRecordsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LiqRecordsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LiqRecordsInfo input)
        {
            if (input is null)
            {
                return false;
            }

            return
                (
                    Id == input.Id ||
                    (Id is not null &&
                    Id.Equals(input.Id))
                ) &&
                (
                    Qty == input.Qty ||
                    (Qty is not null &&
                    Qty.Equals(input.Qty))
                ) &&
                (
                    Side == input.Side ||
                    (Side is not null &&
                    Side.Equals(input.Side))
                ) &&
                (
                    Time == input.Time ||
                    (Time is not null &&
                    Time.Equals(input.Time))
                ) &&
                (
                    Symbol == input.Symbol ||
                    (Symbol is not null &&
                    Symbol.Equals(input.Symbol))
                ) &&
                (
                    Price == input.Price ||
                    (Price is not null &&
                    Price.Equals(input.Price))
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
                if (Id is not null)
                {
                    hashCode = hashCode * 59 + Id.GetHashCode();
                }

                if (Qty is not null)
                {
                    hashCode = hashCode * 59 + Qty.GetHashCode();
                }

                if (Side is not null)
                {
                    hashCode = hashCode * 59 + Side.GetHashCode();
                }

                if (Time is not null)
                {
                    hashCode = hashCode * 59 + Time.GetHashCode();
                }

                if (Symbol is not null)
                {
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
                }

                if (Price is not null)
                {
                    hashCode = hashCode * 59 + Price.GetHashCode();
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
