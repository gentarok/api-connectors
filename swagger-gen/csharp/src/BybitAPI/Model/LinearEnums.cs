namespace BybitAPI.Model
{
    /// <summary>
    /// Side (side)
    /// </summary>
    public enum LinearSide
    {
        Buy,
        Sell,
    }

    /// <summary>
    /// Symbol (symbol)
    /// </summary>
    public enum LinearSymbol
    {
        BTCUSDT,
        ETHUSDT,
        LTCUSDT,
        LINKUSDT,
        XTZUSDT,
        BCHUSDT,
    }

    /// <summary>
    /// Currency (currency/coin)
    /// </summary>
    public enum LinearCurrency
    {
        USDT,
    }

    /// <summary>
    /// Wallet fund type (wallet_fund_type)
    /// </summary>
    public enum LinearWalletFundType
    {
        Deposit,
        Withdraw,
        RealisedPNL,
        Commission,
        Refund,
        Prize,
        ExchangeOrderWithdraw,
        ExchangeOrderDeposit,
    }

    /// <summary>
    /// Withdraw status (status)
    /// </summary>
    public enum LinearWithdrawStatus
    {
        ToBeConfirmed,
        UnderReview,

        /// <summary>
        /// The pending
        /// </summary>
        /// <remarks>
        /// Pending transfer
        /// </remarks>
        Pending,

        Success,
        CancelByUser,
        Reject,
        Expire,
    }

    /// <summary>
    /// Order type (order_type)
    /// </summary>
    public enum LinearOrderType
    {
        Limit,
        Market,
    }

    /// <summary>
    /// Time in force (time_in_force)
    /// </summary>
    public enum LinearTimeInForce
    {
        GoodTillCancel,
        ImmediateOrCancel,
        FillOrKill,
        PostOnly,
    }

    /// <summary>
    /// Trigger price type (trigger_by)
    /// </summary>
    public enum LinearTriggerPriceType
    {
        /// <remarks>
        /// This value is not documented, but the "Get Conditional Order" method returns this value, so add it to the definition.
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-getcond"/>
        /// </remarks>
        Unknown,

        LastPrice,
        IndexPrice,
        MarkPrice,
    }

    /// <summary>
    /// Order (order)
    /// </summary>
    public enum LinearOrder
    {
        Desc,
        Asc,
    }

    /// <summary>
    /// Order status (order_status)
    /// </summary>
    public enum LinearOrderStatus
    {
        /// <summary>
        /// The created
        /// </summary>
        /// <remarks>
        /// order accepted by the system but not yet put through matching engine
        /// </remarks>
        Created,

        /// <summary>
        /// The rejected
        /// </summary>
        /// <remarks>
        /// order is triggered but failed to be placed (for example, due to insufficient margin)
        /// </remarks>
        Rejected,

        /// <summary>
        /// The new
        /// </summary>
        /// <remarks>
        /// order has placed successfully
        /// </remarks>
        New,

        //
        PartiallyFilled,

        Filled,
        Cancelled,

        /// <summary>
        /// The pending cancel
        /// </summary>
        /// <remarks>
        /// the matching engine has received the cancellation but there is no guarantee that it will be successful
        /// </remarks>
        PendingCancel,
    }

    /// <summary>
    /// Cancel type (cancel_type)
    /// </summary>
    public enum LinearCancelType
    {
        CancelByUser,
        CancelByReduceOnly,

        /// <summary>
        /// The cancel by prepare liq
        /// </summary>
        /// <remarks>
        /// Cancelled by force liquidation
        /// </remarks>
        CancelByPrepareLiq,

        /// <summary>
        /// The cancel all before liq
        /// </summary>
        /// <remarks>
        /// Cancelled by force liquidation
        /// </remarks>
        CancelAllBeforeLiq,

        /// <summary>
        /// The cancel by prepare adl
        /// </summary>
        /// <remarks>
        /// Cancelled by ADL
        /// </remarks>
        CancelByPrepareAdl,

        /// <summary>
        /// The cancel all before adl
        /// </summary>
        /// <remarks>
        /// Cancelled by ADL
        /// </remarks>
        CancelAllBeforeAdl,

        CancelByAdmin,

        /// <summary>
        /// The cancel by tp sl ts clear
        /// </summary>
        /// <remarks>
        /// This is a cancelled TP/SL/TS order
        /// </remarks>
        CancelByTpSlTsClear,

        /// <summary>
        /// The cancel by pz side ch
        /// </summary>
        /// <remarks>
        /// This order is cancelled after TP/SL/TS
        /// </remarks>
        CancelByPzSideCh,
    }

    /// <summary>
    /// Exec type (exec_type)
    /// </summary>
    public enum LinearExecType
    {
        Trade,
        AdlTrade,
        Funding,
        BustTrade,
    }

    /// <summary>
    /// Liquidity type (last_liquidity_ind)
    /// </summary>
    public enum LinearLiquidityType
    {
        /// <summary>
        /// The added liquidity
        /// </summary>
        /// <remarks>
        /// Maker liquidity
        /// </remarks>
        AddedLiquidity,

        /// <summary>
        /// The removed liquidity
        /// </summary>
        /// <remarks>
        /// Taker liquidity
        /// </remarks>
        RemovedLiquidity,
    }

    /// <summary>
    /// Tick direction type (tick_direction)
    /// </summary>
    /// <remarks>
    /// It indicates the fluctuation of price, which is up or down relative to the last transaction
    /// </remarks>
    public enum LinearTickDirectionType
    {
        /// <summary>
        /// The plus tick
        /// </summary>
        /// <remarks>
        /// Rise in price
        /// </remarks>
        PlusTick,

        /// <summary>
        /// The zero plus tick
        /// </summary>
        /// <remarks>
        /// Rise in price compared to last trade of different price
        /// </remarks>
        ZeroPlusTick,

        /// <summary>
        /// The minus tick
        /// </summary>
        /// <remarks>
        /// Drop in price
        /// </remarks>
        MinusTick,

        /// <summary>
        /// The zero minus tick
        /// </summary>
        /// <remarks>
        /// Drop in price compared to last trade of different price
        /// </remarks>
        ZeroMinusTick,
    }

    /// <summary>
    /// TpSl Mode type (tp_sl_mode)
    /// </summary>
    /// <remarks>
    /// Take profit/stop loss mode
    /// </remarks>
    public enum LinearTpSlModeType
    {
        /// <summary>
        /// The full
        /// </summary>
        /// <remarks>
        /// Full stop loss take profit
        /// </remarks>
        Full,

        /// <summary>
        /// The partial
        /// </summary>
        /// <remarks>
        /// Partial stop loss take profit
        /// </remarks>
        Partial,
    }

    /// <summary>
    /// Stop order status(stop_order_status)
    /// </summary>
    /// <remarks>
    /// Note: Undocumented.
    /// </remarks>
    public enum LinearStopOrderStatus
    {
        /// <summary>
        /// order is triggered and placed successfully
        /// </summary>
        Active,

        /// <summary>
        /// order waits to be triggered
        /// </summary>
        Untriggered,

        /// <summary>
        /// order is triggered
        /// </summary>
        Triggered,

        /// <summary>
        /// /order is cancelled
        /// </summary>
        Cancelled,

        /// <summary>
        /// order is triggered but failed to be placed(for example, due to insufficient margin)
        /// </summary>
        Rejected,

        /// <summary>
        /// order was cancelled by user before triggering
        /// </summary>
        Deactivated,
    }
}