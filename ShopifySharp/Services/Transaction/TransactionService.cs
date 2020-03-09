using System.Net.Http;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
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
        /// <remarks>
        /// According to Shopify's documentation, this endpoint does not currently support any additional filter parameters for counting.
        /// </remarks>
        public virtual async Task<int> CountAsync(long orderId, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>($"orders/{orderId}/transactions/count.json", "count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's transactions.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the list.</param>
        public virtual async Task<IEnumerable<Transaction>> ListAsync(long orderId, TransactionListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<IEnumerable<Transaction>>($"orders/{orderId}/transactions.json", "transactions", filter);
        }

        /// <summary>
        /// Retrieves the <see cref="Transaction"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="transactionId">The id of the Transaction to retrieve.</param>
        /// <param name="filter">Options for filtering the result.</param>
        public virtual async Task<Transaction> GetAsync(long orderId, long transactionId, TransactionGetFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Transaction>($"orders/{orderId}/transactions/{transactionId}.json", "transaction", filter);
        }

        /// <summary>
        /// Creates a new <see cref="Transaction"/> of the given kind.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns>The new <see cref="Transaction"/>.</returns>
        public virtual async Task<Transaction> CreateAsync(long orderId, Transaction transaction, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/transactions.json");
            var content = new JsonContent(new
            {
                transaction = transaction
            });
            var response = await ExecuteRequestAsync<Transaction>(req, HttpMethod.Post, content, "transaction");

            return response.Result;
        }
    }
}
