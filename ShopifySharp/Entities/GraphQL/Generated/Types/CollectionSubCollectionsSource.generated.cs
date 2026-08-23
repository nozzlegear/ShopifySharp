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
/// A collection source whose membership comes from one or more referenced collections (sub-collections).
/// Sub-collection sources are always non-shareable. Sharing a sub-collection source across owners is not
/// supported because the collection references are owner-bound.
/// </summary>
public record CollectionSubCollectionsSource : IGraphQLObject, ICollectionSource, INode
{
    /// <summary>
    /// The app that created this source, if applicable. In the case of shareable
    /// sources, this app manages this source's conditions and selections exclusively.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The referenced sub-collections that supply products to this source.
    /// </summary>
    [JsonPropertyName("collections")]
    public ICollection<Collection>? collections { get; set; } = null;

    /// <summary>
    /// An optional description of the source.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The unique identifier for this source.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The title of the source.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}