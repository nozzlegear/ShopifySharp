#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the cart transform feature configuration for the shop.
/// </summary>
public record CartTransformFeature : IGraphQLObject
{
    /// <summary>
    /// The cart transform operations eligible for the shop.
    /// </summary>
    [JsonPropertyName("eligibleOperations")]
    public CartTransformEligibleOperations? eligibleOperations { get; set; } = null;
}