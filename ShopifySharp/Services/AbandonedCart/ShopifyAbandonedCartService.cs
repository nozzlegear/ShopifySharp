using RestSharp;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for interacting with a customer's abandoned checkouts
    /// Billing and shipping info has been filled out but no purchase completed
    /// </summary>
    public class ShopifyAbandonedCartService : ShopifyService
    {

        #region Constructor

        /// <summary>
        /// Creates a new instance of the service.
        /// </summary>
        /// <param name="myShopifyUrl"></param>
        /// <param name="shopAccessToken"></param>
        public ShopifyAbandonedCartService(string myShopifyUrl, string shopAccessToken)
            : base(myShopifyUrl, shopAccessToken)
        {}

        #endregion

        /// <summary>
        /// Lists abandoned checkouts through an async call
        /// </summary>
        /// <returns></returns>
        public virtual async Task<ShopifyAbandonedCheckout> ListAsync()
        {
            var req = RequestEngine.CreateRequest($"checkouts.json", Method.GET, "checkout");

            return await RequestEngine.ExecuteRequestAsync<ShopifyAbandonedCheckout>(_RestClient, req);
        }

        /// <summary>
        /// Counts abandonded checkouts through an async call
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        public virtual async Task<int> CountAsync(ShopifyAbandonedCheckoutCountFilter filter = null)
        {
            var request = RequestEngine.CreateRequest("checkouts/count.json", RestSharp.Method.GET, "count");

            if (filter != null)
            {
                request.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));
            }

            return await RequestEngine.ExecuteRequestAsync<int>(_RestClient, request);
        }

    }
}
