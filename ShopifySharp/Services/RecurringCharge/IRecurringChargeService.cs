using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;

namespace ShopifySharp
{
    public interface IRecurringChargeService : IShopifyService
    {
        /// <summary>
        /// Creates a <see cref="RecurringCharge"/>.
        /// </summary>
        /// <param name="charge">The <see cref="RecurringCharge"/> to create.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="RecurringCharge"/>.</returns>
        Task<RecurringCharge> CreateAsync(RecurringCharge charge, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="RecurringCharge"/> with the given id.
        /// </summary>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="RecurringCharge"/>.</returns>
        Task<RecurringCharge> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of all past and present <see cref="RecurringCharge"/> objects.
        /// </summary>
        Task<IEnumerable<RecurringCharge>> ListAsync(RecurringChargeListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a <see cref="RecurringCharge"/>.
        /// </summary>
        /// <param name="id">The id of the charge to delete.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long id, CancellationToken cancellationToken = default);
    }
}