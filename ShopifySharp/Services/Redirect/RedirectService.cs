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
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<int> CountAsync(RedirectCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>("redirects/count.json", "count", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's redirects.
        /// </summary>
        public virtual async Task<ListResult<Redirect>> ListAsync(ListFilter<Redirect> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("redirects.json", "redirects", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's redirects.
        /// </summary>
        public virtual async Task<ListResult<Redirect>> ListAsync(RedirectListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }
        
        /// <summary>
        /// Retrieves the <see cref="Redirect"/> with the given id.
        /// </summary>
        /// <param name="redirectId">The id of the redirect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Redirect"/>.</returns>
        public virtual async Task<Redirect> GetAsync(long redirectId, string fields = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"redirects/{redirectId}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<Redirect>(req, HttpMethod.Get, cancellationToken, rootElement: "redirect");

            return response.Result;
        }

        /// <summary>
        /// Creates a new <see cref="Redirect"/> on the store. The redirect always starts out with a role of
        /// "unpublished." If the redirect has a different role, it will be assigned that only after all of its
        /// files have been extracted and stored by Shopify (which might take a couple of minutes).
        /// </summary>
        /// <param name="redirect">The new <see cref="Redirect"/>.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Redirect"/>.</returns>
        public virtual async Task<Redirect> CreateAsync(Redirect redirect, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("redirects.json");
            var content = new JsonContent(new
            {
                redirect = redirect
            });
            var response = await ExecuteRequestAsync<Redirect>(req, HttpMethod.Post, cancellationToken, content, "redirect");

            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="Redirect"/>.
        /// </summary>
        /// <param name="redirectId">Id of the object being updated.</param>
        /// <param name="redirect">The <see cref="Redirect"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Redirect"/>.</returns>
        public virtual async Task<Redirect> UpdateAsync(long redirectId, Redirect redirect, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"redirects/{redirectId}.json");
            var content = new JsonContent(new
            {
                redirect = redirect
            });
            var response = await ExecuteRequestAsync<Redirect>(req, HttpMethod.Put, cancellationToken, content, "redirect");

            return response.Result;
        }

        /// <summary>
        /// Deletes a redirect with the given Id.
        /// </summary>
        /// <param name="redirectId">The redirect object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long redirectId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"redirects/{redirectId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}
