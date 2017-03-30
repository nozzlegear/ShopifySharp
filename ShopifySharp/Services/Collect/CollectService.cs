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
    /// A service for manipulating mapping between shopify products and collections
    /// </summary>
    public class CollectService : ShopifyService
    {
        #region Constructor
        /// <summary>
        /// Creates a new instance of <see cref="CustomerService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CollectService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion Constructor

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the collects (product-collection mappings).
        /// </summary>
        /// <returns>The count of all collects for the shop.</returns>
        public virtual async Task<int> CountAsync(CollectFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("collects/count.json", Method.GET, "count");

            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's collects.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<Collect>> ListAsync(CollectFilter options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("collects.json", Method.GET, "collects");

            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<Collect>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="Collect"/> with the given id.
        /// </summary>
        /// <param name="collectId">The id of the collect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Collect"/>.</returns>
        public virtual async Task<Collect> GetAsync(long collectId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"collects/{collectId}.json", Method.GET, "collect");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<Collect>(_RestClient, req);
        }


        /// <summary>
        /// Creates a new <see cref="Collect"/> on the store. Map product to collection
        /// </summary>
        /// <param name="collect">A new <see cref="Collect"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="Collect"/>.</returns>
        public virtual async Task<Collect> CreateAsync(Collect collect)
        {
            IRestRequest req = RequestEngine.CreateRequest("collects.json", RestSharp.Method.POST, "collect");

            Dictionary<string, object> body = new Dictionary<string, object>()
            {
                { "collect", collect }
            };

            req.AddJsonBody(body);

            return await RequestEngine.ExecuteRequestAsync<Collect>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a collect with the given Id.
        /// </summary>
        /// <param name="collectId">The product object's Id.</param>
        public virtual async Task DeleteAsync(long collectId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"collects/{collectId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion Public, non-static methods
    }
}
