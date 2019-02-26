using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Filters;

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
        /// Gets a count of all of the shop's transactions.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        public virtual async Task<IEnumerable<ShopifyPaymentsBalance>> GetBalanceAsync()
        {
            var req = PrepareRequest($"shopify_payments/balance.json");

            return await ExecuteRequestAsync<List<ShopifyPaymentsBalance>>(req, HttpMethod.Get, rootElement: "balance");
        }

        public virtual async Task<IEnumerable<ShopifyPaymentsPayout>> ListPayoutsAsync(ShopifyPaymentsPayoutFilter options = null)
        {
            var req = PrepareRequest("shopify_payments/payouts.json");

            if (options != null)
            {
                req.QueryParams.AddRange(options.ToParameters());
            }

            return await ExecuteRequestAsync<List<ShopifyPaymentsPayout>>(req, HttpMethod.Get, rootElement: "payouts");
        }

        public virtual async Task<ShopifyPaymentsPayout> GetPayoutAsync(long payoutId)
        {
            var req = PrepareRequest($"shopify_payments/payouts/{payoutId}.json");
            return await ExecuteRequestAsync<ShopifyPaymentsPayout>(req, HttpMethod.Get, rootElement: "payout");
        }

        public virtual async Task<IEnumerable<ShopifyPaymentsDispute>> ListDisputesAsync(ShopifyPaymentsDisputeFilter options = null)
        {
            var req = PrepareRequest("shopify_payments/disputes.json");

            if (options != null)
            {
                req.QueryParams.AddRange(options.ToParameters());
            }

            return await ExecuteRequestAsync<List<ShopifyPaymentsDispute>>(req, HttpMethod.Get, rootElement: "disputes");
        }

        public virtual async Task<ShopifyPaymentsDispute> GetDisputeAsync(long disputeId)
        {
            var req = PrepareRequest($"shopify_payments/disputes/{disputeId}.json");
            return await ExecuteRequestAsync<ShopifyPaymentsDispute>(req, HttpMethod.Get, rootElement: "dispute");
        }

        public virtual async Task<IEnumerable<ShopifyPaymentsTransaction>> ListTransactionsAsync(ShopifyPaymentsTransactionFilter options = null)
        {
            var req = PrepareRequest("shopify_payments/balance/transactions.json");

            if (options != null)
            {
                req.QueryParams.AddRange(options.ToParameters());
            }

            return await ExecuteRequestAsync<List<ShopifyPaymentsTransaction>>(req, HttpMethod.Get, rootElement: "transactions");
        }
    }
}
