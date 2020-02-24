using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering lists of PriceRules. 
    /// </summary>
    public class PriceRuleListFilter : ListFilter<PriceRule>
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// Restricts results to those created after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those created before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }

        /// <summary>
        /// Restricts results to those last updated after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those last updated before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }

        /// <summary>
        /// Show price rules starting after date.
        /// </summary>
        [JsonProperty("starts_at_min")]
        public DateTimeOffset? StartsAtMin { get; set; }

        /// <summary>
        /// Show price rules starting before date.
        /// </summary>
        [JsonProperty("starts_at_max")]
        public DateTimeOffset? StartsAtMax { get; set; }

        /// <summary>
        /// Show price rules ending after date.
        /// </summary>
        [JsonProperty("ends_at_min")]
        public DateTimeOffset? EndsAtMin { get; set; }

        /// <summary>
        /// Show price rules ending before date.
        /// </summary>
        [JsonProperty("ends_at_max")]
        public DateTimeOffset? EndsAtMax { get; set; }

        /// <summary>
        /// Show price rules with times used.
        /// </summary>
        [JsonProperty("times_used")]
        public int? TimesUsed { get; set; }

        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}