#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Translation of a field of a resource.
/// </summary>
public record Translation : IGraphQLObject
{
    /// <summary>
    /// On the resource that this translation belongs to, the reference to the value being translated.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// ISO code of the translation locale.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The market that the translation is specific to. Null value means the translation is available in all markets.
    /// </summary>
    [JsonPropertyName("market")]
    public Market? market { get; set; } = null;

    /// <summary>
    /// Whether the original content has changed since this translation was updated.
    /// </summary>
    [JsonPropertyName("outdated")]
    public bool? outdated { get; set; } = null;

    /// <summary>
    /// The date and time when the translation was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// Translation value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}