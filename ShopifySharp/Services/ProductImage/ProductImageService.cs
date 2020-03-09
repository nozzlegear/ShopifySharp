using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify ProductImages.
    /// </summary>
    public class ProductImageService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductImageService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductImageService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's ProductImages.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<int> CountAsync(long productId, ProductImageCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>($"products/{productId}/images/count.json", "count", filter, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's ProductImages.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<ProductImage>> ListAsync(long productId, ListFilter<ProductImage> filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync($"products/{productId}/images.json", "images", filter, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="ProductImage"/> with the given id.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="imageId">The id of the ProductImage to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="ProductImage"/>.</returns>
        public virtual async Task<ProductImage> GetAsync(long productId, long imageId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<ProductImage>($"products/{productId}/images/{imageId}.json", "image", fields, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Creates a new <see cref="ProductImage"/>. If the new image has an <see cref="ProductImage.Attachment"/> string, it will be converted to the <see cref="ProductImage.Src"/>.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="image">The new <see cref="ProductImage"/>.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="ProductImage"/>.</returns>
        public virtual async Task<ProductImage> CreateAsync(long productId, ProductImage image, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"products/{productId}/images.json");
            var content = new JsonContent(new
            {
                image = image
            });
            var response = await ExecuteRequestAsync<ProductImage>(req, HttpMethod.Post, content, "image", cancellationToken: cancellationToken);

            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="ProductImage"/>.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="productImageId">Id of the object being updated.</param>
        /// <param name="image">The <see cref="ProductImage"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="ProductImage"/>.</returns>
        public virtual async Task<ProductImage> UpdateAsync(long productId, long productImageId, ProductImage image, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"products/{productId}/images/{productImageId}.json");
            var content = new JsonContent(new
            {
                image = image
            });
            var response = await ExecuteRequestAsync<ProductImage>(req, HttpMethod.Put, content, "image", cancellationToken: cancellationToken);

            return response.Result;
        }

        /// <summary>
        /// Deletes a ProductImage with the given Id.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="imageId">The ProductImage object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long productId, long imageId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"products/{productId}/images/{imageId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken: cancellationToken);
        }
    }
}
