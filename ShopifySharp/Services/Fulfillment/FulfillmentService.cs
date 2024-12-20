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
/// A service for manipulating Shopify fulfillments.
/// </summary>
public class FulfillmentService : ShopifyService, IFulfillmentService
{
    /// <summary>
    /// Creates a new instance of <see cref="FulfillmentService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public FulfillmentService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal FulfillmentService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal FulfillmentService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<int> CountAsync(long orderId, FulfillmentCountFilter filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<int>($"orders/{orderId}/fulfillments/count.json", "count", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Fulfillment>> ListAsync(long orderId, ListFilter<Fulfillment> filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync($"orders/{orderId}/fulfillments.json", "fulfillments", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Fulfillment>> ListAsync(long orderId, FulfillmentListFilter filter, CancellationToken cancellationToken = default) =>
        await ListAsync(orderId, filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Fulfillment>> ListForFulfillmentOrderAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync($"fulfillment_orders/{fulfillmentOrderId}/fulfillments.json", "fulfillments", ListFilter<Fulfillment>.Empty, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Fulfillment> GetAsync(long orderId, long fulfillmentId, string fields = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<Fulfillment>($"orders/{orderId}/fulfillments/{fulfillmentId}.json", "fulfillment", fields, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Fulfillment> CreateAsync(FulfillmentShipping fulfillment, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"fulfillments.json");
        var body = fulfillment.ToDictionary();

        var content = new JsonContent(new
        {
            fulfillment = body
        });

        var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, cancellationToken, content, "fulfillment");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<Fulfillment> UpdateTrackingAsync(long fulfillmentId, FulfillmentShipping fulfillment, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"fulfillments/{fulfillmentId}/update_tracking.json");
        var body = fulfillment.ToDictionary();
        var content = new JsonContent(new
        {
            fulfillment = body
        });

        var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, cancellationToken, content, "fulfillment");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<Fulfillment> CancelAsync(long fulfillmentId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"fulfillments/{fulfillmentId}/cancel.json");

        var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment");
        return response.Result;
    }
}