using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify ProductImages.
    /// </summary>
    public class ShopifyProductImageService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyProductImageService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyProductImageService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the shop's ProductImages.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="filter">An optional filter that restricts the results.</param>
        /// <returns>The count of all ProductImages for the shop.</returns>
        public virtual async Task<int> CountAsync(long productId, PublishableCountFilter filter = null)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/images/count.json", Method.GET);

            if (filter != null)
            {
                req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));
            }

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
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
        public virtual async Task<IEnumerable<ProductImage>> ListAsync(long productId, long? sinceId = null, string fields = null)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/images.json", Method.GET, "images");

            //Add optional parameters to request
            if (sinceId.HasValue)
            {
                req.AddParameter("since_id", sinceId.Value);
            }

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<List<ProductImage>>(_RestClient, req);
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
            var req = RequestEngine.CreateRequest($"products/{productId}/images/{imageId}.json", Method.GET, "image");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ProductImage>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ProductImage"/>. If the new image has an <see cref="ProductImage.Attachment"/> string, it will be converted to the <see cref="ProductImage.Src"/>.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="image">The new <see cref="ProductImage"/>.</param>
        /// <returns>The new <see cref="ProductImage"/>.</returns>
        public virtual async Task<ProductImage> CreateAsync(long productId, ProductImage image)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/images.json", Method.POST, "image");

            req.AddJsonBody(new { image = image });

            return await RequestEngine.ExecuteRequestAsync<ProductImage>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ProductImage"/>. Id must not be null.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="image">The <see cref="ProductImage"/> to update.</param>
        /// <returns>The updated <see cref="ProductImage"/>.</returns>
        public virtual async Task<ProductImage> UpdateAsync(long productId, ProductImage image)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/images/{image.Id.Value}.json", Method.PUT, "image");

            req.AddJsonBody(new { image });

            return await RequestEngine.ExecuteRequestAsync<ProductImage>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a ProductImage with the given Id.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="imageId">The ProductImage object's Id.</param>
        public virtual async Task DeleteAsync(long productId, long imageId)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/images/{imageId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion
    }
}
