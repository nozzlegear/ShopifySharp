using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating a blog's articles.
    /// </summary>
    public class ArticleService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of the service.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ArticleService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of up to 250 articles belonging to the given blog.
        /// </summary>
        /// <param name="blogId">The blog that the articles belong to.</param>
        /// <param name="filter">Options for filtering the result.</param>
        public virtual async Task<IEnumerable<Article>> ListAsync(long blogId, ArticleFilter filter = null)
        {
            var req = PrepareRequest($"blogs/{blogId}/articles.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<List<Article>>(req, HttpMethod.Get, rootElement: "articles");
        }

        /// <summary>
        /// Gets a count of the articles belonging to the given blog.
        /// </summary>
        /// <param name="blogId">The blog that the articles belong to.</param>
        /// <param name="filter">Options for filtering the result.</param>
        public virtual async Task<int> CountAsync(long blogId, PublishableCountFilter filter = null)
        {
            var req = PrepareRequest($"blogs/{blogId}/articles/count.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets an article with the given id.
        /// </summary>
        /// <param name="blogId">The blog that the article belongs to.</param>
        /// <param name="articleId">The article's id.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        public virtual async Task<Article> GetAsync(long blogId, long articleId, string fields = null)
        {
            var req = PrepareRequest($"blogs/{blogId}/articles/{articleId}.json");

            if (fields != null)
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<Article>(req, HttpMethod.Get, rootElement: "article");
        }

        /// <summary>
        /// Creates a new article on the given blog.
        /// </summary>
        /// <param name="blogId">The blog that the article will belong to.</param>
        /// <param name="article">The article being created. Id should be null.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="MetafieldService"/>.</param>
        public virtual async Task<Article> CreateAsync(long blogId, Article article, IEnumerable<Metafield> metafields = null)
        {
            var req = PrepareRequest($"blogs/{blogId}/articles.json");
            var body = article.ToDictionary();

            if (metafields != null)
            {
                body.Add("metafields", metafields);
            }

            var content = new JsonContent(new
            {
                article = body
            });

            return await ExecuteRequestAsync<Article>(req, HttpMethod.Post, content, "article");
        }

        /// <summary>
        /// Updates an article.
        /// </summary>
        /// <param name="blogId">The blog that the article belongs to.</param>
        /// <param name="articleId">Id of the object being updated.</param>
        /// <param name="article">The article being updated.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="MetafieldService"/>.</param>
        public virtual async Task<Article> UpdateAsync(long blogId, long articleId, Article article, IEnumerable<Metafield> metafields = null)
        {
            var req = PrepareRequest($"blogs/{blogId}/articles/{articleId}.json");
            var body = article.ToDictionary();

            if (metafields != null)
            {
                body.Add("metafields", metafields);
            }

            var content = new JsonContent(new
            {
                article = body
            });

            return await ExecuteRequestAsync<Article>(req, HttpMethod.Put, content, "article");
        }

        /// <summary>
        /// Deletes an article with the given id.
        /// </summary>
        /// <param name="blogId">The blog that the article belongs to.</param>
        /// <param name="articleId">The article benig deleted.</param>
        public virtual async Task DeleteAsync(long blogId, long articleId)
        {
            var req = PrepareRequest($"blogs/{blogId}/articles/{articleId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }

        /// <summary>
        /// Gets a list of all article authors.
        /// </summary>
        public virtual async Task<IEnumerable<string>> ListAuthorsAsync()
        {
            var req = PrepareRequest($"articles/authors.json");

            return await ExecuteRequestAsync<List<string>>(req, HttpMethod.Get, rootElement: "authors");
        }

        /// <summary>
        /// Gets a list of all article tags.
        /// </summary>
        /// <param name="limit">The number of tags to return</param>
        /// <param name="popular">A flag to indicate only to a certain number of the most popular tags.</param>
        public virtual async Task<IEnumerable<string>> ListTagsAsync(int? popular = null, int? limit = null)
        {
            var req = PrepareRequest($"articles/tags.json");

            if (popular.HasValue)
            {
                req.QueryParams.Add("popular", popular.Value);
            }

            if (limit.HasValue)
            {
                req.QueryParams.Add("limit", limit.Value);
            }

            return await ExecuteRequestAsync<List<string>>(req, HttpMethod.Get, rootElement: "tags");
        }

        /// <summary>
        /// Gets a list of all article tags for the given blog.
        /// </summary>
        /// <param name="blogId">The blog that the tags belong to.</param>
        /// <param name="limit">The number of tags to return</param>
        /// <param name="popular">A flag to indicate only to a certain number of the most popular tags.</param>
        public virtual async Task<IEnumerable<string>> ListTagsForBlogAsync(long blogId, int? popular = null, int? limit = null)
        {
            var req = PrepareRequest($"blogs/{blogId}/articles/tags.json");

            if (popular.HasValue)
            {
                req.QueryParams.Add("popular", popular.Value);
            }

            if (limit.HasValue)
            {
                req.QueryParams.Add("limit", limit.Value);
            }

            return await ExecuteRequestAsync<List<string>>(req, HttpMethod.Get, rootElement: "tags");
        }
    }
}
