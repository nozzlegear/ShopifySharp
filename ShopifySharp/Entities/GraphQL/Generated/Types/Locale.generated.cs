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
/// A locale.
/// </summary>
public record Locale : IGraphQLObject
{
    /// <summary>
    /// Locale ISO code.
    /// </summary>
    [JsonPropertyName("isoCode")]
    public string? isoCode { get; set; } = null;

    /// <summary>
    /// Human-readable locale name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}