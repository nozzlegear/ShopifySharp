using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating mapping between custom collections and collections
    /// </summary>
    public class CustomCollectionService : ShopifyService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomCollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of up to 250 custom collections.
        /// </summary>
        public virtual async Task<ListResult<CustomCollection>> ListAsync(ListFilter<CustomCollection> filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("custom_collections.json", "custom_collections", filter, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 custom collections.
        /// </summary>
        public virtual async Task<ListResult<CustomCollection>> ListAsync(CustomCollectionListFilter filter, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Creates a new <see cref="CustomCollection"/> Custom Collection
        /// </summary>
        /// <param name="customCollection">A new <see cref="CustomCollection"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="CustomCollection"/>.</returns>
        public virtual async Task<CustomCollection> CreateAsync(CustomCollection customCollection, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("custom_collections.json");
            var content = new JsonContent(new
            {
                custom_collection = customCollection
            });

            var response = await ExecuteRequestAsync<CustomCollection>(req, HttpMethod.Post, content, "custom_collection", cancellationToken: cancellationToken);
            
            return response.Result;
        }

        public virtual async Task<int> CountAsync(CustomCollectionCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>("custom_collections/count.json", "count", filter, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// Retrieves the <see cref="CustomCollection"/> with the given id.
        /// </summary>
        /// <param name="customCollectionId">The id of the custom collection to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="CustomCollection"/>.</returns>
        public virtual async Task<CustomCollection> GetAsync(long customCollectionId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<CustomCollection>($"custom_collections/{customCollectionId}.json", "custom_collection", fields, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Deletes a custom collection with the given Id.
        /// </summary>
        /// <param name="customCollectionId">The custom collection's Id.</param>
        public virtual async Task DeleteAsync(long customCollectionId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"custom_collections/{customCollectionId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Updates the given <see cref="CustomCollection"/>.
        /// </summary>
        /// <param name="customCollectionId">Id of the object being updated.</param>
        /// <param name="customCollection">The <see cref="CustomCollection"/> to update.</param>
        /// <returns>The updated <see cref="CustomCollection"/>.</returns>
        public virtual async Task<CustomCollection> UpdateAsync(long customCollectionId, CustomCollection customCollection, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"custom_collections/{customCollectionId}.json");
            var content = new JsonContent(new
            {
                custom_collection = customCollection
            });

            var response = await ExecuteRequestAsync<CustomCollection>(req, HttpMethod.Put, content, "custom_collection", cancellationToken: cancellationToken);
            return response.Result;
        }
    }
}
