using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// A generic class for filtering the results of a .ListAsync command.
    /// </summary>
    public class ShopifyListFilter : ShopifyCountFilter
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// Limit the amount of results. Default is 50, max is 250.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Page of results to be returned. Default is 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// An optional, comma-separated list of fields to include in the response.
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
    }
}
