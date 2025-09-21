#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `marketRegionDelete` mutation.
/// </summary>
public record MarketRegionDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted market region.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The parent market object of the deleted region.
    /// </summary>
    [JsonPropertyName("market")]
    public Market? market { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketUserError>? userErrors { get; set; } = null;
}