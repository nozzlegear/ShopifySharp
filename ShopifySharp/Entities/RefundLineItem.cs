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
        public int? Quantity { get; set; }

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

        /// <summary>
        /// The subtotal of the refund line item in shop and presentment currencies.
        /// </summary>
        [JsonProperty("subtotal_set")]
        public PriceSet SubTotalTaxSet { get; set; }

        /// <summary>
        /// The total tax of the line item in shop and presentment currencies.
        /// </summary>
        [JsonProperty("total_tax_set")]
        public PriceSet TotalTaxSet { get; set; }

        /// <summary>
        /// How this refund line item affects inventory levels.
        /// </summary>
        [JsonProperty("restock_type")]
        public string RestockType { get; set; }

        /// <summary>
        /// The unique identifier of the location where the items will be restocked.
        /// Required when restock_type has the value return or cancel.
        /// </summary>
        [JsonProperty("location_id")]
        public long? LocationId { get; set; }
    }
}
