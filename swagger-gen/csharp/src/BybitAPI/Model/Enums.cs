namespace BybitAPI.Model
{
    /// <summary>
    /// Side (side)
    /// </summary>
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#side-side"/>
    /// </remarks>
    public enum Side
    {
        /// <summary>
        /// None
        /// </summary>
        /// <remarks>
        /// This value is not documented, but can be found in the 'My Positon' response example...
        /// <seea cref="https://bybit-exchange.github.io/docs/inverse/#t-myposition"/>
        /// </remarks>
        None,

        Buy,
        Sell,
    }

    /// <summary>
    /// Symbol (symbol)
    /// </summary>
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#symbol-symbol"/>
    /// </remarks>
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
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#currency-currency-coin"/>
    /// </remarks>
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
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#wallet-fund-type-wallet_fund_type"/>
    /// </remarks>
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
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#withdraw-status-status"/>
    /// </remarks>
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
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#order-type-order_type"/>
    /// </remarks>
    public enum OrderType
    {
        Limit,
        Market,
    }

    /// <summary>
    /// Time in force(time_in_force)
    /// </summary>
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#time-in-force-time_in_force"/>
    /// </remarks>
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
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#trigger-price-type-trigger_by"/>
    /// </remarks>
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
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#order-order"/>
    /// </remarks>
    public enum Order
    {
        Desc,
        Asc,
    }

    /// <summary>
    /// Order status(order_status)
    /// </summary>
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#order-status-order_status"/>
    /// </remarks>
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
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-querycond"/>
        /// </remarks>
        Untriggered,

        /// <summary>
        /// The deactivated
        /// </summary>
        /// <remarks>
        /// This value is not documented, but the "Get Active Order" method returns this value, so add it to the definition.
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/?console#t-getactive"/>
        /// </remarks>
        Deactivated,
    }

    /// <summary>
    /// Stop order status(stop_order_status)
    /// </summary>
    /// <remarks>
    /// https://bybit-exchange.github.io/docs/inverse/#stop-order-status-stop_order_status
    /// </remarks>
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
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#cancel-type-cancel_type"/>
    /// </remarks>
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
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#create-type-create_type"/>
    /// </remarks>
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
    /// <remarks>
    /// https://bybit-exchange.github.io/docs/inverse/#exec-type-exec_type
    /// </remarks>
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
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#liquidity-type-last_liquidity_ind"/>
    /// </remarks>
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
    /// <remarks>
    /// <see cref="https://bybit-exchange.github.io/docs/inverse/#tick-direction-type-tick_direction"/>
    /// </remarks>
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

    /// <summary>
    /// Position status
    /// </summary>
    /// <remarks>
    /// It is not documented as an enum, but you can find the same definition in the description of some of the response parameters.
    /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/#t-myposition"/>
    /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/#t-tradingstop"/>
    /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/#t-setrisklimit"/>
    /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/#t-websocketposition"/>
    /// </remarks>
    public enum PositionStatus
    {
        Normal,
        Liq,
        Adl,
    }

    /// <summary>
    /// SearchDirection
    /// </summary>
    /// <remarks>
    /// It is not documented as an enum, but you can find the same definition in the description of some of the response parameters.
    /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/#t-getactive"/>
    /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/#t-getcond"/>
    /// <seealso cref="https://bybit-exchange.github.io/docs/inverse/#t-assetexchangerecords"/>
    /// </remarks>
    public enum SearchDirection
    {
        Next,
        Prev,
    }
}