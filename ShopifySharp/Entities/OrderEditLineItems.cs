using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify line item edit.
    /// The Id of this object is the Id of the line item being edited
    /// </summary>
    public class OrderEditLineItems
    {
        /// <summary>
        /// The additions to the line item
        /// </summary>
        [JsonProperty("additions")]
        public IEnumerable<OrderEditLineItemDelta> Additions { get; set; }

        /// <summary>
        /// The removals to the line item
        /// </summary>
        [JsonProperty("removals")]
        public IEnumerable<OrderEditLineItemDelta> Removals { get; set; }
    }
}
