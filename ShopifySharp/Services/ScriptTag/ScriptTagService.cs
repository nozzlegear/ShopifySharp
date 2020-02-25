using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's ScriptTag API.
    /// </summary>
    public class ScriptTagService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ScriptTagService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ScriptTagService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        private async Task<int> _CountAsync(ICountFilter filter = null)
        {
            var req = PrepareRequest("script_tags/count.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }

            var response = await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");

            return response.Result;
        }

        /// <summary>
        /// Gets a count of all of the shop's <see cref="ScriptTag"/>s.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        public virtual async Task<int> CountAsync(ICountFilter filter = null)
        {
            return await _CountAsync(filter);
        }

        /// <summary>
        /// Gets a count of all of the shop's <see cref="ScriptTag"/>s.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        public virtual async Task<int> CountAsync(ScriptTagCountFilter filter = null)
        {
            return await _CountAsync(filter);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's script tags.
        /// </summary>
        public virtual async Task<IListResult<ScriptTag>> ListAsync(IListFilter<ScriptTag> filter)
        {
            var req = PrepareRequest("script_tags.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<ScriptTag>>(req, HttpMethod.Get, rootElement: "script_tags");

            return ParseLinkHeaderToListResult(response);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's script tags.
        /// </summary>
        public virtual async Task<IListResult<ScriptTag>> ListAsync(ScriptTagListFilter filter)
        {
            return await ListAsync((IListFilter<ScriptTag>) filter);
        }

        /// <summary>
        /// Retrieves the <see cref="ScriptTag"/> with the given id.
        /// </summary>
        /// <param name="tagId">The id of the <see cref="ScriptTag"/> to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ScriptTag"/>.</returns>
        public virtual async Task<ScriptTag> GetAsync(long tagId, string fields = null)
        {
            var req = PrepareRequest($"script_tags/{tagId}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<ScriptTag>(req, HttpMethod.Get, rootElement: "script_tag");

            return response.Result;
        }

        /// <summary>
        /// Creates a new <see cref="ScriptTag"/> on the store.
        /// </summary>
        /// <param name="tag">A new <see cref="ScriptTag"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ScriptTag"/>.</returns>
        public virtual async Task<ScriptTag> CreateAsync(ScriptTag tag)
        {
            var req = PrepareRequest("script_tags.json");
            var content = new JsonContent(new
            {
                script_tag = tag
            });
            var response = await ExecuteRequestAsync<ScriptTag>(req, HttpMethod.Post, content, "script_tag");

            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="ScriptTag"/>.
        /// </summary>
        /// <param name="scriptTagId">Id of the object being updated.</param>
        /// <param name="tag">The <see cref="ScriptTag"/> to update.</param>
        /// <returns>The updated <see cref="ScriptTag"/>.</returns>
        public virtual async Task<ScriptTag> UpdateAsync(long scriptTagId, ScriptTag tag)
        {
            var req = PrepareRequest($"script_tags/{scriptTagId}.json");
            var content = new JsonContent(new
            {
                script_tag = tag
            });
            var response = await ExecuteRequestAsync<ScriptTag>(req, HttpMethod.Put, content, "script_tag");

            return response.Result;
        }

        /// <summary>
        /// Deletes the <see cref="ScriptTag"/> with the given Id.
        /// </summary>
        /// <param name="tagId">The tag's Id.</param>
        public virtual async Task DeleteAsync(long tagId)
        {
            var req = PrepareRequest($"script_tags/{tagId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
