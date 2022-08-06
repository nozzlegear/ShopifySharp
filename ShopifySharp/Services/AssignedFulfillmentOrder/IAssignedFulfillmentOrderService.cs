using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public interface IAssignedFulfillmentOrderService
    {

        /// <summary>
        /// <para>The AssignedFulfillmentOrder resource allows you to retrieve all the fulfillment orders that are assigned to an app at the shop level.
        /// The list of fulfillment orders can be filtered by location and assignment status such as cancellation_requested and fulfillment_requested.</para>
        /// <see href="https://shopify.dev/api/admin/rest/reference/shipping-and-fulfillment/assignedfulfillmentorder#index-2021-07 ">API Reference</see>
        /// </summary>
        /// <returns>Retrieves a list of fulfillment orders on a shop for a specific app.</returns>
        /// <exception cref="ShopifyException"></exception>
        Task<IEnumerable<FulfillmentOrder>> ListAsync(AssignedFulfillmentOrderFilter filter, CancellationToken cancellationToken = default);
    }
}