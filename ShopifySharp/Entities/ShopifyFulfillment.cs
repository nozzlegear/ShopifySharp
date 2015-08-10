using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyFulfillment : ShopifyObject
    {
        /// <summary>
        /// The date and time when the fulfillment was created. 
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// A historical record of each item in the fulfillment.
        /// </summary>
        [JsonProperty("line_items")]
        public IEnumerable<ShopifyLineItem> LineItems { get; set; }

        /// <summary>
        /// The unique numeric identifier for the order.
        /// </summary>
        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// A textfield with information about the receipt.
        /// </summary>
        [JsonProperty("receipt")]
        public string Receipt { get; set; }

        /// <summary>
        /// The status of the fulfillment.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The name of the shipping company.
        /// </summary>
        [JsonProperty("tracking_company")]
        public string TrackingCompany { get; set; }

        /// <summary>
        /// The shipping number, provided by the shipping company.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// The date and time when the fulfillment was last modified.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
