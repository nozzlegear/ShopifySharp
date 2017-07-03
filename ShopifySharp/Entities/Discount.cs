using System;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class Discount : ShopifyObject
    {
        /// <summary>
        /// Specify how the discount's value will be applied to the order. Valid values are:
        /// fixed_amount: The value as a unit of the store's currency will be discounted. E.g. If value is 30 and store's currency is USD, then $30 is deducted.
        /// percentage: The percent amount to discount the order, e.g. 15% off.
        /// shipping: Applies a free shipping discount on orders that have a shipping rate less than or equal to the amount specified in the value property.For example, free shipping for any shipping rate that is less than or equal to $70.
        /// </summary>
        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// The case-insensitive discount code that customers use at checkout. Required when creating a discount.Maximum length of 255 characters.
        /// </summary>
        [JsonProperty("code")]
        public string DiscountCode { get; set; }

        /// <summary>
        /// The value of the discount. Required when creating a percentage-based or fixed-amount discount. See the discount_type property to learn more about how value is interpreted.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// The date when the discount code becomes disabled in ISO 8601 format.
        /// </summary>
        [JsonProperty("ends_at")]
        public DateTimeOffset? EndsAt { get; set; }

        /// <summary>
        /// The date the discount becomes valid for use during checkout in ISO 8601 format.
        /// </summary>
        [JsonProperty("starts_at")]
        public DateTimeOffset? StartsAt { get; set; }

        /// <summary>
        /// The status of the discount code. Valid values are enabled, disabled, or depleted.
        /// </summary>
        [JsonProperty("status")]
        [JsonIgnore]
        public string Status { get; set; }

        /// <summary>
        /// The minimum value an order must reach for the discount to be allowed during checkout.
        /// </summary>
        [JsonProperty("minimum_order_amount")]
        public string MinimumOrderAmount { get; set; }

        /// <summary>
        /// The number of times this discount code can be redeemed. It can be redeemed by one or many customers; the usage_limit is a store-wide absolute value. Leave blank for unlimited uses.
        /// </summary>
        [JsonProperty("usage_limit")]
        public int? UsageLimit { get; set; }

        /// <summary>
        /// The id of a collection or product that this discount code is restricted to. Leave blank for a store-wide discount. If applies_to_id is set, then the applies_to_resource property is also mandatory.
        /// </summary>
        [JsonProperty("applies_to_id")]
        public System.Int64 AppliesToId { get; set; }

        /// <summary>
        /// When a discount applies to a product or collection resource, applies_once determines whether the discount should be applied once per order, or to every applicable item in the cart.
        /// </summary>
        [JsonProperty("applies_once")]
        public bool? AppliesOnce { get; set; }

        /// <summary>
        /// Determines whether the discount should be applied once, or any number of times per customer.
        /// </summary>
        [JsonProperty("applies_once_per_customer")]
        public bool? AppliesOncePerCustomer { get; set; }

        /// <summary>
        /// The discount code can be set to apply to only a product, smart_collection, customersavedsearch or custom_collection.If applies_to_resource is set, then applies_to_id should also be set.
        /// </summary>
        [JsonProperty("applies_to_resource")]
        public string AppliesToResource { get; set; }

        /// <summary>
        /// Returns a count of successful checkouts where the discount code has been used.Cannot exceed the usage_limit property.
        /// </summary>
        [JsonProperty("times_used")]
        public int? TimesUsed { get; set; }
    }
}
