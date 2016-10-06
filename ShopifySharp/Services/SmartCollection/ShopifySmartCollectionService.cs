using RestSharp;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's smart collections.
    /// </summary>
    public class ShopifySmartCollectionService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyOrderRiskService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifySmartCollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all smart collections on the store.
        /// </summary>
        /// <param name="filterOptions">Options for filtering the count.</param>
        public async Task<int> CountAsync(ShopifySmartCollectionFilter filterOptions = null)
        {
            var req = RequestEngine.CreateRequest("smart_collections/count.json", Method.GET, "count");

            if (filterOptions != null)
            {
                req.Parameters.AddRange(filterOptions.ToParameters(ParameterType.GetOrPost));
            }

            return await RequestEngine.ExecuteRequestAsync<int>(_RestClient, req);
        }

        /// <summary>
        /// Gets a list of up to 250 smart collections.
        /// </summary>
        /// <param name="filterOptions">Options for filtering the result.</param>
        public async Task<IEnumerable<ShopifySmartCollection>> ListAsync(ShopifySmartCollectionFilter filterOptions = null)
        {
            var req = RequestEngine.CreateRequest($"smart_collections.json", Method.GET, "smart_collections");

            if (filterOptions != null)
            {
                req.Parameters.AddRange(filterOptions.ToParameters(ParameterType.GetOrPost));
            }
            
            return await RequestEngine.ExecuteRequestAsync<List<ShopifySmartCollection>>(_RestClient, req);
        }
        
        /// <summary>
        /// Retrieves the <see cref="ShopifySmartCollection"/> with the given id.
        /// </summary>
        /// <param name="collectionId">The id of the smart collection to retrieve.</param>
        public async Task<ShopifySmartCollection> GetAsync(long collectionId)
        {
            var req = RequestEngine.CreateRequest($"smart_collections/{collectionId}.json", Method.GET, "smart_collection");
            
            return await RequestEngine.ExecuteRequestAsync<ShopifySmartCollection>(_RestClient, req);
        }
        
        /// <summary>
        /// Creates a new <see cref="ShopifySmartCollection"/>.
        /// </summary>
        /// <param name="collection">A new <see cref="ShopifySmartCollection"/>. Id should be set to null.</param>
        public async Task<ShopifySmartCollection> CreateAsync(ShopifySmartCollection collection)
        {
            var req = RequestEngine.CreateRequest($"smart_collections.json", Method.POST, "smart_collection");

            req.AddJsonBody(new { smart_collection = collection });
            
            return await RequestEngine.ExecuteRequestAsync<ShopifySmartCollection>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifySmartCollection"/>. Id must not be null.
        /// </summary>
        /// <param name="collection">The risk to update.</param>
        public async Task<ShopifySmartCollection> UpdateAsync(ShopifySmartCollection collection)
        {
            var req = RequestEngine.CreateRequest($"smart_collections/{collection.Id.Value}.json", Method.PUT, "smart_collection");

            req.AddJsonBody(new { smart_collection = collection });

            return await RequestEngine.ExecuteRequestAsync<ShopifySmartCollection>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a smart collection with the given Id.
        /// </summary>
        /// <param name="collectionId">The smart collection's id.</param>
        public async Task DeleteAsync(long collectionId)
        {
            var req = RequestEngine.CreateRequest($"smart_collections/{collectionId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }
    }
}
