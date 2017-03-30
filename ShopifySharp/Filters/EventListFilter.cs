using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A generic class for filtering the results of a .CountAsync command.
    /// </summary>
    public class EventListFilter : Parameterizable
    {
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
        /// Restrict results to after the specified ID
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// Show events created at or after date and time
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTime? CreatedAtMin { get; set; }

        /// <summary>
        /// Show events created at or before date and time
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTime? CreatedAtMax { get; set; }

        /// <summary>
        /// Only show events specified in filter (comma , separated). A full list of events can be found at https://help.shopify.com/api/reference/event
        /// </summary>
        [JsonProperty("filter")]
        public string Filters { get; set; }

        /// <summary>
        /// Only show events of a certain kind (comma , separated). A full list of events can be found at https://help.shopify.com/api/reference/event
        /// </summary>
        [JsonProperty("verb")]
        public string Verbs { get; set; }

        /// <summary>
        /// comma-separated list of fields to include in the response.
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
    }
}
