using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// Fulfillment Order Move object
    /// </summary>
    public class FulfillmentOrderMove
    {
        /// <summary>
        /// Original fulfillment order
        /// </summary>
        [JsonProperty("original_fulfillment_order")]
        public FulfillmentOrder OriginalFulfillmentOrder { get; set; }

        /// <summary>
        /// Moved fulfillment order
        /// </summary>
        [JsonProperty("moved_fulfillment_order")]
        public FulfillmentOrder MovedFulfillmentOrder { get; set; }

        /// <summary>
        /// Remaining fulfillment order if anything remains.
        /// </summary>
        [JsonProperty("remaining_fulfillment_order")]
        public FulfillmentOrder RemainingFulfillmentOrder { get; set; }

    }
}
