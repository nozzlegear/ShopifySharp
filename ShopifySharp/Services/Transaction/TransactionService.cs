using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify transactions.
    /// </summary>
    public class TransactionService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="TransactionService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public TransactionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's transactions.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        public virtual async Task<int> CountAsync(long orderId)
        {
            var req = PrepareRequest($"orders/{orderId}/transactions/count.json");

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's transactions.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="sinceId">Filters the results to after the specified id.</param>
        /// <returns>The list of transactions.</returns>
        [Obsolete("This ListAsync method targets a version of Shopify's API which will be deprecated and cease to function in April of 2020. ShopifySharp version 5.0 has been published with support for the newer list API. Make sure you update before April of 2020.")]
        public virtual async Task<IEnumerable<Transaction>> ListAsync(long orderId, long? sinceId = null, bool? inShopCurrency = null)
        {
            var req = PrepareRequest($"orders/{orderId}/transactions.json");

            if (sinceId.HasValue)
            {
                req.QueryParams.Add("since_id", sinceId.Value);
            }
            if (inShopCurrency.HasValue)
            {
                req.QueryParams.Add("in_shop_currency", inShopCurrency.Value);
            }

            return await ExecuteRequestAsync<List<Transaction>>(req, HttpMethod.Get, rootElement: "transactions");
        }

        /// <summary>
        /// Retrieves the <see cref="Transaction"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="transactionId">The id of the Transaction to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Transaction"/>.</returns>
        public virtual async Task<Transaction> GetAsync(long orderId, long transactionId, string fields = null, bool? inShopCurrency = null)
        {
            var req = PrepareRequest($"orders/{orderId}/transactions/{transactionId}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }
            if (inShopCurrency.HasValue)
            {
                req.QueryParams.Add("in_shop_currency", inShopCurrency.Value);
            }

            return await ExecuteRequestAsync<Transaction>(req, HttpMethod.Get, rootElement: "transaction");
        }

        /// <summary>
        /// Creates a new <see cref="Transaction"/> of the given kind.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns>The new <see cref="Transaction"/>.</returns>
        public virtual async Task<Transaction> CreateAsync(long orderId, Transaction transaction)
        {
            var req = PrepareRequest($"orders/{orderId}/transactions.json");
            var content = new JsonContent(new
            {
                transaction = transaction
            });

            return await ExecuteRequestAsync<Transaction>(req, HttpMethod.Post, content, "transaction");
        }
    }
}
