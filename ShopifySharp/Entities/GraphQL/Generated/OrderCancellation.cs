#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Details about the order cancellation.
/// </summary>
public record OrderCancellation : IGraphQLObject
{
    /// <summary>
    /// Staff provided note for the order cancellation.
    /// </summary>
    [JsonPropertyName("staffNote")]
    public string? staffNote { get; set; } = null;
}