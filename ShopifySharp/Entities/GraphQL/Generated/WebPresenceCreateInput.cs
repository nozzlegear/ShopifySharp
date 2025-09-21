#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields used to create a web presence.
/// </summary>
public record WebPresenceCreateInput : GraphQLInputObject<WebPresenceCreateInput>
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
    /// The web presence's domain ID. This field must be `null` if the `subfolderSuffix` isn't `null`.
    /// </summary>
    [JsonPropertyName("domainId")]
    public string? domainId { get; set; } = null;

    /// <summary>
    /// The market-specific suffix of the subfolders defined by the web presence.
    /// For example: in `/en-us`, the subfolder suffix is `us`.
    /// Only ASCII characters are allowed. This field must be `null` if the `domainId` isn't `null`.
    /// </summary>
    [JsonPropertyName("subfolderSuffix")]
    public string? subfolderSuffix { get; set; } = null;
}