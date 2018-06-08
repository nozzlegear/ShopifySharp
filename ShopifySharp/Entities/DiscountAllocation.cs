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
        public int DiscountApplicationIndex { get; set; }
    }
}
