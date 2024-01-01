using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// The FulfillmentRequest resource represents a fulfillment request made by the merchant to a fulfillment service for a fulfillment order.
    /// <see href="https://shopify.dev/docs/api/admin-rest/2022-07/resources/fulfillmentrequest">API Reference</see>
    /// </summary>
    public interface IFulfillmentRequestService : IShopifyService
    {
        /// <summary>
        /// Accepts a fulfillment request sent to a fulfillment service for a fulfillment order.
        /// <see href="https://shopify.dev/docs/api/admin-rest/2022-07/resources/fulfillmentrequest#post-fulfillment-orders-fulfillment-order-id-fulfillment-request-accept">API Reference</see>
        /// </summary>
        /// <param name="fulfillmentOrderId"></param>
        /// <param name="message">An optional reason for accepting the fulfillment request</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <exception cref="ShopifyException"></exception>
        Task<FulfillmentOrder> AcceptAsync(long fulfillmentOrderId, string message, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends a fulfillment request to the fulfillment service of a fulfillment order.
        /// <see href="https://shopify.dev/docs/api/admin-rest/2022-07/resources/fulfillmentrequest#post-fulfillment-orders-fulfillment-order-id-fulfillment-request">API Reference</see>
        /// </summary>
        /// <param name="fulfillmentOrderId"></param>
        /// <param name="fulfillmentRequest">A new <see cref="FulfillmentRequest"/>.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <exception cref="ShopifyException"></exception>
        Task<FulfillmentOrder> CreateAsync(long fulfillmentOrderId, FulfillmentRequest fulfillmentRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rejects a fulfillment request sent to a fulfillment service for a fulfillment order.
        /// <see href="https://shopify.dev/docs/api/admin-rest/2022-07/resources/fulfillmentrequest#post-fulfillment-orders-fulfillment-order-id-fulfillment-request-reject">API Reference</see>
        /// </summary>
        /// <param name="fulfillmentOrderId"></param>
        /// <param name="message">An optional reason for accepting the fulfillment request</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <exception cref="ShopifyException"></exception>
        Task<FulfillmentOrder> RejectAsync(long fulfillmentOrderId, string message, CancellationToken cancellationToken = default);
    }
}