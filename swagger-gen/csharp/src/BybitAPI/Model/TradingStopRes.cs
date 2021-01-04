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
    /// Set Trading-Stop Condition response
    /// </summary>
    [DataContract]
    public partial class TradingStopRes : IEquatable<TradingStopRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradingStopRes" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="side">side.</param>
        /// <param name="size">size.</param>
        /// <param name="positionValue">positionValue.</param>
        /// <param name="entryPrice">entryPrice.</param>
        /// <param name="riskId">riskId.</param>
        /// <param name="autoAddMargin">autoAddMargin.</param>
        /// <param name="leverage">leverage.</param>
        /// <param name="positionMargin">positionMargin.</param>
        /// <param name="liqPrice">liqPrice.</param>
        /// <param name="bustPrice">bustPrice.</param>
        /// <param name="occClosingFee">occClosingFee.</param>
        /// <param name="occFundingFee">occFundingFee.</param>
        /// <param name="takeProfit">takeProfit.</param>
        /// <param name="stopLoss">stopLoss.</param>
        /// <param name="positionStatus">positionStatus.</param>
        /// <param name="deleverageIndicator">deleverageIndicator.</param>
        /// <param name="ocCalcData">ocCalcData.</param>
        /// <param name="orderMargin">orderMargin.</param>
        /// <param name="walletBalance">walletBalance.</param>
        /// <param name="realisedPnl">realisedPnl.</param>
        /// <param name="cumRealisedPnl">cumRealisedPnl.</param>
        /// <param name="cumCommission">cumCommission.</param>
        /// <param name="crossSeq">crossSeq.</param>
        /// <param name="positionSeq">positionSeq.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public TradingStopRes(decimal? id = default, decimal? userId = default, string symbol = default, string side = default, decimal? size = default, double? positionValue = default, double? entryPrice = default, decimal? riskId = default, double? autoAddMargin = default, double? leverage = default, double? positionMargin = default, double? liqPrice = default, double? bustPrice = default, double? occClosingFee = default, double? occFundingFee = default, double? takeProfit = default, double? stopLoss = default, string positionStatus = default, decimal? deleverageIndicator = default, string ocCalcData = default, double? orderMargin = default, double? walletBalance = default, double? realisedPnl = default, double? cumRealisedPnl = default, decimal? cumCommission = default, decimal? crossSeq = default, decimal? positionSeq = default, string createdAt = default, string updatedAt = default)
        {
            Id = id;
            UserId = userId;
            Symbol = symbol;
            Side = side;
            Size = size;
            PositionValue = positionValue;
            EntryPrice = entryPrice;
            RiskId = riskId;
            AutoAddMargin = autoAddMargin;
            Leverage = leverage;
            PositionMargin = positionMargin;
            LiqPrice = liqPrice;
            BustPrice = bustPrice;
            OccClosingFee = occClosingFee;
            OccFundingFee = occFundingFee;
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            PositionStatus = positionStatus;
            DeleverageIndicator = deleverageIndicator;
            OcCalcData = ocCalcData;
            OrderMargin = orderMargin;
            WalletBalance = walletBalance;
            RealisedPnl = realisedPnl;
            CumRealisedPnl = cumRealisedPnl;
            CumCommission = cumCommission;
            CrossSeq = crossSeq;
            PositionSeq = positionSeq;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public decimal? Id { get; set; }

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
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// Gets or Sets PositionValue
        /// </summary>
        [DataMember(Name = "position_value", EmitDefaultValue = false)]
        public double? PositionValue { get; set; }

        /// <summary>
        /// Gets or Sets EntryPrice
        /// </summary>
        [DataMember(Name = "entry_price", EmitDefaultValue = false)]
        public double? EntryPrice { get; set; }

        /// <summary>
        /// Gets or Sets RiskId
        /// </summary>
        [DataMember(Name = "risk_id", EmitDefaultValue = false)]
        public decimal? RiskId { get; set; }

        /// <summary>
        /// Gets or Sets AutoAddMargin
        /// </summary>
        [DataMember(Name = "auto_add_margin", EmitDefaultValue = false)]
        public double? AutoAddMargin { get; set; }

        /// <summary>
        /// Gets or Sets Leverage
        /// </summary>
        [DataMember(Name = "leverage", EmitDefaultValue = false)]
        public double? Leverage { get; set; }

        /// <summary>
        /// Gets or Sets PositionMargin
        /// </summary>
        [DataMember(Name = "position_margin", EmitDefaultValue = false)]
        public double? PositionMargin { get; set; }

        /// <summary>
        /// Gets or Sets LiqPrice
        /// </summary>
        [DataMember(Name = "liq_price", EmitDefaultValue = false)]
        public double? LiqPrice { get; set; }

        /// <summary>
        /// Gets or Sets BustPrice
        /// </summary>
        [DataMember(Name = "bust_price", EmitDefaultValue = false)]
        public double? BustPrice { get; set; }

        /// <summary>
        /// Gets or Sets OccClosingFee
        /// </summary>
        [DataMember(Name = "occ_closing_fee", EmitDefaultValue = false)]
        public double? OccClosingFee { get; set; }

        /// <summary>
        /// Gets or Sets OccFundingFee
        /// </summary>
        [DataMember(Name = "occ_funding_fee", EmitDefaultValue = false)]
        public double? OccFundingFee { get; set; }

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
        /// Gets or Sets PositionStatus
        /// </summary>
        [DataMember(Name = "position_status", EmitDefaultValue = false)]
        public string PositionStatus { get; set; }

        /// <summary>
        /// Gets or Sets DeleverageIndicator
        /// </summary>
        [DataMember(Name = "deleverage_indicator", EmitDefaultValue = false)]
        public decimal? DeleverageIndicator { get; set; }

        /// <summary>
        /// Gets or Sets OcCalcData
        /// </summary>
        [DataMember(Name = "oc_calc_data", EmitDefaultValue = false)]
        public string OcCalcData { get; set; }

        /// <summary>
        /// Gets or Sets OrderMargin
        /// </summary>
        [DataMember(Name = "order_margin", EmitDefaultValue = false)]
        public double? OrderMargin { get; set; }

        /// <summary>
        /// Gets or Sets WalletBalance
        /// </summary>
        [DataMember(Name = "wallet_balance", EmitDefaultValue = false)]
        public double? WalletBalance { get; set; }

        /// <summary>
        /// Gets or Sets RealisedPnl
        /// </summary>
        [DataMember(Name = "realised_pnl", EmitDefaultValue = false)]
        public double? RealisedPnl { get; set; }

        /// <summary>
        /// Gets or Sets CumRealisedPnl
        /// </summary>
        [DataMember(Name = "cum_realised_pnl", EmitDefaultValue = false)]
        public double? CumRealisedPnl { get; set; }

        /// <summary>
        /// Gets or Sets CumCommission
        /// </summary>
        [DataMember(Name = "cum_commission", EmitDefaultValue = false)]
        public decimal? CumCommission { get; set; }

        /// <summary>
        /// Gets or Sets CrossSeq
        /// </summary>
        [DataMember(Name = "cross_seq", EmitDefaultValue = false)]
        public decimal? CrossSeq { get; set; }

        /// <summary>
        /// Gets or Sets PositionSeq
        /// </summary>
        [DataMember(Name = "position_seq", EmitDefaultValue = false)]
        public decimal? PositionSeq { get; set; }

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
            sb.Append("class TradingStopRes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  PositionValue: ").Append(PositionValue).Append("\n");
            sb.Append("  EntryPrice: ").Append(EntryPrice).Append("\n");
            sb.Append("  RiskId: ").Append(RiskId).Append("\n");
            sb.Append("  AutoAddMargin: ").Append(AutoAddMargin).Append("\n");
            sb.Append("  Leverage: ").Append(Leverage).Append("\n");
            sb.Append("  PositionMargin: ").Append(PositionMargin).Append("\n");
            sb.Append("  LiqPrice: ").Append(LiqPrice).Append("\n");
            sb.Append("  BustPrice: ").Append(BustPrice).Append("\n");
            sb.Append("  OccClosingFee: ").Append(OccClosingFee).Append("\n");
            sb.Append("  OccFundingFee: ").Append(OccFundingFee).Append("\n");
            sb.Append("  TakeProfit: ").Append(TakeProfit).Append("\n");
            sb.Append("  StopLoss: ").Append(StopLoss).Append("\n");
            sb.Append("  PositionStatus: ").Append(PositionStatus).Append("\n");
            sb.Append("  DeleverageIndicator: ").Append(DeleverageIndicator).Append("\n");
            sb.Append("  OcCalcData: ").Append(OcCalcData).Append("\n");
            sb.Append("  OrderMargin: ").Append(OrderMargin).Append("\n");
            sb.Append("  WalletBalance: ").Append(WalletBalance).Append("\n");
            sb.Append("  RealisedPnl: ").Append(RealisedPnl).Append("\n");
            sb.Append("  CumRealisedPnl: ").Append(CumRealisedPnl).Append("\n");
            sb.Append("  CumCommission: ").Append(CumCommission).Append("\n");
            sb.Append("  CrossSeq: ").Append(CrossSeq).Append("\n");
            sb.Append("  PositionSeq: ").Append(PositionSeq).Append("\n");
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
            return Equals(input as TradingStopRes);
        }

        /// <summary>
        /// Returns true if TradingStopRes instances are equal
        /// </summary>
        /// <param name="input">Instance of TradingStopRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradingStopRes input)
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
                    UserId == input.UserId ||
                    (UserId is not null &&
                    UserId.Equals(input.UserId))
                ) &&
                (
                    Symbol == input.Symbol ||
                    (Symbol is not null &&
                    Symbol.Equals(input.Symbol))
                ) &&
                (
                    Side == input.Side ||
                    (Side is not null &&
                    Side.Equals(input.Side))
                ) &&
                (
                    Size == input.Size ||
                    (Size is not null &&
                    Size.Equals(input.Size))
                ) &&
                (
                    PositionValue == input.PositionValue ||
                    (PositionValue is not null &&
                    PositionValue.Equals(input.PositionValue))
                ) &&
                (
                    EntryPrice == input.EntryPrice ||
                    (EntryPrice is not null &&
                    EntryPrice.Equals(input.EntryPrice))
                ) &&
                (
                    RiskId == input.RiskId ||
                    (RiskId is not null &&
                    RiskId.Equals(input.RiskId))
                ) &&
                (
                    AutoAddMargin == input.AutoAddMargin ||
                    (AutoAddMargin is not null &&
                    AutoAddMargin.Equals(input.AutoAddMargin))
                ) &&
                (
                    Leverage == input.Leverage ||
                    (Leverage is not null &&
                    Leverage.Equals(input.Leverage))
                ) &&
                (
                    PositionMargin == input.PositionMargin ||
                    (PositionMargin is not null &&
                    PositionMargin.Equals(input.PositionMargin))
                ) &&
                (
                    LiqPrice == input.LiqPrice ||
                    (LiqPrice is not null &&
                    LiqPrice.Equals(input.LiqPrice))
                ) &&
                (
                    BustPrice == input.BustPrice ||
                    (BustPrice is not null &&
                    BustPrice.Equals(input.BustPrice))
                ) &&
                (
                    OccClosingFee == input.OccClosingFee ||
                    (OccClosingFee is not null &&
                    OccClosingFee.Equals(input.OccClosingFee))
                ) &&
                (
                    OccFundingFee == input.OccFundingFee ||
                    (OccFundingFee is not null &&
                    OccFundingFee.Equals(input.OccFundingFee))
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
                    PositionStatus == input.PositionStatus ||
                    (PositionStatus is not null &&
                    PositionStatus.Equals(input.PositionStatus))
                ) &&
                (
                    DeleverageIndicator == input.DeleverageIndicator ||
                    (DeleverageIndicator is not null &&
                    DeleverageIndicator.Equals(input.DeleverageIndicator))
                ) &&
                (
                    OcCalcData == input.OcCalcData ||
                    (OcCalcData is not null &&
                    OcCalcData.Equals(input.OcCalcData))
                ) &&
                (
                    OrderMargin == input.OrderMargin ||
                    (OrderMargin is not null &&
                    OrderMargin.Equals(input.OrderMargin))
                ) &&
                (
                    WalletBalance == input.WalletBalance ||
                    (WalletBalance is not null &&
                    WalletBalance.Equals(input.WalletBalance))
                ) &&
                (
                    RealisedPnl == input.RealisedPnl ||
                    (RealisedPnl is not null &&
                    RealisedPnl.Equals(input.RealisedPnl))
                ) &&
                (
                    CumRealisedPnl == input.CumRealisedPnl ||
                    (CumRealisedPnl is not null &&
                    CumRealisedPnl.Equals(input.CumRealisedPnl))
                ) &&
                (
                    CumCommission == input.CumCommission ||
                    (CumCommission is not null &&
                    CumCommission.Equals(input.CumCommission))
                ) &&
                (
                    CrossSeq == input.CrossSeq ||
                    (CrossSeq is not null &&
                    CrossSeq.Equals(input.CrossSeq))
                ) &&
                (
                    PositionSeq == input.PositionSeq ||
                    (PositionSeq is not null &&
                    PositionSeq.Equals(input.PositionSeq))
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

                if (UserId is not null)
                {
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                }

                if (Symbol is not null)
                {
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
                }

                if (Side is not null)
                {
                    hashCode = hashCode * 59 + Side.GetHashCode();
                }

                if (Size is not null)
                {
                    hashCode = hashCode * 59 + Size.GetHashCode();
                }

                if (PositionValue is not null)
                {
                    hashCode = hashCode * 59 + PositionValue.GetHashCode();
                }

                if (EntryPrice is not null)
                {
                    hashCode = hashCode * 59 + EntryPrice.GetHashCode();
                }

                if (RiskId is not null)
                {
                    hashCode = hashCode * 59 + RiskId.GetHashCode();
                }

                if (AutoAddMargin is not null)
                {
                    hashCode = hashCode * 59 + AutoAddMargin.GetHashCode();
                }

                if (Leverage is not null)
                {
                    hashCode = hashCode * 59 + Leverage.GetHashCode();
                }

                if (PositionMargin is not null)
                {
                    hashCode = hashCode * 59 + PositionMargin.GetHashCode();
                }

                if (LiqPrice is not null)
                {
                    hashCode = hashCode * 59 + LiqPrice.GetHashCode();
                }

                if (BustPrice is not null)
                {
                    hashCode = hashCode * 59 + BustPrice.GetHashCode();
                }

                if (OccClosingFee is not null)
                {
                    hashCode = hashCode * 59 + OccClosingFee.GetHashCode();
                }

                if (OccFundingFee is not null)
                {
                    hashCode = hashCode * 59 + OccFundingFee.GetHashCode();
                }

                if (TakeProfit is not null)
                {
                    hashCode = hashCode * 59 + TakeProfit.GetHashCode();
                }

                if (StopLoss is not null)
                {
                    hashCode = hashCode * 59 + StopLoss.GetHashCode();
                }

                if (PositionStatus is not null)
                {
                    hashCode = hashCode * 59 + PositionStatus.GetHashCode();
                }

                if (DeleverageIndicator is not null)
                {
                    hashCode = hashCode * 59 + DeleverageIndicator.GetHashCode();
                }

                if (OcCalcData is not null)
                {
                    hashCode = hashCode * 59 + OcCalcData.GetHashCode();
                }

                if (OrderMargin is not null)
                {
                    hashCode = hashCode * 59 + OrderMargin.GetHashCode();
                }

                if (WalletBalance is not null)
                {
                    hashCode = hashCode * 59 + WalletBalance.GetHashCode();
                }

                if (RealisedPnl is not null)
                {
                    hashCode = hashCode * 59 + RealisedPnl.GetHashCode();
                }

                if (CumRealisedPnl is not null)
                {
                    hashCode = hashCode * 59 + CumRealisedPnl.GetHashCode();
                }

                if (CumCommission is not null)
                {
                    hashCode = hashCode * 59 + CumCommission.GetHashCode();
                }

                if (CrossSeq is not null)
                {
                    hashCode = hashCode * 59 + CrossSeq.GetHashCode();
                }

                if (PositionSeq is not null)
                {
                    hashCode = hashCode * 59 + PositionSeq.GetHashCode();
                }

                if (CreatedAt is not null)
                {
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                }

                if (UpdatedAt is not null)
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}