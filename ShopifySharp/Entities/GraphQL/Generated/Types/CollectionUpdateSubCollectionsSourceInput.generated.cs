#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for updating a sub-collection source — a source whose
/// membership comes from one or more referenced collections.
/// </summary>
public record CollectionUpdateSubCollectionsSourceInput : GraphQLInputObject<CollectionUpdateSubCollectionsSourceInput>
{
    /// <summary>
    /// The global IDs of the sub-collections whose products supply this source. When
    /// provided, it replaces the source's current referenced collections.
    /// </summary>
    [JsonPropertyName("collectionIds")]
    public ICollection<string>? collectionIds { get; set; } = null;

    /// <summary>
    /// An optional description of the source.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The ID of the source to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The title of the source.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}