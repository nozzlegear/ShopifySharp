using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify fulfillment order.
    /// </summary>
    public class FulfillmentOrder : ShopifyObject
    {
        /// <summary>
        /// The unique numeric identifier for the shop.
        /// </summary>
        [JsonProperty("shop_id")]
        public long? ShopId { get; set; }

        /// <summary>
        /// The unique numeric identifier for the order.
        /// </summary>
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// The unique numeric identifier for the location.
        /// </summary>
        [JsonProperty("assigned_location_id")]
        public long? LocationId { get; set; }

        /// <summary>
        /// "mars-fulfillment".
        /// </summary>
        [JsonProperty("fulfillment_service_handle")]
        public string FulfillmentServiceHandle { get; set; }

        /// <summary>
        /// "submitted".
        /// </summary>
        [JsonProperty("request_status")]
        public string RequestStatus { get; set; }

        /// <summary>
        /// "open".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Destination for the fulfillment.
        /// </summary>
        [JsonProperty("destination")]
        public Address Destination { get; set; }

        /// <summary>
        /// A historical record of each item in the fulfillment.
        /// </summary>
        [JsonProperty("destination")]
        public IEnumerable<LineItem> LineItems { get; set; }

        /// <summary>
        /// "create_fulfillment", "request_fulfillment", "cancel_fulfillment_order", "request_cancellation"
        /// </summary>
        [JsonProperty("supported_actions")]
        public IEnumerable<string> SupportedActions { get; set; }

        /// <summary>
        /// ???
        /// </summary>
        [JsonProperty("merchant_requests")]
        public IEnumerable<object> MerchantRequests { get; set; }

        /// <summary>
        /// Destination for the fulfillment.
        /// </summary>
        [JsonProperty("assigned_location")]
        public AssignedLocation AssignedLocation { get; set; }

    }
}