using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

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
        [Obsolete("This ListAsync method targets a version of Shopify's API which will be deprecated and cease to function in April of 2020. ShopifySharp version 5.0 will be published soon with support for the newer list API. Make sure you update before April of 2020.")]
        public virtual async Task<IEnumerable<OrderRisk>> ListAsync(long orderId)
        {
            var req = PrepareRequest($"orders/{orderId}/risks.json");
            
            return await ExecuteRequestAsync<List<OrderRisk>>(req, HttpMethod.Get, rootElement: "risks");
        }
        
        /// <summary>
        /// Retrieves the <see cref="OrderRisk"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="riskId">The id of the risk to retrieve.</param>
        public virtual async Task<OrderRisk> GetAsync(long orderId, long riskId)
        {
            var req = PrepareRequest($"orders/{orderId}/risks/{riskId}.json");
            
            return await ExecuteRequestAsync<OrderRisk>(req, HttpMethod.Get, rootElement: "risk");
        }
        
        /// <summary>
        /// Creates a new <see cref="OrderRisk"/> on the order.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="risk">A new <see cref="OrderRisk"/>. Id should be set to null.</param>
        public virtual async Task<OrderRisk> CreateAsync(long orderId, OrderRisk risk)
        {
            var req = PrepareRequest($"orders/{orderId}/risks.json");
            var content = new JsonContent(new
            {
                risk = risk
            });
            
            return await ExecuteRequestAsync<OrderRisk>(req, HttpMethod.Post, content, "risk");
        }

        /// <summary>
        /// Updates the given <see cref="OrderRisk"/>.
        /// </summary>
        /// <param name="orderRiskId">Id of the object being updated.</param>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="risk">The risk to update.</param>
        public virtual async Task<OrderRisk> UpdateAsync(long orderId, long orderRiskId, OrderRisk risk)
        {
            var req = PrepareRequest($"orders/{orderId}/risks/{orderRiskId}.json");
            var content = new JsonContent(new
            {
                risk = risk
            });

            return await ExecuteRequestAsync<OrderRisk>(req, HttpMethod.Put, content, "risk");
        }

        /// <summary>
        /// Deletes an order with the given Id.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="riskId">The risk's id.</param>
        public virtual async Task DeleteAsync(long orderId, long riskId)
        {
            var req = PrepareRequest($"orders/{orderId}/risks/{riskId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
