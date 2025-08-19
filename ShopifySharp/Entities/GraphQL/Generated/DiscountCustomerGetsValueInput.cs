#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DiscountCustomerGetsValueDiscountAmount(DiscountAmount Value): DiscountCustomerGetsValue;
internal record DiscountCustomerGetsValueDiscountOnQuantity(DiscountOnQuantity Value): DiscountCustomerGetsValue;
internal record DiscountCustomerGetsValueDiscountPercentage(DiscountPercentage Value): DiscountCustomerGetsValue;
#endif /// <summary>

/// The input fields for the quantity of items discounted and the discount value.
/// </summary>
public record DiscountCustomerGetsValueInput : GraphQLInputObject<DiscountCustomerGetsValueInput>
{
    /// <summary>
    /// The value of the discount.
    /// Note: BXGY doesn't support discountAmount.
    /// </summary>
    [JsonPropertyName("discountAmount")]
    public DiscountAmountInput? discountAmount { get; set; } = null;

    /// <summary>
    /// The quantity of the items that are discounted and the discount value.
    /// </summary>
    [JsonPropertyName("discountOnQuantity")]
    public DiscountOnQuantityInput? discountOnQuantity { get; set; } = null;

    /// <summary>
    /// The percentage value of the discount. Value must be between 0.00 - 1.00.
    /// Note: BXGY doesn't support percentage.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}