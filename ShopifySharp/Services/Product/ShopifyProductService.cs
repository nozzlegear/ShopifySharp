using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify products.
    /// </summary>
    public class ShopifyProductService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyProductService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyProductService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the shop's products.
        /// </summary>
        /// <returns>The count of all products for the shop.</returns>
        public async Task<int> CountAsync(ShopifyProductFilterOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("products/count.json", Method.GET);

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's products.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ShopifyProduct>> ListAsync(ShopifyProductFilterOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("products.json", Method.GET, "products");

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyProduct>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyProduct"/> with the given id.
        /// </summary>
        /// <param name="productId">The id of the product to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyProduct"/>.</returns>
        public async Task<ShopifyProduct> GetAsync(long productId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"products/{productId}.json", Method.GET, "product");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyProduct>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ShopifyProduct"/> on the store.
        /// </summary>
        /// <param name="product">A new <see cref="ShopifyProduct"/>. Id should be set to null.</param>
        /// <param name="options">Options for creating the product.</param>
        /// <returns>The new <see cref="ShopifyProduct"/>.</returns>
        public async Task<ShopifyProduct> CreateAsync(ShopifyProduct product, ShopifyProductCreateOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("products.json", Method.POST, "product");

            //Build the request body as a dictionary. Necessary because the create options must be added to the 
            //'product' property.
            var productBody = product.ToDictionary();

            if(options != null)
            {
                foreach(var kvp in options.ToDictionary())
                {
                    productBody.Add(kvp);
                }
            }

            var requestBody = new { product = productBody };

            req.AddJsonBody(requestBody);

            return await RequestEngine.ExecuteRequestAsync<ShopifyProduct>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifyProduct"/>. Id must not be null.
        /// </summary>
        /// <param name="product">The <see cref="ShopifyProduct"/> to update.</param>
        /// <returns>The updated <see cref="ShopifyProduct"/>.</returns>
        public async Task<ShopifyProduct> UpdateAsync(ShopifyProduct product)
        {
            IRestRequest req = RequestEngine.CreateRequest($"products/{product.Id.Value}.json", Method.PUT, "product");

            req.AddJsonBody(new { product });

            return await RequestEngine.ExecuteRequestAsync<ShopifyProduct>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a product with the given Id.
        /// </summary>
        /// <param name="productId">The product object's Id.</param>
        public async Task DeleteAsync(long productId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"products/{productId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion
    }
}
