using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class TenderTransactionListFilter : ListFilter<TenderTransaction>
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// Show tender transactions ordered by processed_at in ascending or descending order (default is descending).
        /// Example values: "processed_at+ASC", "processed_at+DESC".
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }

        /// <summary>
        /// Show tender transactions processed at the specified date.
        /// </summary>
        [JsonProperty("processed_at")]
        public DateTimeOffset? ProcessedAt { get; set; }

        /// <summary>
        /// Show tender transactions processed at or after the specified date.
        /// </summary>
        [JsonProperty("processed_at_min")]
        public DateTimeOffset? ProcessedAtMin { get; set; }

        /// <summary>
        /// Show tender transactions processed at or before the specified date.
        /// </summary>
        [JsonProperty("processed_at_max")]
        public DateTimeOffset? ProcessedAtMax { get; set; }
    }
}