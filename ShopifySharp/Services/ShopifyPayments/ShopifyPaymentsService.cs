using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Filters;
using System.Net;
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
        public virtual async Task<bool> IsShopifyPaymentAPIEnabled()
        {
            try
            {
                //calling any method endpoint would do, but choosing GetBalance because it is likely the most lightweight
                await this.GetBalanceAsync();
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
        /// <returns>The count of all fulfillments for the shop.</returns>
        public virtual async Task<IEnumerable<ShopifyPaymentsBalance>> GetBalanceAsync()
        {
            var req = PrepareRequest($"shopify_payments/balance.json");
            var response = await ExecuteRequestAsync<List<ShopifyPaymentsBalance>>(req, HttpMethod.Get, rootElement: "balance");

            return response.Result;
        }

        public virtual async Task<IEnumerable<ShopifyPaymentsPayout>> ListPayoutsAsync(ShopifyPaymentsPayoutFilter options = null)
        {
            throw new NotImplementedException();
            // var req = PrepareRequest("shopify_payments/payouts.json");
            //
            // if (options != null)
            // {
            //     req.QueryParams.AddRange(options.ToParameters());
            // }
            //
            // return await ExecuteRequestAsync<List<ShopifyPaymentsPayout>>(req, HttpMethod.Get, rootElement: "payouts");
        }

        public virtual async Task<ShopifyPaymentsPayout> GetPayoutAsync(long payoutId)
        {
            var req = PrepareRequest($"shopify_payments/payouts/{payoutId}.json");
            var response = await ExecuteRequestAsync<ShopifyPaymentsPayout>(req, HttpMethod.Get, rootElement: "payout");

            return response.Result;
        }

        public virtual async Task<IListResult<ShopifyPaymentsDispute>> ListDisputesAsync(IListFilter<ShopifyPaymentsDispute> filter)
        {
            var req = PrepareRequest("shopify_payments/disputes.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<ShopifyPaymentsDispute>>(req, HttpMethod.Get, rootElement: "disputes");

            return ParseLinkHeaderToListResult(response);
        }

        public virtual async Task<IListResult<ShopifyPaymentsDispute>> ListDisputesAsync(ShopifyPaymentsDisputeListFilter filter)
        {
            return await ListDisputesAsync((IListFilter<ShopifyPaymentsDispute>) filter);
        }

        public virtual async Task<ShopifyPaymentsDispute> GetDisputeAsync(long disputeId)
        {
            var req = PrepareRequest($"shopify_payments/disputes/{disputeId}.json");
            var response = await ExecuteRequestAsync<ShopifyPaymentsDispute>(req, HttpMethod.Get, rootElement: "dispute");

            return response.Result;
        }

        public virtual async Task<IListResult<ShopifyPaymentsTransaction>> ListTransactionsAsync(IListFilter<ShopifyPaymentsTransaction> filter)
        {
            var req = PrepareRequest("shopify_payments/balance/transactions.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<ShopifyPaymentsTransaction>>(req, HttpMethod.Get, rootElement: "transactions");

            return ParseLinkHeaderToListResult(response);
        }

        public virtual async Task<IListResult<ShopifyPaymentsTransaction>> ListTransactionsAsync(ShopifyPaymentsTransactionListFilter filter)
        {
            return await ListTransactionsAsync((IListFilter<ShopifyPaymentsTransaction>) filter);
        }
    }
}
