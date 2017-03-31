using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

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
        
        /// <summary>
        /// Gets a count of the metafields for the given entity type and filter options. Leave both resourceType and resourceId null for shop metafields.
        /// </summary>
        /// <param name="resourceType">The type of shopify resource to obtain metafields for. This could be variants, products, orders, customers, custom_collections.</param>
        /// <param name="resourceId">The Id for the resource type.</param>
        /// <param name="filter">The <see cref="MetaFieldFilter"/> used to filter results</param>
        /// <returns>The count of all metafields for the given entity and filter options.</returns>
        public virtual async Task<int> CountAsync(long? resourceId, string resourceType = null, MetaFieldFilter filter = null)
        {
            string reqPath = "metafields/count.json";

            if (! string.IsNullOrEmpty(resourceType) && resourceId.HasValue)
            {
                reqPath = $"{resourceType}/{resourceId.Value}/metafields/count.json";
            }

            var req = PrepareRequest(reqPath);

            if (filter != null)
            {
                req.Url.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets a list of the metafields for a specified resource. Leave both resourceType and resourceId null for shop metafields.
        /// </summary>
        /// <param name="resourceType">The type of shopify resource to obtain metafields for. This could be variants, products, orders, customers, custom_collections.</param>
        /// <param name="resourceId">The Id for the resource type.</param>
        /// <param name="options">The <see cref="MetaFieldFilter"/> used to filter results</param>
        /// <returns></returns>
        public virtual async Task<IEnumerable<MetaField>> ListAsync(long? resourceId, string resourceType = null, MetaFieldFilter options = null)
        {
            string reqPath = "metafields.json";

            if (!string.IsNullOrEmpty(resourceType) && resourceId.HasValue)
            {
                reqPath = $"{resourceType}/{resourceId}/metafields.json";
            }

            var req = PrepareRequest(reqPath);

            if (options != null)
            {
                req.Url.QueryParams.AddRange(options.ToParameters());
            }

            return await ExecuteRequestAsync<List<MetaField>>(req, HttpMethod.Get, rootElement: "metafields");
        }

        /// <summary>
        /// Retrieves the <see cref="MetaField"/> with the given id.
        /// </summary>
        /// <param name="metafieldId">The id of the metafield to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="MetaField"/>.</returns>
        public virtual async Task<MetaField> GetAsync(long metafieldId, string fields = null)
        {
            var req = PrepareRequest($"metafields/{metafieldId}.json");

            if (! string.IsNullOrEmpty(fields))
            {
                req.Url.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<MetaField>(req, HttpMethod.Get, rootElement: "metafield");
        }

        /// <summary>
        /// Creates a new <see cref="MetaField"/> associated with the provided resource and resource id. Leave both resourceType and resourceId null for shop metafields.
        /// </summary>
        /// <param name="metafield">A new <see cref="MetaField"/>. Id should be set to null.</param>
        /// <param name="resourceId">The Id of the resource the metafield will be associated with. This can be variants, products, orders, customers, custom_collections, etc.</param>
        /// <param name="resourceType">The resource type the metaifeld will be associated with. This can be variants, products, orders, customers, custom_collections, etc.</param>
        /// <returns>The new <see cref="MetaField"/>.</returns>
        public virtual async Task<MetaField> CreateAsync(MetaField metafield, long? resourceId, string resourceType = null)
        {
            string reqPath = "metafields.json";

            if (!string.IsNullOrEmpty(resourceType) && resourceId.HasValue)
            {
                reqPath = $"{resourceType}/{resourceId}/metafields.json";
            }

            var req = PrepareRequest(reqPath);
            var content = new JsonContent(new
            {
                metafield = metafield
            });
            
            return await ExecuteRequestAsync<MetaField>(req, HttpMethod.Post, content, "metafield");
        }

        /// <summary>
        /// Updates the given <see cref="MetaField"/>. Id must not be null.
        /// </summary>
        /// <param name="metafield">The <see cref="MetaField"/> to update.</param>
        /// <returns>The updated <see cref="MetaField"/>.</returns>
        public virtual async Task<MetaField> UpdateAsync(MetaField metafield)
        {
            var req = PrepareRequest($"metafields/{metafield.Id.Value}.json");
            var content = new JsonContent(new
            {
                metafield = metafield
            });

            return await ExecuteRequestAsync<MetaField>(req, HttpMethod.Put, content, "metafield");
        }

        /// <summary>
        /// Deletes a metafield with the given Id.
        /// </summary>
        /// <param name="metafieldId">The metafield object's Id.</param>
        public virtual async Task DeleteAsync(long metafieldId)
        {
            var req = PrepareRequest($"metafields/{metafieldId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
