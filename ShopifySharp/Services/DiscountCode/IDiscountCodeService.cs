using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IDiscountCodeService
    {
        /// <summary>
        /// Gets a list of up to 250 of the discount codes belonging to the price rule.
        /// </summary>
        Task<ListResult<PriceRuleDiscountCode>> ListAsync(long priceRuleId, ListFilter<PriceRuleDiscountCode> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the discount codes belonging to the price rule.
        /// </summary>
        Task<ListResult<PriceRuleDiscountCode>> ListAsync(long priceRuleId, PriceRuleDiscountCodeListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="PriceRuleDiscountCode"/> with the given id.
        /// </summary>
        /// <param name="priceRuleId">The id of the associated price rule.</param>
        /// <param name="discountId">The id of the discount to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="PriceRuleDiscountCode"/>.</returns>
        Task<PriceRuleDiscountCode> GetAsync(long priceRuleId, long discountId, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="PriceRuleDiscountCode"/> with the given code.
        /// </summary>
        /// <param name="filter">A filter with the code of the associated price rule.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="PriceRuleDiscountCode"/>.</returns>
        Task<PriceRuleDiscountCode> GetAsync(PriceRuleDiscountCodeFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="PriceRuleDiscountCode"/> with the given code.
        /// </summary>
        /// <param name="code">The code of the associated price rule.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="PriceRuleDiscountCode"/>.</returns>
        Task<PriceRuleDiscountCode> GetAsync(string code, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new discount code.
        /// </summary>
        /// <param name="priceRuleId">Id of an existing price rule.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<PriceRuleDiscountCode> CreateAsync(long priceRuleId, PriceRuleDiscountCode code, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the given object.
        /// </summary>
        /// <param name="priceRuleId">The Id of the Price Rule being updated.</param>
        /// <param name="code">The code being updated.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<PriceRuleDiscountCode> UpdateAsync(long priceRuleId, PriceRuleDiscountCode code, CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes the discount with the specified Id.
        /// </summary>
        /// /// <param name="priceRuleId">The price rule object's Id.</param>
        /// <param name="discountId">The discount object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long priceRuleId, long discountCodeId, CancellationToken cancellationToken = default);
    }
}