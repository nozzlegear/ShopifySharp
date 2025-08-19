#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `collectionUnpublish` mutation.
/// </summary>
public record CollectionUnpublishPayload : IGraphQLObject
{
    /// <summary>
    /// The collection that has been unpublished.
    /// </summary>
    [JsonPropertyName("collection")]
    public Collection? collection { get; set; } = null;

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