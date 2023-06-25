using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating a blog's articles.
    /// </summary>
    public class ArticleService : ShopifyService, IArticleService
    {
        /// <summary>
        /// Creates a new instance of the service.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ArticleService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<ListResult<Article>> ListAsync(long blogId, ListFilter<Article> filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync($"blogs/{blogId}/articles.json", "articles", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Article>> ListAsync(int blogId, ArticleListFilter filter, CancellationToken cancellationToken = default) =>
            await ListAsync(blogId, (ListFilter<Article>) filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<int> CountAsync(long blogId, ArticleCountFilter filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<int>($"blogs/{blogId}/articles/count.json", "count", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<Article> GetAsync(long blogId, long articleId, string fields = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"blogs/{blogId}/articles/{articleId}.json");

            if (fields != null)
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<Article>(req, HttpMethod.Get, cancellationToken, rootElement: "article");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Article> CreateAsync(long blogId, Article article, IEnumerable<MetaField> metafields = null, CancellationToken cancellationToken = default)
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

            var response = await ExecuteRequestAsync<Article>(req, HttpMethod.Post, cancellationToken, content, "article");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Article> UpdateAsync(long blogId, long articleId, Article article, IEnumerable<MetaField> metafields = null, CancellationToken cancellationToken = default)
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

            var response = await ExecuteRequestAsync<Article>(req, HttpMethod.Put, cancellationToken, content, "article");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task DeleteAsync(long blogId, long articleId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"blogs/{blogId}/articles/{articleId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<string>> ListAuthorsAsync(CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"articles/authors.json");

            var response = await ExecuteRequestAsync<List<string>>(req, HttpMethod.Get, cancellationToken, rootElement: "authors");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<string>> ListTagsAsync(int? popular = null, int? limit = null, CancellationToken cancellationToken = default)
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

            var response = await ExecuteRequestAsync<List<string>>(req, HttpMethod.Get, cancellationToken, rootElement: "tags");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<string>> ListTagsForBlogAsync(long blogId, int? popular = null, int? limit = null, CancellationToken cancellationToken = default)
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

            var response = await ExecuteRequestAsync<List<string>>(req, HttpMethod.Get, cancellationToken, rootElement: "tags");
            return response.Result;
        }
    }
}