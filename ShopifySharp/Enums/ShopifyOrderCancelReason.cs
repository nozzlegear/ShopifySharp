using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The reason why an order was cancelled.
    /// </summary>
    public enum ShopifyOrderCancelReason
    {
        /// <summary>
        /// The customer changed or cancelled the order.
        /// </summary>
        [JsonProperty("customer")]
        Customer,

        /// <summary>
        /// The order was fraudulent.
        /// </summary>
        [JsonProperty("fraud")]
        Fraud,

        /// <summary>
        /// Items in the order were not in inventory.
        /// </summary>
        [JsonProperty("inventory")]
        Inventory,

        /// <summary>
        /// The order was cancelled for a reason not in the list above.
        /// </summary>
        [JsonProperty("other")]
        Other
    }
}
