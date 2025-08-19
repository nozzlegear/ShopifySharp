#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for specifying a collection to publish and the sales channels to publish it to.
/// </summary>
public record CollectionPublishInput : GraphQLInputObject<CollectionPublishInput>
{
    /// <summary>
    /// The channels where the collection will be published.
    /// </summary>
    [JsonPropertyName("collectionPublications")]
    public ICollection<CollectionPublicationInput>? collectionPublications { get; set; } = null;

    /// <summary>
    /// The collection to create or update publications for.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}