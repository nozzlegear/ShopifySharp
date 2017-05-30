using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class RefundLineItem : ShopifyObject
    {
        /// <summary>
        /// The single <see cref="ShopifySharp.LineItem"/> being returned.
        /// </summary>
        [JsonProperty("line_item")]
        public LineItem LineItem { get; set; }

        /// <summary>
        /// The unique identifier of the refund line item.
        /// </summary>
        [JsonProperty("line_item_id")]
        public long? LineItemId { get; set; }

        /// <summary>
        /// The quantity of the associated line item that was returned.
        /// </summary>
        [JsonProperty("quantity")]
        public int?Quantity { get; set; }

        /// <summary>
        /// Tax amount refunded
        /// </summary>
        [JsonProperty("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Item subtotal
        /// </summary>
        [JsonProperty("subtotal")]
        public decimal? SubTotal { get; set; }
    }
}
