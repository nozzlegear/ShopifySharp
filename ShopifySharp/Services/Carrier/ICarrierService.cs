using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public interface ICarrierService : IShopifyService
    {
        /// <summary>
        /// Retrieve a list of all carrier services that are associated with the store.
        /// </summary>
        Task<IEnumerable<Carrier>> ListAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="Carrier"/> Carrier
        /// </summary>
        /// <param name="carrier">A new <see cref="Carrier"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Carrier"/>.</returns>
        Task<Carrier> CreateAsync(Carrier carrier, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="Carrier"/> with the given id.
        /// </summary>
        /// <param name="carrierId">The id of the Carrier to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Carrier"/>.</returns>
        Task<Carrier> GetAsync(long carrierId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a Carruer with the given Id.
        /// </summary>
        /// <param name="carrierId">The Carrier's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long carrierId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the given <see cref="Carrier"/>.
        /// </summary>
        /// <param name="carrierId">Id of the Carrier being updated.</param>
        /// <param name="carrier">The <see cref="Carrier"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Carrier"/>.</returns>
        Task<Carrier> UpdateAsync(long carrierId, Carrier carrier, CancellationToken cancellationToken = default);
    }
}