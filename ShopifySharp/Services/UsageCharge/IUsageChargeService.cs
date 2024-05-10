using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;

namespace ShopifySharp;

public interface IUsageChargeService : IShopifyService
{
    /// <summary>
    /// Creates a <see cref="UsageCharge"/>.
    /// </summary>
    /// <param name="recurringChargeId">The id of the <see cref="UsageCharge"/> that this usage charge belongs to.</param>
    /// <param name="description">The name or description of the usage charge.</param>
    /// <param name="price">The price of the usage charge.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The new <see cref="UsageCharge"/>.</returns>
    Task<UsageCharge> CreateAsync(long recurringChargeId, string description, decimal price, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="UsageCharge"/> with the given id.
    /// </summary>
    /// <param name="recurringChargeId">The id of the recurring charge that this usage charge belongs to.</param>
    /// <param name="id">The id of the charge to retrieve.</param>
    /// <param name="fields">A comma-separated list of fields to return.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The <see cref="UsageCharge"/>.</returns>
    Task<UsageCharge> GetAsync(long recurringChargeId, long id, string fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a list of all past and present <see cref="UsageCharge"/> objects.
    /// </summary>
    /// <param name="recurringChargeId">The id of the recurring charge that these usage charges belong to.</param>
    /// <param name="filter">Options for filtering the list.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<IEnumerable<UsageCharge>> ListAsync(long recurringChargeId, UsageChargeListFilter filter = null, CancellationToken cancellationToken = default);
}