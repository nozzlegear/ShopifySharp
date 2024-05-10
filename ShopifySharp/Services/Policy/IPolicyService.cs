using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp;

public interface IPolicyService : IShopifyService
{
    /// <summary>
    /// Get the policies and their contents for a shop
    /// </summary>
    Task<IEnumerable<Policy>> ListAsync(CancellationToken cancellationToken = default);
}