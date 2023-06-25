using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's ApplicationCharge API.
    /// </summary>
    public class ChargeService : ShopifyService, IChargeService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ChargeService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ChargeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<Charge> CreateAsync(Charge charge, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("application_charges.json");
            var content = new JsonContent(new { application_charge = charge });

            var response = await ExecuteRequestAsync<Charge>(req, HttpMethod.Post, cancellationToken, content, "application_charge");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Charge> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"application_charges/{id}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<Charge>(req, HttpMethod.Get, cancellationToken, rootElement: "application_charge");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<Charge>> ListAsync(ChargeListFilter filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync< IEnumerable < Charge >>("application_charges.json", "application_charges", filter, cancellationToken);
    }
}
