using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyCustomerService: ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyCustomerService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyCustomerService(string myShopifyUrl, string shopAccessToken): base (myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the shop's customers.
        /// </summary>
        /// <returns>The count of all customers for the shop.</returns>
        public async Task<int> CountAsync()
        {
            RestRequest req = new RestRequest("customers/count.json", Method.GET);
            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's customers.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ShopifyCustomer>> ListAsync(ShopifyListOptions options = null)
        {
            RestRequest req = new RestRequest("customers.json", Method.GET)
            {
                RootElement = "customers"
            };

            //Add querystring parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyCustomer>>(_RestClient, req);
        }

        public async Task<ShopifyCustomer> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ShopifyCustomer>> SearchAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ShopifyCustomer> CreateAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ShopifyCustomer> UpdateAsync()
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
