using System;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify products.
/// </summary>
[Obsolete("Shopify has deprecated the REST API for products. This service is deprecated and will be removed in a future version of ShopifySharp. Use ShopifySharp's GraphService to manage products via the GraphQL API, and check https://github.com/nozzlegear/shopifysharp for a migration guide.")]
public class ProductService : ShopifyService, IProductService
{
    /// <summary>
    /// Creates a new instance of <see cref="ProductService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public ProductService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal ProductService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal ProductService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}

    public virtual async Task<int> CountAsync(ProductCountFilter filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<int>("products/count.json", "count", filter, cancellationToken);

    public virtual async Task<ListResult<Product>> ListAsync(ListFilter<Product> filter, bool includePresentmentPrices = false, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("products.json", "products", filter, cancellationToken, GetHeaders(includePresentmentPrices));

    public virtual async Task<ListResult<Product>> ListAsync(ProductListFilter filter = null, bool includePresentmentPrices = false, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), includePresentmentPrices, cancellationToken);

    public virtual async Task<Product> GetAsync(long productId, string fields = null, bool includePresentmentPrices = false, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<Product>($"products/{productId}.json", "product", fields, cancellationToken, GetHeaders(includePresentmentPrices));

    public virtual async Task<Product> CreateAsync(Product product, ProductCreateOptions options = null, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri("products.json");
        var body = product.ToDictionary();

        if (options != null)
        {
            foreach (var option in options.ToDictionary())
            {
                body.Add(option);
            }
        }

        var content = new JsonContent(new
        {
            product = body
        });
        var response = await ExecuteRequestAsync<Product>(req, HttpMethod.Post, cancellationToken, content, "product");

        return response.Result;
    }

    public virtual async Task<Product> UpdateAsync(long productId, Product product, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"products/{productId}.json");
        var content = new JsonContent(new
        {
            product = product
        });
        var response = await ExecuteRequestAsync<Product>(req, HttpMethod.Put, cancellationToken, content, "product");

        return response.Result;
    }

    public virtual async Task DeleteAsync(long productId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"products/{productId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }

    public virtual async Task<Product> PublishAsync(long id, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"products/{id}.json");
        var content = new JsonContent(new
        {
            product = new
            {
                id = id,
                published = true
            }
        });
        var response = await ExecuteRequestAsync<Product>(req, HttpMethod.Put, cancellationToken, content, "product");

        return response.Result;
    }

    public virtual async Task<Product> UnpublishAsync(long id, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"products/{id}.json");
        var content = new JsonContent(new
        {
            product = new
            {
                id = id,
                published = false
            }
        });
        var response = await ExecuteRequestAsync<Product>(req, HttpMethod.Put, cancellationToken, content, "product");

        return response.Result;
    }

    protected virtual Dictionary<string, string> GetHeaders(bool includePresentmentPrices)
    {
        if (!includePresentmentPrices)
            return null;

        return new Dictionary<string, string>
        {
            { "X-Shopify-Api-Features", "include-presentment-prices" }
        };
    }
}
