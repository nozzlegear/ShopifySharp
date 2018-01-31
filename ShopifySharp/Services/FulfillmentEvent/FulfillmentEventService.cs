using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify fulfillment events.
    /// </summary>
    public class FulfillmentEventService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="FulfillmentEventService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public FulfillmentEventService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Get a list of all fulfillment events for a fulfillment
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillment belongs to.</param>
        /// <param name="fulfillmentId">The fulfillment id to which the fulfillment events belong to.</param>
        /// <returns>The list of fulfillment events for the given fulfillment.</returns>
        public virtual async Task<IEnumerable<FulfillmentEvent>> ListAsync(long orderId, long fulfillmentId)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/events.json");

            return await ExecuteRequestAsync<List<FulfillmentEvent>>(req, HttpMethod.Get, rootElement: "fulfillment_events");
        }

        /// <summary>
        /// Retrieves the <see cref="FulfillmentEvent"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillment belongs to.</param>
        /// <param name="fulfillmentId">The id of the fulfillment to which the event belongs to.</param>
        /// <param name="fulfillmentEventId">The id of the fulfillment event to retrieve.</param>
        /// <returns>The <see cref="FulfillmentEvent"/>.</returns>
        public virtual async Task<FulfillmentEvent> GetAsync(long orderId, long fulfillmentId, long fulfillmentEventId)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/events/{fulfillmentEventId}.json");

            return await ExecuteRequestAsync<FulfillmentEvent>(req, HttpMethod.Get, rootElement: "fulfillment_event");
        }
    }
}
