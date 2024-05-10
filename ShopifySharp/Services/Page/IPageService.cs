using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp;

public interface IPageService : IShopifyService
{
    /// <summary>
    /// Gets a count of all of the shop's pages.
    /// </summary>
    Task<int> CountAsync(PageCountFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of up to 250 of the shop's pages.
    /// </summary>
    Task<ListResult<Page>> ListAsync(ListFilter<Page> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of up to 250 of the shop's pages.
    /// </summary>
    Task<ListResult<Page>> ListAsync(PageListFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="Page"/> with the given id.
    /// </summary>
    /// <param name="pageId">The id of the page to retrieve.</param>
    /// <param name="fields">A comma-separated list of fields to return.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The <see cref="Page"/>.</returns>
    Task<Page> GetAsync(long pageId, string fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new <see cref="Page"/> on the store.
    /// </summary>
    /// <param name="page">A new <see cref="Page"/>. Id should be set to null.</param>
    /// <param name="options">Options for creating the page.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The new <see cref="Page"/>.</returns>
    Task<Page> CreateAsync(Page page, PageCreateOptions options = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the given <see cref="Page"/>.
    /// </summary>
    /// <param name="pageId">Id of the object being updated.</param>
    /// <param name="page">The <see cref="Page"/> to update.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The updated <see cref="Page"/>.</returns>
    Task<Page> UpdateAsync(long pageId, Page page, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a page with the given Id.
    /// </summary>
    /// <param name="pageId">The page object's Id.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task DeleteAsync(long pageId, CancellationToken cancellationToken = default);
}