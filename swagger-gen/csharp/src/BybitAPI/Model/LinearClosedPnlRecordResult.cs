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
    /// LinearClosedPnlRecordResult
    /// </summary>
    [DataContract]
    public partial class LinearClosedPnlRecordResult : IEquatable<LinearClosedPnlRecordResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinearClosedPnlRecordResult" /> class.
        /// </summary>
        /// <param name="avgEntryPrice">avgEntryPrice.</param>
        /// <param name="avgExitPrice">avgExitPrice.</param>
        /// <param name="closedPnl">closedPnl.</param>
        /// <param name="closedSize">closedSize.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="cumEntryValue">cumEntryValue.</param>
        /// <param name="cumExitValue">cumExitValue.</param>
        /// <param name="execType">execType.</param>
        /// <param name="fillCount">fillCount.</param>
        /// <param name="id">id.</param>
        /// <param name="leverage">leverage.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="orderPrice">orderPrice.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="qty">qty.</param>
        /// <param name="side">side.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="userId">userId.</param>
        public LinearClosedPnlRecordResult(double? avgEntryPrice = default, double? avgExitPrice = default, double? closedPnl = default, double? closedSize = default, long? createdAt = default, double? cumEntryValue = default, double? cumExitValue = default, string execType = default, int? fillCount = default, long? id = default, double? leverage = default, string orderId = default, double? orderPrice = default, string orderType = default, double? qty = default, string side = default, string symbol = default, long? userId = default)
        {
            AvgEntryPrice = avgEntryPrice;
            AvgExitPrice = avgExitPrice;
            ClosedPnl = closedPnl;
            ClosedSize = closedSize;
            CreatedAt = createdAt;
            CumEntryValue = cumEntryValue;
            CumExitValue = cumExitValue;
            ExecType = execType;
            FillCount = fillCount;
            Id = id;
            Leverage = leverage;
            OrderId = orderId;
            OrderPrice = orderPrice;
            OrderType = orderType;
            Qty = qty;
            Side = side;
            Symbol = symbol;
            UserId = userId;
        }

        /// <summary>
        /// Gets or Sets AvgEntryPrice
        /// </summary>
        [DataMember(Name = "avg_entry_price", EmitDefaultValue = false)]
        public double? AvgEntryPrice { get; set; }

        /// <summary>
        /// Gets or Sets AvgExitPrice
        /// </summary>
        [DataMember(Name = "avg_exit_price", EmitDefaultValue = false)]
        public double? AvgExitPrice { get; set; }

        /// <summary>
        /// Gets or Sets ClosedPnl
        /// </summary>
        [DataMember(Name = "closed_pnl", EmitDefaultValue = false)]
        public double? ClosedPnl { get; set; }

        /// <summary>
        /// Gets or Sets ClosedSize
        /// </summary>
        [DataMember(Name = "closed_size", EmitDefaultValue = false)]
        public double? ClosedSize { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CumEntryValue
        /// </summary>
        [DataMember(Name = "cum_entry_value", EmitDefaultValue = false)]
        public double? CumEntryValue { get; set; }

        /// <summary>
        /// Gets or Sets CumExitValue
        /// </summary>
        [DataMember(Name = "cum_exit_value", EmitDefaultValue = false)]
        public double? CumExitValue { get; set; }

        /// <summary>
        /// Gets or Sets ExecType
        /// </summary>
        [DataMember(Name = "exec_type", EmitDefaultValue = false)]
        public string ExecType { get; set; }

        /// <summary>
        /// Gets or Sets FillCount
        /// </summary>
        [DataMember(Name = "fill_count", EmitDefaultValue = false)]
        public int? FillCount { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Leverage
        /// </summary>
        [DataMember(Name = "leverage", EmitDefaultValue = false)]
        public double? Leverage { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets OrderPrice
        /// </summary>
        [DataMember(Name = "order_price", EmitDefaultValue = false)]
        public double? OrderPrice { get; set; }

        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name = "order_type", EmitDefaultValue = false)]
        public string OrderType { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name = "qty", EmitDefaultValue = false)]
        public double? Qty { get; set; }

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [DataMember(Name = "side", EmitDefaultValue = false)]
        public string Side { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinearClosedPnlRecordResult {\n");
            sb.Append("  AvgEntryPrice: ").Append(AvgEntryPrice).Append("\n");
            sb.Append("  AvgExitPrice: ").Append(AvgExitPrice).Append("\n");
            sb.Append("  ClosedPnl: ").Append(ClosedPnl).Append("\n");
            sb.Append("  ClosedSize: ").Append(ClosedSize).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CumEntryValue: ").Append(CumEntryValue).Append("\n");
            sb.Append("  CumExitValue: ").Append(CumExitValue).Append("\n");
            sb.Append("  ExecType: ").Append(ExecType).Append("\n");
            sb.Append("  FillCount: ").Append(FillCount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Leverage: ").Append(Leverage).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderPrice: ").Append(OrderPrice).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return Equals(input as LinearClosedPnlRecordResult);
        }

        /// <summary>
        /// Returns true if LinearClosedPnlRecordResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LinearClosedPnlRecordResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinearClosedPnlRecordResult input)
        {
            if (input is null)
            {
                return false;
            }

            return
                (
                    AvgEntryPrice == input.AvgEntryPrice ||
                    (AvgEntryPrice is not null &&
                    AvgEntryPrice.Equals(input.AvgEntryPrice))
                ) &&
                (
                    AvgExitPrice == input.AvgExitPrice ||
                    (AvgExitPrice is not null &&
                    AvgExitPrice.Equals(input.AvgExitPrice))
                ) &&
                (
                    ClosedPnl == input.ClosedPnl ||
                    (ClosedPnl is not null &&
                    ClosedPnl.Equals(input.ClosedPnl))
                ) &&
                (
                    ClosedSize == input.ClosedSize ||
                    (ClosedSize is not null &&
                    ClosedSize.Equals(input.ClosedSize))
                ) &&
                (
                    CreatedAt == input.CreatedAt ||
                    (CreatedAt is not null &&
                    CreatedAt.Equals(input.CreatedAt))
                ) &&
                (
                    CumEntryValue == input.CumEntryValue ||
                    (CumEntryValue is not null &&
                    CumEntryValue.Equals(input.CumEntryValue))
                ) &&
                (
                    CumExitValue == input.CumExitValue ||
                    (CumExitValue is not null &&
                    CumExitValue.Equals(input.CumExitValue))
                ) &&
                (
                    ExecType == input.ExecType ||
                    (ExecType is not null &&
                    ExecType.Equals(input.ExecType))
                ) &&
                (
                    FillCount == input.FillCount ||
                    (FillCount is not null &&
                    FillCount.Equals(input.FillCount))
                ) &&
                (
                    Id == input.Id ||
                    (Id is not null &&
                    Id.Equals(input.Id))
                ) &&
                (
                    Leverage == input.Leverage ||
                    (Leverage is not null &&
                    Leverage.Equals(input.Leverage))
                ) &&
                (
                    OrderId == input.OrderId ||
                    (OrderId is not null &&
                    OrderId.Equals(input.OrderId))
                ) &&
                (
                    OrderPrice == input.OrderPrice ||
                    (OrderPrice is not null &&
                    OrderPrice.Equals(input.OrderPrice))
                ) &&
                (
                    OrderType == input.OrderType ||
                    (OrderType is not null &&
                    OrderType.Equals(input.OrderType))
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
                    Symbol == input.Symbol ||
                    (Symbol is not null &&
                    Symbol.Equals(input.Symbol))
                ) &&
                (
                    UserId == input.UserId ||
                    (UserId is not null &&
                    UserId.Equals(input.UserId))
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
                if (AvgEntryPrice is not null)
                {
                    hashCode = hashCode * 59 + AvgEntryPrice.GetHashCode();
                }

                if (AvgExitPrice is not null)
                {
                    hashCode = hashCode * 59 + AvgExitPrice.GetHashCode();
                }

                if (ClosedPnl is not null)
                {
                    hashCode = hashCode * 59 + ClosedPnl.GetHashCode();
                }

                if (ClosedSize is not null)
                {
                    hashCode = hashCode * 59 + ClosedSize.GetHashCode();
                }

                if (CreatedAt is not null)
                {
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                }

                if (CumEntryValue is not null)
                {
                    hashCode = hashCode * 59 + CumEntryValue.GetHashCode();
                }

                if (CumExitValue is not null)
                {
                    hashCode = hashCode * 59 + CumExitValue.GetHashCode();
                }

                if (ExecType is not null)
                {
                    hashCode = hashCode * 59 + ExecType.GetHashCode();
                }

                if (FillCount is not null)
                {
                    hashCode = hashCode * 59 + FillCount.GetHashCode();
                }

                if (Id is not null)
                {
                    hashCode = hashCode * 59 + Id.GetHashCode();
                }

                if (Leverage is not null)
                {
                    hashCode = hashCode * 59 + Leverage.GetHashCode();
                }

                if (OrderId is not null)
                {
                    hashCode = hashCode * 59 + OrderId.GetHashCode();
                }

                if (OrderPrice is not null)
                {
                    hashCode = hashCode * 59 + OrderPrice.GetHashCode();
                }

                if (OrderType is not null)
                {
                    hashCode = hashCode * 59 + OrderType.GetHashCode();
                }

                if (Qty is not null)
                {
                    hashCode = hashCode * 59 + Qty.GetHashCode();
                }

                if (Side is not null)
                {
                    hashCode = hashCode * 59 + Side.GetHashCode();
                }

                if (Symbol is not null)
                {
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
                }

                if (UserId is not null)
                {
                    hashCode = hashCode * 59 + UserId.GetHashCode();
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
