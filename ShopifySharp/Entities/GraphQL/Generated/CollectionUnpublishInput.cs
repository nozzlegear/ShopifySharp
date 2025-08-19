#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for specifying the collection to unpublish and the sales channels to remove it from.
/// </summary>
public record CollectionUnpublishInput : GraphQLInputObject<CollectionUnpublishInput>
{
    /// <summary>
    /// The channels where the collection is published.
    /// </summary>
    [JsonPropertyName("collectionPublications")]
    public ICollection<CollectionPublicationInput>? collectionPublications { get; set; } = null;

    /// <summary>
    /// The collection to create or update publications for.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}