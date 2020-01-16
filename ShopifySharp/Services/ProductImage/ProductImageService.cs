using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

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
        /// <param name="filter">An optional filter that restricts the results.</param>
        /// <returns>The count of all ProductImages for the shop.</returns>
        public virtual async Task<int> CountAsync(long productId, PublishableCountFilter filter = null)
        {
            var req = PrepareRequest($"products/{productId}/images/count.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's ProductImages.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="fields">
        /// An optional, comma-separated list of fields to include in the response.
        /// </param>
        /// <param name="sinceId">
        /// Restricts results to after the specified id.
        /// </param>
        /// <returns>The list of <see cref="ProductImage"/>.</returns>
        /// <remarks>
        /// Unlike most list commands, this one only accepts the since_id and fields filters.
        /// </remarks>
        public virtual async Task<IEnumerable<ProductImage>> ListAsync(IListFilter filter)
        {
            throw new Exception("not yet implemented");
            var req = PrepareRequest($"products/{productId}/images.json");

            if (sinceId.HasValue)
            {
                req.QueryParams.Add("since_id", sinceId.Value);
            }

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<List<ProductImage>>(req, HttpMethod.Get, rootElement: "images");
        }

        /// <summary>
        /// Retrieves the <see cref="ProductImage"/> with the given id.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="imageId">The id of the ProductImage to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ProductImage"/>.</returns>
        public virtual async Task<ProductImage> GetAsync(long productId, long imageId, string fields = null)
        {
            var req = PrepareRequest($"products/{productId}/images/{imageId}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<ProductImage>(req, HttpMethod.Get, rootElement: "image");
        }

        /// <summary>
        /// Creates a new <see cref="ProductImage"/>. If the new image has an <see cref="ProductImage.Attachment"/> string, it will be converted to the <see cref="ProductImage.Src"/>.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="image">The new <see cref="ProductImage"/>.</param>
        /// <returns>The new <see cref="ProductImage"/>.</returns>
        public virtual async Task<ProductImage> CreateAsync(long productId, ProductImage image)
        {
            var req = PrepareRequest($"products/{productId}/images.json");
            var content = new JsonContent(new
            {
                image = image
            });

            return await ExecuteRequestAsync<ProductImage>(req, HttpMethod.Post, content, "image");
        }

        /// <summary>
        /// Updates the given <see cref="ProductImage"/>.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="productImageId">Id of the object being updated.</param>
        /// <param name="image">The <see cref="ProductImage"/> to update.</param>
        /// <returns>The updated <see cref="ProductImage"/>.</returns>
        public virtual async Task<ProductImage> UpdateAsync(long productId, long productImageId, ProductImage image)
        {
            var req = PrepareRequest($"products/{productId}/images/{productImageId}.json");
            var content = new JsonContent(new
            {
                image = image
            });

            return await ExecuteRequestAsync<ProductImage>(req, HttpMethod.Put, content, "image");
        }

        /// <summary>
        /// Deletes a ProductImage with the given Id.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="imageId">The ProductImage object's Id.</param>
        public virtual async Task DeleteAsync(long productId, long imageId)
        {
            var req = PrepareRequest($"products/{productId}/images/{imageId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
