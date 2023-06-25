using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IUserService : IShopifyService
    {
        /// <summary>
        /// Gets a list of up to 250 of the users.
        /// </summary>
        Task<ListResult<User>> ListAsync(ListFilter<User> filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the users.
        /// </summary>
        Task<ListResult<User>> ListAsync(UserListFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="User"/> with the given id.
        /// </summary>
        /// <param name="userId">The id of the User to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="User"/>.</returns>
        Task<User> GetAsync(long userId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the current logged-in <see cref="User"/> (useful only when the access token was created for a specific user of the shop).
        /// </summary>
        /// <returns>The <see cref="User"/>.</returns>
        Task<User> GetCurrentAsync(CancellationToken cancellationToken = default);
    }
}