using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify users.
/// </summary>
public class UserService : ShopifyService, IUserService
{
    /// <summary>
    /// Creates a new instance of <see cref="UserService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public UserService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal UserService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal UserService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<ListResult<User>> ListAsync(ListFilter<User> filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("users.json", "users", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<User>> ListAsync(UserListFilter filter, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<User> GetAsync(long userId, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<User>($"users/{userId}.json", "user", cancellationToken: cancellationToken);

    /// <inheritdoc />
    public virtual async Task<User> GetCurrentAsync(CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<User>("users/current.json", "user", cancellationToken: cancellationToken);
}