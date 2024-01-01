using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IBlogService : IShopifyService
    {
        /// <summary>
        /// Gets a list of up to 250 blogs belonging to the store.
        /// </summary>
        Task<ListResult<Blog>> ListAsync(ListFilter<Blog> filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 blogs belonging to the store.
        /// </summary>
        Task<ListResult<Blog>> ListAsync(BlogListFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a count of all blogs.
        /// </summary>
        Task<int> CountAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new blog.
        /// </summary>
        /// <param name="blog">The blog being created. Id should be null.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="MetaFieldService"/>.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<Blog> CreateAsync(Blog blog, IEnumerable<MetaField> metafields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a blog.
        /// </summary>
        /// <param name="blogId">Id of the object being updated.</param>
        /// <param name="blog">The updated blog.</param>
        /// <param name="metafields">Optional metafield data that can be returned by the <see cref="MetaFieldService"/>.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<Blog> UpdateAsync(long blogId, Blog blog, IEnumerable<MetaField> metafields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a blog with the given id.
        /// </summary>
        /// <param name="id">The id of the blog you want to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<Blog> GetAsync(long id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a blog with the given id.
        /// </summary>
        /// <param name="id">The id of the blog you want to delete.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long id, CancellationToken cancellationToken = default);
    }
}