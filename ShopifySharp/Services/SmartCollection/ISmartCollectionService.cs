using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface ISmartCollectionService : IShopifyService
    {
        /// <summary>
        /// Gets a count of all smart collections on the store.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<int> CountAsync(SmartCollectionCountFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 smart collections.
        /// </summary>
        Task<ListResult<SmartCollection>> ListAsync(ListFilter<SmartCollection> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 smart collections.
        /// </summary>
        Task<ListResult<SmartCollection>> ListAsync(SmartCollectionListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="SmartCollection"/> with the given id.
        /// </summary>
        /// <param name="collectionId">The id of the smart collection to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<SmartCollection> GetAsync(long collectionId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="SmartCollection"/>.
        /// </summary>
        /// <param name="collection">A new <see cref="SmartCollection"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<SmartCollection> CreateAsync(SmartCollection collection, bool published = true, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the given <see cref="SmartCollection"/>.
        /// </summary>
        /// <param name="smartCollectionId">Id of the object being updated.</param>
        /// <param name="collection">The smart collection to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<SmartCollection> UpdateAsync(long smartCollectionId, SmartCollection collection, CancellationToken cancellationToken = default);

        /// <summary>
        /// Publishes an unpublished smart collection.
        /// </summary>
        /// <param name="smartCollectionId">The collection's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<SmartCollection> PublishAsync(long smartCollectionId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Publishes an unpublished smart collection.
        /// </summary>
        /// <param name="smartCollectionId">The collection's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<SmartCollection> UnpublishAsync(long smartCollectionId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the order of products when a SmartCollection's sort-by method is set to "manual".
        /// </summary>
        /// <param name="smartCollectionId">Id of the object being updated.</param>
        /// <param name="sortOrder">The order in which products in the smart collection appear. Note that specifying productIds parameter will have no effect unless the sort order is "manual"</param>
        /// <param name="productIds">An array of product ids sorted in the order you want them to appear in.</param>
        Task UpdateProductOrderAsync(long smartCollectionId, string sortOrder = null, params long[] productIds);

        /// <summary>
        /// Updates the order of products when a SmartCollection's sort-by method is set to "manual".
        /// </summary>
        /// <param name="smartCollectionId">Id of the object being updated.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <param name="sortOrder">The order in which products in the smart collection appear. Note that specifying productIds parameter will have no effect unless the sort order is "manual"</param>
        /// <param name="productIds">An array of product ids sorted in the order you want them to appear in.</param>
        Task UpdateProductOrderAsync(long smartCollectionId, CancellationToken cancellationToken, string sortOrder = null, params long[] productIds);

        /// <summary>
        /// Deletes a smart collection with the given Id.
        /// </summary>
        /// <param name="collectionId">The smart collection's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long collectionId, CancellationToken cancellationToken = default);
    }
}