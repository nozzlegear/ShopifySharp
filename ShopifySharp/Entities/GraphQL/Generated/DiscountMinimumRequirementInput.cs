#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DiscountMinimumRequirementDiscountMinimumQuantity(DiscountMinimumQuantity Value): DiscountMinimumRequirement;
internal record DiscountMinimumRequirementDiscountMinimumSubtotal(DiscountMinimumSubtotal Value): DiscountMinimumRequirement;
#endif /// <summary>

/// The input fields for the minimum quantity or subtotal required for a discount.
/// </summary>
public record DiscountMinimumRequirementInput : GraphQLInputObject<DiscountMinimumRequirementInput>
{
    /// <summary>
    /// The minimum required quantity.
    /// </summary>
    [JsonPropertyName("quantity")]
    public DiscountMinimumQuantityInput? quantity { get; set; } = null;

    /// <summary>
    /// The minimum required subtotal.
    /// </summary>
    [JsonPropertyName("subtotal")]
    public DiscountMinimumSubtotalInput? subtotal { get; set; } = null;
}