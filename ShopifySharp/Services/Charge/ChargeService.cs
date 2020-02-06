using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's ApplicationCharge API.
    /// </summary>
    public class ChargeService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ChargeService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ChargeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Creates a <see cref="Charge"/>.
        /// </summary>
        /// <param name="charge">The <see cref="Charge"/> to create.</param>
        /// <returns>The new <see cref="Charge"/>.</returns>
        public virtual async Task<Charge> CreateAsync(Charge charge)
        {
            var req = PrepareRequest("application_charges.json");
            var content = new JsonContent(new { application_charge = charge });

            var response = await ExecuteRequestAsync<Charge>(req, HttpMethod.Post, content, "application_charge");
            return response.Result;
        }

        /// <summary>
        /// Retrieves the <see cref="Charge"/> with the given id.
        /// </summary>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Charge"/>.</returns>
        public virtual async Task<Charge> GetAsync(long id, string fields = null)
        {
            var req = PrepareRequest($"application_charges/{id}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<Charge>(req, HttpMethod.Get, rootElement: "application_charge");
            return response.Result;
        }

        /// <summary>
        /// Retrieves a list of all past and present <see cref="Charge"/> objects.
        /// </summary>
        /// <param name="sinceId">Restricts results to any charge after the given id.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The list of <see cref="Charge"/> objects.</returns>
        public virtual async Task<IEnumerable<Charge>> ListAsync(IListFilter filter)
        {
            throw new Exception("not yet implemented");
            // var req = PrepareRequest("application_charges.json");
            //
            // if (string.IsNullOrEmpty(fields) == false)
            // {
            //     req.QueryParams.Add("fields", fields);
            // }
            //
            // if (sinceId.HasValue)
            // {
            //     req.QueryParams.Add("since_id", sinceId);
            // }
            //
            // return await ExecuteRequestAsync<List<Charge>>(req, HttpMethod.Get, rootElement: "application_charges");
        }

        /// <summary>
        /// Activates a <see cref="Charge"/> that the shop owner has accepted.
        /// </summary>
        /// <param name="id">The id of the charge to activate.</param>
        public virtual async Task ActivateAsync(long id)
        {
            var req = PrepareRequest($"application_charges/{id}/activate.json");

            await ExecuteRequestAsync(req, HttpMethod.Post);
        }
    }
}
