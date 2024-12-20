using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for interacting with a store's blogs (not blog posts).
/// </summary>
public class BlogService : ShopifyService, IBlogService
{
    /// <summary>
    /// Creates a new instance of <see cref="BlogService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public BlogService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal BlogService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal BlogService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<ListResult<Blog>> ListAsync(ListFilter<Blog> filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("blogs.json", "blogs", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Blog>> ListAsync(BlogListFilter filter, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<int>("blogs/count.json", "count", cancellationToken: cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Blog> CreateAsync(Blog blog, IEnumerable<MetaField> metafields = null, CancellationToken cancellationToken = default)
    {
        var request = BuildRequestUri("blogs.json");
        var body = blog.ToDictionary();

        if (metafields != null && metafields.Any())
        {
            body.Add("metafields", metafields);
        }

        var content = new JsonContent(new
        {
            blog = body
        });

        var response = await ExecuteRequestAsync<Blog>(request, HttpMethod.Post, cancellationToken, content, "blog");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<Blog> UpdateAsync(long blogId, Blog blog, IEnumerable<MetaField> metafields = null, CancellationToken cancellationToken = default)
    {
        var request = BuildRequestUri($"blogs/{blogId}.json");
        var body = blog.ToDictionary();

        if (metafields != null && metafields.Count() >= 1)
        {
            body.Add("metafields", metafields);
        }

        var content = new JsonContent(new
        {
            blog = body
        });

        var response = await ExecuteRequestAsync<Blog>(request, HttpMethod.Put, cancellationToken, content, "blog");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<Blog> GetAsync(long id, CancellationToken cancellationToken = default)
    {
        var request = BuildRequestUri($"blogs/{id}.json");

        var response = await ExecuteRequestAsync<Blog>(request, HttpMethod.Get, cancellationToken, rootElement: "blog");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long id, CancellationToken cancellationToken = default)
    {
        var request = BuildRequestUri($"blogs/{id}.json");

        await ExecuteRequestAsync(request, HttpMethod.Delete, cancellationToken);
    }
}