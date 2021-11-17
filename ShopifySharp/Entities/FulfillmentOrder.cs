using System.Collections.Generic;
using Newtonsoft.Json;
using ShopifySharp.Entities;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify fulfillment order.
    /// </summary>
    public class FulfillmentOrder : ShopifyObject
    {
        /// <summary>
        /// The ID of the shop that's associated with the fulfillment order.
        /// </summary>
        [JsonProperty("shop_id")]
        public long? ShopId { get; set; }

        /// <summary>
        /// The ID of the order that's associated with the fulfillment order.
        /// </summary>
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// The ID of the location that has been assigned to do the work.
        /// </summary>
        [JsonProperty("assigned_location_id")]
        public long? AssignedLocationId { get; set; }

        /// <summary>
        /// "mars-fulfillment".
        /// </summary>
        [JsonProperty("fulfillment_service_handle")]
        [Obsolete("FulfillmentServiceHandle is deprecated and will be removed in a future release.")]
        public string FulfillmentServiceHandle { get; set; }

        /// <summary>
        /// The status of the fulfillment order. 
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
        public FulfillmentOrderDestination FulfillmentOrderDestination { get; set; }

        /// <summary>
        /// Represents line items belonging to a fulfillment order:
        /// </summary>
        [JsonProperty("line_items")]
        public IEnumerable<FulfillmentOrderLineItem> FulfillmentOrderLineItems { get; set; }

        /// <summary>
        /// Followings actions can be performed on this fulfillment order.
        /// <br>create_fulfillment</br>
        /// <br>request_fulfillment</br>
        /// <br>cancel_fulfillment_order</br>
        /// <br>request_cancellation</br>
        /// </summary>
        [JsonProperty("supported_actions")]
        public IEnumerable<string> SupportedActions { get; set; }

        /// <summary>
        /// A list of requests sent by the merchant to the fulfillment service for this fulfillment order.
        /// </summary>
        [JsonProperty("merchant_requests")]
        public IEnumerable<MerchantRequest> MerchantRequests { get; set; }

        /// <summary>
        /// The fulfillment order's assigned location
        /// </summary>
        [JsonProperty("assigned_location")]
        public AssignedLocation AssignedLocation { get; set; }
    }
}
