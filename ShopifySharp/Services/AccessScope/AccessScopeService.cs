using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for getting the access scopes associated with the access token
    /// </summary>
    public class AccessScopeService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of the service.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public AccessScopeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        //oauth endpoints don't support versioning
        protected override bool SupportsAPIVersioning => false;

        /// <summary>
        /// Retrieves a list of access scopes associated to the access token.
        /// </summary>
        public virtual async Task<IEnumerable<AccessScope>> ListAsync(IListFilter filter)
        {
            throw new Exception("not yet implemented");
            return await ExecuteRequestAsync<List<AccessScope>>(req, HttpMethod.Get, rootElement: "access_scopes");
        }
    }
}
