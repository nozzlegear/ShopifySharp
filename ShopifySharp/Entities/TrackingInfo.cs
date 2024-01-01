using Newtonsoft.Json;

namespace ShopifySharp
{
    public class TrackingInfo
    {
        /// <summary>
        /// The tracking number.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// The public URL to the tracking company.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The tracking company name.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }
    }
}
