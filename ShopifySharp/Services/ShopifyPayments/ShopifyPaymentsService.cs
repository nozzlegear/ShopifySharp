using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Filters;
using System.Net;
using System.Threading;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify payments.
    /// </summary>
    public class ShopifyPaymentsService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyPaymentsService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyPaymentsService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Checks whether the Shopify Payments API is enabled on this store.
        /// If not enabled, all Shopify Payments API endpoints will return HTTP 404 / Not Found
        /// </summary>
        public virtual async Task<bool> IsShopifyPaymentApiEnabledAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                //calling any method endpoint would do, but choosing GetBalance because it is likely the most lightweight
                await this.GetBalanceAsync(cancellationToken);
                return true;
            }
            catch (ShopifyException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                return false;
            }
        }

        /// <summary>
        /// Gets a count of all of the shop's transactions.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        public virtual async Task<IEnumerable<ShopifyPaymentsBalance>> GetBalanceAsync(CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<IEnumerable<ShopifyPaymentsBalance>>("shopify_payments/balance.json", "balance", cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// Retrieves a list of all payouts ordered by payout date, with the most recent being first.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<ShopifyPaymentsPayout>> ListPayoutsAsync(ListFilter<ShopifyPaymentsPayout> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("shopify_payments/payouts.json", "payouts", filter, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of all payouts ordered by payout date, with the most recent being first.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<ShopifyPaymentsPayout>> ListPayoutsAsync(ShopifyPaymentsPayoutListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListPayoutsAsync(filter?.AsListFilter(), cancellationToken);
        }
        
        public virtual async Task<ShopifyPaymentsPayout> GetPayoutAsync(long payoutId, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<ShopifyPaymentsPayout>($"shopify_payments/payouts/{payoutId}.json", "payout", cancellationToken: cancellationToken);
        }

        public virtual async Task<ListResult<ShopifyPaymentsDispute>> ListDisputesAsync(ListFilter<ShopifyPaymentsDispute> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("shopify_payments/disputes.json", "disputes", filter, cancellationToken: cancellationToken);
        }

        public virtual async Task<ListResult<ShopifyPaymentsDispute>> ListDisputesAsync(ShopifyPaymentsDisputeListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListDisputesAsync(filter?.AsListFilter(), cancellationToken);
        }

        public virtual async Task<ShopifyPaymentsDispute> GetDisputeAsync(long disputeId, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync< ShopifyPaymentsDispute>($"shopify_payments/disputes/{disputeId}.json", "dispute", cancellationToken: cancellationToken);
        }

        public virtual async Task<ListResult<ShopifyPaymentsTransaction>> ListTransactionsAsync(ListFilter<ShopifyPaymentsTransaction> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("shopify_payments/balance/transactions.json", "transactions", filter, cancellationToken: cancellationToken);
        }

        public virtual async Task<ListResult<ShopifyPaymentsTransaction>> ListTransactionsAsync(ShopifyPaymentsTransactionListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListTransactionsAsync(filter?.AsListFilter(), cancellationToken);
        }
    }
}
