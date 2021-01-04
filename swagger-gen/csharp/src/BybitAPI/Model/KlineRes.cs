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
    /// Get the orderbook response
    /// </summary>
    [DataContract]
    public partial class KlineRes : IEquatable<KlineRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KlineRes" /> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="interval">interval.</param>
        /// <param name="openTime">openTime.</param>
        /// <param name="open">open.</param>
        /// <param name="high">high.</param>
        /// <param name="low">low.</param>
        /// <param name="close">close.</param>
        /// <param name="volume">volume.</param>
        public KlineRes(string symbol = default(string), string interval = default(string), decimal? openTime = default(decimal?), string open = default(string), string high = default(string), string low = default(string), string close = default(string), string volume = default(string))
        {
            this.Symbol = symbol;
            this.Interval = interval;
            this.OpenTime = openTime;
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
            this.Volume = volume;
        }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public string Interval { get; set; }

        /// <summary>
        /// Gets or Sets OpenTime
        /// </summary>
        [DataMember(Name = "open_time", EmitDefaultValue = false)]
        public decimal? OpenTime { get; set; }

        /// <summary>
        /// Gets or Sets Open
        /// </summary>
        [DataMember(Name = "open", EmitDefaultValue = false)]
        public string Open { get; set; }

        /// <summary>
        /// Gets or Sets High
        /// </summary>
        [DataMember(Name = "high", EmitDefaultValue = false)]
        public string High { get; set; }

        /// <summary>
        /// Gets or Sets Low
        /// </summary>
        [DataMember(Name = "low", EmitDefaultValue = false)]
        public string Low { get; set; }

        /// <summary>
        /// Gets or Sets Close
        /// </summary>
        [DataMember(Name = "close", EmitDefaultValue = false)]
        public string Close { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public string Volume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KlineRes {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  OpenTime: ").Append(OpenTime).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
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
            return this.Equals(input as KlineRes);
        }

        /// <summary>
        /// Returns true if KlineRes instances are equal
        /// </summary>
        /// <param name="input">Instance of KlineRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KlineRes input)
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
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) &&
                (
                    this.OpenTime == input.OpenTime ||
                    (this.OpenTime != null &&
                    this.OpenTime.Equals(input.OpenTime))
                ) &&
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) &&
                (
                    this.High == input.High ||
                    (this.High != null &&
                    this.High.Equals(input.High))
                ) &&
                (
                    this.Low == input.Low ||
                    (this.Low != null &&
                    this.Low.Equals(input.Low))
                ) &&
                (
                    this.Close == input.Close ||
                    (this.Close != null &&
                    this.Close.Equals(input.Close))
                ) &&
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
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
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.OpenTime != null)
                    hashCode = hashCode * 59 + this.OpenTime.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.Close != null)
                    hashCode = hashCode * 59 + this.Close.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
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