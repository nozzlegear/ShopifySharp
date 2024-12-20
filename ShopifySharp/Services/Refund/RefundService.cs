using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for creating Shopify Refunds.
/// </summary>
public class RefundService : ShopifyService, IRefundService
{
    /// <summary>
    /// Creates a new instance of <see cref="RefundService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public RefundService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal RefundService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal RefundService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<ListResult<Refund>> ListForOrderAsync(long orderId, ListFilter<Refund> filter, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync($"orders/{orderId}/refunds.json", "refunds", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Refund>> ListForOrderAsync(long orderId, RefundListFilter filter = null, CancellationToken cancellationToken = default) =>
        await ListForOrderAsync(orderId, filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Refund> GetAsync(long orderId, long refundId, string fields = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<Refund>($"orders/{orderId}/refunds/{refundId}.json", "refund", fields, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Refund> CalculateAsync(long orderId, Refund options, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"orders/{orderId}/refunds/calculate.json");
        var content = new JsonContent(new { refund = options });
        var response = await ExecuteRequestAsync<Refund>(req, HttpMethod.Post, cancellationToken, content, "refund");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<Refund> RefundAsync(long orderId, Refund options, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"orders/{orderId}/refunds.json");
        var content = new JsonContent(new { refund = options });
        var response = await ExecuteRequestAsync<Refund>(req, HttpMethod.Post, cancellationToken, content, "refund");

        return response.Result;
    }
}