#nullable enable
using Newtonsoft.Json;

namespace ShopifySharp;

public class CheckoutLineItemAppliedDiscount
{
    /// The amount that is deducted from payment_due in presentment currency.
    [JsonProperty("amount")]
    public decimal? Amount { get; set; }

    /// Title of the discount.
    [JsonProperty("title")]
    public string? Title { get; set; }

    /// Reason for the discount.
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// Whether this discount code can be applied to the checkout.
    [JsonProperty("applicable")]
    public bool? Applicable { get; set; }

    /// Describes how the discount was applied to the checkout. Possible values:
    /// <list>
    /// <item>automatic: The discount was applied automatically.</item>
    /// <item>discount_code: The merchant or customer entered a discount code.</item>
    /// <item>manual: The discount was applied manually by the merchant or an app.</item>
    /// <item>script: The discount was applied by a Shopify Script.</item>
    /// </list>
    [JsonProperty("application_type")]
    public string? ApplicationType { get; set; }

    /// The reason why the discount is not applicable, if the discount cannot be applied to the checkout.
    [JsonProperty("non_applicable_reason")]
    public string? NonApplicableReason { get; set; }

    /// The value that was used to calculate the final applied discount amount.
    [JsonProperty("value")]
    public string? Value { get; set; }

    /// The type of value that was used to calculate the final applied discount amount. Valid values: `fixed_amount` and `percentage`.
    [JsonProperty("value_type")]
    public string? ValueType { get; set; }
}
