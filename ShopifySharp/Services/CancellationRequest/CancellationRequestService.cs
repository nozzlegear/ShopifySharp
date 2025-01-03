using ShopifySharp.Infrastructure;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// The CancellationRequest resource represents a cancellation request made by the merchant or an order management app to a fulfillment service for a fulfillment order.
/// </summary>
public class CancellationRequestService : ShopifyService, ICancellationRequestService
{
    /// <summary>
    /// Creates a new instance of <see cref="CancellationRequestService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public CancellationRequestService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal CancellationRequestService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal CancellationRequestService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<FulfillmentOrder> CreateAsync(long fulfillmentOrderId, string message, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($@"fulfillment_orders/{fulfillmentOrderId}/cancellation_request.json");
        var cancellationRequest = new CancellationRequest { Message = message };
        var body = cancellationRequest.ToDictionary();

        var content = new JsonContent(new
        {
            cancellation_request = body
        });

        var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, content, "fulfillment_order");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<FulfillmentOrder> AcceptAsync(long fulfillmentOrderId, string message, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"fulfillment_orders/{fulfillmentOrderId}/cancellation_request/accept.json");
        var cancellationRequest = new CancellationRequest { Message = message };
        var body = cancellationRequest.ToDictionary();

        var content = new JsonContent(new
        {
            cancellation_request = body
        });

        var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, content, "fulfillment_order");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<FulfillmentOrder> RejectAsync(long fulfillmentOrderId, string message, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($@"fulfillment_orders/{fulfillmentOrderId}/cancellation_request/reject.json");
        var cancellationRequest = new CancellationRequest { Message = message };
        var body = cancellationRequest.ToDictionary();

        var content = new JsonContent(new
        {
            cancellation_request = body
        });

        var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, content, "fulfillment_order");
        return response.Result;
    }
}