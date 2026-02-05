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
/// Information about the unique values capability on a metafield definition.
/// </summary>
public record MetafieldCapabilityUniqueValues : IGraphQLObject
{
    /// <summary>
    /// Indicates if the definition is eligible to have the capability.
    /// </summary>
    [JsonPropertyName("eligible")]
    public bool? eligible { get; set; } = null;

    /// <summary>
    /// Indicates if the capability is enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}