#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `collectionDelete` mutation.
/// </summary>
public record CollectionDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the collection that was deleted. Returns `null` if the collection doesn't exist.
    /// </summary>
    [JsonPropertyName("deletedCollectionId")]
    public string? deletedCollectionId { get; set; } = null;

    /// <summary>
    /// The shop associated with the collection.
    /// </summary>
    [JsonPropertyName("shop")]
    public Shop? shop { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}