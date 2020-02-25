using System;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's smart collections.
    /// </summary>
    public class SmartCollectionService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="SmartCollectionService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public SmartCollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        private async Task<int> _CountAsync(ICountFilter filter = null)
        {
            var req = PrepareRequest("smart_collections/count.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");

            return response.Result;
        }

        /// <summary>
        /// Gets a count of all smart collections on the store.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        public virtual async Task<int> CountAsync(ICountFilter filter = null)
        {
            return await _CountAsync(filter);
        }

        /// <summary>
        /// Gets a count of all smart collections on the store.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        public virtual async Task<int> CountAsync(SmartCollectionCountFilter filter = null)
        {
            return await _CountAsync(filter);
        }
        
        /// <summary>
        /// Gets a list of up to 250 smart collections.
        /// </summary>
        public virtual async Task<IListResult<SmartCollection>> ListAsync(IListFilter filter)
        {
            var req = PrepareRequest($"smart_collections.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<SmartCollection>>(req, HttpMethod.Get, rootElement: "smart_collections");

            return ParseLinkHeaderToListResult(response);
        }

        /// <summary>
        /// Gets a list of up to 250 smart collections.
        /// </summary>
        public virtual async Task<IListResult<SmartCollection>> ListAsync(SmartCollectionListFilter filter)
        {
            return await ListAsync((IListFilter) filter);
        }

        /// <summary>
        /// Retrieves the <see cref="SmartCollection"/> with the given id.
        /// </summary>
        /// <param name="collectionId">The id of the smart collection to retrieve.</param>
        public virtual async Task<SmartCollection> GetAsync(long collectionId)
        {
            var req = PrepareRequest($"smart_collections/{collectionId}.json");
            var response = await ExecuteRequestAsync<SmartCollection>(req, HttpMethod.Get, rootElement: "smart_collection");

            return response.Result;
        }

        /// <summary>
        /// Creates a new <see cref="SmartCollection"/>.
        /// </summary>
        /// <param name="collection">A new <see cref="SmartCollection"/>. Id should be set to null.</param>
        public virtual async Task<SmartCollection> CreateAsync(SmartCollection collection, bool published = true)
        {
            var req = PrepareRequest($"smart_collections.json");
            var body = collection.ToDictionary();

            body.Add("published", published);

            var content = new JsonContent(new
            {
                smart_collection = body
            });
            var response = await ExecuteRequestAsync<SmartCollection>(req, HttpMethod.Post, content, "smart_collection");

            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="SmartCollection"/>.
        /// </summary>
        /// <param name="smartCollectionId">Id of the object being updated.</param>
        /// <param name="collection">The smart collection to update.</param>
        public virtual async Task<SmartCollection> UpdateAsync(long smartCollectionId, SmartCollection collection)
        {
            var req = PrepareRequest($"smart_collections/{smartCollectionId}.json");
            var content = new JsonContent(new
            {
                smart_collection = collection
            });
            var response = await ExecuteRequestAsync<SmartCollection>(req, HttpMethod.Put, content, "smart_collection");

            return response.Result;
        }

        /// <summary>
        /// Publishes an unpublished smart collection.
        /// </summary>
        /// <param name="smartCollectionId">The collection's id.</param>
        public virtual async Task<SmartCollection> PublishAsync(long smartCollectionId)
        {
            var req = PrepareRequest($"smart_collections/{smartCollectionId}.json");
            var body = new Dictionary<string, object>()
            {
                { "id", smartCollectionId },
                { "published", true }
            };
            var content = new JsonContent(new 
            {
                smart_collection = body
            });
            var response = await ExecuteRequestAsync<SmartCollection>(req, HttpMethod.Put, content, "smart_collection");

            return response.Result;
        }

        /// <summary>
        /// Publishes an unpublished smart collection.
        /// </summary>
        /// <param name="smartCollectionId">The collection's id.</param>
        public virtual async Task<SmartCollection> UnpublishAsync(long smartCollectionId)
        {
            var req = PrepareRequest($"smart_collections/{smartCollectionId}.json");
            var body = new Dictionary<string, object>()
            {
                { "id", smartCollectionId },
                { "published", false }
            };
            var content = new JsonContent(new 
            {
                smart_collection = body
            });
            var response = await ExecuteRequestAsync<SmartCollection>(req, HttpMethod.Put, content, "smart_collection");

            return response.Result;
        }

        /// <summary>
        /// Updates the order of products when a SmartCollection's sort-by method is set to "manual".
        /// </summary>
        /// <param name="smartCollectionId">Id of the object being updated.</param>
        /// <param name="sortOrder">The order in which products in the smart collection appear. Note that specifying productIds parameter will have no effect unless the sort order is "manual"</param>
        /// <param name="productIds">An array of product ids sorted in the order you want them to appear in.</param>
        public virtual async Task UpdateProductOrderAsync(long smartCollectionId, string sortOrder = null, params long[] productIds)
        {
            var req = PrepareRequest($"smart_collections/{smartCollectionId}/order.json");
            var content = new JsonContent(new
            {
                sort_order = sortOrder,
                products = productIds
            });
            await ExecuteRequestAsync(req, HttpMethod.Put, content);
        }

        /// <summary>
        /// Deletes a smart collection with the given Id.
        /// </summary>
        /// <param name="collectionId">The smart collection's id.</param>
        public virtual async Task DeleteAsync(long collectionId)
        {
            var req = PrepareRequest($"smart_collections/{collectionId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
