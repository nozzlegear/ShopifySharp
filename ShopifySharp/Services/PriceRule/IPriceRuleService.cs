using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp;

public interface IPriceRuleService : IShopifyService
{
    /// <summary>
    /// Gets a list of up to 250 of the shop's price rules.
    /// </summary>
    Task<ListResult<PriceRule>> ListAsync(ListFilter<PriceRule> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of up to 250 of the shop's price rules.
    /// </summary>
    Task<ListResult<PriceRule>> ListAsync(PriceRuleListFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the object with the given id.
    /// </summary>
    /// <param name="id">The id of the object to retrieve.</param>
    /// <param name="fields">A comma-separated list of fields to return.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<PriceRule> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new price rule.
    /// </summary>
    /// <param name="rule">A new price rule. Id should be set to null.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<PriceRule> CreateAsync(PriceRule rule, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the given object.
    /// </summary>
    /// <param name="id">Id of the object being updated.</param>
    /// <param name="rule">The updated rule.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<PriceRule> UpdateAsync(long id, PriceRule rule, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes the object with the given Id.
    /// </summary>
    /// <param name="id">The object's Id.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task DeleteAsync(long id, CancellationToken cancellationToken = default);
}