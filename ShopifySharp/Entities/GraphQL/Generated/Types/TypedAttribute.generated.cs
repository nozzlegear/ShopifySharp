#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a typed custom attribute.
/// </summary>
public record TypedAttribute : IGraphQLObject
{
    /// <summary>
    /// Key or name of the attribute.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}