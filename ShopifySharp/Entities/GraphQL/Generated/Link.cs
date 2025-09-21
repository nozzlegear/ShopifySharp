#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A link to direct users to.
/// </summary>
public record Link : IGraphQLObject, IHasPublishedTranslations
{
    /// <summary>
    /// A context-sensitive label for the link.
    /// </summary>
    [JsonPropertyName("label")]
    public string? label { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The URL that the link visits.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}