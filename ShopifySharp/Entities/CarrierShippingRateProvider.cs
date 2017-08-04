using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class CarrierShippingRateProvider : ShopifyObject
    {
        /// <summary>
        /// A Carrier Service (also known as a Carrier Calculated Service or Shipping Service) provides real-time shipping rates to Shopify. Some common carrier services include: Canada Post, FedEx, UPS, and USPS. Note that the term "carrier" is often used interchangeably with the terms "shipping company" and "rate provider."
        /// </summary>
        [JsonProperty("carrier_service_id")]
        public long? CarrierServiceId { get; set; }

        /// <summary>
        /// Rate adjustments - Flat fee
        /// </summary>
        [JsonProperty("flat_modifier")]
        public string FlatModifier { get; set; }

        /// <summary>
        /// Rate adjustments - percentage
        /// </summary>
        [JsonProperty("percent_modifier")]
        public int PercentModifier { get; set; }


        [JsonProperty("service_filter")]
        public ServiceFilter ServiceFilter { get; set; }

        /// <summary>
        /// Shipping zone id
        /// </summary>
        [JsonProperty("shipping_zone_id")]
        public long? ShippingZoneId { get; set; }
    }

}