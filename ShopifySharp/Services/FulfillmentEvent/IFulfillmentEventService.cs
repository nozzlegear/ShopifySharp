using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public interface IFulfillmentEventService
    {
        /// <summary>
        /// Get a list of all fulfillment events for a fulfillment
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillment belongs to.</param>
        /// <param name="fulfillmentId">The fulfillment id to which the fulfillment events belong to.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The list of fulfillment events for the given fulfillment.</returns>
        Task<IEnumerable<FulfillmentEvent>> ListAsync(long orderId, long fulfillmentId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="FulfillmentEvent"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillment belongs to.</param>
        /// <param name="fulfillmentId">The id of the fulfillment to which the event belongs to.</param>
        /// <param name="fulfillmentEventId">The id of the fulfillment event to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="FulfillmentEvent"/>.</returns>
        Task<FulfillmentEvent> GetAsync(long orderId, long fulfillmentId, long fulfillmentEventId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="FulfillmentEvent"/> on the fulfillment.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillment belongs to.</param>
        /// <param name="fulfillmentId">The id of the fulfillment to which the event belongs to.</param>
        /// <param name="event">A new <see cref="Fulfillment"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="FulfillmentEvent"/>.</returns>
        Task<FulfillmentEvent> CreateAsync(long orderId, long fulfillmentId, FulfillmentEvent @event, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the <see cref="FulfillmentEvent"/> with the given Id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillment belongs to.</param>
        /// <param name="fulfillmentId">The id of the fulfillment to which the event belongs to.</param>
        /// <param name="fulfillmentEventId">The id of the fulfillment event to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long orderId, long fulfillmentId, long fulfillmentEventId, CancellationToken cancellationToken = default);
    }
}