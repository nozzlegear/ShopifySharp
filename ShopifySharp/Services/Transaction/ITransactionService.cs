using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;

namespace ShopifySharp;

public interface ITransactionService : IShopifyService
{
    /// <summary>
    /// Gets a count of all of the shop's transactions.
    /// </summary>
    /// <param name="orderId">The order id to which the fulfillments belong.</param>
    /// <param name="cancellationToken">Task cancellation token.</param>
    /// <remarks>
    /// According to Shopify's documentation, this endpoint does not currently support any additional filter parameters for counting.
    /// </remarks>
    Task<int> CountAsync(long orderId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of up to 250 of the shop's transactions.
    /// </summary>
    /// <param name="orderId">The order id to which the fulfillments belong.</param>
    /// <param name="filter">Options for filtering the list.</param>
    /// <param name="includeCurrencyExchangeAdjustments">Whether currency exchange adjustments should be included.</param>
    /// <param name="cancellationToken">Task cancellation token</param>
    Task<IEnumerable<Transaction>> ListAsync(long orderId, TransactionListFilter filter = null, bool includeCurrencyExchangeAdjustments = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="Transaction"/> with the given id.
    /// </summary>
    /// <param name="orderId">The order id to which the fulfillments belong.</param>
    /// <param name="transactionId">The id of the Transaction to retrieve.</param>
    /// <param name="filter">Options for filtering the result.</param>
    /// <param name="includeCurrencyExchangeAdjustments">Whether currency exchange adjustments should be included.</param>
    /// <param name="cancellationToken">Task cancellation token</param>
    Task<Transaction> GetAsync(long orderId, long transactionId, TransactionGetFilter filter = null, bool includeCurrencyExchangeAdjustments = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new <see cref="Transaction"/> of the given kind.
    /// </summary>
    /// <param name="orderId">The order id to which the fulfillments belong.</param>
    /// <param name="transaction">The transaction.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The new <see cref="Transaction"/>.</returns>
    Task<Transaction> CreateAsync(long orderId, Transaction transaction, CancellationToken cancellationToken = default);
}