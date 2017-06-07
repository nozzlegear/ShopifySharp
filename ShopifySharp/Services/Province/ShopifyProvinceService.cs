using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifySharp.Entities;

namespace ShopifySharp.Services.Province
{
    public class ShopifyProvinceService : ShopifyService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifyProvinceService"/> class.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyProvinceService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken)
        {}


        public virtual async Task<ShopifyProvince> GetAsync(long countryId, long id)
        {
            var request = RequestEngine.CreateRequest($"admin/countries/{countryId}/provinces/{id}.json", RestSharp.Method.GET, "province");

            return await RequestEngine.ExecuteRequestAsync<ShopifyProvince>(_RestClient, request);
        }
    }
}
