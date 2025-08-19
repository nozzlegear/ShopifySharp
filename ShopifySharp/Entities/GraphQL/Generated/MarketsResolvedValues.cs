#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The resolved values based on the markets configuration for a buyer signal.
/// Resolved values include the resolved catalogs, web presences, currency, and
/// price inclusivity.
/// </summary>
public record MarketsResolvedValues : IGraphQLObject
{
    /// <summary>
    /// The resolved catalogs.
    /// </summary>
    [JsonPropertyName("catalogs")]
    public MarketCatalogConnection? catalogs { get; set; } = null;

    /// <summary>
    /// The resolved currency code.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public CurrencyCode? currencyCode { get; set; } = null;

    /// <summary>
    /// The resolved price inclusivity attributes.
    /// </summary>
    [JsonPropertyName("priceInclusivity")]
    public ResolvedPriceInclusivity? priceInclusivity { get; set; } = null;

    /// <summary>
    /// The resolved web presences ordered by priority.
    /// </summary>
    [JsonPropertyName("webPresences")]
    public MarketWebPresenceConnection? webPresences { get; set; } = null;
}