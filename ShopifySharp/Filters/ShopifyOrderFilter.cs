using Newtonsoft.Json;
using ShopifySharp.Enums;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="ShopifyOrderService.CountAsync(ShopifyOrderFilter)"/> and
    /// <see cref="ShopifyOrderService.ListAsync(ShopifyOrderFilter)"/> results.
    /// </summary>
    public class ShopifyOrderFilter : ShopifyListFilter
    {
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
        public string FulfillmentStatus { get; set; }
    }
}
