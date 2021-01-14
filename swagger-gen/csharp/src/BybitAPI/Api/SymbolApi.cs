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

    /// <inheritdoc/>
    public partial class SymbolApi : ApiBase, ISymbolApi
    {
        public SymbolApi(string basePath) : base(basePath)
        {
        }

        public SymbolApi(Configuration? configuration = null) : base(configuration)
        {
        }

        public SymbolGetBase SymbolGet()
            => SymbolGetWithHttpInfo().Data;

        public ApiResponse<SymbolGetBase> SymbolGetWithHttpInfo()
        {
            var localVarPath = "/v2/public/symbols";
            return CallApiWithHttpInfo<SymbolGetBase>(localVarPath, Method.GET);
        }

        public async Task<SymbolGetBase> SymbolGetAsync()
            => (await SymbolGetAsyncWithHttpInfo()).Data;

        public Task<ApiResponse<SymbolGetBase>> SymbolGetAsyncWithHttpInfo()
        {
            var localVarPath = "/v2/public/symbols";
            return CallApiAsyncWithHttpInfo<SymbolGetBase>(localVarPath, Method.GET);
        }
    }
}