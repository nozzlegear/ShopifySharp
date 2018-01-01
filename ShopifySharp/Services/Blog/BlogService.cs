using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using ShopifySharp.Infrastructure;

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
        /// Gets a list of all blogs.
        /// </summary>
        /// <param name="sinceId">Restrict results to after the specified ID</param>
        /// <param name="handle">Filter by Blog handle</param>
        /// <param name="fields">comma-separated list of fields to include in the response</param>
        public virtual async Task<IEnumerable<Blog>> ListAsync(long? sinceId = null, string handle = null, string fields = null)
        {
            var request = PrepareRequest("blogs.json");

            if (sinceId.HasValue)
            {
                request.QueryParams.Add("since_id", sinceId.Value);
            }

            if (!string.IsNullOrEmpty(handle))
            {
                request.QueryParams.Add("handle", handle);
            }

            if (!string.IsNullOrEmpty(fields))
            {
                request.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<List<Blog>>(request, HttpMethod.Get, rootElement: "blogs");
        }

        /// <summary>
        /// Gets a count of all blogs.
        /// </summary>
        public virtual async Task<int> CountAsync()
        {
            var request = PrepareRequest("blogs/count.json");

            return await ExecuteRequestAsync<int>(request, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Creates a new blog.
        /// </summary>
        /// <param name="blog">The blog being created. Id should be null.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="MetaFieldService"/>.</param>
        public virtual async Task<Blog> CreateAsync(Blog blog, IEnumerable<MetaField> metafields = null)
        {
            var request = PrepareRequest("blogs.json");
            var body = blog.ToDictionary();

            if (metafields != null && metafields.Count() >= 1)
            {
                body.Add("metafields", metafields);
            }

            var content = new JsonContent(new
            {
                blog = body
            });

            return await ExecuteRequestAsync<Blog>(request, HttpMethod.Post, content, rootElement: "blog");
        }

        /// <summary>
        /// Updates a blog.
        /// </summary>
        /// <param name="blogId">Id of the object being updated.</param>
        /// <param name="blog">The updated blog.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="MetaFieldService"/>.</param>
        public virtual async Task<Blog> UpdateAsync(long blogId, Blog blog, IEnumerable<MetaField> metafields = null)
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

            return await ExecuteRequestAsync<Blog>(request, HttpMethod.Put, content, "blog");
        }

        /// <summary>
        /// Gets a blog with the given id.
        /// </summary>
        /// <param name="id">The id of the blog you want to retrieve.</param>
        public virtual async Task<Blog> GetAsync(long id)
        {
            var request = PrepareRequest($"blogs/{id}.json");

            return await ExecuteRequestAsync<Blog>(request, HttpMethod.Get, rootElement: "blog");
        }

        /// <summary>
        /// Deletes a blog with the given id.
        /// </summary>
        /// <param name="id">The id of the blog you want to delete.</param>
        public virtual async Task DeleteAsync(long id)
        {
            var request = PrepareRequest($"blogs/{id}.json");

            await ExecuteRequestAsync(request, HttpMethod.Delete);
        }
    }
}
