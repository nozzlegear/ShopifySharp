using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for getting the access scopes associated with the access token
    /// </summary>
    public class AccessScopeService : ShopifyService, IAccessScopeService
    {
        //oauth endpoints don't support versioning
        protected override bool SupportsAPIVersioning => false;

        /// <summary>
        /// Creates a new instance of the service.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public AccessScopeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

		/// <inheritdoc />
        public virtual async Task<IEnumerable<AccessScope>> ListAsync(CancellationToken cancellationToken = default) => 
            await ExecuteGetAsync<IEnumerable<AccessScope>>("oauth/access_scopes.json", "access_scopes", cancellationToken: cancellationToken);
    }
}