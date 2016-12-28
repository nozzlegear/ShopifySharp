using RestSharp;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating a blog's articles.
    /// </summary>
    public class ShopifyArticleService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of the service.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyArticleService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of up to 250 articles belonging to the given blog.
        /// </summary>
        /// <param name="blogId">The blog that the articles belong to.</param>
        /// <param name="filter">Options for filtering the result.</param>
        public virtual async Task<IEnumerable<ShopifyArticle>> ListAsync(long blogId, ShopifyArticleFilter filter = null)
        {
            var req = RequestEngine.CreateRequest($"blogs/{blogId}/articles.json", Method.GET, "articles");

            if (filter != null)
            {
                req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));
            }

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyArticle>>(_RestClient, req);
        }

        /// <summary>
        /// Gets a count of the articles belonging to the given blog.
        /// </summary>
        /// <param name="blogId">The blog that the articles belong to.</param>
        /// <param name="filter">Options for filtering the result.</param>
        public virtual async Task<int> CountAsync(long blogId, ShopifyPublishableCountFilter filter = null)
        {
            var req = RequestEngine.CreateRequest($"blogs/{blogId}/articles/count.json", Method.GET, "count");

            if (filter != null)
            {
                req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));
            }

            return await RequestEngine.ExecuteRequestAsync<int>(_RestClient, req);
        }

        /// <summary>
        /// Gets an article with the given id.
        /// </summary>
        /// <param name="blogId">The blog that the article belongs to.</param>
        /// <param name="articleId">The article's id.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        public virtual async Task<ShopifyArticle> GetAsync(long blogId, long articleId, string fields = null)
        {
            var req = RequestEngine.CreateRequest($"blogs/{blogId}/articles/{articleId}.json", Method.GET, "article");

            if (fields != null)
            {
                req.AddQueryParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyArticle>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new article on the given blog.
        /// </summary>
        /// <param name="blogId">The blog that the article will belong to.</param>
        /// <param name="article">The article being created. Id should be null.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="ShopifyMetaFieldService"/>.</param>
        public virtual async Task<ShopifyArticle> CreateAsync(long blogId, ShopifyArticle article, IEnumerable<ShopifyMetaField> metafields = null)
        {
            var req = RequestEngine.CreateRequest($"blogs/{blogId}/articles.json", Method.POST, "article");
            var body = article.ToDictionary();
            
            if (metafields != null)
            {
                body.Add("metafields", metafields);
            }

            req.AddJsonBody(new
            {
                article = body
            });

            return await RequestEngine.ExecuteRequestAsync<ShopifyArticle>(_RestClient, req);
        }

        /// <summary>
        /// Updates an article.
        /// </summary>
        /// <param name="blogId">The blog that the article belongs to.</param>
        /// <param name="article">The article being updated. Id should not be null.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="ShopifyMetaFieldService"/>.</param>
        public virtual async Task<ShopifyArticle> UpdateAsync(long blogId, ShopifyArticle article, IEnumerable<ShopifyMetaField> metafields = null)
        {
            var req = RequestEngine.CreateRequest($"blogs/{blogId}/articles/{article.Id}.json", Method.PUT, "article");
            var body = article.ToDictionary();

            if (metafields != null)
            {
                body.Add("metafields", metafields);
            }

            req.AddJsonBody(new
            {
                article = body
            });

            return await RequestEngine.ExecuteRequestAsync<ShopifyArticle>(_RestClient, req);
        }

        /// <summary>
        /// Deletes an article with the given id.
        /// </summary>
        /// <param name="blogId">The blog that the article belongs to.</param>
        /// <param name="articleId">The article benig deleted.</param>
        public virtual async Task DeleteAsync(long blogId, long articleId)
        {
            var req = RequestEngine.CreateRequest($"blogs/{blogId}/articles/{articleId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        /// <summary>
        /// Gets a list of all article authors.
        /// </summary>
        public virtual async Task<IEnumerable<string>> ListAuthorsAsync()
        {
            var req = RequestEngine.CreateRequest($"articles/authors.json", Method.GET, "authors");

            return await RequestEngine.ExecuteRequestAsync<List<string>>(_RestClient, req);
        }

        /// <summary>
        /// Gets a list of all article tags.
        /// </summary>
        /// <param name="limit">The number of tags to return</param>
        /// <param name="popular">A flag to indicate only to a certain number of the most popular tags.</param>
        public virtual async Task<IEnumerable<string>> ListTagsAsync(int? popular = null, int? limit = null)
        {
            var req = RequestEngine.CreateRequest($"articles/tags.json", Method.GET, "tags");

            if (popular.HasValue)
            {
                req.AddQueryParameter("popular", popular.Value.ToString());
            }

            if (limit.HasValue)
            {
                req.AddQueryParameter("limit", limit.Value.ToString());
            }

            return await RequestEngine.ExecuteRequestAsync<List<string>>(_RestClient, req);
        }

        /// <summary>
        /// Gets a list of all article tags for the given blog.
        /// </summary>
        /// <param name="blogId">The blog that the tags belong to.</param>
        /// <param name="limit">The number of tags to return</param>
        /// <param name="popular">A flag to indicate only to a certain number of the most popular tags.</param>
        public virtual async Task<IEnumerable<string>> ListTagsForBlogAsync(long blogId, int? popular = null, int? limit = null)
        {
            var req = RequestEngine.CreateRequest($"blogs/{blogId}/articles/tags.json", Method.GET, "tags");

            if (popular.HasValue)
            {
                req.AddQueryParameter("popular", popular.Value.ToString());
            }

            if (limit.HasValue)
            {
                req.AddQueryParameter("limit", limit.Value.ToString());
            }

            return await RequestEngine.ExecuteRequestAsync<List<string>>(_RestClient, req);
        }
    }
}
