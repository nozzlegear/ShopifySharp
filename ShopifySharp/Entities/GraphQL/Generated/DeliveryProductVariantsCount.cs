#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// How many product variants are in a profile. This count is capped at 500.
/// </summary>
public record DeliveryProductVariantsCount : IGraphQLObject
{
    /// <summary>
    /// Whether the count has reached the cap of 500.
    /// </summary>
    [JsonPropertyName("capped")]
    public bool? capped { get; set; } = null;

    /// <summary>
    /// The product variant count.
    /// </summary>
    [JsonPropertyName("count")]
    public int? count { get; set; } = null;
}