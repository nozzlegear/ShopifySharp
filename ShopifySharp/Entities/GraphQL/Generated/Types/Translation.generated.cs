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
/// A localized version of a field on a resource. Translations enable merchants to
/// provide content in multiple languages for
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) objects, [`Collection`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Collection)
/// objects, and other store resources.
/// Each translation specifies the locale, the field being translated (identified by
/// its key), and the translated value. Translations can be market-specific,
/// allowing different content for the same language across different markets, or
/// available globally when no
/// [`Market`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Market) is
/// specified. The `outdated` flag indicates whether the original content has
/// changed since this translation was last updated.
/// Learn more about [managing translated content](https://shopify.dev/docs/apps/build/markets/manage-translated-content).
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
    public DateTimeOffset? updatedAt { get; set; } = null;

    /// <summary>
    /// Translation value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}