using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading;
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
        public virtual async Task<Charge> CreateAsync(Charge charge, CancellationToken cancellationToken = default)
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
        public virtual async Task<Charge> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default)
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
        /// <param name="filter">Options for filtering the list.</param>
        public virtual async Task<IEnumerable<Charge>> ListAsync(ChargeListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync< IEnumerable < Charge >>("application_charges.json", "application_charges", filter);
        }

        /// <summary>
        /// Activates a <see cref="Charge"/> that the shop owner has accepted.
        /// </summary>
        /// <param name="id">The id of the charge to activate.</param>
        public virtual async Task ActivateAsync(long id, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"application_charges/{id}/activate.json");

            await ExecuteRequestAsync(req, HttpMethod.Post);
        }
    }
}
