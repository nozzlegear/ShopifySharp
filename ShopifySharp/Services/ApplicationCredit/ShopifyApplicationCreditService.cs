using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for offering credits for payments made via the Application Charge, Recurring Application Charge, and Usage Charge APIs.
    /// </summary>
    public class ShopifyApplicationCreditService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyApplicationCreditService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyApplicationCreditService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of all past and present application credits. 
        /// </summary>
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        public virtual async Task<IEnumerable<ShopifyApplicationCredit>> ListAsync(string fields = null)
        {
            var req = RequestEngine.CreateRequest($"application_credits.json", Method.GET, "application_credits");

            if (!string.IsNullOrEmpty(fields))
            {
                req.AddQueryParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyApplicationCredit>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the application credit with the given id.
        /// </summary>
        /// <param name="id">The application credit's id.</param>
        /// <param name="fields">A comma-separated list of fields to include in the response.</param>
        public virtual async Task<ShopifyApplicationCredit> GetAsync(long id, string fields = null)
        {
            var req = RequestEngine.CreateRequest($"application_credits/{id}.json", Method.GET, "application_credit");

            if (!string.IsNullOrEmpty(fields))
            {
                req.AddQueryParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyApplicationCredit>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ShopifyApplicationCredit"/>.
        /// </summary>
        /// <param name="credit">A new <see cref="ShopifyApplicationCredit"/>. Id should be set to null.</param>
        public virtual async Task<ShopifyApplicationCredit> CreateAsync(ShopifyApplicationCredit credit)
        {
            var req = RequestEngine.CreateRequest($"application_credits.json", Method.POST, "application_credit");

            req.AddJsonBody(new { application_credit = credit });

            return await RequestEngine.ExecuteRequestAsync<ShopifyApplicationCredit>(_RestClient, req);
        }        
    }
}
