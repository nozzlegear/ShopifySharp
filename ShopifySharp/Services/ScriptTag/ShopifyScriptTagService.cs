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
    /// A service for manipulating Shopify's ScriptTag API.
    /// </summary>
    public class ShopifyScriptTagService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyScriptTagService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyScriptTagService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the shop's <see cref="ShopifyScriptTag"/>s.
        /// </summary>
        /// <param name="src">Optionally filters the count to only those <see cref="ShopifyScriptTag"/>s with the 
        /// given <see cref="ShopifyScriptTag.Src"/> value.</param>
        /// <returns>The count.</returns>
        public async Task<int> CountAsync(string src = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("script_tags/count.json", Method.GET);

            //Filter the count where necessary.
            if (string.IsNullOrEmpty(src) == false) req.AddQueryParameter("src", src);

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's <see cref="ShopifyScriptTag"/>s.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ShopifyScriptTag>> ListAsync(ShopifyScriptTagListOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("script_tags.json", Method.GET, "script_tags");

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyScriptTag>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyScriptTag"/> with the given id.
        /// </summary>
        /// <param name="tagId">The id of the <see cref="ShopifyScriptTag"/> to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyScriptTag"/>.</returns>
        public async Task<ShopifyScriptTag> GetAsync(long tagId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"script_tags/{tagId}.json", Method.GET, "script_tag");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyScriptTag>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ShopifyScriptTag"/> on the store.
        /// </summary>
        /// <param name="tag">A new <see cref="ShopifyScriptTag"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ShopifyScriptTag"/>.</returns>
        public async Task<ShopifyScriptTag> CreateAsync(ShopifyScriptTag tag)
        {
            IRestRequest req = RequestEngine.CreateRequest("script_tags.json", Method.POST, "script_tag");

            //Build the request body
            var body = new Dictionary<string, object>()
            {
                { "script_tag", tag }
            };

            req.AddJsonBody(body);

            return await RequestEngine.ExecuteRequestAsync<ShopifyScriptTag>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifyScriptTag"/>. Id must not be null.
        /// </summary>
        /// <param name="tag">The <see cref="ShopifyScriptTag"/> to update.</param>
        /// <returns>The updated <see cref="ShopifyScriptTag"/>.</returns>
        public async Task<ShopifyScriptTag> UpdateAsync(ShopifyScriptTag tag)
        {
            IRestRequest req = RequestEngine.CreateRequest($"script_tags/{tag.Id.Value}.json", Method.PUT, "script_tag");

            req.AddJsonBody(new { script_tag = tag });

            return await RequestEngine.ExecuteRequestAsync<ShopifyScriptTag>(_RestClient, req);
        }

        /// <summary>
        /// Deletes the <see cref="ShopifyScriptTag"/> with the given Id.
        /// </summary>
        /// <param name="tagId">The tag's Id.</param>
        public async Task DeleteAsync(long tagId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"script_tags/{tagId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion
    }
}
