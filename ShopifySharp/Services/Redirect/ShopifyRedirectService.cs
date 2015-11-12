using Humanizer;
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
    /// A service for manipulating Shopify redirects.
    /// </summary>
    public class ShopifyRedirectService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyRedirectService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyRedirectService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the shop's redirects.
        /// </summary>
        /// <param name="path">An optional parameter that filters the result to redirects with the given path.</param>
        /// <param name="target">An optional parameter that filters the result to redirects with the given target.</param>
        /// <returns>The count of all redirects for the shop.</returns>
        public async Task<int> CountAsync(string path = null, string target = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("redirects/count.json", Method.GET);

            //Add optional parameters to request
            if(string.IsNullOrEmpty(path) == false)
            {
                req.AddParameter("path", path);
            }
            if(string.IsNullOrEmpty(target) == false)
            {
                req.AddParameter("target", target);
            }

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's redirects.
        /// </summary>
        /// <param name="options">An optional filter that restricts the results.</param>
        /// <returns>The list of <see cref="ShopifyRedirect"/>.</returns>
        public async Task<IEnumerable<ShopifyRedirect>> ListAsync(ShopifyRedirectFilterOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("redirects.json", Method.GET, "redirects");

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyRedirect>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyRedirect"/> with the given id.
        /// </summary>
        /// <param name="redirectId">The id of the redirect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyRedirect"/>.</returns>
        public async Task<ShopifyRedirect> GetAsync(long redirectId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("redirects/{0}.json".FormatWith(redirectId), Method.GET, "redirect");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyRedirect>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ShopifyRedirect"/> on the store. The redirect always starts out with a role of 
        /// "unpublished." If the redirect has a different role, it will be assigned that only after all of its 
        /// files have been extracted and stored by Shopify (which might take a couple of minutes). 
        /// </summary>
        /// <param name="redirect">The new <see cref="ShopifyRedirect"/>.</param>
        /// <returns>The new <see cref="ShopifyRedirect"/>.</returns>
        public async Task<ShopifyRedirect> CreateAsync(ShopifyRedirect redirect)
        {
            IRestRequest req = RequestEngine.CreateRequest("redirects.json", Method.POST, "redirect");

            req.AddJsonBody(new { redirect });

            return await RequestEngine.ExecuteRequestAsync<ShopifyRedirect>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifyRedirect"/>. Id must not be null.
        /// </summary>
        /// <param name="redirect">The <see cref="ShopifyRedirect"/> to update.</param>
        /// <returns>The updated <see cref="ShopifyRedirect"/>.</returns>
        public async Task<ShopifyRedirect> UpdateAsync(ShopifyRedirect redirect)
        {
            IRestRequest req = RequestEngine.CreateRequest("redirects/{0}.json".FormatWith(redirect.Id.Value), Method.PUT, "redirect");

            req.AddJsonBody(new { redirect });

            return await RequestEngine.ExecuteRequestAsync<ShopifyRedirect>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a redirect with the given Id.
        /// </summary>
        /// <param name="redirectId">The redirect object's Id.</param>
        public async Task DeleteAsync(long redirectId)
        {
            IRestRequest req = RequestEngine.CreateRequest("redirects/{0}.json".FormatWith(redirectId), Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion
    }
}
