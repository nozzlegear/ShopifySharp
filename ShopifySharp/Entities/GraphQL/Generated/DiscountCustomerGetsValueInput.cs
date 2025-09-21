#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
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