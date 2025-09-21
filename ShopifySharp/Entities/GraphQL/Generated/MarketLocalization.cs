#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The market localization of a field within a resource, which is determined by the market ID.
/// </summary>
public record MarketLocalization : IGraphQLObject
{
    /// <summary>
    /// A reference to the value being localized on the resource that this market localization belongs to.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The market that the localization is specific to.
    /// </summary>
    [JsonPropertyName("market")]
    public Market? market { get; set; } = null;

    /// <summary>
    /// Whether the original content has changed since this market localization was updated.
    /// </summary>
    [JsonPropertyName("outdated")]
    public bool? outdated { get; set; } = null;

    /// <summary>
    /// The date and time when the market localization was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// The value of the market localization.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}