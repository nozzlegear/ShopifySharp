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
/// A source that provides products for a collection.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CollectionConditionsSource), typeDiscriminator: "CollectionConditionsSource")]
[JsonDerivedType(typeof(CollectionSubCollectionsSource), typeDiscriminator: "CollectionSubCollectionsSource")]
public interface ICollectionSource : IGraphQLObject
{
    /// <summary>
    /// The app that created this source, if applicable. In the case of shareable
    /// sources, this app manages this source's conditions and selections exclusively.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; }

    /// <summary>
    /// An optional description of the source.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; }

    /// <summary>
    /// The unique identifier for this source.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// The title of the source.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; }
}