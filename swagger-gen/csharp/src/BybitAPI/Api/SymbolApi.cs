using BybitAPI.Client;
using BybitAPI.Model;
using RestSharp;
using System.Threading.Tasks;

namespace BybitAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISymbolApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Query Symbols.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-querysymbol"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns><see cref="SymbolGetBase"/></returns>
        SymbolGetBase SymbolGet();

        /// <summary>
        /// Query Symbols.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-querysymbol"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SymbolGetBase</returns>
        ApiResponse<SymbolGetBase> SymbolGetWithHttpInfo();

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Query Symbols.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-querysymbol"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SymbolGetBase</returns>
        Task<SymbolGetBase> SymbolGetAsync();

        /// <summary>
        /// Query Symbols.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-querysymbol"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SymbolGetBase)</returns>
        Task<ApiResponse<SymbolGetBase>> SymbolGetAsyncWithHttpInfo();

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SymbolApi : ApiBase, ISymbolApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SymbolApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SymbolApi(string basePath) : base(basePath) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SymbolApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SymbolApi(Configuration? configuration = null) : base(configuration) { }

        /// <summary>
        /// Query Symbols.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-querysymbol"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns><see cref="SymbolGetBase"/></returns>
        public SymbolGetBase SymbolGet()
            => SymbolGetWithHttpInfo().Data;

        /// <summary>
        /// Query Symbols.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-querysymbol"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SymbolGetBase</returns>
        public ApiResponse<SymbolGetBase> SymbolGetWithHttpInfo()
        {
            var localVarPath = "/v2/public/symbols";
            return CallApiWithHttpInfo<SymbolGetBase>(localVarPath, Method.GET);
        }

        /// <summary>
        /// Query Symbols.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-querysymbol"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SymbolGetBase</returns>
        public async Task<SymbolGetBase> SymbolGetAsync()
            => (await SymbolGetAsyncWithHttpInfo()).Data;

        /// <summary>
        /// Query Symbols.
        /// </summary>
        /// <remarks>
        /// <see cref="https://bybit-exchange.github.io/docs/inverse/#t-querysymbol"/>
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SymbolGetBase)</returns>
        public Task<ApiResponse<SymbolGetBase>> SymbolGetAsyncWithHttpInfo()
        {
            var localVarPath = "/v2/public/symbols";
            return CallApiAsyncWithHttpInfo<SymbolGetBase>(localVarPath, Method.GET);
        }
    }
}