#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update a web presence.
/// </summary>
public record WebPresenceUpdateInput : GraphQLInputObject<WebPresenceUpdateInput>
{
    /// <summary>
    /// The alternate locales for the web presence.
    /// </summary>
    [JsonPropertyName("alternateLocales")]
    public ICollection<string>? alternateLocales { get; set; } = null;

    /// <summary>
    /// The default locale for the web presence.
    /// </summary>
    [JsonPropertyName("defaultLocale")]
    public string? defaultLocale { get; set; } = null;

    /// <summary>
    /// The market-specific suffix of the subfolders defined by the web presence.
    /// Example: in `/en-us` the subfolder suffix is `us`.
    /// Only ASCII characters are allowed.
    /// This field must be null if subfolder suffix is not already defined for the web presence.
    /// </summary>
    [JsonPropertyName("subfolderSuffix")]
    public string? subfolderSuffix { get; set; } = null;
}