using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public interface IStorefrontAccessTokenService : IShopifyService
    {
        /// <summary>
        /// Creates a new <see cref="StorefrontAccessToken"/> with the given <paramref name="title"/>. A store can only have a
        /// maximum of 100 storefront access tokens. 
        /// </summary>
        Task<StorefrontAccessToken> CreateAsync(string title, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the storefront access token with the given <paramref name="id"/>.
        /// </summary>
        Task DeleteAsync(long id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of storefront access tokens. A store can only have a maximum of 100 access tokens. 
        /// </summary>
        Task<IEnumerable<StorefrontAccessToken>> ListAsync(CancellationToken cancellationToken = default);
    }
}