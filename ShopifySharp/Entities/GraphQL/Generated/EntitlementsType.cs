#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The shop's entitlements.
/// </summary>
public record EntitlementsType : IGraphQLObject
{
    /// <summary>
    /// Represents the markets for the shop.
    /// </summary>
    [JsonPropertyName("markets")]
    public MarketsType? markets { get; set; } = null;
}