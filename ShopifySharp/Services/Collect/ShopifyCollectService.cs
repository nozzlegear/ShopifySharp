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
    /// A service for manipulating mapping between shopify products and collections
    /// </summary>
    public class ShopifyCollectService : ShopifyService
    {
        #region Constructor
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyCustomerService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyCollectService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion Constructor

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the collects (product-collection mappings).
        /// </summary>
        /// <returns>The count of all collects for the shop.</returns>
        public async Task<int> CountAsync(ShopifyCollectFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("collects/count.json", Method.GET, "count");

            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's collects.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ShopifyCollect>> ListAsync(ShopifyCollectFilter options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("collects.json", Method.GET, "collects");

            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyCollect>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyCollect"/> with the given id.
        /// </summary>
        /// <param name="collectId">The id of the collect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyCollect"/>.</returns>
        public async Task<ShopifyCollect> GetAsync(long collectId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"collects/{collectId}.json", Method.GET, "collect");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyCollect>(_RestClient, req);
        }


        /// <summary>
        /// Creates a new <see cref="ShopifyCollect"/> on the store. Map product to collection
        /// </summary>
        /// <param name="collect">A new <see cref="ShopifyCollect"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ShopifyCollect"/>.</returns>
        public async Task<ShopifyCollect> CreateAsync(ShopifyCollect collect)
        {
            IRestRequest req = RequestEngine.CreateRequest("collects.json", RestSharp.Method.POST, "collect");

            Dictionary<string, object> body = new Dictionary<string, object>()
            {
                { "collect", collect }
            };

            req.AddJsonBody(body);

            return await RequestEngine.ExecuteRequestAsync<ShopifyCollect>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a collect with the given Id.
        /// </summary>
        /// <param name="collectId">The product object's Id.</param>
        public async Task DeleteAsync(long collectId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"collects/{collectId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion Public, non-static methods
    }
}
