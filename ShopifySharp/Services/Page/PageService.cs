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
    /// A service for manipulating Shopify pages.
    /// </summary>
    public class PageService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="PageService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public PageService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the shop's pages.
        /// </summary>
        /// <returns>The count of all pages for the shop.</returns>
        public virtual async Task<int> CountAsync(PageFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("pages/count.json", Method.GET);

            //Add optional parameters to request
            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's pages.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<Page>> ListAsync(PageFilter options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("pages.json", Method.GET, "pages");

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<Page>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="Page"/> with the given id.
        /// </summary>
        /// <param name="pageId">The id of the page to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Page"/>.</returns>
        public virtual async Task<Page> GetAsync(long pageId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"pages/{pageId}.json", Method.GET, "page");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<Page>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="Page"/> on the store.
        /// </summary>
        /// <param name="page">A new <see cref="Page"/>. Id should be set to null.</param>
        /// <param name="options">Options for creating the page.</param>
        /// <returns>The new <see cref="Page"/>.</returns>
        public virtual async Task<Page> CreateAsync(Page page, PageCreateOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("pages.json", Method.POST, "page");

            //Build the request body
            Dictionary<string, object> body = new Dictionary<string, object>(options?.ToDictionary() ?? new Dictionary<string, object>())
            {
                { "page", page }
            };

            req.AddJsonBody(body);

            return await RequestEngine.ExecuteRequestAsync<Page>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="Page"/>. Id must not be null.
        /// </summary>
        /// <param name="page">The <see cref="Page"/> to update.</param>
        /// <returns>The updated <see cref="Page"/>.</returns>
        public virtual async Task<Page> UpdateAsync(Page page)
        {
            IRestRequest req = RequestEngine.CreateRequest($"pages/{page.Id.Value}.json", Method.PUT, "page");

            req.AddJsonBody(new { page });

            return await RequestEngine.ExecuteRequestAsync<Page>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a page with the given Id.
        /// </summary>
        /// <param name="pageId">The page object's Id.</param>
        public virtual async Task DeleteAsync(long pageId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"pages/{pageId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="Page"/>. Id must not be null.
        /// </summary>
        /// <param name="pageId">The <see cref="Page"/> pageId to update.</param>
        /// <param name="metafield">The <see cref="MetaField"/> to update.</param>
        /// <returns>The updated <see cref="MetaField"/>.</returns>
        public virtual async Task<MetaField> UpdateMetafieldAsync(long pageId, MetaField metafield)
        {
            var requestPath = $"pages/{pageId}/metafields.json";
            var method = Method.POST;

            if (metafield.Id.HasValue)
            {
                requestPath = $"pages/{pageId}/metafields/{metafield.Id.Value}.json";
                method = Method.PUT;
            }

            IRestRequest req = RequestEngine.CreateRequest(requestPath, method, "metafield");

            req.AddJsonBody(new {metafield});
            
            return await RequestEngine.ExecuteRequestAsync<MetaField>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the collection of <see cref="MetaField"/> for the given page id.
        /// </summary>
        /// <param name="pageId">The id of the page to retrieve.</param>
        /// <returns>The <see cref="Page"/>.</returns>
        public virtual async Task<List<MetaField>> GetMetaFieldsAsync(long pageId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"pages/{pageId}/metafields.json", Method.GET,"metafields");
            
            return await RequestEngine.ExecuteRequestAsync<List<MetaField>>(_RestClient, req);
        }

        #endregion
    }
}
