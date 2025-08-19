#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The app plan that the merchant is subscribed to.
/// </summary>
public record AppPlanV2 : IGraphQLObject
{
    /// <summary>
    /// The plan billed to a shop on a recurring basis.
    /// </summary>
    [JsonPropertyName("pricingDetails")]
    public AppPricingDetails? pricingDetails { get; set; } = null;
}