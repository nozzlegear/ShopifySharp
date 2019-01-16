using Newtonsoft.Json;
using System;

namespace ShopifySharp.Filters 
{
    public class ShopifyPaymentsTransactionFilter : Parameterizable 
    {
        /// <summary>
        /// Filter response to transactions exclusively after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// Filter response to transactions exclusively before the specified ID
        /// </summary>
        [JsonProperty("last_id")]
        public long? LastId { get; set; }

        /// <summary>
        /// Filter response to transactions placed in test mode.
        /// </summary>
        [JsonProperty("test")]
        public bool Test { get; set; }

        /// <summary>
        /// Filter response to transactions paid out in the specified payout.
        /// </summary>
        [JsonProperty("payout_id")]
        public string PayoutId { get; set; }

        /// <summary>
        /// Filter response to transactions with the specified payout status
        /// </summary>
        [JsonProperty("payout_status")]
        public string PayoutStatus { get; set; }
    }
}