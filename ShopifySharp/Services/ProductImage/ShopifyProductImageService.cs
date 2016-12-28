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
        public virtual async Task<int> CountAsync(long productId, ShopifyPublishableCountFilter filter = null)
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
        /// <returns>The list of <see cref="ShopifyProductImage"/>.</returns>
        /// <remarks>
        /// Unlike most list commands, this one only accepts the since_id and fields filters.
        /// </remarks>
        public virtual async Task<IEnumerable<ShopifyProductImage>> ListAsync(long productId, long? sinceId = null, string fields = null)
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

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyProductImage>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyProductImage"/> with the given id.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="imageId">The id of the ProductImage to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyProductImage"/>.</returns>
        public virtual async Task<ShopifyProductImage> GetAsync(long productId, long imageId, string fields = null)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/images/{imageId}.json", Method.GET, "image");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyProductImage>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ShopifyProductImage"/>. If the new image has an <see cref="ShopifyProductImage.Attachment"/> string, it will be converted to the <see cref="ShopifyProductImage.Src"/>.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="image">The new <see cref="ShopifyProductImage"/>.</param>
        /// <returns>The new <see cref="ShopifyProductImage"/>.</returns>
        public virtual async Task<ShopifyProductImage> CreateAsync(long productId, ShopifyProductImage image)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/images.json", Method.POST, "image");

            req.AddJsonBody(new { image = image });

            return await RequestEngine.ExecuteRequestAsync<ShopifyProductImage>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifyProductImage"/>. Id must not be null.
        /// </summary>
        /// <param name="productId">The id of the product that counted images belong to.</param>
        /// <param name="image">The <see cref="ShopifyProductImage"/> to update.</param>
        /// <returns>The updated <see cref="ShopifyProductImage"/>.</returns>
        public virtual async Task<ShopifyProductImage> UpdateAsync(long productId, ShopifyProductImage image)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/images/{image.Id.Value}.json", Method.PUT, "image");

            req.AddJsonBody(new { image });

            return await RequestEngine.ExecuteRequestAsync<ShopifyProductImage>(_RestClient, req);
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
