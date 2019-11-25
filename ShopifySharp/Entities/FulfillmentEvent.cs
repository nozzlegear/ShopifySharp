using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using ShopifySharp.Converters;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify fulfillment event.
    /// </summary>
    public class FulfillmentEvent : ShopifyObject
    {
        /// <summary>
        /// The date and time when the fulfillment event was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The unique numeric identifier for the order.
        /// </summary>
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// The unique numeric identifier for the shop.
        /// </summary>
        [JsonProperty("shop_id")]
        public long? ShopId { get; set; }

        /// <summary>
        /// The unique numeric identifier for the fulfillment.
        /// </summary>
        [JsonProperty("fulfillment_id")]
        public long? FulfillmentId { get; set; }

        /// <summary>
        /// The status of the fulfillment event. Valid values are 'confirmed', 'in_transit', 
        /// 'out_for_delivery', 'delivered' and 'failure'
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The date and time when the fulfillment event occurred
        /// </summary>
        [JsonProperty("happened_at")]
        public DateTimeOffset? HappenedAt { get; set; }

        /// <summary>
        /// An arbitrary message describing the status.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// The city in which the fulfillment event occurred.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The province in which the fulfillment event occurred.
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// The zip code in the location in which the fulfillment event occurred.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// The country in which the fulfillment event occurred.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The fulfillment event's street address.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Geographic coordinate specifying the north/south location of a fulfillment event.
        /// </summary>
        [JsonProperty("latitude")]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Geographic coordinate specifying the east/west location of a fulfillment event.
        /// </summary>
        [JsonProperty("longitude")]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// The estimated date of delivery.
        /// </summary>
        [JsonProperty("estimated_delivery_at")]
        [JsonConverter(typeof(InvalidDateToNullConverter))]
        public DateTimeOffset? EstimatedDeliveryAt { get; set; }

        /// <summary>
        /// The date and time when the fulfillment event was last modified.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
