using Newtonsoft.Json;
using System;

namespace ShopifySharp.Filters 
{
    public class ShopifyPaymentsPayoutFilter : Parameterizable 
    {
        /// <summary>
        /// Filter response to payouts exclusively after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// Filter response to payouts exclusively before the specified ID
        /// </summary>
        [JsonProperty("last_id")]
        public long? LastId { get; set; }

        /// <summary>
        /// Filter response to payouts inclusively after the specified date.
        /// </summary>
        [JsonProperty("date_min")]
        public DateTimeOffset? DateMin { get; set; }

        /// <summary>
        /// Filter response to payouts inclusively before the specified date.
        /// </summary>
        [JsonProperty("date_max")]
        public DateTimeOffset? DateMax { get; set; }

        /// <summary>
        /// Filter response to payouts on the specified date.
        /// </summary>
        [JsonProperty("date")]
        public DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Filter response to payouts with the specified status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}