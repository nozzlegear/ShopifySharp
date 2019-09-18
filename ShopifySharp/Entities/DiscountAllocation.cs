using Newtonsoft.Json;

namespace ShopifySharp
{
    public class DiscountAllocation
    {
        /// <summary>
        /// The discount amount allocated to the line (not sure why it is a string)
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// The index of the associated discount application in the order's discount_applications list.
        /// </summary>
        [JsonProperty("discount_application_index")]
        public long DiscountApplicationIndex { get; set; }

        /// <summary>
        /// The discount amount allocated to the line item in shop and presentment currencies.
        /// </summary>
        [JsonProperty("amount_set")]
        public PriceSet AmountSet { get; set; }
    }
}
