#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the minimum subtotal required for a discount.
/// </summary>
public record DiscountMinimumSubtotalInput : GraphQLInputObject<DiscountMinimumSubtotalInput>
{
    /// <summary>
    /// The minimum subtotal that's required for the discount to be applied.
    /// </summary>
    [JsonPropertyName("greaterThanOrEqualToSubtotal")]
    public decimal? greaterThanOrEqualToSubtotal { get; set; } = null;
}