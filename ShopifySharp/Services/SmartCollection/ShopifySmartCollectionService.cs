using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for getting data and setting data about Shopify smart collection objects
    /// </summary>
    public class ShopifySmartCollectionService : ShopifyService
    {
        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifySmartCollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion Constructor

        #region Public, non-static methods

        /// <summary>
        /// Get a count of all smart collections that contain a given product
        /// </summary>
        /// <returns>The count of all smart collections for the shop.</returns>
        public async Task<int> CountAsync(ShopifySmartCollectionFilterOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("smart_collections/count.json", Method.GET, "count");

            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Get a list of all smart collections 
        /// </summary>
        /// <returns>The <see cref="ShopifySmartCollection"/></returns>
        public async Task<IEnumerable<ShopifySmartCollection>> ListAsync(ShopifySmartCollectionFilterOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("smart_collections.json", Method.GET, "smart_collections");

            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifySmartCollection>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifySmartCollection"/> with the given id.
        /// </summary>
        /// <param name="smartCollecttionId">The id of the collect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifySmartCollection"/>.</returns>
        public async Task<ShopifySmartCollection> GetAsync(long smartCollecttionId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"smart_collections/{smartCollecttionId}.json", Method.GET, "smart_collection");
            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }
            return await RequestEngine.ExecuteRequestAsync<ShopifySmartCollection>(_RestClient, req);
        }

        #endregion Public, non-static methods
    }
}
