using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for interacting with Shopify Collections.
    /// </summary>
    public class CollectionService : ShopifyService, ICollectionService
    {
        /// <summary>
        /// Creates a new instance of the service.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<ListResult<Product>> ListProductsAsync(long collectionId, ListFilter<Product> filter, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync($"collections/{collectionId}/products.json", "products", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Product>> ListProductsAsync(long collectionId, CollectionProductsListFilter filter = null, CancellationToken cancellationToken = default) =>
            await ListProductsAsync(collectionId, filter?.AsListFilter(), cancellationToken);

        /// <inheritdoc />
        public virtual async Task<Collection> GetAsync(long collectionId, string fields = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<Collection>($"collections/{collectionId}.json", "collection", fields, cancellationToken);
    }
}