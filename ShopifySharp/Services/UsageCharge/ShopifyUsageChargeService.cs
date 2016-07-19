using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's UsageCharge API.
    /// </summary>
    public class ShopifyUsageChargeService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyUsageChargeService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyUsageChargeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Creates a <see cref="ShopifyUsageCharge"/>. 
        /// </summary>
        /// <param name="recurringChargeId">The id of the <see cref="ShopifyUsageCharge"/> that this usage charge belongs to.</param>
        /// <param name="description">The name or description of the usage charge.</param>
        /// <param name="price">The price of the usage charge.</param>
        /// <returns>The new <see cref="ShopifyUsageCharge"/>.</returns>
        public async Task<ShopifyUsageCharge> CreateAsync(long recurringChargeId, string description, double price)
        {
            var req = RequestEngine.CreateRequest($"recurring_application_charges/{recurringChargeId}/usage_charges.json", Method.POST, "usage_charge");
            
            req.AddJsonBody(new { usage_charge = new { description = description, price = price } });

            return await RequestEngine.ExecuteRequestAsync<ShopifyUsageCharge>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyUsageCharge"/> with the given id.
        /// </summary>
        /// <param name="recurringChargeId">The id of the recurring charge that this usage charge belongs to.</param>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyUsageCharge"/>.</returns>
        public async Task<ShopifyUsageCharge> GetAsync(long recurringChargeId, long id, string fields = null)
        {
            var req = RequestEngine.CreateRequest($"recurring_application_charges/{recurringChargeId}/usage_charges/{id}.json", Method.GET, "usage_charge");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyUsageCharge>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves a list of all past and present <see cref="ShopifyUsageCharge"/> objects.
        /// </summary>
        /// <param name="recurringChargeId">The id of the recurring charge that these usage charges belong to.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The list of <see cref="ShopifyUsageCharge"/> objects.</returns>
        public async Task<IEnumerable<ShopifyUsageCharge>> ListAsync(long recurringChargeId, string fields = null)
        {
            var req = RequestEngine.CreateRequest($"recurring_application_charges/{recurringChargeId}/usage_charges.json", Method.GET, "usage_charges");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }            

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyUsageCharge>>(_RestClient, req);
        }

        #endregion
    }
}
