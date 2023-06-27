using System.Collections.Generic;
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
    }
}