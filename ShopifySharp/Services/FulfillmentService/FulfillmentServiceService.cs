using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify fulfillments.
/// </summary>
public class FulfillmentServiceService : ShopifyService, IFulfillmentServiceService
{
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public FulfillmentServiceService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal FulfillmentServiceService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal FulfillmentServiceService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<IEnumerable<FulfillmentServiceEntity>> ListAsync(FulfillmentServiceListFilter filter = null, CancellationToken cancellationToken = default) => 
        await ExecuteGetAsync<List<FulfillmentServiceEntity>>("fulfillment_services.json", "fulfillment_services", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<FulfillmentServiceEntity> GetAsync(long fulfillmentServiceId, string fields = null, CancellationToken cancellationToken = default) => 
        await ExecuteGetAsync<FulfillmentServiceEntity>($"fulfillment_services/{fulfillmentServiceId}.json", "fulfillment_service", fields, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<FulfillmentServiceEntity> CreateAsync(FulfillmentServiceEntity fulfillmentServiceEntity, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"fulfillment_services.json");
        var body = fulfillmentServiceEntity.ToDictionary();

        var content = new JsonContent(new
        {
            fulfillment_service = body
        });

        var response = await ExecuteRequestAsync<FulfillmentServiceEntity>(req, HttpMethod.Post, cancellationToken, content, "fulfillment_service");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<FulfillmentServiceEntity> UpdateAsync(long fulfillmentServiceId, FulfillmentServiceEntity fulfillmentServiceEntity, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"fulfillment_services/{fulfillmentServiceId}.json");
        var body = fulfillmentServiceEntity.ToDictionary();

        var content = new JsonContent(new
        {
            fulfillment_service = body
        });

        var response = await ExecuteRequestAsync<FulfillmentServiceEntity>(req, HttpMethod.Put, cancellationToken, content, "fulfillment_service");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long fulfillmentServiceId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"fulfillment_services/{fulfillmentServiceId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }
}