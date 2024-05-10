using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify's smart collections.
/// </summary>
public class SmartCollectionService : ShopifyService, ISmartCollectionService
{
    /// <summary>
    /// Creates a new instance of <see cref="SmartCollectionService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public SmartCollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    internal SmartCollectionService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<int> CountAsync(SmartCollectionCountFilter filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<int>("smart_collections/count.json", "count", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<SmartCollection>> ListAsync(ListFilter<SmartCollection> filter, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync($"smart_collections.json", "smart_collections", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<SmartCollection>> ListAsync(SmartCollectionListFilter filter = null, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<SmartCollection> GetAsync(long collectionId, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<SmartCollection>($"smart_collections/{collectionId}.json", "smart_collection", cancellationToken: cancellationToken);

    /// <inheritdoc />
    public virtual async Task<SmartCollection> CreateAsync(SmartCollection collection, bool published = true, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"smart_collections.json");
        var body = collection.ToDictionary();

        body.Add("published", published);

        var content = new JsonContent(new
        {
            smart_collection = body
        });
        var response = await ExecuteRequestAsync<SmartCollection>(req, HttpMethod.Post, cancellationToken, content, "smart_collection");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<SmartCollection> UpdateAsync(long smartCollectionId, SmartCollection collection, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"smart_collections/{smartCollectionId}.json");
        var content = new JsonContent(new
        {
            smart_collection = collection
        });
        var response = await ExecuteRequestAsync<SmartCollection>(req, HttpMethod.Put, cancellationToken, content, "smart_collection");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<SmartCollection> PublishAsync(long smartCollectionId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"smart_collections/{smartCollectionId}.json");
        var body = new Dictionary<string, object>()
        {
            { "id", smartCollectionId },
            { "published", true }
        };
        var content = new JsonContent(new 
        {
            smart_collection = body
        });
        var response = await ExecuteRequestAsync<SmartCollection>(req, HttpMethod.Put, cancellationToken, content, "smart_collection");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<SmartCollection> UnpublishAsync(long smartCollectionId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"smart_collections/{smartCollectionId}.json");
        var body = new Dictionary<string, object>()
        {
            { "id", smartCollectionId },
            { "published", false }
        };
        var content = new JsonContent(new 
        {
            smart_collection = body
        });
        var response = await ExecuteRequestAsync<SmartCollection>(req, HttpMethod.Put, cancellationToken, content, "smart_collection");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task UpdateProductOrderAsync(long smartCollectionId, string sortOrder = null, params long[] productIds)
    {
        var req = BuildRequestUri($"smart_collections/{smartCollectionId}/order.json");
        var content = new JsonContent(new
        {
            sort_order = sortOrder,
            products = productIds
        });
        await ExecuteRequestAsync(req, HttpMethod.Put, CancellationToken.None, content);
    }

    /// <inheritdoc />
    public virtual async Task UpdateProductOrderAsync(long smartCollectionId, CancellationToken cancellationToken, string sortOrder = null, params long[] productIds)
    {
        var req = BuildRequestUri($"smart_collections/{smartCollectionId}/order.json");
        var content = new JsonContent(new
        {
            sort_order = sortOrder,
            products = productIds
        });
        await ExecuteRequestAsync(req, HttpMethod.Put, cancellationToken, content);
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long collectionId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"smart_collections/{collectionId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }
}