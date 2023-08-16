using ShopifySharp.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public interface IAccessScopeService : IShopifyService
    {
        /// <summary>
        /// Retrieves a list of access scopes associated to the access token.
        /// </summary>
        Task<IEnumerable<AccessScope>> ListAsync(CancellationToken cancellationToken = default);

        /// <summary> 
        ///  Requests a subset of granular access scopes for an individual shop installation. 
        /// </summary> 
        Task<IEnumerable<AccessScope>> RequestGranularAccessScopesAsync(IEnumerable<AuthorizationScope> requestedScopes, CancellationToken cancellationToken = default);

        /// <summary> 
        ///  Requests a subset of granular access scopes for an individual shop installation. 
        /// </summary> 
        Task<IEnumerable<AccessScope>> RequestGranularAccessScopesAsync(IEnumerable<string> requestedScopes, CancellationToken cancellationToken = default);
    }
}