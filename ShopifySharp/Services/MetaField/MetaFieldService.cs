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
/// A service for manipulating Shopify metafields.
/// </summary>
public class MetaFieldService : ShopifyService, IMetaFieldService
{
    /// <summary>
    /// Creates a new instance of <see cref="MetaFieldService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public MetaFieldService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal MetaFieldService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal MetaFieldService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default) =>
        await _CountAsync("metafields/count.json", cancellationToken);

    /// <inheritdoc />
    public virtual async Task<int> CountAsync(long resourceId, string resourceType, CancellationToken cancellationToken = default) =>
        await _CountAsync($"{resourceType.ToLower()}/{resourceId}/metafields/count.json", cancellationToken);

    /// <inheritdoc />
    public virtual async Task<int> CountAsync(long resourceId, string resourceType, long parentResourceId, string parentResourceType, CancellationToken cancellationToken = default) =>
        await _CountAsync($"{parentResourceType.ToLower()}/{parentResourceId}/{resourceType.ToLower()}/{resourceId}/metafields/count.json", cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<MetaField>> ListAsync(ListFilter<MetaField> filter, CancellationToken cancellationToken = default) =>
        await _ListAsync("metafields.json", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<MetaField>> ListAsync(long resourceId, string resourceType, ListFilter<MetaField> filter, CancellationToken cancellationToken = default) =>
        await _ListAsync($"{resourceType.ToLower()}/{resourceId}/metafields.json", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<MetaField>> ListAsync(long resourceId, string resourceType, long parentResourceId, string parentResourceType, ListFilter<MetaField> filter, CancellationToken cancellationToken = default) =>
        await _ListAsync($"{parentResourceType.ToLower()}/{parentResourceId}/{resourceType.ToLower()}/{resourceId}/metafields.json", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<MetaField>> ListAsync(MetaFieldFilter filter = null, CancellationToken cancellationToken = default) =>
        await _ListAsync("metafields.json", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<MetaField>> ListAsync(long resourceId, string resourceType, MetaFieldFilter filter = null, CancellationToken cancellationToken = default) =>
        await _ListAsync($"{resourceType.ToLower()}/{resourceId}/metafields.json", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<MetaField>> ListAsync(long resourceId, string resourceType, long parentResourceId, string parentResourceType, MetaFieldFilter filter = null, CancellationToken cancellationToken = default) =>
        await _ListAsync($"{parentResourceType.ToLower()}/{parentResourceId}/{resourceType.ToLower()}/{resourceId}/metafields.json", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<MetaField> GetAsync(long metafieldId, string fields = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<MetaField>($"metafields/{metafieldId}.json", "metafield", fields, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<MetaField> CreateAsync(MetaField metafield, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri("metafields.json");
        var content = new JsonContent(new
        {
            metafield = metafield
        });

        var response = await ExecuteRequestAsync<MetaField>(req, HttpMethod.Post, cancellationToken, content, "metafield");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<MetaField> CreateAsync(MetaField metafield, long resourceId, string resourceType, long parentResourceId, string parentResourceType, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"{parentResourceType.ToLower()}/{parentResourceId}/{resourceType.ToLower()}/{resourceId}/metafields.json");
        var content = new JsonContent(new
        {
            metafield = metafield
        });

        var response = await ExecuteRequestAsync<MetaField>(req, HttpMethod.Post, cancellationToken, content, "metafield");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<MetaField> CreateAsync(MetaField metafield, long resourceId, string resourceType, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"{resourceType.ToLower()}/{resourceId}/metafields.json");
        var content = new JsonContent(new
        {
            metafield = metafield
        });

        var response = await ExecuteRequestAsync<MetaField>(req, HttpMethod.Post, cancellationToken, content, "metafield");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<MetaField> UpdateAsync(long metafieldId, MetaField metafield, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"metafields/{metafieldId}.json");
        var content = new JsonContent(new
        {
            metafield = metafield
        });
        var response = await ExecuteRequestAsync<MetaField>(req, HttpMethod.Put, cancellationToken, content, "metafield");
            
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long metafieldId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"metafields/{metafieldId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }

    private async Task<int> _CountAsync(string path, CancellationToken cancellationToken) =>
        await ExecuteGetAsync<int>(path, "count", cancellationToken: cancellationToken);

    private async Task<ListResult<MetaField>> _ListAsync(string path, ListFilter<MetaField> filter, CancellationToken cancellationToken) =>
        await ExecuteGetListAsync(path, "metafields", filter, cancellationToken);
}