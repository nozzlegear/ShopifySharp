#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `marketRegionsDelete` mutation.
/// </summary>
public record MarketRegionsDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted market region.
    /// </summary>
    [JsonPropertyName("deletedIds")]
    public ICollection<string>? deletedIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketUserError>? userErrors { get; set; } = null;
}