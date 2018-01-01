using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's RecurringApplicationCharge API.
    /// </summary>
    public class RecurringChargeService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="RecurringChargeService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public RecurringChargeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Creates a <see cref="RecurringCharge"/>.
        /// </summary>
        /// <param name="charge">The <see cref="RecurringCharge"/> to create.</param>
        /// <returns>The new <see cref="RecurringCharge"/>.</returns>
        public virtual async Task<RecurringCharge> CreateAsync(RecurringCharge charge)
        {
            var req = PrepareRequest("recurring_application_charges.json");
            var content = new JsonContent(new
            {
                recurring_application_charge = charge
            });

            return await ExecuteRequestAsync<RecurringCharge>(req, HttpMethod.Post, content, "recurring_application_charge");
        }

        /// <summary>
        /// Retrieves the <see cref="RecurringCharge"/> with the given id.
        /// </summary>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="RecurringCharge"/>.</returns>
        public virtual async Task<RecurringCharge> GetAsync(long id, string fields = null)
        {
            var req = PrepareRequest($"recurring_application_charges/{id}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<RecurringCharge>(req, HttpMethod.Get, rootElement: "recurring_application_charge");
        }

        /// <summary>
        /// Retrieves a list of all past and present <see cref="RecurringCharge"/> objects.
        /// </summary>
        /// <param name="sinceId">Restricts results to any charge after the given id.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The list of <see cref="RecurringCharge"/> objects.</returns>
        public virtual async Task<IEnumerable<RecurringCharge>> ListAsync(long? sinceId = null, string fields = null)
        {
            var req = PrepareRequest("recurring_application_charges.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            if (sinceId.HasValue)
            {
                req.QueryParams.Add("since_id", sinceId.Value);
            }

            return await ExecuteRequestAsync<List<RecurringCharge>>(req, HttpMethod.Get, rootElement: "recurring_application_charges");
        }

        /// <summary>
        /// Activates a <see cref="RecurringCharge"/> that the shop owner has accepted.
        /// </summary>
        /// <param name="id">The id of the charge to activate.</param>
        public virtual async Task ActivateAsync(long id)
        {
            var req = PrepareRequest($"recurring_application_charges/{id}/activate.json");

            await ExecuteRequestAsync(req, HttpMethod.Post);
        }

        /// <summary>
        /// Deletes a <see cref="RecurringCharge"/>.
        /// </summary>
        /// <param name="id">The id of the charge to delete.</param>
        public virtual async Task DeleteAsync(long id)
        {
            var req = PrepareRequest($"recurring_application_charges/{id}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
