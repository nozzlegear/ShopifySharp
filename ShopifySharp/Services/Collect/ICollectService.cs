using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface ICollectService : IShopifyService
    {
        Task<int> CountAsync(CollectCountFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's collects.
        /// </summary>
        Task<ListResult<Collect>> ListAsync(ListFilter<Collect> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's collects.
        /// </summary>
        Task<ListResult<Collect>> ListAsync(CollectListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="Collect"/> with the given id.
        /// </summary>
        /// <param name="collectId">The id of the collect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Collect"/>.</returns>
        Task<Collect> GetAsync(long collectId, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="Collect"/> on the store. Map product to collection
        /// </summary>
        /// <param name="collect">A new <see cref="Collect"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Collect"/>.</returns>
        Task<Collect> CreateAsync(Collect collect, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a collect with the given Id.
        /// </summary>
        /// <param name="collectId">The product object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long collectId, CancellationToken cancellationToken = default);
    }
}