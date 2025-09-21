#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a branded promise presented to buyers.
/// </summary>
public record DeliveryBrandedPromise : IGraphQLObject
{
    /// <summary>
    /// The handle of the branded promise.  For example: `shop_promise`.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The name of the branded promise.  For example: `Shop Promise`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}