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
    /// A service for manipulating Shopify pages.
    /// </summary>
    public class ShopifyPageService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyPageService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyPageService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the shop's pages.
        /// </summary>
        /// <returns>The count of all pages for the shop.</returns>
        public async Task<int> CountAsync(ShopifyPageFilterOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("pages/count.json", Method.GET);

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's pages.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ShopifyPage>> ListAsync(ShopifyPageFilterOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("pages.json", Method.GET, "pages");

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyPage>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyPage"/> with the given id.
        /// </summary>
        /// <param name="pageId">The id of the page to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyPage"/>.</returns>
        public async Task<ShopifyPage> GetAsync(long pageId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"pages/{pageId}.json", Method.GET, "page");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyPage>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ShopifyPage"/> on the store.
        /// </summary>
        /// <param name="page">A new <see cref="ShopifyPage"/>. Id should be set to null.</param>
        /// <param name="options">Options for creating the page.</param>
        /// <returns>The new <see cref="ShopifyPage"/>.</returns>
        public async Task<ShopifyPage> CreateAsync(ShopifyPage page, ShopifyPageCreateOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("pages.json", Method.POST, "page");

            //Build the request body
            Dictionary<string, object> body = new Dictionary<string, object>(options?.ToDictionary() ?? new Dictionary<string, object>())
            {
                { "page", page }
            };

            req.AddJsonBody(body);

            return await RequestEngine.ExecuteRequestAsync<ShopifyPage>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifyPage"/>. Id must not be null.
        /// </summary>
        /// <param name="page">The <see cref="ShopifyPage"/> to update.</param>
        /// <returns>The updated <see cref="ShopifyPage"/>.</returns>
        public async Task<ShopifyPage> UpdateAsync(ShopifyPage page)
        {
            IRestRequest req = RequestEngine.CreateRequest($"pages/{page.Id.Value}.json", Method.PUT, "page");

            req.AddJsonBody(new { page });

            return await RequestEngine.ExecuteRequestAsync<ShopifyPage>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a page with the given Id.
        /// </summary>
        /// <param name="pageId">The page object's Id.</param>
        public async Task DeleteAsync(long pageId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"pages/{pageId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifyPage"/>. Id must not be null.
        /// </summary>
        /// <param name="pageId">The <see cref="ShopifyPage"/> pageId to update.</param>
        /// <param name="metafield">The <see cref="ShopifyMetaField"/> to update.</param>
        /// <returns>The updated <see cref="ShopifyMetaField"/>.</returns>
        public async Task<ShopifyMetaField> UpdateMetafieldAsync(long pageId, ShopifyMetaField metafield)
        {
            var requestPath = $"pages/{pageId}/metafields.json";
            var method = Method.POST;

            if (metafield.Id.HasValue)
            {
                requestPath = $"pages/{pageId}/metafields/{metafield.Id.Value}.json";
                method = Method.PUT;
            }

            IRestRequest req = RequestEngine.CreateRequest(requestPath, method,
                    "metafield");

             req.AddJsonBody(new {metafield});
            
            return await RequestEngine.ExecuteRequestAsync<ShopifyMetaField>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the collection of <see cref="ShopifyMetaField"/> for the given page id.
        /// </summary>
        /// <param name="pageId">The id of the page to retrieve.</param>
        /// <returns>The <see cref="ShopifyPage"/>.</returns>
        public async Task<List<ShopifyMetaField>> GetMetaFieldsAsync(long pageId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"pages/{pageId}/metafields.json", Method.GET,"metafields");


            return await RequestEngine.ExecuteRequestAsync<List<ShopifyMetaField>>(_RestClient, req);
        }

        #endregion
    }
}
