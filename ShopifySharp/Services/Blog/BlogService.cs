using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for interacting with a store's blogs (not blog posts).
    /// </summary>
    public class BlogService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="BlogService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public BlogService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of up to 250 blogs belonging to the store.
        /// </summary>
        public virtual async Task<ListResult<Blog>> ListAsync(ListFilter<Blog> filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("blogs.json", "blogs", filter, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 blogs belonging to the store.
        /// </summary>
        public virtual async Task<ListResult<Blog>> ListAsync(BlogListFilter filter, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Gets a count of all blogs.
        /// </summary>
        public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>("blogs/count.json", "count", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Creates a new blog.
        /// </summary>
        /// <param name="blog">The blog being created. Id should be null.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="MetaFieldService"/>.</param>
        public virtual async Task<Blog> CreateAsync(Blog blog, IEnumerable<MetaField> metafields = null, CancellationToken cancellationToken = default)
        {
            var request = PrepareRequest("blogs.json");
            var body = blog.ToDictionary();

            if (metafields != null && metafields.Any())
            {
                body.Add("metafields", metafields);
            }

            var content = new JsonContent(new
            {
                blog = body
            });

            var response = await ExecuteRequestAsync<Blog>(request, HttpMethod.Post, content, rootElement: "blog", cancellationToken: cancellationToken);
            return response.Result;
        }

        /// <summary>
        /// Updates a blog.
        /// </summary>
        /// <param name="blogId">Id of the object being updated.</param>
        /// <param name="blog">The updated blog.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="MetaFieldService"/>.</param>
        public virtual async Task<Blog> UpdateAsync(long blogId, Blog blog, IEnumerable<MetaField> metafields = null, CancellationToken cancellationToken = default)
        {
            var request = PrepareRequest($"blogs/{blogId}.json");
            var body = blog.ToDictionary();

            if (metafields != null && metafields.Count() >= 1)
            {
                body.Add("metafields", metafields);
            }

            var content = new JsonContent(new
            {
                blog = body
            });

            var response = await ExecuteRequestAsync<Blog>(request, HttpMethod.Put, content, "blog", cancellationToken: cancellationToken);
            return response.Result;
        }

        /// <summary>
        /// Gets a blog with the given id.
        /// </summary>
        /// <param name="id">The id of the blog you want to retrieve.</param>
        public virtual async Task<Blog> GetAsync(long id, CancellationToken cancellationToken = default)
        {
            var request = PrepareRequest($"blogs/{id}.json");

            var response = await ExecuteRequestAsync<Blog>(request, HttpMethod.Get, rootElement: "blog", cancellationToken: cancellationToken);
            return response.Result;
        }

        /// <summary>
        /// Deletes a blog with the given id.
        /// </summary>
        /// <param name="id">The id of the blog you want to delete.</param>
        public virtual async Task DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            var request = PrepareRequest($"blogs/{id}.json");

            await ExecuteRequestAsync(request, HttpMethod.Delete, cancellationToken: cancellationToken);
        }
    }
}
