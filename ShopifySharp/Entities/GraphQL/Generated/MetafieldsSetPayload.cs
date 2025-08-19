#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `metafieldsSet` mutation.
/// </summary>
public record MetafieldsSetPayload : IGraphQLObject
{
    /// <summary>
    /// The list of metafields that were set.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<Metafield>? metafields { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MetafieldsSetUserError>? userErrors { get; set; } = null;
}