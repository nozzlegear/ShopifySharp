#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A version of the API, as defined by [Shopify API versioning](https://shopify.dev/api/usage/versioning).
/// Versions are commonly referred to by their handle (for example, `2021-10`).
/// </summary>
public record ApiVersion : IGraphQLObject
{
    /// <summary>
    /// The human-readable name of the version.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// The unique identifier of an ApiVersion. All supported API versions have a date-based (YYYY-MM) or `unstable` handle.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Whether the version is actively supported by Shopify. Supported API versions
    /// are guaranteed to be stable. Unsupported API versions include unstable,
    /// release candidate, and end-of-life versions that are marked as unsupported.
    /// For more information, refer to
    /// [Versioning](https://shopify.dev/api/usage/versioning).
    /// </summary>
    [JsonPropertyName("supported")]
    public bool? supported { get; set; } = null;
}