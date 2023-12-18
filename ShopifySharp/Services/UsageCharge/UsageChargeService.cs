using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's UsageCharge API.
    /// </summary>
    public class UsageChargeService : ShopifyService, IUsageChargeService
    {
        /// <summary>
        /// Creates a new instance of <see cref="UsageChargeService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public UsageChargeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<UsageCharge> CreateAsync(long recurringChargeId, string description, decimal price, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"recurring_application_charges/{recurringChargeId}/usage_charges.json");
            var content = new JsonContent(new
            {
                usage_charge = new
                {
                    description = description,
                    price = price
                }
            });
            var response = await ExecuteRequestAsync<UsageCharge>(req, HttpMethod.Post, cancellationToken, content, "usage_charge");

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<UsageCharge> GetAsync(long recurringChargeId, long id, string fields = null, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"recurring_application_charges/{recurringChargeId}/usage_charges/{id}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<UsageCharge>(req, HttpMethod.Get, cancellationToken, rootElement: "usage_charge");

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<UsageCharge>> ListAsync(long recurringChargeId, UsageChargeListFilter filter = null, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"recurring_application_charges/{recurringChargeId}/usage_charges.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<UsageCharge>>(req, HttpMethod.Get, cancellationToken, rootElement: "usage_charges");

            return response.Result;
        }
    }
}