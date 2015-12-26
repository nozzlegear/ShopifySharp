using RestSharp;
using ShopifySharp.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify transactions.
    /// </summary>
    public class ShopifyTransactionService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyTransactionService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyTransactionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's transactions.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        public async Task<int> CountAsync(long orderId)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/transactions/count.json", Method.GET);
            var responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's transactions.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="sinceId">Filters the results to after the specified id.</param>
        /// <returns>The list of transactions.</returns>
        public async Task<IEnumerable<ShopifyTransaction>> ListAsync(long orderId, long? sinceId = null)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/transactions.json", Method.GET, "transactions");

            //Add optional parameters to request
            if (sinceId != null)
            {
                req.Parameters.Add(new Parameter()
                {
                    Name = "since_id",
                    Value = sinceId,
                    Type = ParameterType.GetOrPost
                });
            }

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyTransaction>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyTransaction"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="transactionId">The id of the Transaction to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyTransaction"/>.</returns>
        public async Task<ShopifyTransaction> GetAsync(long orderId, long transactionId, string fields = null)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/transactions/{transactionId}.json", Method.GET, "transaction");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyTransaction>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ShopifyTransaction"/> of the given kind.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns>The new <see cref="ShopifyTransaction"/>.</returns>
        public async Task<ShopifyTransaction> CreateAsync(long orderId, ShopifyTransaction transaction)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/transactions.json", Method.POST, "transaction");

            req.AddJsonBody(new { transaction = transaction });

            return await RequestEngine.ExecuteRequestAsync<ShopifyTransaction>(_RestClient, req);
        }
    }
}
