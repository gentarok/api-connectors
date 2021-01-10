namespace BybitAPI.Model
{
    /// <summary>
    /// Side (side)
    /// </summary>
    public enum Side
    {
        Buy,
        Sell,
    }

    /// <summary>
    /// Symbol (symbol)
    /// </summary>
    public enum Symbol
    {
        BTCUSD,
        ETHUSD,
        EOSUSD,
        XRPUSD,
    }

    /// <summary>
    /// Currency (currency/coin)
    /// </summary>
    public enum Currency
    {
        BTC,
        ETH,
        EOS,
        XRP,
        USDT,
    }

    /// <summary>
    /// Wallet fund type (wallet_fund_type)
    /// </summary>
    public enum WalletFundType
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
    public enum WithdrawStatus
    {
        ToBeConfirmed,
        UnderReview,

        /// <summary>
        /// Pending transfer
        /// </summary>
        Pending,

        Success,
        CancelByUser,
        Reject,
        Expire,
    }

    /// <summary>
    /// Order type (order_type)
    /// </summary>
    public enum OrderType
    {
        Limit,
        Market,
    }

    /// <summary>
    /// Time in force(time_in_force)
    /// </summary>
    public enum TimeInForce
    {
        GoodTillCancel,
        ImmediateOrCancel,
        FillOrKill,
        PostOnly,
    }

    /// <summary>
    /// Trigger price type(trigger_by)
    /// </summary>
    public enum TriggerPriceType
    {
        LastPrice,
        IndexPrice,
        MarkPrice,
    }

    /// <summary>
    /// Order (order)
    /// This is for sorting orders/trades in a specified direction.
    /// </summary>
    public enum Order
    {
        Desc,
        Asc,
    }

    /// <summary>
    /// Order status(order_status)
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// order accepted by the system but not yet put through matching engine
        /// </summary>
        Created,

        Rejected,

        /// <summary>
        /// order has placed successfully
        /// </summary>
        New,

        PartiallyFilled,
        Filled,
        Cancelled,

        /// <summary>
        /// the matching engine has received the cancellation but there is no guarantee that it will be successful
        /// </summary>
        PendingCancel,

        /// <summary>
        /// The untriggered
        /// </summary>
        /// <remarks>
        /// This value is not documented, but the "Conditional Order Query" method returns this value, so add it to the definition.
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#order-status-order_status"/>
        /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
        /// </remarks>
        Untriggered,

        /// <summary>
        /// The deactivated
        /// </summary>
        /// <remarks>
        /// This value is not documented, but the "Get Active Order" method returns this value, so add it to the definition.
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#order-status-order_status"/>
        /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/?console#t-getactive"/>
        /// </remarks>
        Deactivated,
    }

    /// <summary>
    /// Stop order status(stop_order_status)
    /// </summary>
    public enum StopOrderStatus
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

    /// <summary>
    /// Cancel type(cancel_type)
    /// </summary>
    public enum CancelType
    {
        Unknown,
        CancelByUser,
        CancelByReduceOnly,

        /// <summary>
        /// Cancelled by force liquidation
        /// </summary>
        CancelByPrepareLiq,

        /// <summary>
        /// Cancelled by force liquidation
        /// </summary>
        CancelAllBeforeLiq,

        /// <summary>
        /// Cancelled by ADL
        /// </summary>
        CancelByPrepareAdl,

        /// <summary>
        /// Cancelled by ADL
        /// </summary>
        CancelAllBeforeAdl,

        CancelByAdmin,

        /// <summary>
        /// This is a cancelled TP/SL/TS order
        /// </summary>
        CancelByTpSlTsClear,

        /// <summary>
        /// This order is cancelled after TP/SL/TS
        /// </summary>
        CancelByPzSideCh,
    }

    /// <summary>
    /// Create type(create_type)
    /// </summary>
    public enum CreateType
    {
        CreateByUser,
        CreateByClosing,
        CreateByAdminClosing,
        CreateByStopOrder,
        CreateByTakeProfit,
        CreateByStopLoss,
        CreateByTrailingStop,

        /// <summary>
        /// Created by partial liquidation
        /// </summary>
        CreateByLiq,

        /// <summary>
        /// Created by ADL
        /// </summary>
        CreateByAdl_PassThrough,

        /// <summary>
        /// Created by liquidation takeover
        /// </summary>
        CreateByTakeOver_PassThrough,
    }

    /// <summary>
    /// Exec type(exec_type)
    /// </summary>
    public enum ExecType
    {
        Trade,
        AdlTrade,
        Funding,
        BustTrade,
    }

    /// <summary>
    /// Liquidity type(last_liquidity_ind)
    /// </summary>
    public enum LiquidityType
    {
        /// <summary>
        /// Maker liquidity
        /// </summary>
        AddedLiquidity,

        /// <summary>
        /// Taker liquidity
        /// </summary>
        RemovedLiquidity,
    }

    /// <summary>
    /// Tick direction type(tick_direction)
    /// It indicates the fluctuation of price, which is up or down relative to the last transaction
    /// </summary>
    public enum TickDirectionType
    {
        /// <summary>
        /// Rise in price
        /// </summary>
        PlusTick,

        /// <summary>
        /// Rise in price compared to last trade of different price
        /// </summary>
        ZeroPlusTick,

        /// <summary>
        /// Drop in price
        /// </summary>
        MinusTick,

        /// <summary>
        /// Drop in price compared to last trade of different price
        /// </summary>
        ZeroMinusTick,
    }
}