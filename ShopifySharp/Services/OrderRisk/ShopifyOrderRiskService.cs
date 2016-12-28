using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify order risks.
    /// </summary>
    public class ShopifyOrderRiskService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyOrderRiskService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyOrderRiskService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of all order risks for an order.
        /// </summary>
        /// <param name="orderId">The order the risks belong to.</param>
        public virtual async Task<IEnumerable<ShopifyOrderRisk>> ListAsync(long orderId)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/risks.json", Method.GET, "risks");
            
            return await RequestEngine.ExecuteRequestAsync<List<ShopifyOrderRisk>>(_RestClient, req);
        }
        
        /// <summary>
        /// Retrieves the <see cref="ShopifyOrderRisk"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="riskId">The id of the risk to retrieve.</param>
        public virtual async Task<ShopifyOrderRisk> GetAsync(long orderId, long riskId)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/risks/{riskId}.json", Method.GET, "risk");
            
            return await RequestEngine.ExecuteRequestAsync<ShopifyOrderRisk>(_RestClient, req);
        }
        
        /// <summary>
        /// Creates a new <see cref="ShopifyOrderRisk"/> on the order.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="risk">A new <see cref="ShopifyOrderRisk"/>. Id should be set to null.</param>
        public virtual async Task<ShopifyOrderRisk> CreateAsync(long orderId, ShopifyOrderRisk risk)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/risks.json", Method.POST, "risk");

            req.AddJsonBody(new { risk });
            
            return await RequestEngine.ExecuteRequestAsync<ShopifyOrderRisk>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifyOrderRisk"/>. Id must not be null.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="risk">The risk to update.</param>
        public virtual async Task<ShopifyOrderRisk> UpdateAsync(long orderId, ShopifyOrderRisk risk)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/risks/{risk.Id.Value}.json", Method.PUT, "risk");

            req.AddJsonBody(new { risk });

            return await RequestEngine.ExecuteRequestAsync<ShopifyOrderRisk>(_RestClient, req);
        }

        /// <summary>
        /// Deletes an order with the given Id.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="riskId">The risk's id.</param>
        public virtual async Task DeleteAsync(long orderId, long riskId)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/risks/{riskId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }
    }
}
