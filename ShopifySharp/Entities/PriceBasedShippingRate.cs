using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PriceBasedShippingRate : ShopifyObject
    {
        /// <summary>
        /// The name of the price based shipping rate, specified by the user.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Minimum order price
        /// </summary>
        [JsonProperty("min_order_subtotal")]
        public decimal? MinOrderSubtotal { get; set; }

        /// <summary>
        /// Rate amount
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Maximum order price
        /// </summary>
        [JsonProperty("max_order_subtotal")]
        public decimal? MaxOrderSubtotal { get; set; }

        /// <summary>
        /// Shipping zone id
        /// </summary>
        [JsonProperty("shipping_zone_id")]
        public long? ShippingZoneId { get; set; }
    }
}