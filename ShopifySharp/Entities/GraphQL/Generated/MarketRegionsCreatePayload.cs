#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `marketRegionsCreate` mutation.
/// </summary>
public record MarketRegionsCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The market object.
    /// </summary>
    [JsonPropertyName("market")]
    public Market? market { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketUserError>? userErrors { get; set; } = null;
}