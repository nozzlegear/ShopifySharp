using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IProductListingService : IShopifyService
    {
        /// <summary>
        /// Gets a list of up to 1000 default 50 of the shop's product listings.
        /// </summary>
        Task<ListResult<ProductListing>> ListAsync(ListFilter<ProductListing> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 1000 default 50 of the shop's product listings.
        /// </summary>
        Task<ListResult<ProductListing>> ListAsync(ProductListingListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the specific <see cref="ProductListing"/> that is published to your app
        /// </summary>
        /// <param name="productId">The id of the product to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="ProductListing"/>.</returns>
        Task<ProductListing> GetAsync(long productId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve a count of products that are published to your app
        /// </summary>
        /// <returns>The count of all products for the shop.</returns>
        Task<int> CountAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve product_ids that are published to your app. Maximum 1,000 results per page
        /// </summary>
        Task<ListResult<long>> ListIdsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a product listing to publish a product to your app <see cref="ProductListing"/>.
        /// </summary>
        /// <param name="productId">Id of listing product</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="ProductListing"/>.</returns>
        Task<ProductListing> CreateAsync(long productId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a product listing to unpublish a product from your app
        /// </summary>
        /// <param name="productId">The product object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long productId, CancellationToken cancellationToken = default);
    }
}