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
    /// A service for manipulating Shopify redirects.
    /// </summary>
    public class RedirectService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="RedirectService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public RedirectService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's redirects.
        /// </summary>
        /// <param name="path">An optional parameter that filters the result to redirects with the given path.</param>
        /// <param name="target">An optional parameter that filters the result to redirects with the given target.</param>
        /// <returns>The count of all redirects for the shop.</returns>
        public virtual async Task<int> CountAsync(string path = null, string target = null)
        {
            var req = PrepareRequest("redirects/count.json");

            if (!string.IsNullOrEmpty(path))
            {
                req.QueryParams.Add("path", path);
            }

            if (!string.IsNullOrEmpty(target))
            {
                req.QueryParams.Add("target", target);
            }

            var response = await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
            
            return response.Result;
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's redirects.
        /// </summary>
        public virtual async Task<IListResult<Redirect>> ListAsync(IListFilter<Redirect> filter)
        {
            var req = PrepareRequest("redirects.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<Redirect>>(req, HttpMethod.Get, rootElement: "redirects");

            return ParseLinkHeaderToListResult(response);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's redirects.
        /// </summary>
        public virtual async Task<IListResult<Redirect>> ListAsync(RedirectListFilter filter)
        {
            return await ListAsync((IListFilter<Redirect>) filter);
        }
        
        /// <summary>
        /// Retrieves the <see cref="Redirect"/> with the given id.
        /// </summary>
        /// <param name="redirectId">The id of the redirect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Redirect"/>.</returns>
        public virtual async Task<Redirect> GetAsync(long redirectId, string fields = null)
        {
            var req = PrepareRequest($"redirects/{redirectId}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<Redirect>(req, HttpMethod.Get, rootElement: "redirect");

            return response.Result;
        }

        /// <summary>
        /// Creates a new <see cref="Redirect"/> on the store. The redirect always starts out with a role of
        /// "unpublished." If the redirect has a different role, it will be assigned that only after all of its
        /// files have been extracted and stored by Shopify (which might take a couple of minutes).
        /// </summary>
        /// <param name="redirect">The new <see cref="Redirect"/>.</param>
        /// <returns>The new <see cref="Redirect"/>.</returns>
        public virtual async Task<Redirect> CreateAsync(Redirect redirect)
        {
            var req = PrepareRequest("redirects.json");
            var content = new JsonContent(new
            {
                redirect = redirect
            });
            var response = await ExecuteRequestAsync<Redirect>(req, HttpMethod.Post, content, "redirect");

            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="Redirect"/>.
        /// </summary>
        /// <param name="redirectId">Id of the object being updated.</param>
        /// <param name="redirect">The <see cref="Redirect"/> to update.</param>
        /// <returns>The updated <see cref="Redirect"/>.</returns>
        public virtual async Task<Redirect> UpdateAsync(long redirectId, Redirect redirect)
        {
            var req = PrepareRequest($"redirects/{redirectId}.json");
            var content = new JsonContent(new
            {
                redirect = redirect
            });
            var response = await ExecuteRequestAsync<Redirect>(req, HttpMethod.Put, content, "redirect");

            return response.Result;
        }

        /// <summary>
        /// Deletes a redirect with the given Id.
        /// </summary>
        /// <param name="redirectId">The redirect object's Id.</param>
        public virtual async Task DeleteAsync(long redirectId)
        {
            var req = PrepareRequest($"redirects/{redirectId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
