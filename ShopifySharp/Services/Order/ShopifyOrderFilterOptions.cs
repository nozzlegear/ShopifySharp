using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyOrderFilterOptions : ShopifyFilterOptions
    {
        /// <summary>
        /// An optional array of order ids to retrieve. 
        /// </summary>
        public IEnumerable<long> Ids { get; set; }

        /// <summary>
        /// The status of orders to retrieve. Default is <see cref="ShopifyOrderStatus.Any"/>.
        /// </summary>
        [JsonProperty("status")]
        public ShopifyOrderStatus? Status { get; set; } = ShopifyOrderStatus.Any;

        /// <summary>
        /// The financial status of orders to retrieve. Leave this null to retrieve orders with any financial status.
        /// </summary>
        [JsonProperty("financial_status")]
        public ShopifyOrderFinancialStatus? FinancialStatus { get; set; }

        /// <summary>
        /// The fulfillment status of orders to retrieve. Leave this null to retrieve orders with any fulfillment status.
        /// </summary>
        [JsonProperty("fulfillment_status")]
        public ShopifyFulfillmentStatus? FulfillmentStatus { get; set; }
    }
}
