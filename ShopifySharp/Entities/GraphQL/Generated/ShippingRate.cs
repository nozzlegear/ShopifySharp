#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A shipping rate is an additional cost added to the cost of the products that were ordered.
/// </summary>
public record ShippingRate : IGraphQLObject
{
    /// <summary>
    /// Human-readable unique identifier for this shipping rate.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The cost associated with the shipping rate.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// The name of the shipping rate.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}