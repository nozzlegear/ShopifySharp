using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class CheckoutLineItem : LineItem
    {
        /// <summary>
        /// The key for the line item.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// The unique numeric identifier for the product in the fulfillment. Can be null if the original product associated with the order is deleted at a later date
        /// </summary>
        [JsonProperty("origin_location_id")]
        public long? OriginLocationId { get; set; }
    }
}
