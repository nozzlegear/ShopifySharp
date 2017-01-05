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
    /// A service for manipulating Shopify's ApplicationCharge API.
    /// </summary>
    public class ShopifyChargeService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyChargeService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyChargeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static Charge methods

        /// <summary>
        /// Creates a <see cref="ShopifyCharge"/>. 
        /// </summary>
        /// <param name="charge">The <see cref="ShopifyCharge"/> to create.</param>
        /// <returns>The new <see cref="ShopifyCharge"/>.</returns>
        public virtual async Task<ShopifyCharge> CreateAsync(ShopifyCharge charge)
        {
            IRestRequest req = RequestEngine.CreateRequest("application_charges.json", Method.POST, "application_charge");

            req.AddJsonBody(new { application_charge = charge });

            return await RequestEngine.ExecuteRequestAsync<ShopifyCharge>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyCharge"/> with the given id.
        /// </summary>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyCharge"/>.</returns>
        public virtual async Task<ShopifyCharge> GetAsync(long id, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"application_charges/{id}.json", Method.GET, "application_charge");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyCharge>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves a list of all past and present <see cref="ShopifyCharge"/> objects.
        /// </summary>
        /// <param name="sinceId">Restricts results to any charge after the given id.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The list of <see cref="ShopifyCharge"/> objects.</returns>
        public virtual async Task<IEnumerable<ShopifyCharge>> ListAsync(long? sinceId = null, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("application_charges.json", Method.GET, "application_charges");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            if (sinceId.HasValue)
            {
                req.AddParameter("since_id", sinceId);
            }

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyCharge>>(_RestClient, req);
        }

        /// <summary>
        /// Activates a <see cref="ShopifyCharge"/> that the shop owner has accepted.
        /// </summary>
        /// <param name="id">The id of the charge to activate.</param>
        public virtual async Task ActivateAsync(long id)
        {
            IRestRequest req = RequestEngine.CreateRequest($"application_charges/{id}/activate.json", Method.POST);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion
    }
}
