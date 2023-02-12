using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// The CancellationRequest resource represents a cancellation request made by the merchant or an order management app to a fulfillment service for a fulfillment order.
    /// <see href="https://shopify.dev/docs/api/admin-rest/2022-07/resources/cancellationrequest">API Reference</see>
    /// </summary>
    public interface ICancellationRequestService
    {
        /// <summary>
        /// Sends a cancellation request to the fulfillment service of a fulfillment order.
        /// <see href="https://shopify.dev/docs/api/admin-rest/2022-07/resources/cancellationrequest#post-fulfillment-orders-fulfillment-order-id-cancellation-request">API Reference</see>
        /// </summary>
        /// <param name="fulfillmentOrderId"></param>
        /// <param name="message">An optional reason for the cancellation request</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <exception cref="ShopifyException"></exception>
        Task<FulfillmentOrder> CreateAsync(long fulfillmentOrderId, string message, CancellationToken cancellationToken = default);

        /// <summary>
        /// Accepts a cancellation request sent to a fulfillment service for a fulfillment order.
        /// <see href="https://shopify.dev/docs/api/admin-rest/2022-07/resources/cancellationrequest#post-fulfillment-orders-fulfillment-order-id-cancellation-request-accept">API Reference</see>
        /// </summary>
        /// <param name="fulfillmentOrderId"></param>
        /// <param name="message">An optional reason for accepting the cancellation request</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <exception cref="ShopifyException"></exception>
        Task<FulfillmentOrder> AcceptAsync(long fulfillmentOrderId, string message, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rejects a cancellation request sent to a fulfillment service for a fulfillment order.
        /// <see href="https://shopify.dev/docs/api/admin-rest/2022-07/resources/cancellationrequest#post-fulfillment-orders-fulfillment-order-id-cancellation-request-reject">API Reference</see>
        /// </summary>
        /// <param name="fulfillmentOrderId"></param>
        /// <param name="message">An optional reason for rejecting the cancellation request</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <exception cref="ShopifyException"></exception>
        Task<FulfillmentOrder> RejectAsync(long fulfillmentOrderId, string message, CancellationToken cancellationToken = default);
    }
}