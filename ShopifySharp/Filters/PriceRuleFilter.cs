using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A class for filtering the results of a .ListAsync command that returns PriceRules.
    /// </summary>
    public class PriceRuleFilter : Parameterizable
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
    }
}