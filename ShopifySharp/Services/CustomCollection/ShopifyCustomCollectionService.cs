using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for getting data and setting data about Shopify Custom collection objects
    /// </summary>
    public class ShopifyCustomCollectionService : ShopifyService
    {
        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyCustomCollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion Constructor

        #region Public, non-static methods

        /// <summary>
        /// Get a count of all Custom collections that contain a given product
        /// </summary>
        /// <returns>The count of all Custom collections for the shop.</returns>
        public async Task<int> CountAsync(ShopifyCustomCollectionFilterOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("custom_collections/count.json", Method.GET, "count");

            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Get a list of all Custom collections 
        /// </summary>
        /// <returns>The <see cref="ShopifyCustomCollection"/></returns>
        public async Task<IEnumerable<ShopifyCustomCollection>> ListAsync(ShopifyCustomCollectionFilterOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("custom_collections.json", Method.GET, "custom_collections");

            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyCustomCollection>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyCustomCollection"/> with the given id.
        /// </summary>
        /// <param name="CustomCollecttionId">The id of the collect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyCustomCollection"/>.</returns>
        public async Task<ShopifyCustomCollection> GetAsync(long CustomCollecttionId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"custom_collections/{CustomCollecttionId}.json", Method.GET, "custom_collection");
            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }
            return await RequestEngine.ExecuteRequestAsync<ShopifyCustomCollection>(_RestClient, req);
        }

        #endregion Public, non-static methods
    }
}
