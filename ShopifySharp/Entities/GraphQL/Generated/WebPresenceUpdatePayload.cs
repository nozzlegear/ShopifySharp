#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `webPresenceUpdate` mutation.
/// </summary>
public record WebPresenceUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketUserError>? userErrors { get; set; } = null;

    /// <summary>
    /// The web presence object.
    /// </summary>
    [JsonPropertyName("webPresence")]
    public MarketWebPresence? webPresence { get; set; } = null;
}