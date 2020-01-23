using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ShopifySharp.Filters;

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
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        public virtual async Task<IEnumerable<ApplicationCredit>> ListAsync(IListFilter filter)
        {
            throw new System.Exception("not yet implemented");
            // var req = PrepareRequest($"application_credits.json");
            //
            // if (!string.IsNullOrEmpty(fields))
            // {
            //     req.QueryParams.Add("fields", fields);
            // }
            //
            // return await ExecuteRequestAsync<List<ApplicationCredit>>(req, HttpMethod.Get, rootElement: "application_credits");
        }

        /// <summary>
        /// Retrieves the application credit with the given id.
        /// </summary>
        /// <param name="id">The application credit's id.</param>
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        public virtual async Task<ApplicationCredit> GetAsync(long id, string fields = null)
        {
            var req = PrepareRequest($"application_credits/{id}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<ApplicationCredit>(req, HttpMethod.Get, rootElement: "application_credit");
        }

        /// <summary>
        /// Creates a new <see cref="ApplicationCredit"/>.
        /// </summary>
        /// <param name="credit">A new <see cref="ApplicationCredit"/>. Id should be set to null.</param>
        public virtual async Task<ApplicationCredit> CreateAsync(ApplicationCredit credit)
        {
            var req = PrepareRequest($"application_credits.json");
            var body = new JsonContent(new
            {
                application_credit = credit,
            });

            return await ExecuteRequestAsync<ApplicationCredit>(req, HttpMethod.Post, body, "application_credit");
        }
    }
}
