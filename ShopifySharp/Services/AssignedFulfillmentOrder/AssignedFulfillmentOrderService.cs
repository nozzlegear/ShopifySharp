using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    public class AssignedFulfillmentOrderService : ShopifyService, IAssignedFulfillmentOrderService
    {
        /// <summary>
        /// Creates a new instance of <see cref="AssignedFulfillmentOrderService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public AssignedFulfillmentOrderService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        public virtual async Task<IEnumerable<FulfillmentOrder>> ListAsync(AssignedFulfillmentOrderFilter filter, CancellationToken cancellationToken = default) =>
			await ExecuteGetAsync<List<FulfillmentOrder>>("assigned_fulfillment_orders.json", "fulfillment_orders", filter, cancellationToken);
    }
}
