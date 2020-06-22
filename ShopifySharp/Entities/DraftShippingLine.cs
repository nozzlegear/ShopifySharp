using Newtonsoft.Json;

namespace ShopifySharp
{
    public class DraftShippingLine
    {
        /// <summary>
        /// Whether this is a regular shipping line or custom shipping line.
        /// </summary>
        [JsonProperty("custom")]
        public bool? Custom { get; set; }

        /// <summary>
        /// The handle of the shipping rate which was selected and applied. Required for regular shipping lines.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// The title of the shipping method. Required for custom shipping lines. (maximum: 255 characters)
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The price of the shipping method. Required for custom shipping lines.
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; set; } 
    }
}