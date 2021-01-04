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
    /// Create Linear Order
    /// </summary>
    [DataContract]
    public partial class LinearCreateOrderResult : IEquatable<LinearCreateOrderResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinearCreateOrderResult" /> class.
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
        public LinearCreateOrderResult(string createdTime = default(string), double? cumExecFee = default(double?), double? cumExecQty = default(double?), double? cumExecValue = default(double?), double? lastExecPrice = default(double?), string orderId = default(string), string orderLinkId = default(string), string orderStatus = default(string), string orderType = default(string), double? price = default(double?), double? qty = default(double?), bool? reduceOnly = default(bool?), string side = default(string), string symbol = default(string), string timeInForce = default(string), string updatedTime = default(string), long? userId = default(long?), double? takeProfit = default(double?), double? stopLoss = default(double?), string tpTriggerBy = default(string), string slTriggerBy = default(string))
        {
            this.CreatedTime = createdTime;
            this.CumExecFee = cumExecFee;
            this.CumExecQty = cumExecQty;
            this.CumExecValue = cumExecValue;
            this.LastExecPrice = lastExecPrice;
            this.OrderId = orderId;
            this.OrderLinkId = orderLinkId;
            this.OrderStatus = orderStatus;
            this.OrderType = orderType;
            this.Price = price;
            this.Qty = qty;
            this.ReduceOnly = reduceOnly;
            this.Side = side;
            this.Symbol = symbol;
            this.TimeInForce = timeInForce;
            this.UpdatedTime = updatedTime;
            this.UserId = userId;
            this.TakeProfit = takeProfit;
            this.StopLoss = stopLoss;
            this.TpTriggerBy = tpTriggerBy;
            this.SlTriggerBy = slTriggerBy;
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
            sb.Append("class LinearCreateOrderResult {\n");
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
            return this.Equals(input as LinearCreateOrderResult);
        }

        /// <summary>
        /// Returns true if LinearCreateOrderResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LinearCreateOrderResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinearCreateOrderResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) &&
                (
                    this.CumExecFee == input.CumExecFee ||
                    (this.CumExecFee != null &&
                    this.CumExecFee.Equals(input.CumExecFee))
                ) &&
                (
                    this.CumExecQty == input.CumExecQty ||
                    (this.CumExecQty != null &&
                    this.CumExecQty.Equals(input.CumExecQty))
                ) &&
                (
                    this.CumExecValue == input.CumExecValue ||
                    (this.CumExecValue != null &&
                    this.CumExecValue.Equals(input.CumExecValue))
                ) &&
                (
                    this.LastExecPrice == input.LastExecPrice ||
                    (this.LastExecPrice != null &&
                    this.LastExecPrice.Equals(input.LastExecPrice))
                ) &&
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) &&
                (
                    this.OrderLinkId == input.OrderLinkId ||
                    (this.OrderLinkId != null &&
                    this.OrderLinkId.Equals(input.OrderLinkId))
                ) &&
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) &&
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) &&
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) &&
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) &&
                (
                    this.ReduceOnly == input.ReduceOnly ||
                    (this.ReduceOnly != null &&
                    this.ReduceOnly.Equals(input.ReduceOnly))
                ) &&
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) &&
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) &&
                (
                    this.TimeInForce == input.TimeInForce ||
                    (this.TimeInForce != null &&
                    this.TimeInForce.Equals(input.TimeInForce))
                ) &&
                (
                    this.UpdatedTime == input.UpdatedTime ||
                    (this.UpdatedTime != null &&
                    this.UpdatedTime.Equals(input.UpdatedTime))
                ) &&
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) &&
                (
                    this.TakeProfit == input.TakeProfit ||
                    (this.TakeProfit != null &&
                    this.TakeProfit.Equals(input.TakeProfit))
                ) &&
                (
                    this.StopLoss == input.StopLoss ||
                    (this.StopLoss != null &&
                    this.StopLoss.Equals(input.StopLoss))
                ) &&
                (
                    this.TpTriggerBy == input.TpTriggerBy ||
                    (this.TpTriggerBy != null &&
                    this.TpTriggerBy.Equals(input.TpTriggerBy))
                ) &&
                (
                    this.SlTriggerBy == input.SlTriggerBy ||
                    (this.SlTriggerBy != null &&
                    this.SlTriggerBy.Equals(input.SlTriggerBy))
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
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.CumExecFee != null)
                    hashCode = hashCode * 59 + this.CumExecFee.GetHashCode();
                if (this.CumExecQty != null)
                    hashCode = hashCode * 59 + this.CumExecQty.GetHashCode();
                if (this.CumExecValue != null)
                    hashCode = hashCode * 59 + this.CumExecValue.GetHashCode();
                if (this.LastExecPrice != null)
                    hashCode = hashCode * 59 + this.LastExecPrice.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OrderLinkId != null)
                    hashCode = hashCode * 59 + this.OrderLinkId.GetHashCode();
                if (this.OrderStatus != null)
                    hashCode = hashCode * 59 + this.OrderStatus.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.ReduceOnly != null)
                    hashCode = hashCode * 59 + this.ReduceOnly.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.TimeInForce != null)
                    hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                if (this.UpdatedTime != null)
                    hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.TakeProfit != null)
                    hashCode = hashCode * 59 + this.TakeProfit.GetHashCode();
                if (this.StopLoss != null)
                    hashCode = hashCode * 59 + this.StopLoss.GetHashCode();
                if (this.TpTriggerBy != null)
                    hashCode = hashCode * 59 + this.TpTriggerBy.GetHashCode();
                if (this.SlTriggerBy != null)
                    hashCode = hashCode * 59 + this.SlTriggerBy.GetHashCode();
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