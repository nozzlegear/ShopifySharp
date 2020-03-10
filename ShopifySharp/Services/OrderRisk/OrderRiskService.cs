using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify order risks.
    /// </summary>
    public class OrderRiskService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="OrderRiskService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public OrderRiskService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of all order risks for an order.
        /// </summary>
        /// <param name="orderId">The order the risks belong to.</param>
        /// <param name="filter">Options for filtering the request.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<OrderRisk>> ListAsync(long orderId, ListFilter<OrderRisk> filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync($"orders/{orderId}/risks.json", "risks", filter, cancellationToken);
        }
        
        /// <summary>
        /// Retrieves the <see cref="OrderRisk"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="riskId">The id of the risk to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<OrderRisk> GetAsync(long orderId, long riskId, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<OrderRisk>($"orders/{orderId}/risks/{riskId}.json", "risk", cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// Creates a new <see cref="OrderRisk"/> on the order.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="risk">A new <see cref="OrderRisk"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<OrderRisk> CreateAsync(long orderId, OrderRisk risk, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/risks.json");
            var content = new JsonContent(new
            {
                risk = risk
            });
            var response = await ExecuteRequestAsync<OrderRisk>(req, HttpMethod.Post, cancellationToken, content, "risk");

            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="OrderRisk"/>.
        /// </summary>
        /// <param name="orderRiskId">Id of the object being updated.</param>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="risk">The risk to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<OrderRisk> UpdateAsync(long orderId, long orderRiskId, OrderRisk risk, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/risks/{orderRiskId}.json");
            var content = new JsonContent(new
            {
                risk = risk
            });

            var response = await ExecuteRequestAsync<OrderRisk>(req, HttpMethod.Put, cancellationToken, content, "risk");
            return response.Result;
        }

        /// <summary>
        /// Deletes an order with the given Id.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="riskId">The risk's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long orderId, long riskId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/risks/{riskId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}
