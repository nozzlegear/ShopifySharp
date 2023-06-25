using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface ILocationService : IShopifyService
    {
        /// <summary>
        /// Retrieves the <see cref="Location"/> with the given id.
        /// </summary>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Location"/>.</returns>
        Task<Location> GetAsync(long id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the locations.
        /// </summary>
        Task<ListResult<Location>> ListAsync(ListFilter<Location> filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the locations.
        /// </summary>
        Task<ListResult<Location>> ListAsync(LocationListFilter filter, CancellationToken cancellationToken = default);
    }
}