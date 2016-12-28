using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating mapping between custom collections and collections
    /// </summary>
    public class ShopifyCustomCollectionService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyCustomCollectionService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyCustomCollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }        
        
        /// <summary>
        /// default: 50
        /// Gets a list of up to 250 custom collections for the corresponding productId
        /// </summary>
        /// <param name="filter">The <see cref="ShopifyCustomCollection"/>. used to filter results</param>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ShopifyCustomCollection>> ListAsync(ShopifyCustomCollectionFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("/custom_collections.json", Method.GET, "custom_collections");

            //Add optional parameters to request
            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyCustomCollection>>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ShopifyCustomCollection"/> Custom Collection
        /// </summary>
        /// <param name="customCollection">A new <see cref="ShopifyCustomCollection"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ShopifyCustomCollection"/>.</returns>
        public virtual async Task<ShopifyCustomCollection> CreateAsync(ShopifyCustomCollection customCollection)
        {
            string reqPath = "custom_collections.json";

            IRestRequest req = RequestEngine.CreateRequest(reqPath, Method.POST, "custom_collection");

            //Build the request body
            Dictionary<string, object> body = new Dictionary<string, object>()
            {
                { "custom_collection", customCollection }
            };

            req.AddJsonBody(body);

            return await RequestEngine.ExecuteRequestAsync<ShopifyCustomCollection>(_RestClient, req);
        }

        /// <summary>
        /// Gets a count of all of the custom collections
        /// </summary>
        /// <returns>The count of all collects for the shop.</returns>
        public virtual async Task<int> CountAsync(ShopifyCustomCollectionFilter options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("custom_collections/count.json", Method.GET, "count");

            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyCustomCollection"/> with the given id.
        /// </summary>
        /// <param name="customCollectionId">The id of the custom collection to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyCustomCollection"/>.</returns>
        public virtual async Task<ShopifyCustomCollection> GetAsync(long customCollectionId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"custom_collections/{customCollectionId}.json", Method.GET, "custom_collection");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyCustomCollection>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a custom collection with the given Id.
        /// </summary>
        /// <param name="customCollectionId">The custom collection's Id.</param>
        public virtual async Task DeleteAsync(long customCollectionId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"custom_collections/{customCollectionId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifyCustomCollection"/>. Id must not be null.
        /// </summary>
        /// <param name="customCollection">The <see cref="ShopifyCustomCollection"/> to update.</param>
        /// <returns>The updated <see cref="ShopifyCustomCollection"/>.</returns>
        public virtual async Task<ShopifyCustomCollection> UpdateAsync(ShopifyCustomCollection customCollection)
        {
            IRestRequest req = RequestEngine.CreateRequest($"custom_collections/{customCollection.Id.Value}.json", Method.PUT, "custom_collection");

            //Build the request body
            Dictionary<string, object> body = new Dictionary<string, object>()
            {
                { "custom_collection", customCollection }
            };

            req.AddJsonBody(body);

            return await RequestEngine.ExecuteRequestAsync<ShopifyCustomCollection>(_RestClient, req);
        }
    }
}
