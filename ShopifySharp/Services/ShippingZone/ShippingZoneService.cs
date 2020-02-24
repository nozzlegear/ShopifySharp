using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Filters;

namespace ShopifySharp
{
    /// <summary>
    /// A service for retrieve Shopify shipping zones.
    /// </summary>
    public class ShippingZoneService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShippingZoneService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShippingZoneService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Retrieves a list of all shipping zones. 
        /// </summary>
        public virtual async Task<IEnumerable<ShippingZone>> ListAsync(ShippingZoneListFilter filter = null)
        {
            var req = PrepareRequest("shipping_zones.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<ShippingZone>>(req, HttpMethod.Get, rootElement: "shipping_zones");

            return response.Result;
        }
    }
}
