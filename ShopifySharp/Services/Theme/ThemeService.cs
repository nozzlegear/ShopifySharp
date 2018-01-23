using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify themes.
    /// </summary>
    public class ThemeService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ThemeService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ThemeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of up to 250 of the shop's themes.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<Theme>> ListAsync(ListFilter filter = null)
        {
            var req = PrepareRequest("themes.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<List<Theme>>(req, HttpMethod.Get, rootElement: "themes");
        }

        /// <summary>
        /// Retrieves the <see cref="Theme"/> with the given id.
        /// </summary>
        /// <param name="themeId">The id of the theme to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Theme"/>.</returns>
        public virtual async Task<Theme> GetAsync(long themeId, string fields = null)
        {
            var req = PrepareRequest($"themes/{themeId}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<Theme>(req, HttpMethod.Get, rootElement: "theme");
        }

        private async Task<Theme> _CreateAsync(Theme theme, string sourceUrl = null)
        {
            var req = PrepareRequest("themes.json");
            var body = theme.ToDictionary();

            if (!string.IsNullOrEmpty(sourceUrl))
            {
                body.Add("src", sourceUrl);
            }

            var content = new JsonContent(new
            {
                theme = body
            });

            return await ExecuteRequestAsync<Theme>(req, HttpMethod.Post, content, "theme");
        }

        /// <summary>
        /// Creates a new theme on the store. The theme always starts out with a role of
        /// "unpublished." If the theme has a different role, it will be assigned that only after all of its
        /// files have been extracted and stored by Shopify (which might take a couple of minutes).
        /// </summary>
        /// <param name="theme">The new theme.</param>
        /// <param name="sourceUrl">A URL that points to the .zip file containing the theme's source files.</param>
        public virtual async Task<Theme> CreateAsync(Theme theme)
        {
            return await _CreateAsync(theme);
        }

        /// <summary>
        /// Creates a new theme on the store. The theme always starts out with a role of
        /// "unpublished." If the theme has a different role, it will be assigned that only after all of its
        /// files have been extracted and stored by Shopify (which might take a couple of minutes).
        /// </summary>
        /// <param name="theme">The new theme.</param>
        /// <param name="sourceUrl">A URL that points to the .zip file containing the theme's source files.</param>
        public virtual async Task<Theme> CreateAsync(Theme theme, string sourceUrl)
        {
            return await _CreateAsync(theme, sourceUrl);
        }

        /// <summary>
        /// Updates the given <see cref="Theme"/>.
        /// </summary>
        /// <param name="themeId">Id of the object being updated.</param>
        /// <param name="theme">The <see cref="Theme"/> to update.</param>
        /// <returns>The updated <see cref="Theme"/>.</returns>
        public virtual async Task<Theme> UpdateAsync(long themeId, Theme theme)
        {
            var req = PrepareRequest($"themes/{themeId}.json");
            var content = new JsonContent(new
            {
                theme = theme
            });

            return await ExecuteRequestAsync<Theme>(req, HttpMethod.Put, content, "theme");
        }

        /// <summary>
        /// Deletes a Theme with the given Id.
        /// </summary>
        /// <param name="themeId">The Theme object's Id.</param>
        public virtual async Task DeleteAsync(long themeId)
        {
            var req = PrepareRequest($"themes/{themeId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
