using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
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
        /// Gets all the users.
        /// </summary>
        public virtual async Task<IEnumerable<User>> ListAsync(CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<IEnumerable<User>>("users.json", "users", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="User"/> with the given id.
        /// </summary>
        /// <param name="userId">The id of the User to retrieve.</param>
        /// <returns>The <see cref="User"/>.</returns>
        public virtual async Task<User> GetAsync(long userId, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<User>($"users/{userId}.json", "user", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Retrieves the current logged-in <see cref="User"/> (useful only when the access token was created for a specific user of the shop).
        /// </summary>
        /// <returns>The <see cref="User"/>.</returns>
        public virtual async Task<User> GetCurrentAsync(CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<User>("users/current.json", "user", cancellationToken: cancellationToken);
        }
    }
}
