using BybitAPI.Client;
using BybitAPI.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BybitAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILinearPositionsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Add/Reduce Margin
        /// </summary>
        /// <remarks>
        /// This will Add/Reduce Margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-addmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side">Side</param>
        /// <param name="margin">Add/Remove how much margin: Increase 10; decrease -10, supports 4 decimal places</param>
        /// <returns><see cref="LinearPositionsChangeMarginBase"/></returns>
        LinearPositionsChangeMarginBase LinearPositionsChangeMargin(LinearSymbol symbol, LinearSide side, decimal margin);

        /// <summary>
        /// Add/Reduce Margin
        /// </summary>
        /// <remarks>
        /// This will Add/Reduce Margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-addmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side">Side</param>
        /// <param name="margin">Add/Remove how much margin: Increase 10; decrease -10, supports 4 decimal places</param>
        /// <returns>ApiResponse of LinearPositionsChangeMarginBase</returns>
        ApiResponse<LinearPositionsChangeMarginBase> LinearPositionsChangeMarginWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal margin);

        /// <summary>
        /// Get user&#39;s closed profit and loss records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s closed profit and loss records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="startTime">Start timestamp point for result, in seconds</param>
        /// <param name="endTime">End timestamp point for result, in seconds</param>
        /// <param name="execType">Execution type</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page.</param>
        /// <returns><see cref="LinearPositionsClosePnlRecordsBase"/></returns>
        LinearPositionsClosePnlRecordsBase LinearPositionsClosePnlRecords(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get user&#39;s closed profit and loss records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s closed profit and loss records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="startTime">Start timestamp point for result, in seconds</param>
        /// <param name="endTime">End timestamp point for result, in seconds</param>
        /// <param name="execType">Execution type</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page.</param>
        /// <returns>ApiResponse of LinearPositionsClosePnlRecordsBase</returns>
        ApiResponse<LinearPositionsClosePnlRecordsBase> LinearPositionsClosePnlRecordsWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>LinearPositionsMyPositionBase of List (LinearPositionsMyPositionRes)</returns>
        LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>> LinearPositionsMyPosition(LinearSymbol symbol);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>ApiResponse of LinearPositionsMyPositionBase (List of LinearPositionsMyPositionRes)</returns>
        ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>> LinearPositionsMyPositionWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>LinearPositionsMyPositionBase of List (LinearPositionsMyPositionResBase)</returns>
        LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>> LinearPositionsMyPosition();

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of LinearPositionsMyPositionBase (List of LinearPositionsMyPositionResBase)</returns>
        ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>> LinearPositionsMyPositionWithHttpInfo();

        /// <summary>
        /// Set leverage
        /// </summary>
        /// <remarks>
        /// This will Set Leverage
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-setleverage"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/> (optional)</param>
        /// <param name="buyLeverage">Must be greater than 0 and less than the risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <param name="sellLeverage">Must be greater than 0 and less than the risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <returns><see cref="LinearPositionsSaveLeverageBase"/></returns>
        LinearPositionsSaveLeverageBase LinearPositionsSaveLeverage(LinearSymbol symbol, decimal buyLeverage, decimal sellLeverage);

        /// <summary>
        /// Set leverage
        /// </summary>
        /// <remarks>
        /// This will Set Leverage
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-setleverage"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/> (optional)</param>
        /// <param name="buyLeverage">Must be greater than 0 and less than the risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <param name="sellLeverage">Must be greater than 0 and less than the risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <returns>ApiResponse of LinearPositionsSaveLeverageBase</returns>
        ApiResponse<LinearPositionsSaveLeverageBase> LinearPositionsSaveLeverageWithHttpInfo(LinearSymbol symbol, decimal buyLeverage, decimal sellLeverage);

        /// <summary>
        /// Set auto add margin
        /// </summary>
        /// <remarks>
        /// This will Set auto add margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-setautoaddmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side"><see cref="LinearSide"/></param>
        /// <param name="autoAddMargin">Auto add margin button</param>
        /// <returns><see cref="LinearPositionsSetAutoAddMarginBase"/></returns>
        LinearPositionsSetAutoAddMarginBase LinearPositionsSetAutoAddMargin(LinearSymbol symbol, LinearSide side, bool autoAddMargin);

        /// <summary>
        /// Set auto add margin
        /// </summary>
        /// <remarks>
        /// This will Set auto add margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-setautoaddmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side"><see cref="LinearSide"/></param>
        /// <param name="autoAddMargin">Auto add margin button</param>
        /// <returns>ApiResponse of LinearPositionsSetAutoAddMarginBase</returns>
        ApiResponse<LinearPositionsSetAutoAddMarginBase> LinearPositionsSetAutoAddMarginWithHttpInfo(LinearSymbol symbol, LinearSide side, bool autoAddMargin);

        /// <summary>
        /// Switch isolated
        /// </summary>
        /// <remarks>
        /// This will switch isolated
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-marginswitch"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="isIsolated">Cross/Isolated: true is Isolated; false is Cross</param>
        /// <param name="buyLeverage">Must be greater than 0 and less than the  risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <param name="sellLeverage">Must be greater than 0 and less than the  risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <returns><see cref="LinearPositionsSwitchIsolatedBase"/></returns>
        LinearPositionsSwitchIsolatedBase LinearPositionsSwitchIsolated(LinearSymbol symbol, bool isIsolated, decimal buyLeverage, decimal sellLeverage);

        /// <summary>
        /// Switch isolated
        /// </summary>
        /// <remarks>
        /// This will switch isolated
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-marginswitch"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="isIsolated">Cross/Isolated: true is Isolated; false is Cross</param>
        /// <param name="buyLeverage">Must be greater than 0 and less than the  risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <param name="sellLeverage">Must be greater than 0 and less than the  risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <returns>ApiResponse of LinearPositionsSwitchIsolatedBase</returns>
        ApiResponse<LinearPositionsSwitchIsolatedBase> LinearPositionsSwitchIsolatedWithHttpInfo(LinearSymbol symbol, bool isIsolated, decimal buyLeverage, decimal sellLeverage);

        /// <summary>
        /// Switch Mode
        /// </summary>
        /// <remarks>
        /// This will Switch TP/SL Mode
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="tpSlMode"><see cref="LinearTpSlModeType"/></param>
        /// <returns><see cref="LinearPositionsSwitchModeBase"/></returns>
        LinearPositionsSwitchModeBase LinearPositionsSwitchMode(LinearSymbol symbol, LinearTpSlModeType tpSlMode);

        /// <summary>
        /// Switch Mode
        /// </summary>
        /// <remarks>
        /// This will Switch TP/SL Mode
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="tpSlMode"><see cref="LinearTpSlModeType"/></param>
        /// <returns>ApiResponse of LinearPositionsSwitchModeBase</returns>
        ApiResponse<LinearPositionsSwitchModeBase> LinearPositionsSwitchModeWithHttpInfo(LinearSymbol symbol, LinearTpSlModeType tpSlMode);

        /// <summary>
        /// Set tradingStop
        /// </summary>
        /// <remarks>
        /// This will set tradingStop
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-tradingstop"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side"><see cref="LinearSide"/></param>
        /// <param name="takeProfit">Cannot be less than 0, 0 means cancel TP. (optional)</param>
        /// <param name="stopLoss">Cannot be less than 0, 0 means cancel SL. (optional)</param>
        /// <param name="trailingStop">Cannot be less than 0, 0 means cancel TS. (optional)</param>
        /// <param name="tpTriggerBy"><see cref="LinearTriggerPriceType"/>, default: <see cref="LinearTriggerPriceType.LastPrice"/>(optional)</param>
        /// <param name="slTriggerBy"><see cref="LinearTriggerPriceType"/>, default: <see cref="LinearTriggerPriceType.LastPrice"/>(optional)</param>
        /// <param name="slSize">Stop loss quantity (when in partial mode) <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/> (optional)</param>
        /// <param name="tpSize">Take profit quantity (when in partial mode) <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/> (optional)</param>
        /// <returns><see cref="LinearPositionsTradingStopBase"/></returns>
        LinearPositionsTradingStopBase LinearPositionsTradingStop(LinearSymbol symbol, LinearSide side, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, decimal? slSize = null, decimal? tpSize = null);

        /// <summary>
        /// Set tradingStop
        /// </summary>
        /// <remarks>
        /// This will set tradingStop
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-tradingstop"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side"><see cref="LinearSide"/></param>
        /// <param name="takeProfit">Cannot be less than 0, 0 means cancel TP. (optional)</param>
        /// <param name="stopLoss">Cannot be less than 0, 0 means cancel SL. (optional)</param>
        /// <param name="trailingStop">Cannot be less than 0, 0 means cancel TS. (optional)</param>
        /// <param name="tpTriggerBy"><see cref="LinearTriggerPriceType"/>, default: <see cref="LinearTriggerPriceType.LastPrice"/>(optional)</param>
        /// <param name="slTriggerBy"><see cref="LinearTriggerPriceType"/>, default: <see cref="LinearTriggerPriceType.LastPrice"/>(optional)</param>
        /// <param name="slSize">Stop loss quantity (when in partial mode) <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/> (optional)</param>
        /// <param name="tpSize">Take profit quantity (when in partial mode) <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/> (optional)</param>
        /// <returns>ApiResponse of LinearPositionsTradingStopBase</returns>
        ApiResponse<LinearPositionsTradingStopBase> LinearPositionsTradingStopWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, decimal? slSize = null, decimal? tpSize = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Add/Reduce Margin
        /// </summary>
        /// <remarks>
        /// This will Add/Reduce Margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-addmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side">Side</param>
        /// <param name="margin">Add/Remove how much margin: Increase 10; decrease -10, supports 4 decimal places</param>
        /// <returns>Task of LinearPositionsChangeMarginBase</returns>
        Task<LinearPositionsChangeMarginBase> LinearPositionsChangeMarginAsync(LinearSymbol symbol, LinearSide side, decimal margin);

        /// <summary>
        /// Add/Reduce Margin
        /// </summary>
        /// <remarks>
        /// This will Add/Reduce Margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-addmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side">Side</param>
        /// <param name="margin">Add/Remove how much margin: Increase 10; decrease -10, supports 4 decimal places</param>
        /// <returns>Task of ApiResponse (LinearPositionsChangeMarginBase)</returns>
        Task<ApiResponse<LinearPositionsChangeMarginBase>> LinearPositionsChangeMarginAsyncWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal margin);

        /// <summary>
        /// Get user&#39;s closed profit and loss records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s closed profit and loss records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="startTime">Start timestamp point for result, in seconds</param>
        /// <param name="endTime">End timestamp point for result, in seconds</param>
        /// <param name="execType">Execution type</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page.</param>
        /// <returns>Task of LinearPositionsClosePnlRecordsBase</returns>
        Task<LinearPositionsClosePnlRecordsBase> LinearPositionsClosePnlRecordsAsync(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get user&#39;s closed profit and loss records.
        /// </summary>
        /// <remarks>
        /// This will get user&#39;s closed profit and loss records.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-closedprofitandloss"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="startTime">Start timestamp point for result, in seconds</param>
        /// <param name="endTime">End timestamp point for result, in seconds</param>
        /// <param name="execType">Execution type</param>
        /// <param name="page">Page. By default, gets first page of data. Maximum of 50 pages</param>
        /// <param name="limit">Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page.</param>
        /// <returns>Task of ApiResponse (LinearPositionsClosePnlRecordsBase)</returns>
        Task<ApiResponse<LinearPositionsClosePnlRecordsBase>> LinearPositionsClosePnlRecordsAsyncWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of LinearPositionsMyPositionBase (List of LinearPositionsMyPositionRes)</returns>
        Task<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>> LinearPositionsMyPositionAsync(LinearSymbol symbol);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <returns>Task of ApiResponse (LinearPositionsMyPositionBase of List (LinearPositionsMyPositionRes))</returns>
        Task<ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>>> LinearPositionsMyPositionAsyncWithHttpInfo(LinearSymbol symbol);

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LinearPositionsMyPositionBase (List of LinearPositionsMyPositionResBase)</returns>
        Task<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>> LinearPositionsMyPositionAsync();

        /// <summary>
        /// Get my position list.
        /// </summary>
        /// <remarks>
        /// This will get my position list.
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-myposition"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (LinearPositionsMyPositionBase of List (LinearPositionsMyPositionResBase))</returns>
        Task<ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>>> LinearPositionsMyPositionAsyncWithHttpInfo();

        /// <summary>
        /// Set leverage
        /// </summary>
        /// <remarks>
        /// This will Set Leverage
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-setleverage"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/> (optional)</param>
        /// <param name="buyLeverage">Must be greater than 0 and less than the risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <param name="sellLeverage">Must be greater than 0 and less than the risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <returns>Task of LinearPositionsSaveLeverageBase</returns>
        Task<LinearPositionsSaveLeverageBase> LinearPositionsSaveLeverageAsync(LinearSymbol symbol, decimal buyLeverage, decimal sellLeverage);

        /// <summary>
        /// Set leverage
        /// </summary>
        /// <remarks>
        /// This will Set Leverage
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-setleverage"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/> (optional)</param>
        /// <param name="buyLeverage">Must be greater than 0 and less than the risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <param name="sellLeverage">Must be greater than 0 and less than the risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <returns>Task of ApiResponse (LinearPositionsSaveLeverageBase)</returns>
        Task<ApiResponse<LinearPositionsSaveLeverageBase>> LinearPositionsSaveLeverageAsyncWithHttpInfo(LinearSymbol symbol, decimal buyLeverage, decimal sellLeverage);

        /// <summary>
        /// Set auto add margin
        /// </summary>
        /// <remarks>
        /// This will Set auto add margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-setautoaddmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side"><see cref="LinearSide"/></param>
        /// <param name="autoAddMargin">Auto add margin button</param>
        /// <returns>Task of LinearPositionsSetAutoAddMarginBase</returns>
        Task<LinearPositionsSetAutoAddMarginBase> LinearPositionsSetAutoAddMarginAsync(LinearSymbol symbol, LinearSide side, bool autoAddMargin);

        /// <summary>
        /// Set auto add margin
        /// </summary>
        /// <remarks>
        /// This will Set auto add margin
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-setautoaddmargin"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side"><see cref="LinearSide"/></param>
        /// <param name="autoAddMargin">Auto add margin button</param>
        /// <returns>Task of ApiResponse (LinearPositionsSetAutoAddMarginBase)</returns>
        Task<ApiResponse<LinearPositionsSetAutoAddMarginBase>> LinearPositionsSetAutoAddMarginAsyncWithHttpInfo(LinearSymbol symbol, LinearSide side, bool autoAddMargin);

        /// <summary>
        /// Switch isolated
        /// </summary>
        /// <remarks>
        /// This will switch isolated
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-marginswitch"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="isIsolated">Cross/Isolated: true is Isolated; false is Cross</param>
        /// <param name="buyLeverage">Must be greater than 0 and less than the  risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <param name="sellLeverage">Must be greater than 0 and less than the  risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <returns>Task of LinearPositionsSwitchIsolatedBase</returns>
        Task<LinearPositionsSwitchIsolatedBase> LinearPositionsSwitchIsolatedAsync(LinearSymbol symbol, bool isIsolated, decimal buyLeverage, decimal sellLeverage);

        /// <summary>
        /// Switch isolated
        /// </summary>
        /// <remarks>
        /// This will switch isolated
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-marginswitch"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="isIsolated">Cross/Isolated: true is Isolated; false is Cross</param>
        /// <param name="buyLeverage">Must be greater than 0 and less than the  risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <param name="sellLeverage">Must be greater than 0 and less than the  risk limit leverage.<see cref="https://help.bybit.com/hc/en-us/articles/360039749753-What-is-Risk-Limit-What-effect-does-the-Risk-Limit-have-on-Margin-Inverse-Contract-"/></param>
        /// <returns>Task of ApiResponse (LinearPositionsSwitchIsolatedBase)</returns>
        Task<ApiResponse<LinearPositionsSwitchIsolatedBase>> LinearPositionsSwitchIsolatedAsyncWithHttpInfo(LinearSymbol symbol, bool isIsolated, decimal buyLeverage, decimal sellLeverage);

        /// <summary>
        /// Switch Mode
        /// </summary>
        /// <remarks>
        /// This will Switch TP/SL Mode
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="tpSlMode"><see cref="LinearTpSlModeType"/></param>
        /// <returns>Task of LinearPositionsSwitchModeBase</returns>
        Task<LinearPositionsSwitchModeBase> LinearPositionsSwitchModeAsync(LinearSymbol symbol, LinearTpSlModeType tpSlMode);

        /// <summary>
        /// Switch Mode
        /// </summary>
        /// <remarks>
        /// This will Switch TP/SL Mode
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="tpSlMode"><see cref="LinearTpSlModeType"/></param>
        /// <returns>Task of ApiResponse (LinearPositionsSwitchModeBase)</returns>
        Task<ApiResponse<LinearPositionsSwitchModeBase>> LinearPositionsSwitchModeAsyncWithHttpInfo(LinearSymbol symbol, LinearTpSlModeType tpSlMode);

        /// <summary>
        /// Set tradingStop
        /// </summary>
        /// <remarks>
        /// This will set tradingStop
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-tradingstop"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side"><see cref="LinearSide"/></param>
        /// <param name="takeProfit">Cannot be less than 0, 0 means cancel TP. (optional)</param>
        /// <param name="stopLoss">Cannot be less than 0, 0 means cancel SL. (optional)</param>
        /// <param name="trailingStop">Cannot be less than 0, 0 means cancel TS. (optional)</param>
        /// <param name="tpTriggerBy"><see cref="LinearTriggerPriceType"/>, default: <see cref="LinearTriggerPriceType.LastPrice"/>(optional)</param>
        /// <param name="slTriggerBy"><see cref="LinearTriggerPriceType"/>, default: <see cref="LinearTriggerPriceType.LastPrice"/>(optional)</param>
        /// <param name="slSize">Stop loss quantity (when in partial mode) <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/> (optional)</param>
        /// <param name="tpSize">Take profit quantity (when in partial mode) <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/> (optional)</param>
        /// <returns>Task of LinearPositionsTradingStopBase</returns>
        Task<LinearPositionsTradingStopBase> LinearPositionsTradingStopAsync(LinearSymbol symbol, LinearSide side, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, decimal? slSize = null, decimal? tpSize = null);

        /// <summary>
        /// Set tradingStop
        /// </summary>
        /// <remarks>
        /// This will set tradingStop
        /// <see cref="https://bybit-exchange.github.io/docs/linear/#t-tradingstop"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol"><see cref="LinearSymbol"/></param>
        /// <param name="side"><see cref="LinearSide"/></param>
        /// <param name="takeProfit">Cannot be less than 0, 0 means cancel TP. (optional)</param>
        /// <param name="stopLoss">Cannot be less than 0, 0 means cancel SL. (optional)</param>
        /// <param name="trailingStop">Cannot be less than 0, 0 means cancel TS. (optional)</param>
        /// <param name="tpTriggerBy"><see cref="LinearTriggerPriceType"/>, default: <see cref="LinearTriggerPriceType.LastPrice"/>(optional)</param>
        /// <param name="slTriggerBy"><see cref="LinearTriggerPriceType"/>, default: <see cref="LinearTriggerPriceType.LastPrice"/>(optional)</param>
        /// <param name="slSize">Stop loss quantity (when in partial mode) <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/> (optional)</param>
        /// <param name="tpSize">Take profit quantity (when in partial mode) <see cref="https://bybit-exchange.github.io/docs/linear/#t-switchmode"/> (optional)</param>
        /// <returns>Task of ApiResponse (LinearPositionsTradingStopBase)</returns>
        Task<ApiResponse<LinearPositionsTradingStopBase>> LinearPositionsTradingStopAsyncWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, decimal? slSize = null, decimal? tpSize = null);

        #endregion Asynchronous Operations
    }

    /// <inheritdoc/>
    public partial class LinearPositionsApi : ApiBase, ILinearPositionsApi
    {
        private const int LinearPositionsClosePnlRecordsPageMaxValue = 50;
        private const int LinearPositionsClosePnlRecordsLimitMaxValue = 50;

        public LinearPositionsApi(string basePath) : base(basePath)
        {
        }

        public LinearPositionsApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public LinearPositionsChangeMarginBase LinearPositionsChangeMargin(LinearSymbol symbol, LinearSide side, decimal margin)
            => LinearPositionsChangeMarginWithHttpInfo(symbol, side, margin).Data;

        public ApiResponse<LinearPositionsChangeMarginBase> LinearPositionsChangeMarginWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal margin)
        {
            var localVarPath = "/private/linear/position/add-margin";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "margin", Configuration.ApiClient.ParameterToString(margin)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearPositionsChangeMarginBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<LinearPositionsChangeMarginBase> LinearPositionsChangeMarginAsync(LinearSymbol symbol, LinearSide side, decimal margin)
            => (await LinearPositionsChangeMarginAsyncWithHttpInfo(symbol, side, margin)).Data;

        public Task<ApiResponse<LinearPositionsChangeMarginBase>> LinearPositionsChangeMarginAsyncWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal margin)
        {
            var localVarPath = "/private/linear/position/add-margin";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "margin", Configuration.ApiClient.ParameterToString(margin)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearPositionsChangeMarginBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public LinearPositionsClosePnlRecordsBase LinearPositionsClosePnlRecords(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
            => LinearPositionsClosePnlRecordsWithHttpInfo(symbol, startTime, endTime, execType, page, limit).Data;

        public ApiResponse<LinearPositionsClosePnlRecordsBase> LinearPositionsClosePnlRecordsWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
        {
            // verify the parameter 'page'
            if (page is not null and < 0 or > LinearPositionsClosePnlRecordsPageMaxValue)
            {
                throw new ApiException(400, "Validation error on 'page' parameter occured when calling LinearPositionsApi->LinearPositionsClosePnlRecords");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearPositionsClosePnlRecordsLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearPositionsApi->LinearPositionsClosePnlRecords");
            }

            var localVarPath = "/private/linear/trade/closed-pnl/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (startTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime));
            }

            if (endTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime));
            }

            if (execType is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exec_type", execType));
            }

            if (page is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearPositionsClosePnlRecordsBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearPositionsClosePnlRecordsBase> LinearPositionsClosePnlRecordsAsync(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
            => (await LinearPositionsClosePnlRecordsAsyncWithHttpInfo(symbol, startTime, endTime, execType, page, limit)).Data;

        public Task<ApiResponse<LinearPositionsClosePnlRecordsBase>> LinearPositionsClosePnlRecordsAsyncWithHttpInfo(LinearSymbol symbol, long? startTime = null, long? endTime = null, LinearExecType? execType = null, int? page = null, int? limit = null)
        {
            // verify the parameter 'page'
            if (page is not null and < 0 or > LinearPositionsClosePnlRecordsPageMaxValue)
            {
                throw new ApiException(400, "Validation error on 'page' parameter occured when calling LinearPositionsApi->LinearPositionsClosePnlRecords");
            }
            // verify the parameter 'limit'
            if (limit is not null and < 0 or > LinearPositionsClosePnlRecordsLimitMaxValue)
            {
                throw new ApiException(400, "Validation error on 'limit' parameter occured when calling LinearPositionsApi->LinearPositionsClosePnlRecords");
            }

            var localVarPath = "/private/linear/trade/closed-pnl/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            if (startTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime));
            }

            if (endTime is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime));
            }

            if (execType is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exec_type", execType));
            }

            if (page is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page));
            }

            if (limit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearPositionsClosePnlRecordsBase>(localVarPath, Method.GET, localVarQueryParams);
        }

        public LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>> LinearPositionsMyPosition(LinearSymbol symbol)
            => LinearPositionsMyPositionWithHttpInfo(symbol).Data;

        public ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>> LinearPositionsMyPositionWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/position/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>> LinearPositionsMyPositionAsync(LinearSymbol symbol)
            => (await LinearPositionsMyPositionAsyncWithHttpInfo(symbol)).Data;

        public Task<ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>>> LinearPositionsMyPositionAsyncWithHttpInfo(LinearSymbol symbol)
        {
            var localVarPath = "/private/linear/position/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", symbol));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionRes>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>> LinearPositionsMyPosition()
            => LinearPositionsMyPositionWithHttpInfo().Data;

        public ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>> LinearPositionsMyPositionWithHttpInfo()
        {
            var localVarPath = "/private/linear/position/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public async Task<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>> LinearPositionsMyPositionAsync()
            => (await LinearPositionsMyPositionAsyncWithHttpInfo()).Data;

        public Task<ApiResponse<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>>> LinearPositionsMyPositionAsyncWithHttpInfo()
        {
            var localVarPath = "/private/linear/position/list";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearPositionsMyPositionBase<IReadOnlyList<LinearPositionsMyPositionResBase>>>(localVarPath, Method.GET, localVarQueryParams);
        }

        public LinearPositionsSaveLeverageBase LinearPositionsSaveLeverage(LinearSymbol symbol, decimal buyLeverage, decimal sellLeverage)
            => LinearPositionsSaveLeverageWithHttpInfo(symbol, buyLeverage, sellLeverage).Data;

        public ApiResponse<LinearPositionsSaveLeverageBase> LinearPositionsSaveLeverageWithHttpInfo(LinearSymbol symbol, decimal buyLeverage, decimal sellLeverage)
        {
            // verify the parameter 'buyLeverage'
            if (buyLeverage <= 0)
            {
                throw new ApiException(400, "Validation error on 'buyLeverage' parameter occured when calling LinearPositionsApi->LinearPositionsSaveLeverage");
            }
            // verify the parameter 'sellLeverage'
            if (sellLeverage <= 0)
            {
                throw new ApiException(400, "Validation error on 'sellLeverage' parameter occured when calling LinearPositionsApi->LinearPositionsSaveLeverage");
            }

            var localVarPath = "/private/linear/position/set-leverage";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buy_leverage", Configuration.ApiClient.ParameterToString(buyLeverage)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sell_leverage", Configuration.ApiClient.ParameterToString(sellLeverage)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearPositionsSaveLeverageBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<LinearPositionsSaveLeverageBase> LinearPositionsSaveLeverageAsync(LinearSymbol symbol, decimal buyLeverage, decimal sellLeverage)
            => (await LinearPositionsSaveLeverageAsyncWithHttpInfo(symbol, buyLeverage, sellLeverage)).Data;

        public Task<ApiResponse<LinearPositionsSaveLeverageBase>> LinearPositionsSaveLeverageAsyncWithHttpInfo(LinearSymbol symbol, decimal buyLeverage, decimal sellLeverage)
        {
            // verify the parameter 'buyLeverage'
            if (buyLeverage <= 0)
            {
                throw new ApiException(400, "Validation error on 'buyLeverage' parameter occured when calling LinearPositionsApi->LinearPositionsSaveLeverage");
            }
            // verify the parameter 'sellLeverage'
            if (sellLeverage <= 0)
            {
                throw new ApiException(400, "Validation error on 'sellLeverage' parameter occured when calling LinearPositionsApi->LinearPositionsSaveLeverage");
            }

            var localVarPath = "/private/linear/position/set-leverage";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buy_leverage", Configuration.ApiClient.ParameterToString(buyLeverage)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sell_leverage", Configuration.ApiClient.ParameterToString(sellLeverage)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearPositionsSaveLeverageBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public LinearPositionsSetAutoAddMarginBase LinearPositionsSetAutoAddMargin(LinearSymbol symbol, LinearSide side, bool autoAddMargin)
            => LinearPositionsSetAutoAddMarginWithHttpInfo(symbol, side, autoAddMargin).Data;

        public ApiResponse<LinearPositionsSetAutoAddMarginBase> LinearPositionsSetAutoAddMarginWithHttpInfo(LinearSymbol symbol, LinearSide side, bool autoAddMargin)
        {
            var localVarPath = "/private/linear/position/set-auto-add-margin";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "auto_add_margin", Configuration.ApiClient.ParameterToString(autoAddMargin)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearPositionsSetAutoAddMarginBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<LinearPositionsSetAutoAddMarginBase> LinearPositionsSetAutoAddMarginAsync(LinearSymbol symbol, LinearSide side, bool autoAddMargin)
            => (await LinearPositionsSetAutoAddMarginAsyncWithHttpInfo(symbol, side, autoAddMargin)).Data;

        public Task<ApiResponse<LinearPositionsSetAutoAddMarginBase>> LinearPositionsSetAutoAddMarginAsyncWithHttpInfo(LinearSymbol symbol, LinearSide side, bool autoAddMargin)
        {
            var localVarPath = "/private/linear/position/set-auto-add-margin";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "auto_add_margin", Configuration.ApiClient.ParameterToString(autoAddMargin)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearPositionsSetAutoAddMarginBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public LinearPositionsSwitchIsolatedBase LinearPositionsSwitchIsolated(LinearSymbol symbol, bool isIsolated, decimal buyLeverage, decimal sellLeverage)
            => LinearPositionsSwitchIsolatedWithHttpInfo(symbol, isIsolated, buyLeverage, sellLeverage).Data;

        public ApiResponse<LinearPositionsSwitchIsolatedBase> LinearPositionsSwitchIsolatedWithHttpInfo(LinearSymbol symbol, bool isIsolated, decimal buyLeverage, decimal sellLeverage)
        {
            // verify the parameter 'buyLeverage'
            if (buyLeverage <= 0)
            {
                throw new ApiException(400, "Validation error on 'buyLeverage' parameter occured when calling LinearPositionsApi->LinearPositionsSwitchIsolated");
            }
            // verify the parameter 'sellLeverage'
            if (sellLeverage <= 0)
            {
                throw new ApiException(400, "Validation error on 'sellLeverage' parameter occured when calling LinearPositionsApi->LinearPositionsSwitchIsolated");
            }

            var localVarPath = "/private/linear/position/switch-isolated";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_isolated", Configuration.ApiClient.ParameterToString(isIsolated)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buy_leverage", Configuration.ApiClient.ParameterToString(buyLeverage)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sell_leverage", Configuration.ApiClient.ParameterToString(sellLeverage)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearPositionsSwitchIsolatedBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<LinearPositionsSwitchIsolatedBase> LinearPositionsSwitchIsolatedAsync(LinearSymbol symbol, bool isIsolated, decimal buyLeverage, decimal sellLeverage)
            => (await LinearPositionsSwitchIsolatedAsyncWithHttpInfo(symbol, isIsolated, buyLeverage, sellLeverage)).Data;

        public Task<ApiResponse<LinearPositionsSwitchIsolatedBase>> LinearPositionsSwitchIsolatedAsyncWithHttpInfo(LinearSymbol symbol, bool isIsolated, decimal buyLeverage, decimal sellLeverage)
        {
            // verify the parameter 'buyLeverage'
            if (buyLeverage <= 0)
            {
                throw new ApiException(400, "Validation error on 'buyLeverage' parameter occured when calling LinearPositionsApi->LinearPositionsSwitchIsolated");
            }
            // verify the parameter 'sellLeverage'
            if (sellLeverage <= 0)
            {
                throw new ApiException(400, "Validation error on 'sellLeverage' parameter occured when calling LinearPositionsApi->LinearPositionsSwitchIsolated");
            }

            var localVarPath = "/private/linear/position/switch-isolated";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_isolated", Configuration.ApiClient.ParameterToString(isIsolated)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buy_leverage", Configuration.ApiClient.ParameterToString(buyLeverage)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sell_leverage", Configuration.ApiClient.ParameterToString(sellLeverage)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearPositionsSwitchIsolatedBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public LinearPositionsSwitchModeBase LinearPositionsSwitchMode(LinearSymbol symbol, LinearTpSlModeType tpSlMode)
            => LinearPositionsSwitchModeWithHttpInfo(symbol, tpSlMode).Data;

        public ApiResponse<LinearPositionsSwitchModeBase> LinearPositionsSwitchModeWithHttpInfo(LinearSymbol symbol, LinearTpSlModeType tpSlMode)
        {
            var localVarPath = "/private/linear/tpsl/switch-mode";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_sl_mode", Configuration.ApiClient.ParameterToString(tpSlMode)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearPositionsSwitchModeBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<LinearPositionsSwitchModeBase> LinearPositionsSwitchModeAsync(LinearSymbol symbol, LinearTpSlModeType tpSlMode)
            => (await LinearPositionsSwitchModeAsyncWithHttpInfo(symbol, tpSlMode)).Data;

        public Task<ApiResponse<LinearPositionsSwitchModeBase>> LinearPositionsSwitchModeAsyncWithHttpInfo(LinearSymbol symbol, LinearTpSlModeType tpSlMode)
        {
            var localVarPath = "/private/linear/tpsl/switch-mode";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_sl_mode", Configuration.ApiClient.ParameterToString(tpSlMode)));

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearPositionsSwitchModeBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public LinearPositionsTradingStopBase LinearPositionsTradingStop(LinearSymbol symbol, LinearSide side, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, decimal? slSize = null, decimal? tpSize = null)
            => LinearPositionsTradingStopWithHttpInfo(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize).Data;

        public ApiResponse<LinearPositionsTradingStopBase> LinearPositionsTradingStopWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, decimal? slSize = null, decimal? tpSize = null)
        {
            // verify the parameter 'takeProfit'
            if (takeProfit is not null and < 0)
            {
                throw new ApiException(400, "Validation error on 'takeProfit' parameter occured when calling LinearPositionsApi->LinearPositionsTradingStop");
            }
            // verify the parameter 'stopLoss'
            if (stopLoss is not null and < 0)
            {
                throw new ApiException(400, "Validation error on 'stopLoss' parameter occured when calling LinearPositionsApi->LinearPositionsTradingStop");
            }

            // verify the parameter 'trailingStop'
            if (trailingStop is not null and < 0)
            {
                throw new ApiException(400, "Validation error on 'trailingStop' parameter occured when calling LinearPositionsApi->LinearPositionsTradingStop");
            }

            var localVarPath = "/private/linear/position/trading-stop";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));

            if (takeProfit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "take_profit", Configuration.ApiClient.ParameterToString(takeProfit)));
            }

            if (stopLoss is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_loss", Configuration.ApiClient.ParameterToString(stopLoss)));
            }

            if (trailingStop is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "trailing_stop", Configuration.ApiClient.ParameterToString(trailingStop)));
            }

            if (tpTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_trigger_by", Configuration.ApiClient.ParameterToString(tpTriggerBy)));
            }

            if (slTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_trigger_by", Configuration.ApiClient.ParameterToString(slTriggerBy)));
            }

            if (slSize is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_size", Configuration.ApiClient.ParameterToString(slSize)));
            }

            if (tpSize is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_size", Configuration.ApiClient.ParameterToString(tpSize)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiWithHttpInfo<LinearPositionsTradingStopBase>(localVarPath, Method.POST, localVarQueryParams);
        }

        public async Task<LinearPositionsTradingStopBase> LinearPositionsTradingStopAsync(LinearSymbol symbol, LinearSide side, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, decimal? slSize = null, decimal? tpSize = null)
            => (await LinearPositionsTradingStopAsyncWithHttpInfo(symbol, side, takeProfit, stopLoss, trailingStop, tpTriggerBy, slTriggerBy, slSize, tpSize)).Data;

        public Task<ApiResponse<LinearPositionsTradingStopBase>> LinearPositionsTradingStopAsyncWithHttpInfo(LinearSymbol symbol, LinearSide side, decimal? takeProfit = null, decimal? stopLoss = null, decimal? trailingStop = null, LinearTriggerPriceType? tpTriggerBy = null, LinearTriggerPriceType? slTriggerBy = null, decimal? slSize = null, decimal? tpSize = null)
        {
            // verify the parameter 'takeProfit'
            if (takeProfit is not null and < 0)
            {
                throw new ApiException(400, "Validation error on 'takeProfit' parameter occured when calling LinearPositionsApi->LinearPositionsTradingStop");
            }
            // verify the parameter 'stopLoss'
            if (stopLoss is not null and < 0)
            {
                throw new ApiException(400, "Validation error on 'stopLoss' parameter occured when calling LinearPositionsApi->LinearPositionsTradingStop");
            }

            // verify the parameter 'trailingStop'
            if (trailingStop is not null and < 0)
            {
                throw new ApiException(400, "Validation error on 'trailingStop' parameter occured when calling LinearPositionsApi->LinearPositionsTradingStop");
            }

            var localVarPath = "/private/linear/position/trading-stop";
            var localVarQueryParams = new List<KeyValuePair<string, string>>();

            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "symbol", Configuration.ApiClient.ParameterToString(symbol)));
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "side", Configuration.ApiClient.ParameterToString(side)));

            if (takeProfit is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "take_profit", Configuration.ApiClient.ParameterToString(takeProfit)));
            }

            if (stopLoss is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stop_loss", Configuration.ApiClient.ParameterToString(stopLoss)));
            }

            if (trailingStop is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "trailing_stop", Configuration.ApiClient.ParameterToString(trailingStop)));
            }

            if (tpTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_trigger_by", Configuration.ApiClient.ParameterToString(tpTriggerBy)));
            }

            if (slTriggerBy is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_trigger_by", Configuration.ApiClient.ParameterToString(slTriggerBy)));
            }

            if (slSize is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sl_size", Configuration.ApiClient.ParameterToString(slSize)));
            }

            if (tpSize is not null)
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tp_size", Configuration.ApiClient.ParameterToString(tpSize)));
            }

            // authentication (timestamp) required
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()));

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            return CallApiAsyncWithHttpInfo<LinearPositionsTradingStopBase>(localVarPath, Method.POST, localVarQueryParams);
        }
    }
}