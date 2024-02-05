using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify assigned fulfillment order.
    /// </summary>
    public class AssignedFulfillmentOrder : ShopifyObject
    {
        /// <summary>
        /// The ID of the fulfillment order's assigned location. This is the location from which the order is expected to be fulfilled.
        /// </summary>
        [JsonProperty("assigned_location_id")]
        public long? AssignedLocationId { get; set; }

        /// <summary>
        /// The destination where the items should be sent upon fulfillment.
        /// </summary>
        [JsonProperty("destination")]
        public FulfillmentOrderDestination Destination { get; set; }

        /// <summary>
        /// Represents line items belonging to a fulfillment order:
        /// </summary>
        [JsonProperty("line_items")]
        public IEnumerable<AssignedFulfillmentOrderLineItem> LineItems { get; set; }

        /// <summary>
        /// The ID of the order that's associated with the fulfillment order.
        /// </summary>
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// The status of the fulfillment order.
        ///     unsubmitted: The initial request status for the newly-created fulfillment orders. This is the only valid request status for fulfillment orders that aren't assigned to a fulfillment service.
        ///     submitted: The merchant requested fulfillment for this fulfillment order.
        ///     accepted: The fulfillment service accepted the merchant's fulfillment request.
        ///     rejected: The fulfillment service rejected the merchant's fulfillment request.
        ///     cancellation_requested: The merchant requested a cancellation of the fulfillment request for this fulfillment order.
        ///     cancellation_accepted: The fulfillment service accepted the merchant's fulfillment cancellation request.
        ///     cancellation_rejected: The fulfillment service rejected the merchant's fulfillment cancellation request.
        ///     closed: The fulfillment service closed the fulfillment order without completing it.
        /// </summary>
        [JsonProperty("request_status")]
        public string RequestStatus { get; set; }

        /// <summary>
        /// The ID of the shop that's associated with the fulfillment order.
        /// </summary>
        [JsonProperty("shop_id")]
        public long? ShopId { get; set; }

        /// <summary>
        /// The status of the fulfillment order. Valid values:
        ///     open: Default state for newly created fulfillment orders.
        ///     in_progress: The fulfillment order is being processed.
        ///     cancelled: The fulfillment order has been cancelled by the merchant.
        ///     incomplete: The fulfillment order cannot be completed as requested.
        ///     closed: The fulfillment order has been completed and closed.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
