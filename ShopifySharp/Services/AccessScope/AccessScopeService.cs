using ShopifySharp.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
        public virtual async Task<IEnumerable<AccessScope>> ListAsync(CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<IEnumerable<AccessScope>>("oauth/access_scopes.json", "access_scopes", cancellationToken: cancellationToken);
        }

        /// <summary> 
        ///  Requests a subset of granular access scopes for an individual shop installation. 
        /// </summary> 
        public virtual async Task<IEnumerable<AccessScope>> RequestGranularAccessScopesAsync(IEnumerable<AuthorizationScope> requestedScopes, CancellationToken cancellationToken = default) 
        {
            return await RequestGranularAccessScopesAsync(requestedScopes.Select(s => s.ToSerializedString()), cancellationToken); 
        }

        /// <summary> 
        ///  Requests a subset of granular access scopes for an individual shop installation. 
        /// </summary> 
        public virtual async Task<IEnumerable<AccessScope>> RequestGranularAccessScopesAsync(IEnumerable<string> requestedScopes, CancellationToken cancellationToken = default)
        {
            var content = new
            {
                requested_scopes = requestedScopes,
            };
            return await ExecutePostAsync<IEnumerable<AccessScope>>("request_granular_access_scopes.json", "access_scopes", cancellationToken: cancellationToken, content);
        }
    }
}


