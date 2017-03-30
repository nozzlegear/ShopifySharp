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
    /// A service for manipulating Shopify themes.
    /// </summary>
    public class ThemeService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ThemeService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ThemeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a list of up to 250 of the shop's themes.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<Theme>> ListAsync(ListFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("themes.json", Method.GET, "themes");

            //Add optional parameters to request
            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<Theme>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="Theme"/> with the given id.
        /// </summary>
        /// <param name="themeId">The id of the theme to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Theme"/>.</returns>
        public virtual async Task<Theme> GetAsync(long themeId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"themes/{themeId}.json", Method.GET, "theme");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<Theme>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="Theme"/> on the store. The theme always starts out with a role of 
        /// "unpublished." If the theme has a different role, it will be assigned that only after all of its 
        /// files have been extracted and stored by Shopify (which might take a couple of minutes). 
        /// </summary>
        /// <param name="theme">The new <see cref="Theme"/>.</param>
        /// <param name="sourceUrl">A URL that points to the .zip file containing the theme's source files.</param>
        /// <returns>The new <see cref="Theme"/>.</returns>
        public virtual async Task<Theme> CreateAsync(Theme theme, string sourceUrl)
        {
            IRestRequest req = RequestEngine.CreateRequest("themes.json", Method.POST, "theme");

            //Convert the theme to a dictionary, which will let us add the src URL to the request.
            var body = theme.ToDictionary();

            if (string.IsNullOrEmpty(sourceUrl) == false)
            {
                body["src"] = sourceUrl;
            }

            req.AddJsonBody(new { theme = body });

            return await RequestEngine.ExecuteRequestAsync<Theme>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="Theme"/>. Id must not be null.
        /// </summary>
        /// <param name="theme">The <see cref="Theme"/> to update.</param>
        /// <returns>The updated <see cref="Theme"/>.</returns>
        public virtual async Task<Theme> UpdateAsync(Theme theme)
        {
            IRestRequest req = RequestEngine.CreateRequest($"themes/{theme.Id.Value}.json", Method.PUT, "theme");

            req.AddJsonBody(new { theme });

            return await RequestEngine.ExecuteRequestAsync<Theme>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a Theme with the given Id.
        /// </summary>
        /// <param name="themeId">The Theme object's Id.</param>
        public virtual async Task DeleteAsync(long themeId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"themes/{themeId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion
    }
}
