using Humanizer;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's ApplicationCharge and RecurringApplicationCharge API.
    /// </summary>
    public class ShopifyBillingService:ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyBillingService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyBillingService(string myShopifyUrl, string shopAccessToken): base (myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static RecurringCharge methods

        /// <summary>
        /// Creates a <see cref="ShopifyRecurringCharge"/>. 
        /// </summary>
        /// <param name="charge">The <see cref="ShopifyRecurringCharge"/> to create.</param>
        /// <returns>The new <see cref="ShopifyRecurringCharge"/>.</returns>
        public async Task<ShopifyRecurringCharge> CreateAsync(ShopifyRecurringCharge charge)
        {
            IRestRequest req = RequestEngine.CreateRequest("recurring_application_charges.json", Method.POST, "recurring_application_charge");

            req.AddJsonBody(new { recurring_application_charge = charge });

            return await RequestEngine.ExecuteRequestAsync<ShopifyRecurringCharge>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyRecurringCharge"/> with the given id.
        /// </summary>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyRecurringCharge"/>.</returns>
        public async Task<ShopifyRecurringCharge> GetAsync(long id, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("recurring_application_charges/{0}.json".FormatWith(id), Method.GET, "recurring_application_charge");

            if(string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyRecurringCharge>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves a list of all past and present <see cref="ShopifyRecurringCharge"/> objects.
        /// </summary>
        /// <param name="sinceId">Restricts results to any charge after the given id.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The list of <see cref="ShopifyRecurringCharge"/> objects.</returns>
        public async Task<IEnumerable<ShopifyRecurringCharge>> ListAsync(long? sinceId = null, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("recurring_application_charges.json", Method.GET, "recurring_application_charges");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            if (sinceId.HasValue)
            {
                req.AddParameter("since_id", sinceId);
            }

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyRecurringCharge>>(_RestClient, req);
        }

        /// <summary>
        /// Activates a <see cref="ShopifyRecurringCharge"/> that the shop owner has accepted.
        /// </summary>
        /// <param name="id">The id of the charge to activate.</param>
        /// <returns>The activated <see cref="ShopifyRecurringCharge"/>.</returns>
        public async Task<ShopifyRecurringCharge> ActivateAsync(long id)
        {
            IRestRequest req = RequestEngine.CreateRequest("recurring_application_charges/{0}/activate.json".FormatWith(id), Method.POST, "recurring_application_charge");

            return await RequestEngine.ExecuteRequestAsync<ShopifyRecurringCharge>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a <see cref="ShopifyRecurringCharge"/>.
        /// </summary>
        /// <param name="id">The id of the charge to delete.</param>
        public async Task DeleteAsync(long id)
        {
            IRestRequest req = RequestEngine.CreateRequest("recurring_application_charges/{0}.json".FormatWith(id), Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion

        #region Public, non-static SingleCharge methods

        #endregion
    }
}
