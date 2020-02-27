using Newtonsoft.Json;
using System;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A generic class for filtering the results of a .CountAsync command.
    /// </summary>
    public class EventListFilter : ListFilter<Event>
    {
        /// <summary>
        /// Restrict results to after the specified ID
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// Show events created at or after date and time
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }

        /// <summary>
        /// Show events created at or before date and time
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }

        /// <summary>
        /// Only show events specified in filter (comma , separated). A full list of events can be found at https://help.shopify.com/api/reference/event
        /// </summary>
        [JsonProperty("filter")]
        public string Filter { get; set; }

        /// <summary>
        /// Only show events of a certain kind (comma , separated). A full list of events can be found at https://help.shopify.com/api/reference/event
        /// </summary>
        [JsonProperty("verb")]
        public string Verbs { get; set; }
    }
}
