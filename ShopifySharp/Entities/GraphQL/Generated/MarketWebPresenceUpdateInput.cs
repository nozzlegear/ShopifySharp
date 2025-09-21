#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields used to update a web presence for a market.
/// </summary>
public record MarketWebPresenceUpdateInput : GraphQLInputObject<MarketWebPresenceUpdateInput>
{
    /// <summary>
    /// The alternate locales for the market’s web presence.
    /// </summary>
    [JsonPropertyName("alternateLocales")]
    public ICollection<string>? alternateLocales { get; set; } = null;

    /// <summary>
    /// The default locale for the market’s web presence.
    /// </summary>
    [JsonPropertyName("defaultLocale")]
    public string? defaultLocale { get; set; } = null;

    /// <summary>
    /// The web presence's domain ID. This field must be null if `subfolderSuffix` is not null.
    /// </summary>
    [JsonPropertyName("domainId")]
    public string? domainId { get; set; } = null;

    /// <summary>
    /// The market-specific suffix of the subfolders defined by the web presence.
    /// Example: in `/en-us` the subfolder suffix is `us`.
    /// Only ASCII characters are allowed. This field must be null if `domainId` is not null.
    /// </summary>
    [JsonPropertyName("subfolderSuffix")]
    public string? subfolderSuffix { get; set; } = null;
}