using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp;

public interface IAssignedFulfillmentOrderService : IShopifyService
{
    /// <summary>
    /// <para>The AssignedFulfillmentOrder resource allows you to retrieve all the fulfillment orders that are assigned to an app at the shop level.
    /// The list of fulfillment orders can be filtered by location and assignment status such as cancellation_requested and fulfillment_requested.</para>
    /// <see href="https://shopify.dev/api/admin/rest/reference/shipping-and-fulfillment/assignedfulfillmentorder#index-2021-07 ">API Reference</see>
    /// </summary>
    /// <param name="filter">The filter object.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>Retrieves a list of fulfillment orders on a shop for a specific app.</returns>
    /// <exception cref="ShopifyException"></exception>
    Task<ListResult<AssignedFulfillmentOrder>> ListAsync(ListFilter<AssignedFulfillmentOrder> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// <para>The AssignedFulfillmentOrder resource allows you to retrieve all the fulfillment orders that are assigned to an app at the shop level.
    /// The list of fulfillment orders can be filtered by location and assignment status such as cancellation_requested and fulfillment_requested.</para>
    /// <see href="https://shopify.dev/api/admin/rest/reference/shipping-and-fulfillment/assignedfulfillmentorder#index-2021-07 ">API Reference</see>
    /// </summary>
    /// <param name="filter">The filter object.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>Retrieves a list of fulfillment orders on a shop for a specific app.</returns>
    /// <exception cref="ShopifyException"></exception>
    Task<ListResult<AssignedFulfillmentOrder>> ListAsync(AssignedFulfillmentOrderFilter filter = null, CancellationToken cancellationToken = default);
}