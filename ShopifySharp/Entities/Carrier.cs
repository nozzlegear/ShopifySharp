using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify CarrierService.
    /// </summary>
    public class Carrier : ShopifyObject
    {
        /// <summary>
        /// States whether or not this carrier service is active. Valid values are "true" and "false".
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// States the URL endpoint that shopify needs to retrieve shipping rates. This must be a public URL.
        /// </summary>
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Distinguishes between api or legacy carrier services.
        /// </summary>
        [JsonProperty("carrier_service_type")]
        public string CarrierServiceType { get; set; }

        /// <summary>
        /// The name of the shipping service as seen by merchants and their customers.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// States if merchants are able to send dummy data to your service through the Shopify admin
        /// to see shipping rate examples. Valid values are "true" and "false".
        /// </summary>
        [JsonProperty("service_discovery")]
        public bool? ServiceDiscovery { get; set; }

        /// <summary>
        /// The format of the data returned by the URL endpoint. Valid values are "json" and "xml".
        /// If a format is not specified, it will default to json.
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

    }
}