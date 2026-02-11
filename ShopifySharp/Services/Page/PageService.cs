using System;
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
/// A service for manipulating Shopify pages.
/// </summary>
public class PageService : ShopifyService, IPageService
{
    /// <summary>
    /// Creates a new instance of <see cref="PageService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public PageService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal PageService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    internal PageService(ShopifyApiCredentials shopifyApiCredentials, IServiceProvider serviceProvider) : base(shopifyApiCredentials, serviceProvider) {}
    #nullable restore
    internal PageService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<int> CountAsync(PageCountFilter filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<int>("pages/count.json", "count", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Page>> ListAsync(ListFilter<Page> filter, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("pages.json", "pages", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Page>> ListAsync(PageListFilter filter = null, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Page> GetAsync(long pageId, string fields = null, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"pages/{pageId}.json");

        if (!string.IsNullOrEmpty(fields))
        {
            req.QueryParams.Add("fields", fields);
        }

        var response = await ExecuteRequestAsync<Page>(req, HttpMethod.Get, cancellationToken, rootElement: "page");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<Page> CreateAsync(Page page, PageCreateOptions options = null, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri("pages.json");
        var body = page.ToDictionary();

        if (options != null)
        {
            foreach (var option in options.ToDictionary())
            {
                body.Add(option);
            }
        }

        var content = new JsonContent(new
        {
            page = body
        });
        var response = await ExecuteRequestAsync<Page>(req, HttpMethod.Post, cancellationToken, content, "page");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<Page> UpdateAsync(long pageId, Page page, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"pages/{pageId}.json");
        var content = new JsonContent(new
        {
            page = page
        });
        var response = await ExecuteRequestAsync<Page>(req, HttpMethod.Put, cancellationToken, content, "page");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long pageId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"pages/{pageId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }
}