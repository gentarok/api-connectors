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
    /// LinearListOrderResult
    /// </summary>
    [DataContract]
    public partial class LinearListOrderResult : IEquatable<LinearListOrderResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinearListOrderResult" /> class.
        /// </summary>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="cumExecFee">cumExecFee.</param>
        /// <param name="cumExecQty">cumExecQty.</param>
        /// <param name="cumExecValue">cumExecValue.</param>
        /// <param name="lastExecPrice">lastExecPrice.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="orderLinkId">orderLinkId.</param>
        /// <param name="orderStatus">orderStatus.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="price">price.</param>
        /// <param name="qty">qty.</param>
        /// <param name="reduceOnly">reduceOnly.</param>
        /// <param name="side">side.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="timeInForce">timeInForce.</param>
        /// <param name="updatedTime">updatedTime.</param>
        /// <param name="userId">userId.</param>
        /// <param name="takeProfit">takeProfit.</param>
        /// <param name="stopLoss">stopLoss.</param>
        /// <param name="tpTriggerBy">tpTriggerBy.</param>
        /// <param name="slTriggerBy">slTriggerBy.</param>
        public LinearListOrderResult(string createdTime = default, double? cumExecFee = default, double? cumExecQty = default, double? cumExecValue = default, double? lastExecPrice = default, string orderId = default, string orderLinkId = default, string orderStatus = default, string orderType = default, double? price = default, double? qty = default, bool? reduceOnly = default, string side = default, string symbol = default, string timeInForce = default, string updatedTime = default, long? userId = default, double? takeProfit = default, double? stopLoss = default, string tpTriggerBy = default, string slTriggerBy = default)
        {
            CreatedTime = createdTime;
            CumExecFee = cumExecFee;
            CumExecQty = cumExecQty;
            CumExecValue = cumExecValue;
            LastExecPrice = lastExecPrice;
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            OrderStatus = orderStatus;
            OrderType = orderType;
            Price = price;
            Qty = qty;
            ReduceOnly = reduceOnly;
            Side = side;
            Symbol = symbol;
            TimeInForce = timeInForce;
            UpdatedTime = updatedTime;
            UserId = userId;
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            TpTriggerBy = tpTriggerBy;
            SlTriggerBy = slTriggerBy;
        }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "created_time", EmitDefaultValue = false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets CumExecFee
        /// </summary>
        [DataMember(Name = "cum_exec_fee", EmitDefaultValue = false)]
        public double? CumExecFee { get; set; }

        /// <summary>
        /// Gets or Sets CumExecQty
        /// </summary>
        [DataMember(Name = "cum_exec_qty", EmitDefaultValue = false)]
        public double? CumExecQty { get; set; }

        /// <summary>
        /// Gets or Sets CumExecValue
        /// </summary>
        [DataMember(Name = "cum_exec_value", EmitDefaultValue = false)]
        public double? CumExecValue { get; set; }

        /// <summary>
        /// Gets or Sets LastExecPrice
        /// </summary>
        [DataMember(Name = "last_exec_price", EmitDefaultValue = false)]
        public double? LastExecPrice { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets OrderLinkId
        /// </summary>
        [DataMember(Name = "order_link_id", EmitDefaultValue = false)]
        public string OrderLinkId { get; set; }

        /// <summary>
        /// Gets or Sets OrderStatus
        /// </summary>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name = "order_type", EmitDefaultValue = false)]
        public string OrderType { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name = "qty", EmitDefaultValue = false)]
        public double? Qty { get; set; }

        /// <summary>
        /// Gets or Sets ReduceOnly
        /// </summary>
        [DataMember(Name = "reduce_only", EmitDefaultValue = false)]
        public bool? ReduceOnly { get; set; }

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
        /// Gets or Sets TimeInForce
        /// </summary>
        [DataMember(Name = "time_in_force", EmitDefaultValue = false)]
        public string TimeInForce { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedTime
        /// </summary>
        [DataMember(Name = "updated_time", EmitDefaultValue = false)]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or Sets TakeProfit
        /// </summary>
        [DataMember(Name = "take_profit", EmitDefaultValue = false)]
        public double? TakeProfit { get; set; }

        /// <summary>
        /// Gets or Sets StopLoss
        /// </summary>
        [DataMember(Name = "stop_loss", EmitDefaultValue = false)]
        public double? StopLoss { get; set; }

        /// <summary>
        /// Gets or Sets TpTriggerBy
        /// </summary>
        [DataMember(Name = "tp_trigger_by", EmitDefaultValue = false)]
        public string TpTriggerBy { get; set; }

        /// <summary>
        /// Gets or Sets SlTriggerBy
        /// </summary>
        [DataMember(Name = "sl_trigger_by", EmitDefaultValue = false)]
        public string SlTriggerBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinearListOrderResult {\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  CumExecFee: ").Append(CumExecFee).Append("\n");
            sb.Append("  CumExecQty: ").Append(CumExecQty).Append("\n");
            sb.Append("  CumExecValue: ").Append(CumExecValue).Append("\n");
            sb.Append("  LastExecPrice: ").Append(LastExecPrice).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderLinkId: ").Append(OrderLinkId).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  ReduceOnly: ").Append(ReduceOnly).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  UpdatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TakeProfit: ").Append(TakeProfit).Append("\n");
            sb.Append("  StopLoss: ").Append(StopLoss).Append("\n");
            sb.Append("  TpTriggerBy: ").Append(TpTriggerBy).Append("\n");
            sb.Append("  SlTriggerBy: ").Append(SlTriggerBy).Append("\n");
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
        public override bool Equals(object input) => Equals(input as LinearListOrderResult);

        /// <summary>
        /// Returns true if LinearListOrderResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LinearListOrderResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinearListOrderResult input)
        {
            if (input is null)
            {
                return false;
            }

            return
                (
                    CreatedTime == input.CreatedTime ||
                    (CreatedTime is not null &&
                    CreatedTime.Equals(input.CreatedTime))
                ) &&
                (
                    CumExecFee == input.CumExecFee ||
                    (CumExecFee is not null &&
                    CumExecFee.Equals(input.CumExecFee))
                ) &&
                (
                    CumExecQty == input.CumExecQty ||
                    (CumExecQty is not null &&
                    CumExecQty.Equals(input.CumExecQty))
                ) &&
                (
                    CumExecValue == input.CumExecValue ||
                    (CumExecValue is not null &&
                    CumExecValue.Equals(input.CumExecValue))
                ) &&
                (
                    LastExecPrice == input.LastExecPrice ||
                    (LastExecPrice is not null &&
                    LastExecPrice.Equals(input.LastExecPrice))
                ) &&
                (
                    OrderId == input.OrderId ||
                    (OrderId is not null &&
                    OrderId.Equals(input.OrderId))
                ) &&
                (
                    OrderLinkId == input.OrderLinkId ||
                    (OrderLinkId is not null &&
                    OrderLinkId.Equals(input.OrderLinkId))
                ) &&
                (
                    OrderStatus == input.OrderStatus ||
                    (OrderStatus is not null &&
                    OrderStatus.Equals(input.OrderStatus))
                ) &&
                (
                    OrderType == input.OrderType ||
                    (OrderType is not null &&
                    OrderType.Equals(input.OrderType))
                ) &&
                (
                    Price == input.Price ||
                    (Price is not null &&
                    Price.Equals(input.Price))
                ) &&
                (
                    Qty == input.Qty ||
                    (Qty is not null &&
                    Qty.Equals(input.Qty))
                ) &&
                (
                    ReduceOnly == input.ReduceOnly ||
                    (ReduceOnly is not null &&
                    ReduceOnly.Equals(input.ReduceOnly))
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
                    TimeInForce == input.TimeInForce ||
                    (TimeInForce is not null &&
                    TimeInForce.Equals(input.TimeInForce))
                ) &&
                (
                    UpdatedTime == input.UpdatedTime ||
                    (UpdatedTime is not null &&
                    UpdatedTime.Equals(input.UpdatedTime))
                ) &&
                (
                    UserId == input.UserId ||
                    (UserId is not null &&
                    UserId.Equals(input.UserId))
                ) &&
                (
                    TakeProfit == input.TakeProfit ||
                    (TakeProfit is not null &&
                    TakeProfit.Equals(input.TakeProfit))
                ) &&
                (
                    StopLoss == input.StopLoss ||
                    (StopLoss is not null &&
                    StopLoss.Equals(input.StopLoss))
                ) &&
                (
                    TpTriggerBy == input.TpTriggerBy ||
                    (TpTriggerBy is not null &&
                    TpTriggerBy.Equals(input.TpTriggerBy))
                ) &&
                (
                    SlTriggerBy == input.SlTriggerBy ||
                    (SlTriggerBy is not null &&
                    SlTriggerBy.Equals(input.SlTriggerBy))
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
                if (CreatedTime is not null)
                {
                    hashCode = hashCode * 59 + CreatedTime.GetHashCode();
                }

                if (CumExecFee is not null)
                {
                    hashCode = hashCode * 59 + CumExecFee.GetHashCode();
                }

                if (CumExecQty is not null)
                {
                    hashCode = hashCode * 59 + CumExecQty.GetHashCode();
                }

                if (CumExecValue is not null)
                {
                    hashCode = hashCode * 59 + CumExecValue.GetHashCode();
                }

                if (LastExecPrice is not null)
                {
                    hashCode = hashCode * 59 + LastExecPrice.GetHashCode();
                }

                if (OrderId is not null)
                {
                    hashCode = hashCode * 59 + OrderId.GetHashCode();
                }

                if (OrderLinkId is not null)
                {
                    hashCode = hashCode * 59 + OrderLinkId.GetHashCode();
                }

                if (OrderStatus is not null)
                {
                    hashCode = hashCode * 59 + OrderStatus.GetHashCode();
                }

                if (OrderType is not null)
                {
                    hashCode = hashCode * 59 + OrderType.GetHashCode();
                }

                if (Price is not null)
                {
                    hashCode = hashCode * 59 + Price.GetHashCode();
                }

                if (Qty is not null)
                {
                    hashCode = hashCode * 59 + Qty.GetHashCode();
                }

                if (ReduceOnly is not null)
                {
                    hashCode = hashCode * 59 + ReduceOnly.GetHashCode();
                }

                if (Side is not null)
                {
                    hashCode = hashCode * 59 + Side.GetHashCode();
                }

                if (Symbol is not null)
                {
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
                }

                if (TimeInForce is not null)
                {
                    hashCode = hashCode * 59 + TimeInForce.GetHashCode();
                }

                if (UpdatedTime is not null)
                {
                    hashCode = hashCode * 59 + UpdatedTime.GetHashCode();
                }

                if (UserId is not null)
                {
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                }

                if (TakeProfit is not null)
                {
                    hashCode = hashCode * 59 + TakeProfit.GetHashCode();
                }

                if (StopLoss is not null)
                {
                    hashCode = hashCode * 59 + StopLoss.GetHashCode();
                }

                if (TpTriggerBy is not null)
                {
                    hashCode = hashCode * 59 + TpTriggerBy.GetHashCode();
                }

                if (SlTriggerBy is not null)
                {
                    hashCode = hashCode * 59 + SlTriggerBy.GetHashCode();
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