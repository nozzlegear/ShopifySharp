using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface ICollectionService
    {
        /// <summary>
        /// Gets a list of the products belonging to the collection.
        /// </summary>
        /// <param name="collectionId">Id of the collection for which to retrieve products.</param>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<Product>> ListProductsAsync(long collectionId, ListFilter<Product> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of the products belonging to the collection.
        /// </summary>
        /// <param name="collectionId">Id of the collection for which to retrieve products.</param>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<Product>> ListProductsAsync(long collectionId, CollectionProductsListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the object with the given id.
        /// </summary>
        /// <param name="collectionId">The id of the object to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<Collection> GetAsync(long collectionId, string fields = null, CancellationToken cancellationToken = default);
    }
}