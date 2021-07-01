using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading.Tasks;

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
        /// Gets a list of up to 250 of the users.
        /// </summary>
        public virtual async Task<ListResult<User>> ListAsync(ListFilter<User> filter = null)
        {
            return await ExecuteGetListAsync("users.json", "users", filter);
        }

        /// <summary>
        /// Gets a list of up to 250 of the users.
        /// </summary>
        public virtual async Task<ListResult<User>> ListAsync(UserListFilter filter)
        {
            return await ListAsync(filter?.AsListFilter());
        }

        /// <summary>
        /// Retrieves the <see cref="User"/> with the given id.
        /// </summary>
        /// <param name="userId">The id of the User to retrieve.</param>
        /// <returns>The <see cref="User"/>.</returns>
        public virtual async Task<User> GetAsync(long userId)
        {
            return await ExecuteGetAsync<User>($"users/{userId}.json", "user");
        }

        /// <summary>
        /// Retrieves the current logged-in <see cref="User"/> (useful only when the access token was created for a specific user of the shop).
        /// </summary>
        /// <returns>The <see cref="User"/>.</returns>
        public virtual async Task<User> GetCurrentAsync()
        {
            return await ExecuteGetAsync<User>("users/current.json", "user");
        }
    }
}
