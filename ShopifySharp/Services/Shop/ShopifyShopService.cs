using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyShopService: ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyShopService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyShopService(string myShopifyUrl, string shopAccessToken): base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Returns the shop's <see cref="ShopifyShop"/> information.
        /// </summary>
        /// <returns></returns>
        public async Task<ShopifyShop> GetAsync()
        {
            RestRequest request = new RestRequest("shop.json", Method.GET)
            {
                RootElement = "shop"
            };

            //Make request
            return await RequestEngine.ExecuteRequestAsync<ShopifyShop>(_RestClient, request);
        }

        #endregion
    }
}
