using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;

namespace ShopifySharp
{
    public interface IChargeService : IShopifyService
    {
        /// <summary>
        /// Creates a <see cref="Charge"/>.
        /// </summary>
        /// <param name="charge">The <see cref="Charge"/> to create.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Charge"/>.</returns>
        Task<Charge> CreateAsync(Charge charge, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="Charge"/> with the given id.
        /// </summary>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Charge"/>.</returns>
        Task<Charge> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of all past and present <see cref="Charge"/> objects.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<IEnumerable<Charge>> ListAsync(ChargeListFilter filter = null, CancellationToken cancellationToken = default);
    }
}