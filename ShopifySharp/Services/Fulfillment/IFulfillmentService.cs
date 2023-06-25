using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IFulfillmentService
    {
        /// <summary>
        /// Gets a count of all of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the count.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        Task<int> CountAsync(long orderId, FulfillmentCountFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<Fulfillment>> ListAsync(long orderId, ListFilter<Fulfillment> filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<Fulfillment>> ListAsync(long orderId, FulfillmentListFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of the fulfillment order's fulfillments.
        /// </summary>
        /// <param name="fulfillmentOrderId">The fulfillment order id to which the fulfillments belong.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<Fulfillment>> ListForFulfillmentOrderAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="Fulfillment"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The id of the Fulfillment to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Fulfillment"/>.</returns>
        Task<Fulfillment> GetAsync(long orderId, long fulfillmentId, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a fulfillment for one or many fulfillment orders.
        /// </summary>
        /// <param name="fulfillment">An object containing fulfillment order and tracking data.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Fulfillment"/>.</returns>
        Task<Fulfillment> CreateAsync(FulfillmentShipping fulfillment, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates tracking for the given <see cref="Fulfillment"/>.
        /// </summary>
        /// <param name="fulfillmentId">Id of the object being updated.</param>
        /// <param name="fulfillment">The <see cref="Fulfillment"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Fulfillment"/>.</returns>
        Task<Fulfillment> UpdateTrackingAsync(long fulfillmentId, FulfillmentShipping fulfillment, CancellationToken cancellationToken = default);
    }
}