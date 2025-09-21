#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the minimum quantity required for the discount.
/// </summary>
public record DiscountMinimumQuantityInput : GraphQLInputObject<DiscountMinimumQuantityInput>
{
    /// <summary>
    /// The minimum quantity of items that's required for the discount to be applied.
    /// </summary>
    [JsonPropertyName("greaterThanOrEqualToQuantity")]
    public ulong? greaterThanOrEqualToQuantity { get; set; } = null;
}