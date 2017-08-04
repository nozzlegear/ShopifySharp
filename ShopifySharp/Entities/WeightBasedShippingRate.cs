using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class WeightBasedShippingRate : ShopifyObject
    {
        /// <summary>
        /// Minimum order weight
        /// </summary>
        [JsonProperty("weight_low")]
        public double? WeightLow { get; set; }

        /// <summary>
        /// Maximum order weight
        /// </summary>
        [JsonProperty("weight_high")]
        public double? WeightHigh { get; set; }

        /// <summary>
        /// Name of weight based rate
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Rate amount
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Shipping zone id
        /// </summary>
        [JsonProperty("shipping_zone_id")]
        public long? ShippingZoneId { get; set; }
    }
}