#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `catalogUpdate` mutation.
/// </summary>
public record CatalogUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated catalog.
    /// </summary>
    [JsonPropertyName("catalog")]
    public ICatalog? catalog { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CatalogUserError>? userErrors { get; set; } = null;
}