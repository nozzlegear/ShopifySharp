#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `marketCurrencySettingsUpdate` mutation.
/// </summary>
public record MarketCurrencySettingsUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The market object.
    /// </summary>
    [JsonPropertyName("market")]
    [Obsolete("Use `marketCreate` and `marketUpdate` mutations instead.")]
    public Market? market { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketCurrencySettingsUserError>? userErrors { get; set; } = null;
}