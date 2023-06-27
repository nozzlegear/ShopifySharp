using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify order risks.
    /// </summary>
    public class OrderRiskService : ShopifyService, IOrderRiskService
    {
        /// <summary>
        /// Creates a new instance of <see cref="OrderRiskService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public OrderRiskService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<ListResult<OrderRisk>> ListAsync(long orderId, ListFilter<OrderRisk> filter = null, CancellationToken cancellationToken = default) => await ExecuteGetListAsync($"orders/{orderId}/risks.json", "risks", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<OrderRisk> GetAsync(long orderId, long riskId, CancellationToken cancellationToken = default) => await ExecuteGetAsync<OrderRisk>($"orders/{orderId}/risks/{riskId}.json", "risk", cancellationToken: cancellationToken);

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <inheritdoc />
        public virtual async Task DeleteAsync(long orderId, long riskId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/risks/{riskId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}