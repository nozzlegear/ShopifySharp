using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for offering credits for payments made via the Application Charge, Recurring Application Charge, and Usage Charge APIs.
    /// </summary>
    public class ApplicationCreditService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ApplicationCreditService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ApplicationCreditService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of all past and present application credits.
        /// </summary>
        public virtual async Task<ListResult<ApplicationCredit>> ListAsync(ListFilter<ApplicationCredit> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("application_credits.json", "application_credits", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of all past and present application credits.
        /// </summary>
        public virtual async Task<ListResult<ApplicationCredit>> ListAsync(ApplicationCreditListFilter filter, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the application credit with the given id.
        /// </summary>
        /// <param name="id">The application credit's id.</param>
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ApplicationCredit> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<ApplicationCredit>($"application_credits/{id}.json", "application_credit", fields, cancellationToken);
        }

        /// <summary>
        /// Creates a new <see cref="ApplicationCredit"/>.
        /// </summary>
        /// <param name="credit">A new <see cref="ApplicationCredit"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ApplicationCredit> CreateAsync(ApplicationCredit credit, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"application_credits.json");
            var body = new JsonContent(new
            {
                application_credit = credit,
            });

            var response = await ExecuteRequestAsync<ApplicationCredit>(req, HttpMethod.Post, cancellationToken, body, "application_credit");

            return response.Result;
        }
    }
}
