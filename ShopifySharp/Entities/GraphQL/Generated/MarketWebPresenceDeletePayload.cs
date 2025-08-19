#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `marketWebPresenceDelete` mutation.
/// </summary>
public record MarketWebPresenceDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted web presence.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The market for which the web presence was deleted.
    /// </summary>
    [JsonPropertyName("market")]
    public Market? market { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketUserError>? userErrors { get; set; } = null;
}