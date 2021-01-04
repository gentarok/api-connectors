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
    /// Query real-time active order information response
    /// </summary>
    [DataContract]
    public partial class QueryOrderRes : IEquatable<QueryOrderRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryOrderRes" /> class.
        /// </summary>
        /// <param name="orderId">orderId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="side">side.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="price">price.</param>
        /// <param name="qty">qty.</param>
        /// <param name="timeInForce">timeInForce.</param>
        /// <param name="orderStatus">orderStatus.</param>
        /// <param name="extFields">extFields.</param>
        /// <param name="leavesQty">leavesQty.</param>
        /// <param name="leavesValue">leavesValue.</param>
        /// <param name="cumExecQty">cumExecQty.</param>
        /// <param name="rejectReason">rejectReason.</param>
        /// <param name="orderLinkId">orderLinkId.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public QueryOrderRes(string orderId = default, decimal? userId = default, string symbol = default, string side = default, string orderType = default, double? price = default, string qty = default, string timeInForce = default, string orderStatus = default, object extFields = default, decimal? leavesQty = default, decimal? leavesValue = default, decimal? cumExecQty = default, string rejectReason = default, string orderLinkId = default, string createdAt = default, string updatedAt = default)
        {
            OrderId = orderId;
            UserId = userId;
            Symbol = symbol;
            Side = side;
            OrderType = orderType;
            Price = price;
            Qty = qty;
            TimeInForce = timeInForce;
            OrderStatus = orderStatus;
            ExtFields = extFields;
            LeavesQty = leavesQty;
            LeavesValue = leavesValue;
            CumExecQty = cumExecQty;
            RejectReason = rejectReason;
            OrderLinkId = orderLinkId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public decimal? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [DataMember(Name = "side", EmitDefaultValue = false)]
        public string Side { get; set; }

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
        public string Qty { get; set; }

        /// <summary>
        /// Gets or Sets TimeInForce
        /// </summary>
        [DataMember(Name = "time_in_force", EmitDefaultValue = false)]
        public string TimeInForce { get; set; }

        /// <summary>
        /// Gets or Sets OrderStatus
        /// </summary>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// Gets or Sets ExtFields
        /// </summary>
        [DataMember(Name = "ext_fields", EmitDefaultValue = false)]
        public object ExtFields { get; set; }

        /// <summary>
        /// Gets or Sets LeavesQty
        /// </summary>
        [DataMember(Name = "leaves_qty", EmitDefaultValue = false)]
        public decimal? LeavesQty { get; set; }

        /// <summary>
        /// Gets or Sets LeavesValue
        /// </summary>
        [DataMember(Name = "leaves_value", EmitDefaultValue = false)]
        public decimal? LeavesValue { get; set; }

        /// <summary>
        /// Gets or Sets CumExecQty
        /// </summary>
        [DataMember(Name = "cum_exec_qty", EmitDefaultValue = false)]
        public decimal? CumExecQty { get; set; }

        /// <summary>
        /// Gets or Sets RejectReason
        /// </summary>
        [DataMember(Name = "reject_reason", EmitDefaultValue = false)]
        public string RejectReason { get; set; }

        /// <summary>
        /// Gets or Sets OrderLinkId
        /// </summary>
        [DataMember(Name = "order_link_id", EmitDefaultValue = false)]
        public string OrderLinkId { get; set; }

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
            sb.Append("class QueryOrderRes {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  ExtFields: ").Append(ExtFields).Append("\n");
            sb.Append("  LeavesQty: ").Append(LeavesQty).Append("\n");
            sb.Append("  LeavesValue: ").Append(LeavesValue).Append("\n");
            sb.Append("  CumExecQty: ").Append(CumExecQty).Append("\n");
            sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
            sb.Append("  OrderLinkId: ").Append(OrderLinkId).Append("\n");
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
            return Equals(input as QueryOrderRes);
        }

        /// <summary>
        /// Returns true if QueryOrderRes instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryOrderRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryOrderRes input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    OrderId == input.OrderId ||
                    (OrderId != null &&
                    OrderId.Equals(input.OrderId))
                ) &&
                (
                    UserId == input.UserId ||
                    (UserId != null &&
                    UserId.Equals(input.UserId))
                ) &&
                (
                    Symbol == input.Symbol ||
                    (Symbol != null &&
                    Symbol.Equals(input.Symbol))
                ) &&
                (
                    Side == input.Side ||
                    (Side != null &&
                    Side.Equals(input.Side))
                ) &&
                (
                    OrderType == input.OrderType ||
                    (OrderType != null &&
                    OrderType.Equals(input.OrderType))
                ) &&
                (
                    Price == input.Price ||
                    (Price != null &&
                    Price.Equals(input.Price))
                ) &&
                (
                    Qty == input.Qty ||
                    (Qty != null &&
                    Qty.Equals(input.Qty))
                ) &&
                (
                    TimeInForce == input.TimeInForce ||
                    (TimeInForce != null &&
                    TimeInForce.Equals(input.TimeInForce))
                ) &&
                (
                    OrderStatus == input.OrderStatus ||
                    (OrderStatus != null &&
                    OrderStatus.Equals(input.OrderStatus))
                ) &&
                (
                    ExtFields == input.ExtFields ||
                    (ExtFields != null &&
                    ExtFields.Equals(input.ExtFields))
                ) &&
                (
                    LeavesQty == input.LeavesQty ||
                    (LeavesQty != null &&
                    LeavesQty.Equals(input.LeavesQty))
                ) &&
                (
                    LeavesValue == input.LeavesValue ||
                    (LeavesValue != null &&
                    LeavesValue.Equals(input.LeavesValue))
                ) &&
                (
                    CumExecQty == input.CumExecQty ||
                    (CumExecQty != null &&
                    CumExecQty.Equals(input.CumExecQty))
                ) &&
                (
                    RejectReason == input.RejectReason ||
                    (RejectReason != null &&
                    RejectReason.Equals(input.RejectReason))
                ) &&
                (
                    OrderLinkId == input.OrderLinkId ||
                    (OrderLinkId != null &&
                    OrderLinkId.Equals(input.OrderLinkId))
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
                if (OrderId != null)
                {
                    hashCode = hashCode * 59 + OrderId.GetHashCode();
                }

                if (UserId != null)
                {
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                }

                if (Symbol != null)
                {
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
                }

                if (Side != null)
                {
                    hashCode = hashCode * 59 + Side.GetHashCode();
                }

                if (OrderType != null)
                {
                    hashCode = hashCode * 59 + OrderType.GetHashCode();
                }

                if (Price != null)
                {
                    hashCode = hashCode * 59 + Price.GetHashCode();
                }

                if (Qty != null)
                {
                    hashCode = hashCode * 59 + Qty.GetHashCode();
                }

                if (TimeInForce != null)
                {
                    hashCode = hashCode * 59 + TimeInForce.GetHashCode();
                }

                if (OrderStatus != null)
                {
                    hashCode = hashCode * 59 + OrderStatus.GetHashCode();
                }

                if (ExtFields != null)
                {
                    hashCode = hashCode * 59 + ExtFields.GetHashCode();
                }

                if (LeavesQty != null)
                {
                    hashCode = hashCode * 59 + LeavesQty.GetHashCode();
                }

                if (LeavesValue != null)
                {
                    hashCode = hashCode * 59 + LeavesValue.GetHashCode();
                }

                if (CumExecQty != null)
                {
                    hashCode = hashCode * 59 + CumExecQty.GetHashCode();
                }

                if (RejectReason != null)
                {
                    hashCode = hashCode * 59 + RejectReason.GetHashCode();
                }

                if (OrderLinkId != null)
                {
                    hashCode = hashCode * 59 + OrderLinkId.GetHashCode();
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
