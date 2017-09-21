using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify users.
    /// </summary>
    public class UserService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="UserService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public UserService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Gets all the users
        /// </summary>
        /// <returns>The list of all users.</returns>
        public virtual async Task<IEnumerable<User>> ListAsync()
        {
            var req = PrepareRequest("users.json");

            return await ExecuteRequestAsync<List<User>>(req, HttpMethod.Get, rootElement: "users");
        }

        /// <summary>
        /// Retrieves the <see cref="User"/> with the given id.
        /// </summary>
        /// <param name="userId">The id of the User to retrieve.</param>
        /// <returns>The <see cref="User"/>.</returns>
        public virtual async Task<User> GetAsync(long userId)
        {
            var req = PrepareRequest($"users/{userId}.json");
            
            return await ExecuteRequestAsync<User>(req, HttpMethod.Get, rootElement: "user");
        }

        /// <summary>
        /// Retrieves the current logged-in <see cref="User"/> (useful only when the access token was created for a specific user of the shop).
        /// </summary>
        /// <returns>The <see cref="User"/>.</returns>
        public virtual async Task<User> GetCurrentAsync()
        {
            var req = PrepareRequest("users/current.json");

            return await ExecuteRequestAsync<User>(req, HttpMethod.Get, rootElement: "user");
        }
    }
}