using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp;

public interface ICustomCollectionService : IShopifyService
{
    /// <summary>
    /// Gets a list of up to 250 custom collections.
    /// </summary>
    Task<ListResult<CustomCollection>> ListAsync(ListFilter<CustomCollection> filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of up to 250 custom collections.
    /// </summary>
    Task<ListResult<CustomCollection>> ListAsync(CustomCollectionListFilter filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new <see cref="CustomCollection"/> Custom Collection
    /// </summary>
    /// <param name="customCollection">A new <see cref="CustomCollection"/>. Id should be set to null.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The new <see cref="CustomCollection"/>.</returns>
    Task<CustomCollection> CreateAsync(CustomCollection customCollection, CancellationToken cancellationToken = default);

    Task<int> CountAsync(CustomCollectionCountFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="CustomCollection"/> with the given id.
    /// </summary>
    /// <param name="customCollectionId">The id of the custom collection to retrieve.</param>
    /// <param name="fields">A comma-separated list of fields to return.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The <see cref="CustomCollection"/>.</returns>
    Task<CustomCollection> GetAsync(long customCollectionId, string fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a custom collection with the given Id.
    /// </summary>
    /// <param name="customCollectionId">The custom collection's Id.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task DeleteAsync(long customCollectionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the given <see cref="CustomCollection"/>.
    /// </summary>
    /// <param name="customCollectionId">Id of the object being updated.</param>
    /// <param name="customCollection">The <see cref="CustomCollection"/> to update.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The updated <see cref="CustomCollection"/>.</returns>
    Task<CustomCollection> UpdateAsync(long customCollectionId, CustomCollection customCollection, CancellationToken cancellationToken = default);
}