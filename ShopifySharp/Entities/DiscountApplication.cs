using Newtonsoft.Json;

namespace ShopifySharp
{
    public class DiscountApplication
    {
        /// <summary>
        /// The discount application type. Valid values:
        /// manual: The discount was manually applied by the merchant(for example, by using an app or creating a draft order).
        /// script: The discount was applied by a Shopify Script.
        /// discount_code: The discount was applied by a discount code.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The discount code that was used to apply the discount. Available only for discount code applications.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The title of the discount application, as defined by the merchant. Available only for manual discount applications.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The description of the discount application, as defined by the merchant or the Shopify Script. Available only for manual and script discount applications.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The value of the discount application as a decimal. This represents the intention of the discount application.
        /// For example, if the intent was to apply a 20% discount, then the value will be 20.0.
        /// If the intent was to apply a $15 discount, then the value will be 15.0.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// The type of the value. Valid values:
        /// fixed_amount: A fixed amount discount value in the currency of the order.
        /// percentage: A percentage discount value.
        /// </summary>
        [JsonProperty("value_type")]
        public string ValueType { get; set; }

        /// <summary>
        /// The method by which the discount application value has been allocated to entitled lines. Valid values:
        /// across: The value is spread across all entitled lines.
        /// each: The value is applied onto every entitled line.
        /// one: The value is applied onto a single line.
        /// </summary>
        [JsonProperty("allocation_method")]
        public string AllocationMethod { get; set; }

        /// <summary>
        /// The lines on the order, of the type defined by target_type, that the discount is allocated over. Valid values:
        /// all: The discount is allocated onto all lines,
        /// entitled: The discount is allocated only onto lines it is entitled for.
        /// explicit: The discount is allocated onto explicitly selected lines.
        /// </summary>
        [JsonProperty("target_selection")]
        public string TargetSelection { get; set; }

        /// <summary>
        /// The type of line on the order that the discount is applicable on. Valid values:
        /// line_item: The discount applies to line items.
        /// shipping_line: The discount applies to shipping lines.
        /// </summary>
        [JsonProperty("target_type")]
        public string TargetType { get; set; }
    }
}
