#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Quantity of prerequisite items required for the price rule to be applicable, compared to quantity of entitled items.
/// </summary>
public record PriceRuleEntitlementToPrerequisiteQuantityRatio : IGraphQLObject
{
    /// <summary>
    /// The quantity of entitled items in the ratio.
    /// </summary>
    [JsonPropertyName("entitlementQuantity")]
    public int? entitlementQuantity { get; set; } = null;

    /// <summary>
    /// The quantity of prerequisite items in the ratio.
    /// </summary>
    [JsonPropertyName("prerequisiteQuantity")]
    public int? prerequisiteQuantity { get; set; } = null;
}