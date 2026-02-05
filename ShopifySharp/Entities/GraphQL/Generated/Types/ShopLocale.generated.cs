#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A locale that's been enabled on a shop.
/// </summary>
public record ShopLocale : IGraphQLObject
{
    /// <summary>
    /// The locale ISO code.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The market web presences that use the locale.
    /// </summary>
    [JsonPropertyName("marketWebPresences")]
    public ICollection<MarketWebPresence>? marketWebPresences { get; set; } = null;

    /// <summary>
    /// The human-readable locale name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Whether the locale is the default locale for the shop.
    /// </summary>
    [JsonPropertyName("primary")]
    public bool? primary { get; set; } = null;

    /// <summary>
    /// Whether the locale is visible to buyers.
    /// </summary>
    [JsonPropertyName("published")]
    public bool? published { get; set; } = null;
}