#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the selling plan for a line item.
/// </summary>
public record LineItemSellingPlan : IGraphQLObject
{
    /// <summary>
    /// The name of the selling plan for display purposes.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The ID of the selling plan associated with the line item.
    /// </summary>
    [JsonPropertyName("sellingPlanId")]
    public string? sellingPlanId { get; set; } = null;
}