using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for interacting with Shopify product collection that a merchant has made available to your sales channel
    /// </summary>
    public class CollectionListingService: ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CollectionListingService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CollectionListingService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl,
            shopAccessToken)
        { }

        /// <summary>
        /// Retrieve collection listings that are published to your app.
        /// </summary>
        public virtual Task<ListResult<CollectionListing>> ListAsync(ListFilter<CollectionListing> filter = default, CancellationToken cancellationToken = default)
        {
            return ExecuteGetListAsync("collection_listings.json", "collection_listings", filter, cancellationToken);
        }

        /// <summary>
        /// Retrieves the specific <see cref="CollectionListing"/> that is published to your app
        /// </summary>
        /// <param name="collectionId">The id of the collection to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="ProductListing"/>.</returns>
        public virtual Task<CollectionListing> GetAsync(long collectionId,
            CancellationToken cancellationToken = default)
        {
            return ExecuteGetAsync<CollectionListing>($"collection_listings/{collectionId}.json", "collection_listing",
                cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Retrieve product_ids that are published to a collection_id. Maximum 1,000 results per page
        /// </summary>
        public virtual Task<ListResult<long>> ListIdsAsync(long collectionId, ListFilter<long> filter = default, CancellationToken cancellationToken = default)
        {
            return ExecuteGetListAsync($"collection_listings/{collectionId}/product_ids.json", "product_ids", filter,
                cancellationToken);
        }
    }
}
