#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The percentage value of a selling plan pricing policy percentage type.
/// </summary>
public record SellingPlanPricingPolicyPercentageValue : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The percentage value.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}