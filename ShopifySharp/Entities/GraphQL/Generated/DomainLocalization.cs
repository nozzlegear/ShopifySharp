#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The country and language settings assigned to a domain.
/// </summary>
public record DomainLocalization : IGraphQLObject
{
    /// <summary>
    /// The ISO codes for the domain’s alternate locales. For example, `["en"]`.
    /// </summary>
    [JsonPropertyName("alternateLocales")]
    public ICollection<string>? alternateLocales { get; set; } = null;

    /// <summary>
    /// The ISO code for the country assigned to the domain. For example, `"CA"` or "*" for a domain set to "Rest of world".
    /// </summary>
    [JsonPropertyName("country")]
    public string? country { get; set; } = null;

    /// <summary>
    /// The ISO code for the domain’s default locale. For example, `"en"`.
    /// </summary>
    [JsonPropertyName("defaultLocale")]
    public string? defaultLocale { get; set; } = null;
}