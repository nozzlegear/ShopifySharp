#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Information about product is restricted for a given resource.
/// </summary>
public record RestrictedForResource : IGraphQLObject
{
    /// <summary>
    /// Returns true when the product is restricted for the given resource.
    /// </summary>
    [JsonPropertyName("restricted")]
    public bool? restricted { get; set; } = null;

    /// <summary>
    /// Restriction reason for the given resource.
    /// </summary>
    [JsonPropertyName("restrictedReason")]
    public string? restrictedReason { get; set; } = null;
}