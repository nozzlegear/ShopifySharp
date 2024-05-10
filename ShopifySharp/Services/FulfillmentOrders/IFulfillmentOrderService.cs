using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp;

public interface IFulfillmentOrderService : IShopifyService
{
    /// <summary>
    /// Cancel a fulfillment order with the given id.
    /// </summary>
    /// <param name="fulfillmentOrderId">The fulfillment order to which the fulfillment orders belong.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<FulfillmentOrder> CancelAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Marks an in progress fulfillment order as incomplete, indicating the fulfillment service is unable to ship any remaining items and intends to close the fulfillment order.
    /// </summary>
    /// <param name="fulfillmentOrderId">The fulfillment order id.</param>
    /// <param name="message">Close reason.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<FulfillmentOrder> CloseAsync(long fulfillmentOrderId, string message, CancellationToken cancellationToken = default);

    /// <summary>
    /// Halts all fulfillment work on a fulfillment order with status OPEN and changes the status of the fulfillment order to ON_HOLD.
    /// </summary>
    /// <param name="fulfillmentOrderId">The fulfillment order id.</param>
    /// <param name="fulfillmentHold">The fulfillment hold.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<FulfillmentOrder> HoldAsync(long fulfillmentOrderId, FulfillmentHold fulfillmentHold, CancellationToken cancellationToken = default);

    /// <summary>
    /// Moves a fulfillment order from one merchant managed location to another merchant managed location.
    /// </summary>
    /// <param name="fulfillmentOrderId">The fulfillment order id.</param>
    /// <param name="newLocationId">The new fulfillment order location.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<FulfillmentOrderMove> MoveAsync(long fulfillmentOrderId, long newLocationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Marks a scheduled fulfillment order as ready for fulfillment.
    /// </summary>
    /// <param name="fulfillmentOrderId">The fulfillment order to which the fulfillment orders belong.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<FulfillmentOrder> OpenAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Release the fulfillment hold on a fulfillment order and changes the status of the fulfillment order to OPEN or SCHEDULED
    /// </summary>
    /// <param name="fulfillmentOrderId">The fulfillment order to which the fulfillment orders belong.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<FulfillmentOrder> ReleaseHoldAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the fulfill_at time of a scheduled fulfillment order. This endpoint is used to manage the time a scheduled fulfillment order will be marked as ready for fulfillment.
    /// </summary>
    /// <param name="fulfillmentOrderId">The fulfillment order id.</param>
    /// <param name="newFulfillAt">The new fulfill date.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<FulfillmentOrder> RescheduleAsync(long fulfillmentOrderId, DateTimeOffset newFulfillAt, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a fulfillment order with the given id.
    /// </summary>
    /// <param name="fulfillmentOrderId">The fulfillment order to which the fulfillment orders belong.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<FulfillmentOrder> GetAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of up to 250 of the order's fulfillment orders.
    /// </summary>
    /// <param name="orderId">The order id to which the fulfillment orders belong.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<IEnumerable<FulfillmentOrder>> ListAsync(long orderId, CancellationToken cancellationToken = default);
}