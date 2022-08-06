using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify order edit webhook (orders/edited topic)
    /// </summary>
    public class OrderEditWebhook
    {
        /// <summary>
        /// The OrderEdit object
        /// </summary>
        [JsonProperty("order_edit")]
        public OrderEdit OrderEdit { get; set; }
    }
}
