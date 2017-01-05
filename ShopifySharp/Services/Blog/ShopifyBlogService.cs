using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for interacting with a store's blogs (not blog posts).
    /// </summary>
    public class ShopifyBlogService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyBlogService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyBlogService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of all blogs.
        /// </summary>
        /// <param name="sinceId">Restrict results to after the specified ID</param>
        /// <param name="handle">Filter by Blog handle</param>
        /// <param name="fields">comma-separated list of fields to include in the response</param>
        public virtual async Task<IEnumerable<ShopifyBlog>> ListAsync(long? sinceId = null, string handle = null, string fields = null)
        {
            var request = RequestEngine.CreateRequest("blogs.json", RestSharp.Method.GET, "blogs");

            if (sinceId.HasValue)
            {
                request.AddParameter("since_id", sinceId.Value, RestSharp.ParameterType.GetOrPost);
            }

            if (!string.IsNullOrEmpty(handle))
            {
                request.AddParameter("handle", handle);
            }

            if (!string.IsNullOrEmpty(fields))
            {
                request.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyBlog>>(_RestClient, request);
        }

        /// <summary>
        /// Gets a count of all blogs.
        /// </summary>
        public virtual async Task<int> CountAsync()
        {
            var request = RequestEngine.CreateRequest("blogs/count.json", RestSharp.Method.GET, "count");

            return await RequestEngine.ExecuteRequestAsync<int>(_RestClient, request);
        }

        /// <summary>
        /// Creates a new blog.
        /// </summary>
        /// <param name="blog">The blog being created. Id should be null.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="ShopifyMetaFieldService"/>.</param>
        public virtual async Task<ShopifyBlog> CreateAsync(ShopifyBlog blog, IEnumerable<ShopifyMetaField> metafields = null)
        {
            var request = RequestEngine.CreateRequest("blogs.json", RestSharp.Method.POST, "blog");
            var body = blog.ToDictionary();

            if (metafields != null && metafields.Count() >= 1)
            {
                body.Add("metafields", metafields);
            }

            request.AddJsonBody(new
            {
                blog = body
            });

            return await RequestEngine.ExecuteRequestAsync<ShopifyBlog>(_RestClient, request);
        }

        /// <summary>
        /// Updates a blog.
        /// </summary>
        /// <param name="blog">The updated blog. Id should not be null.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="ShopifyMetaFieldService"/>.</param>
        public virtual async Task<ShopifyBlog> UpdateAsync(ShopifyBlog blog, IEnumerable<ShopifyMetaField> metafields = null)
        {
            var request = RequestEngine.CreateRequest($"blogs/{blog.Id.Value}.json", RestSharp.Method.PUT, "blog");
            var body = blog.ToDictionary();

            if (metafields != null && metafields.Count() >= 1)
            {
                body.Add("metafields", metafields);
            }

            request.AddJsonBody(new
            {
                blog = body
            });

            return await RequestEngine.ExecuteRequestAsync<ShopifyBlog>(_RestClient, request);
        }

        /// <summary>
        /// Gets a blog with the given id.
        /// </summary>
        /// <param name="id">The id of the blog you want to retrieve.</param>
        public virtual async Task<ShopifyBlog> GetAsync(long id)
        {
            var request = RequestEngine.CreateRequest($"blogs/{id}.json", RestSharp.Method.GET, "blog");

            return await RequestEngine.ExecuteRequestAsync<ShopifyBlog>(_RestClient, request);
        }

        /// <summary>
        /// Deletes a blog with the given id.
        /// </summary>
        /// <param name="id">The id of the blog you want to delete.</param>
        public virtual async Task DeleteAsync(long id)
        {
            var request = RequestEngine.CreateRequest($"blogs/{id}.json", RestSharp.Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, request);
        }
    }
}
