using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify metafields.
    /// </summary>
    public class ShopifyMetaFieldService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyMetaFieldService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyMetaFieldService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of the metafields for the given entity type and filter options. Leave both resourceType and resourceId null for shop metafields.
        /// </summary>
        /// <param name="resourceType">The type of shopify resource to obtain metafields for. This could be variants, products, orders, customers, custom_collections.</param>
        /// <param name="resourceId">The Id for the resource type.</param>
        /// <param name="options">The <see cref="ShopifyMetaFieldFilterOptions"/> used to filter results</param>
        /// <returns>The count of all metafields for the given entity and filter options.</returns>
        public async Task<int> CountAsync(long? resourceId, string resourceType = null, ShopifyMetaFieldFilterOptions options = null)
        {
            string reqPath = "metafields/count.json";
            if (resourceType != null && resourceId != null)
            {
                reqPath = $"{resourceType}/{resourceId}/metafields/count.json";
            }
            IRestRequest req = RequestEngine.CreateRequest(reqPath, Method.GET);

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of the metafields for a specified resource. Leave both resourceType and resourceId null for shop metafields.
        /// </summary>
        /// <param name="resourceType">The type of shopify resource to obtain metafields for. This could be variants, products, orders, customers, custom_collections.</param>
        /// <param name="resourceId">The Id for the resource type.</param>
        /// <param name="options">The <see cref="ShopifyMetaFieldFilterOptions"/> used to filter results</param>
        /// <returns></returns>
        public async Task<IEnumerable<ShopifyMetaField>> ListAsync(long? resourceId, string resourceType = null, ShopifyMetaFieldFilterOptions options = null)
        {
            string reqPath = "metafields.json";
            if (resourceType != null && resourceId != null)
            {
                reqPath = $"{resourceType}/{resourceId}/metafields.json";
            }
            IRestRequest req = RequestEngine.CreateRequest(reqPath, Method.GET, "metafields");

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyMetaField>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyMetaField"/> with the given id.
        /// </summary>
        /// <param name="metafieldId">The id of the metafield to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyMetaField"/>.</returns>
        public async Task<ShopifyMetaField> GetAsync(long metafieldId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"metafields/{metafieldId}.json", Method.GET, "metafields");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyMetaField>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ShopifyMetaField"/> associated with the provided resource and resource id. Leave both resourceType and resourceId null for shop metafields.
        /// </summary>
        /// <param name="metafield">A new <see cref="ShopifyMetaField"/>. Id should be set to null.</param>
        /// <param name="resourceId">The Id of the resource the metafield will be associated with. This can be variants, products, orders, customers, custom_collections, etc.</param>
        /// <param name="resourceType">The resource type the metaifeld will be associated with. This can be variants, products, orders, customers, custom_collections, etc.</param>
        /// <returns>The new <see cref="ShopifyMetaField"/>.</returns>
        public async Task<ShopifyMetaField> CreateAsync(ShopifyMetaField metafield, long? resourceId, string resourceType = null)
        {
            string reqPath = "metafields.json";
            if (resourceType != null && resourceId != null)
            {
                reqPath = $"{resourceType}/{resourceId}/metafields.json";
            }
            IRestRequest req = RequestEngine.CreateRequest(reqPath, Method.POST, "metafield");

            //Build the request body
            Dictionary<string, object> body = new Dictionary<string, object>()
            {
                { "metafield", metafield }
            };

            req.AddJsonBody(body);

            return await RequestEngine.ExecuteRequestAsync<ShopifyMetaField>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifyMetaField"/>. Id must not be null.
        /// </summary>
        /// <param name="metafield">The <see cref="ShopifyMetaField"/> to update.</param>
        /// <returns>The updated <see cref="ShopifyMetaField"/>.</returns>
        public async Task<ShopifyMetaField> UpdateAsync(ShopifyMetaField metafield)
        {
            IRestRequest req = RequestEngine.CreateRequest($"metafields/{metafield.Id.Value}.json", Method.PUT, "metafield");

            req.AddJsonBody(new { metafield });

            return await RequestEngine.ExecuteRequestAsync<ShopifyMetaField>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a metafield with the given Id.
        /// </summary>
        /// <param name="metafieldId">The metafield object's Id.</param>
        public async Task DeleteAsync(long metafieldId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"metafields/{metafieldId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion
    }
}
