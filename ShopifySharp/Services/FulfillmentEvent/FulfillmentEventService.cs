using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify fulfillment events.
/// </summary>
public class FulfillmentEventService : ShopifyService, IFulfillmentEventService
{
    /// <summary>
    /// Creates a new instance of <see cref="FulfillmentEventService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public FulfillmentEventService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    internal FulfillmentEventService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<IEnumerable<FulfillmentEvent>> ListAsync(long orderId, long fulfillmentId, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<IEnumerable<FulfillmentEvent>>($"orders/{orderId}/fulfillments/{fulfillmentId}/events.json", "fulfillment_events", cancellationToken: cancellationToken);

    /// <inheritdoc />
    public virtual async Task<FulfillmentEvent> GetAsync(long orderId, long fulfillmentId, long fulfillmentEventId, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<FulfillmentEvent>($"orders/{orderId}/fulfillments/{fulfillmentId}/events/{fulfillmentEventId}.json", "fulfillment_event", cancellationToken: cancellationToken);

    /// <inheritdoc />
    public virtual async Task<FulfillmentEvent> CreateAsync(long orderId, long fulfillmentId, FulfillmentEvent @event, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"orders/{orderId}/fulfillments/{fulfillmentId}/events.json");

        var content = new JsonContent(new
        {
            @event
        });

        var response = await ExecuteRequestAsync<FulfillmentEvent>(req, HttpMethod.Post, cancellationToken, content, "fulfillment_event");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long orderId, long fulfillmentId, long fulfillmentEventId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"orders/{orderId}/fulfillments/{fulfillmentId}/events/{fulfillmentEventId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }
}