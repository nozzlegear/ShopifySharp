using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating mapping between custom collections and collections
    /// </summary>
    public class CustomCollectionService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CustomCollectionService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomCollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }        
        
        /// <summary>
        /// default: 50
        /// Gets a list of up to 250 custom collections for the corresponding productId
        /// </summary>
        /// <param name="filter">The <see cref="CustomCollection"/>. used to filter results</param>
        /// <returns></returns>
        public virtual async Task<IEnumerable<CustomCollection>> ListAsync(CustomCollectionFilter filter = null)
        {
            var req = PrepareRequest("custom_collections.json");

            //Add optional parameters to request
            if (filter != null)
            {
                req.Url.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<List<CustomCollection>>(req, HttpMethod.Get, rootElement: "custom_collections");
        }

        /// <summary>
        /// Creates a new <see cref="CustomCollection"/> Custom Collection
        /// </summary>
        /// <param name="customCollection">A new <see cref="CustomCollection"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="CustomCollection"/>.</returns>
        public virtual async Task<CustomCollection> CreateAsync(CustomCollection customCollection)
        {
            var req = PrepareRequest("custom_collections.json");
            var content = new JsonContent(new
            {
                custom_collection = customCollection
            });

            return await ExecuteRequestAsync<CustomCollection>(req, HttpMethod.Post, content, "custom_collection");
        }

        /// <summary>
        /// Gets a count of all of the custom collections
        /// </summary>
        /// <returns>The count of all collects for the shop.</returns>
        public virtual async Task<int> CountAsync(CustomCollectionFilter options = null)
        {
            var req = PrepareRequest("custom_collections/count.json");

            if (options != null)
            {
                req.Url.QueryParams.AddRange(options.ToParameters());
            }

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Retrieves the <see cref="CustomCollection"/> with the given id.
        /// </summary>
        /// <param name="customCollectionId">The id of the custom collection to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="CustomCollection"/>.</returns>
        public virtual async Task<CustomCollection> GetAsync(long customCollectionId, string fields = null)
        {
            var req = PrepareRequest($"custom_collections/{customCollectionId}.json");

            if (! string.IsNullOrEmpty(fields))
            {
                req.Url.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<CustomCollection>(req, HttpMethod.Get, rootElement: "custom_collection");
        }

        /// <summary>
        /// Deletes a custom collection with the given Id.
        /// </summary>
        /// <param name="customCollectionId">The custom collection's Id.</param>
        public virtual async Task DeleteAsync(long customCollectionId)
        {
            var req = PrepareRequest($"custom_collections/{customCollectionId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }

        /// <summary>
        /// Updates the given <see cref="CustomCollection"/>. Id must not be null.
        /// </summary>
        /// <param name="customCollection">The <see cref="CustomCollection"/> to update.</param>
        /// <returns>The updated <see cref="CustomCollection"/>.</returns>
        public virtual async Task<CustomCollection> UpdateAsync(CustomCollection customCollection)
        {
            var req = PrepareRequest($"custom_collections/{customCollection.Id.Value}.json");
            var content = new JsonContent(new
            {
                custom_collection = customCollection
            });

            return await ExecuteRequestAsync<CustomCollection>(req, HttpMethod.Put, content, "custom_collection");
        }
    }
}
