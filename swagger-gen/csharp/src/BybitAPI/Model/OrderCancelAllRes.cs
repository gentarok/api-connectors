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
    /// Cancel all active orders response
    /// </summary>
    [DataContract]
    public partial class OrderCancelAllRes : IEquatable<OrderCancelAllRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCancelAllRes" /> class.
        /// </summary>
        /// <param name="clOrdID">clOrdID.</param>
        /// <param name="userId">userId.</param>
        /// <param name="side">side.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="price">price.</param>
        /// <param name="qty">qty.</param>
        /// <param name="timeInForce">timeInForce.</param>
        /// <param name="createType">createType.</param>
        /// <param name="orderStatus">orderStatus.</param>
        /// <param name="leavesQty">leavesQty.</param>
        /// <param name="leavesValue">leavesValue.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="crossStatus">crossStatus.</param>
        /// <param name="crossSeq">crossSeq.</param>
        public OrderCancelAllRes(string clOrdID = default, decimal? userId = default, string side = default, string orderType = default, string price = default, string qty = default, string timeInForce = default, string createType = default, string orderStatus = default, decimal? leavesQty = default, decimal? leavesValue = default, string createdAt = default, string updatedAt = default, string crossStatus = default, decimal? crossSeq = default)
        {
            ClOrdID = clOrdID;
            UserId = userId;
            Side = side;
            OrderType = orderType;
            Price = price;
            Qty = qty;
            TimeInForce = timeInForce;
            CreateType = createType;
            OrderStatus = orderStatus;
            LeavesQty = leavesQty;
            LeavesValue = leavesValue;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            CrossStatus = crossStatus;
            CrossSeq = crossSeq;
        }

        /// <summary>
        /// Gets or Sets ClOrdID
        /// </summary>
        [DataMember(Name = "clOrdID", EmitDefaultValue = false)]
        public string ClOrdID { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public decimal? UserId { get; set; }

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
        public string Price { get; set; }

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
        /// Gets or Sets CreateType
        /// </summary>
        [DataMember(Name = "create_type", EmitDefaultValue = false)]
        public string CreateType { get; set; }

        /// <summary>
        /// Gets or Sets OrderStatus
        /// </summary>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public string OrderStatus { get; set; }

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
        /// Gets or Sets CrossStatus
        /// </summary>
        [DataMember(Name = "cross_status", EmitDefaultValue = false)]
        public string CrossStatus { get; set; }

        /// <summary>
        /// Gets or Sets CrossSeq
        /// </summary>
        [DataMember(Name = "cross_seq", EmitDefaultValue = false)]
        public decimal? CrossSeq { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderCancelAllRes {\n");
            sb.Append("  ClOrdID: ").Append(ClOrdID).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  CreateType: ").Append(CreateType).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  LeavesQty: ").Append(LeavesQty).Append("\n");
            sb.Append("  LeavesValue: ").Append(LeavesValue).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CrossStatus: ").Append(CrossStatus).Append("\n");
            sb.Append("  CrossSeq: ").Append(CrossSeq).Append("\n");
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
        public override bool Equals(object input) => Equals(input as OrderCancelAllRes);

        /// <summary>
        /// Returns true if OrderCancelAllRes instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderCancelAllRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderCancelAllRes input)
        {
            if (input is null)
            {
                return false;
            }

            return
                (
                    ClOrdID == input.ClOrdID ||
                    (ClOrdID is not null &&
                    ClOrdID.Equals(input.ClOrdID))
                ) &&
                (
                    UserId == input.UserId ||
                    (UserId is not null &&
                    UserId.Equals(input.UserId))
                ) &&
                (
                    Side == input.Side ||
                    (Side is not null &&
                    Side.Equals(input.Side))
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
                    TimeInForce == input.TimeInForce ||
                    (TimeInForce is not null &&
                    TimeInForce.Equals(input.TimeInForce))
                ) &&
                (
                    CreateType == input.CreateType ||
                    (CreateType is not null &&
                    CreateType.Equals(input.CreateType))
                ) &&
                (
                    OrderStatus == input.OrderStatus ||
                    (OrderStatus is not null &&
                    OrderStatus.Equals(input.OrderStatus))
                ) &&
                (
                    LeavesQty == input.LeavesQty ||
                    (LeavesQty is not null &&
                    LeavesQty.Equals(input.LeavesQty))
                ) &&
                (
                    LeavesValue == input.LeavesValue ||
                    (LeavesValue is not null &&
                    LeavesValue.Equals(input.LeavesValue))
                ) &&
                (
                    CreatedAt == input.CreatedAt ||
                    (CreatedAt is not null &&
                    CreatedAt.Equals(input.CreatedAt))
                ) &&
                (
                    UpdatedAt == input.UpdatedAt ||
                    (UpdatedAt is not null &&
                    UpdatedAt.Equals(input.UpdatedAt))
                ) &&
                (
                    CrossStatus == input.CrossStatus ||
                    (CrossStatus is not null &&
                    CrossStatus.Equals(input.CrossStatus))
                ) &&
                (
                    CrossSeq == input.CrossSeq ||
                    (CrossSeq is not null &&
                    CrossSeq.Equals(input.CrossSeq))
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
                if (ClOrdID is not null)
                {
                    hashCode = hashCode * 59 + ClOrdID.GetHashCode();
                }

                if (UserId is not null)
                {
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                }

                if (Side is not null)
                {
                    hashCode = hashCode * 59 + Side.GetHashCode();
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

                if (TimeInForce is not null)
                {
                    hashCode = hashCode * 59 + TimeInForce.GetHashCode();
                }

                if (CreateType is not null)
                {
                    hashCode = hashCode * 59 + CreateType.GetHashCode();
                }

                if (OrderStatus is not null)
                {
                    hashCode = hashCode * 59 + OrderStatus.GetHashCode();
                }

                if (LeavesQty is not null)
                {
                    hashCode = hashCode * 59 + LeavesQty.GetHashCode();
                }

                if (LeavesValue is not null)
                {
                    hashCode = hashCode * 59 + LeavesValue.GetHashCode();
                }

                if (CreatedAt is not null)
                {
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                }

                if (UpdatedAt is not null)
                {
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                }

                if (CrossStatus is not null)
                {
                    hashCode = hashCode * 59 + CrossStatus.GetHashCode();
                }

                if (CrossSeq is not null)
                {
                    hashCode = hashCode * 59 + CrossSeq.GetHashCode();
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
