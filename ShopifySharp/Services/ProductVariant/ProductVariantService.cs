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
/// A service for manipulating a Shopify product's variants.
/// </summary>
public class ProductVariantService : ShopifyService, IProductVariantService
{
    /// <summary>
    /// Creates a new instance of <see cref="ProductVariantService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public ProductVariantService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal ProductVariantService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal ProductVariantService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<int> CountAsync(long productId, CancellationToken cancellationToken = default)
    {
        return await ExecuteGetAsync<int>($"products/{productId}/variants/count.json", "count", cancellationToken: cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<ListResult<ProductVariant>> ListAsync(long productId, ListFilter<ProductVariant> filter, CancellationToken cancellationToken = default)
    {
        return await ExecuteGetListAsync($"products/{productId}/variants.json", "variants", filter, cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<ListResult<ProductVariant>> ListAsync(long productId, ProductVariantListFilter filter = null, CancellationToken cancellationToken = default)
    {
        return await ListAsync(productId, filter?.AsListFilter(), cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<ProductVariant> GetAsync(long variantId, CancellationToken cancellationToken = default)
    {
        return await ExecuteGetAsync<ProductVariant>($"variants/{variantId}.json", "variant", cancellationToken: cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<ProductVariant> CreateAsync(long productId, ProductVariant variant, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"products/{productId}/variants.json");
        var content = new JsonContent(new
        {
            variant = variant
        });
        var response = await ExecuteRequestAsync<ProductVariant>(req, HttpMethod.Post, cancellationToken, content, "variant");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<ProductVariant> UpdateAsync(long productVariantId, ProductVariant variant, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"variants/{productVariantId}.json");
        var content = new JsonContent(new
        {
            variant = variant
        });
        var response = await ExecuteRequestAsync<ProductVariant>(req, HttpMethod.Put, cancellationToken, content, "variant");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long productId, long variantId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"products/{productId}/variants/{variantId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }
}