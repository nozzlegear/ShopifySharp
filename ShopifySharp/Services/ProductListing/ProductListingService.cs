using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    ///  A service for manipulating Shopify Product which is available to your sales channel
    /// </summary>
    public class ProductListingService: ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductListingService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductListingService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken)
        { }

        /// <summary>
        /// Gets a list of up to 1000 default 50 of the shop's product listings.
        /// </summary>
        public virtual Task<ListResult<ProductListing>> ListAsync(ListFilter<ProductListing> filter, CancellationToken cancellationToken = default)
        {
            return ExecuteGetListAsync("product_listings.json", "product_listings", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 1000 default 50 of the shop's product listings.
        /// </summary>
        public virtual Task<ListResult<ProductListing>> ListAsync(ProductLististingListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the specific <see cref="ProductListing"/> that is published to your app
        /// </summary>
        /// <param name="productId">The id of the product to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="ProductListing"/>.</returns>
        public virtual Task<ProductListing> GetAsync(long productId,
            CancellationToken cancellationToken = default)
        {
            return ExecuteGetAsync<ProductListing>($"product_listings/{productId}.json", "product_listing",
                cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Retrieve a count of products that are published to your app
        /// </summary>
        /// <returns>The count of all products for the shop.</returns>
        public virtual Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            return ExecuteGetAsync<int>("product_listings/count.json", "count", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Retrieve product_ids that are published to your app. Maximum 1,000 results per page
        /// </summary>
        public virtual Task<ListResult<long>> ListIdsAsync(CancellationToken cancellationToken = default)
        {
            return ExecuteGetListAsync("product_listings/product_ids.json", "product_ids", ListFilter<long>.Empty,
                cancellationToken);
        }

        /// <summary>
        /// Create a product listing to publish a product to your app <see cref="ProductListing"/>.
        /// </summary>
        /// <param name="productId">Id of listing product</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="ProductListing"/>.</returns>
        public virtual async Task<ProductListing> CreateAsync(long productId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"product_listings/{productId}.json");
            var content = new JsonContent(new
            {
                product_listing = new { product_id = productId }
            });
            var response = await ExecuteRequestAsync<ProductListing>(req, HttpMethod.Put, cancellationToken, content, "product_listing");

            return response.Result;
        }

        /// <summary>
        /// Delete a product listing to unpublish a product from your app
        /// </summary>
        /// <param name="productId">The product object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long productId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"product_listings/{productId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}
