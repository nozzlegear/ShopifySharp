using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Filters;
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
        /// Gets a count of all of the shop's <see cref="ScriptTag"/>s.
        /// </summary>
        /// <param name="src">Optionally filters the count to only those <see cref="ScriptTag"/>s with the 
        /// given <see cref="ScriptTag.Src"/> value.</param>
        /// <returns>The count.</returns>
        public virtual async Task<int> CountAsync(string src = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("script_tags/count.json", Method.GET);

            //Filter the count where necessary.
            if (string.IsNullOrEmpty(src) == false) req.AddQueryParameter("src", src);

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's <see cref="ScriptTag"/>s.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ScriptTag>> ListAsync(ScriptTagFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("script_tags.json", Method.GET, "script_tags");

            //Add optional parameters to request
            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ScriptTag>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ScriptTag"/> with the given id.
        /// </summary>
        /// <param name="tagId">The id of the <see cref="ScriptTag"/> to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ScriptTag"/>.</returns>
        public virtual async Task<ScriptTag> GetAsync(long tagId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"script_tags/{tagId}.json", Method.GET, "script_tag");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ScriptTag>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ScriptTag"/> on the store.
        /// </summary>
        /// <param name="tag">A new <see cref="ScriptTag"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ScriptTag"/>.</returns>
        public virtual async Task<ScriptTag> CreateAsync(ScriptTag tag)
        {
            IRestRequest req = RequestEngine.CreateRequest("script_tags.json", Method.POST, "script_tag");

            //Build the request body
            var body = new Dictionary<string, object>()
            {
                { "script_tag", tag }
            };

            req.AddJsonBody(body);

            return await RequestEngine.ExecuteRequestAsync<ScriptTag>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ScriptTag"/>. Id must not be null.
        /// </summary>
        /// <param name="tag">The <see cref="ScriptTag"/> to update.</param>
        /// <returns>The updated <see cref="ScriptTag"/>.</returns>
        public virtual async Task<ScriptTag> UpdateAsync(ScriptTag tag)
        {
            IRestRequest req = RequestEngine.CreateRequest($"script_tags/{tag.Id.Value}.json", Method.PUT, "script_tag");

            req.AddJsonBody(new { script_tag = tag });

            return await RequestEngine.ExecuteRequestAsync<ScriptTag>(_RestClient, req);
        }

        /// <summary>
        /// Deletes the <see cref="ScriptTag"/> with the given Id.
        /// </summary>
        /// <param name="tagId">The tag's Id.</param>
        public virtual async Task DeleteAsync(long tagId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"script_tags/{tagId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion
    }
}
