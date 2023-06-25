using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IArticleService : IShopifyService
    {
        /// <summary>
        /// Gets a list of up to 250 articles belonging to the given blog.
        /// </summary>
        Task<ListResult<Article>> ListAsync(long blogId, ListFilter<Article> filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 articles belonging to the given blog.
        /// </summary>
        Task<ListResult<Article>> ListAsync(int blogId, ArticleListFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a count of the articles belonging to the given blog.
        /// </summary>
        /// <param name="blogId">The blog that the articles belong to.</param>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<int> CountAsync(long blogId, ArticleCountFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets an article with the given id.
        /// </summary>
        /// <param name="blogId">The blog that the article belongs to.</param>
        /// <param name="articleId">The article's id.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<Article> GetAsync(long blogId, long articleId, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new article on the given blog.
        /// </summary>
        /// <param name="blogId">The blog that the article will belong to.</param>
        /// <param name="article">The article being created. Id should be null.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="MetaFieldService"/>.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<Article> CreateAsync(long blogId, Article article, IEnumerable<MetaField> metafields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an article.
        /// </summary>
        /// <param name="blogId">The blog that the article belongs to.</param>
        /// <param name="articleId">Id of the object being updated.</param>
        /// <param name="article">The article being updated.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="MetaFieldService"/>.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<Article> UpdateAsync(long blogId, long articleId, Article article, IEnumerable<MetaField> metafields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an article with the given id.
        /// </summary>
        /// <param name="blogId">The blog that the article belongs to.</param>
        /// <param name="articleId">The article benig deleted.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long blogId, long articleId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of all article authors.
        /// </summary>
        Task<IEnumerable<string>> ListAuthorsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of all article tags.
        /// </summary>
        /// <param name="limit">The number of tags to return</param>
        /// <param name="popular">A flag to indicate only to a certain number of the most popular tags.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<IEnumerable<string>> ListTagsAsync(int? popular = null, int? limit = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of all article tags for the given blog.
        /// </summary>
        /// <param name="blogId">The blog that the tags belong to.</param>
        /// <param name="limit">The number of tags to return</param>
        /// <param name="popular">A flag to indicate only to a certain number of the most popular tags.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<IEnumerable<string>> ListTagsForBlogAsync(long blogId, int? popular = null, int? limit = null, CancellationToken cancellationToken = default);
    }
}