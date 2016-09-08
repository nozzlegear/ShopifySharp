using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Entities;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for getting Shopify Events
    /// Reference: https://help.shopify.com/api/reference/event
    /// </summary>
    public class ShopifyEventService : ShopifyService
    {

        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyEventService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyEventService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all site events.
        /// </summary>
        /// <returns>The count of all site events.</returns>
        public async Task<int> CountAsync(ShopifyEventCountFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("events/count.json", Method.GET);

            //Add optional parameters to request
            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets the site events.
        /// </summary>
        /// <returns>Site events.</returns>
        public async Task<IEnumerable<ShopifyEvent>> ListAsync(ShopifyEventCountFilter options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("events.json", Method.GET, "products");

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyEvent>>(_RestClient, req);
        }
        #endregion
    }
}
