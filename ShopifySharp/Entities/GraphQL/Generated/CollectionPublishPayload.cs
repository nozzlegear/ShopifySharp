#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `collectionPublish` mutation.
/// </summary>
public record CollectionPublishPayload : IGraphQLObject
{
    /// <summary>
    /// The published collection.
    /// </summary>
    [JsonPropertyName("collection")]
    public Collection? collection { get; set; } = null;

    /// <summary>
    /// The channels where the collection has been published.
    /// </summary>
    [JsonPropertyName("collectionPublications")]
    public ICollection<CollectionPublication>? collectionPublications { get; set; } = null;

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