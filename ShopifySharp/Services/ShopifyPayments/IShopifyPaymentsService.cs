using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IShopifyPaymentsService : IShopifyService
    {
        /// <summary>
        /// Checks whether the Shopify Payments API is enabled on this store.
        /// If not enabled, all Shopify Payments API endpoints will return HTTP 404 / Not Found
        /// </summary>
        Task<bool> IsShopifyPaymentApiEnabledAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a count of all of the shop's transactions.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        Task<IEnumerable<ShopifyPaymentsBalance>> GetBalanceAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of all payouts ordered by payout date, with the most recent being first.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<ShopifyPaymentsPayout>> ListPayoutsAsync(ListFilter<ShopifyPaymentsPayout> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of all payouts ordered by payout date, with the most recent being first.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<ShopifyPaymentsPayout>> ListPayoutsAsync(ShopifyPaymentsPayoutListFilter filter = null, CancellationToken cancellationToken = default);

        Task<ShopifyPaymentsPayout> GetPayoutAsync(long payoutId, CancellationToken cancellationToken = default);
        Task<ListResult<ShopifyPaymentsDispute>> ListDisputesAsync(ListFilter<ShopifyPaymentsDispute> filter, CancellationToken cancellationToken = default);
        Task<ListResult<ShopifyPaymentsDispute>> ListDisputesAsync(ShopifyPaymentsDisputeListFilter filter = null, CancellationToken cancellationToken = default);
        Task<ShopifyPaymentsDispute> GetDisputeAsync(long disputeId, CancellationToken cancellationToken = default);
        Task<ListResult<ShopifyPaymentsTransaction>> ListTransactionsAsync(ListFilter<ShopifyPaymentsTransaction> filter, CancellationToken cancellationToken = default);
        Task<ListResult<ShopifyPaymentsTransaction>> ListTransactionsAsync(ShopifyPaymentsTransactionListFilter filter = null, CancellationToken cancellationToken = default);
    }
}