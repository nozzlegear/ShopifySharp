#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A shop's banner settings.
/// </summary>
public record CookieBanner : IGraphQLObject, IHasPublishedTranslations
{
    /// <summary>
    /// Indicates if the banner is auto managed.
    /// </summary>
    [JsonPropertyName("autoManaged")]
    public bool? autoManaged { get; set; } = null;

    /// <summary>
    /// Indicates if the banner is enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;
}