using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for interacting with Shopify Collections.
    /// </summary>
    public class CollectionService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of the service.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of the products belonging to the collection.
        /// </summary>
        /// <param name="collectionId">Id of the collection for which to retrieve products.</param>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public async Task<ListResult<Product>> ListProductsAsync(long collectionId, ListFilter<Product> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync($"collections/{collectionId}/products.json", "products", filter, cancellationToken);
        }
        
        /// <summary>
        /// Gets a list of the products belonging to the collection.
        /// </summary>
        /// <param name="collectionId">Id of the collection for which to retrieve products.</param>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public async Task<ListResult<Product>> ListProductsAsync(long collectionId, CollectionProductsListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListProductsAsync(collectionId, filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the object with the given id.
        /// </summary>
        /// <param name="collectionId">The id of the object to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<Collection> GetAsync(long collectionId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Collection>($"collections/{collectionId}.json", "collection", fields, cancellationToken);
        }
    }
}