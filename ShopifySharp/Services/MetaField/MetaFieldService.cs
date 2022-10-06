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
    /// A service for manipulating Shopify metafields.
    /// </summary>
    public class MetaFieldService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="MetaFieldService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public MetaFieldService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        private async Task<int> _CountAsync(string path, CancellationToken cancellationToken)
        {
            return await ExecuteGetAsync<int>(path, "count", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets a count of the metafields on the shop itself.
        /// </summary>
        /// <remarks>
        /// According to Shopify's documentation, this endpoint does not currently support any additional filter parameters for counting.
        /// </remarks>
        public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            return await _CountAsync("metafields/count.json", cancellationToken);
        }

        /// <summary>
        /// Gets a count of the metafields for the given entity type and filter options.
        /// </summary>
        /// <param name="resourceType">The type of shopify resource to obtain metafields for. This could be variants, products, orders, customers, custom_collections.</param>
        /// <param name="resourceId">The Id for the resource type.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <remarks>
        /// According to Shopify's documentation, this endpoint does not currently support any additional filter parameters for counting.
        /// </remarks>
        public virtual async Task<int> CountAsync(long resourceId, string resourceType, CancellationToken cancellationToken = default)
        {
            return await _CountAsync($"{resourceType.ToLower()}/{resourceId}/metafields/count.json", cancellationToken);
        }

        /// <summary>
        /// Gets a count of the metafields for the given entity type and filter options.
        /// </summary>
        /// <param name="resourceType">The type of shopify resource to obtain metafields for. This could be variants, products, orders, customers, custom_collections.</param>
        /// <param name="resourceId">The Id for the resource type.</param>
        /// <param name="parentResourceType">The type of shopify parent resource to obtain metafields for. This could be blogs, products.</param>
        /// <param name="parentResourceId">The Id for the resource type.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <remarks>
        /// According to Shopify's documentation, this endpoint does not currently support any additional filter parameters for counting.
        /// </remarks>
        public virtual async Task<int> CountAsync(long resourceId, string resourceType, long parentResourceId, string parentResourceType, CancellationToken cancellationToken = default)
        {
            return await _CountAsync($"{parentResourceType.ToLower()}/{parentResourceId}/{resourceType.ToLower()}/{resourceId}/metafields/count.json", cancellationToken);
        }

        private async Task<ListResult<MetaField>> _ListAsync(string path, ListFilter<MetaField> filter,
            CancellationToken cancellationToken)
        {
            return await ExecuteGetListAsync(path, "metafields", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of the metafields for the shop itself.
        /// </summary>
        /// <param name="filter">Options to filter the results.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<MetaField>> ListAsync(ListFilter<MetaField> filter, CancellationToken cancellationToken = default)
        {
            return await _ListAsync("metafields.json", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of the metafields for the given entity type and filter options.
        /// </summary>
        /// <param name="resourceType">The type of shopify resource to obtain metafields for. This could be variants, products, orders, customers, custom_collections.</param>
        /// <param name="resourceId">The Id for the resource type.</param>
        /// <param name="filter">Options to filter the results.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<MetaField>> ListAsync(long resourceId, string resourceType, ListFilter<MetaField> filter, CancellationToken cancellationToken = default)
        {
            return await _ListAsync($"{resourceType.ToLower()}/{resourceId}/metafields.json", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of the metafields for the given entity type and filter options.
        /// </summary>
        /// <param name="parentResourceType">The type of shopify parentresource to obtain metafields for. This could be blogs, products.</param>
        /// <param name="parentResourceId">The Id for the parent resource type.</param>
        /// <param name="resourceType">The type of shopify resource to obtain metafields for. This could be variants, products, orders, customers, custom_collections.</param>
        /// <param name="resourceId">The Id for the resource type.</param>
        /// <param name="filter">Options to filter the results.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<MetaField>> ListAsync(long resourceId, string resourceType, long parentResourceId, string parentResourceType, ListFilter<MetaField> filter, CancellationToken cancellationToken = default)
        {
            return await _ListAsync($"{parentResourceType.ToLower()}/{parentResourceId}/{resourceType.ToLower()}/{resourceId}/metafields.json", filter, cancellationToken);
        }



        /// <summary>
        /// Gets a list of the metafields for the shop itself.
        /// </summary>
        /// <param name="filter">Options to filter the results.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<MetaField>> ListAsync(MetaFieldFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await _ListAsync("metafields.json", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of the metafields for the given entity type and filter options.
        /// </summary>
        /// <param name="resourceType">The type of shopify resource to obtain metafields for. This could be variants, products, orders, customers, custom_collections.</param>
        /// <param name="resourceId">The Id for the resource type.</param>
        /// <param name="filter">Options to filter the results.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<MetaField>> ListAsync(long resourceId, string resourceType, MetaFieldFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await _ListAsync($"{resourceType.ToLower()}/{resourceId}/metafields.json", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of the metafields for the given entity type and filter options.
        /// </summary>
        /// <param name="parentResourceType">The type of shopify parentresource to obtain metafields for. This could be blogs, products.</param>
        /// <param name="parentResourceId">The Id for the parent resource type.</param>
        /// <param name="resourceType">The type of shopify resource to obtain metafields for. This could be variants, products, orders, customers, custom_collections.</param>
        /// <param name="resourceId">The Id for the resource type.</param>
        /// <param name="filter">Options to filter the results.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<MetaField>> ListAsync(long resourceId, string resourceType, long parentResourceId, string parentResourceType, MetaFieldFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await _ListAsync($"{parentResourceType.ToLower()}/{parentResourceId}/{resourceType.ToLower()}/{resourceId}/metafields.json", filter, cancellationToken);
        }

        /// <summary>
        /// Retrieves the metafield with the given id.
        /// </summary>
        /// <param name="metafieldId">The id of the metafield to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<MetaField> GetAsync(long metafieldId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<MetaField>($"metafields/{metafieldId}.json", "metafield", fields, cancellationToken);
        }

        /// <summary>
        /// Creates a new metafield on the shop itself.
        /// </summary>
        /// <param name="metafield">A new metafield. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<MetaField> CreateAsync(MetaField metafield, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("metafields.json");
            var content = new JsonContent(new
            {
                metafield = metafield
            });

            var response = await ExecuteRequestAsync<MetaField>(req, HttpMethod.Post, cancellationToken, content, "metafield");
            return response.Result;
        }

        /// <summary>
        /// Creates a new metafield on the given entity.
        /// </summary>
        /// <param name="metafield">A new metafield. Id should be set to null.</param>
        /// <param name="resourceId">The Id of the resource the metafield will be associated with. This can be variants, products, orders, customers, custom_collections, etc.</param>
        /// <param name="resourceType">The resource type the metaifeld will be associated with. This can be variants, products, orders, customers, custom_collections, etc.</param>
        /// <param name="parentResourceId">The Id of the parent resource the metafield will be associated with. This can be blogs, products.</param>
        /// <param name="parentResourceType">The resource type the metaifeld will be associated with. This can be articles, variants.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<MetaField> CreateAsync(MetaField metafield, long resourceId, string resourceType, long parentResourceId, string parentResourceType, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"{parentResourceType.ToLower()}/{parentResourceId}/{resourceType.ToLower()}/{resourceId}/metafields.json");
            var content = new JsonContent(new
            {
                metafield = metafield
            });

            var response = await ExecuteRequestAsync<MetaField>(req, HttpMethod.Post, cancellationToken, content, "metafield");
            return response.Result;
        }

        /// <summary>
        /// Creates a new metafield on the given entity.
        /// </summary>
        /// <param name="metafield">A new metafield. Id should be set to null.</param>
        /// <param name="resourceId">The Id of the resource the metafield will be associated with. This can be variants, products, orders, customers, custom_collections, etc.</param>
        /// <param name="resourceType">The resource type the metaifeld will be associated with. This can be variants, products, orders, customers, custom_collections, etc.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<MetaField> CreateAsync(MetaField metafield, long resourceId, string resourceType, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"{resourceType.ToLower()}/{resourceId}/metafields.json");
            var content = new JsonContent(new
            {
                metafield = metafield
            });

            var response = await ExecuteRequestAsync<MetaField>(req, HttpMethod.Post, cancellationToken, content, "metafield");
            return response.Result;
        }

        /// <summary>
        /// Updates the given metafield.
        /// </summary>
        /// <param name="metafieldId">Id of the object being updated.</param>
        /// <param name="metafield">The metafield to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<MetaField> UpdateAsync(long metafieldId, MetaField metafield, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"metafields/{metafieldId}.json");
            var content = new JsonContent(new
            {
                metafield = metafield
            });
            var response = await ExecuteRequestAsync<MetaField>(req, HttpMethod.Put, cancellationToken, content, "metafield");
            
            return response.Result;
        }

        /// <summary>
        /// Deletes a metafield with the given Id.
        /// </summary>
        /// <param name="metafieldId">The metafield object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long metafieldId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"metafields/{metafieldId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}
