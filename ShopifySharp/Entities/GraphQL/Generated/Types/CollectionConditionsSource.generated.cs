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
/// A collection source that uses conditions and selections to determine which products are included.
/// </summary>
public record CollectionConditionsSource : IGraphQLObject, ICollectionSource, INode
{
    /// <summary>
    /// The app that created this source, if applicable. In the case of shareable
    /// sources, this app manages this source's conditions and selections exclusively.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// An optional description of the source.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The rules and selections for excluding products from the collection.
    /// </summary>
    [JsonPropertyName("exclusion")]
    public CollectionSourceExclusion? exclusion { get; set; } = null;

    /// <summary>
    /// The unique identifier for this source.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The rules and selections for including products in the collection.
    /// </summary>
    [JsonPropertyName("inclusion")]
    public CollectionSourceInclusion? inclusion { get; set; } = null;

    /// <summary>
    /// The products that are members of this source: products matched by the source's inclusion
    /// conditions and manual selections, with the source's exclusion conditions, excluded
    /// collections, and manual exclusions removed.
    /// </summary>
    [JsonPropertyName("products")]
    public ProductConnection? products { get; set; } = null;

    /// <summary>
    /// Whether this source can be shared across multiple collections.
    /// </summary>
    [JsonPropertyName("shareable")]
    public bool? shareable { get; set; } = null;

    /// <summary>
    /// Whether conditions match products or individual variants.
    /// </summary>
    [JsonPropertyName("targetType")]
    public CollectionSourceTargetType? targetType { get; set; } = null;

    /// <summary>
    /// The title of the source.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}