using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering gift cards. 
    /// </summary>
    public class GiftCardFilter : ListFilter
    {
        /// <summary>
        /// Restrict results to after the specified ID
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// A comma-separated list of fields to include in the response.
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
        
        /// <summary>
        /// The status of gift card to retrieve. Known values are "enabled", "disabled".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
