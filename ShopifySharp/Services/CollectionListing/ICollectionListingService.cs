using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface ICollectionListingService
    {
        /// <summary>
        /// Retrieve collection listings that are published to your app.
        /// </summary>
        Task<ListResult<CollectionListing>> ListAsync(ListFilter<CollectionListing> filter = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the specific <see cref="CollectionListing"/> that is published to your app
        /// </summary>
        /// <param name="collectionId">The id of the collection to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="ProductListing"/>.</returns>
        Task<CollectionListing> GetAsync(long collectionId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve product_ids that are published to a collection_id. Maximum 1,000 results per page
        /// </summary>
        Task<ListResult<long>> ListIdsAsync(long collectionId, ListFilter<long> filter = default, CancellationToken cancellationToken = default);
    }
}