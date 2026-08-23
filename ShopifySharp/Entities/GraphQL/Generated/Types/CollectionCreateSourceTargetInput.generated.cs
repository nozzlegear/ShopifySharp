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
/// The input fields for adding a source to a collection — provide exactly one field
/// that represents the type of source to create.
/// </summary>
public record CollectionCreateSourceTargetInput : GraphQLInputObject<CollectionCreateSourceTargetInput>
{
    /// <summary>
    /// An existing shareable source to link to the collection.
    /// </summary>
    [JsonPropertyName("shareableSource")]
    public CollectionShareableSourceInput? shareableSource { get; set; } = null;

    /// <summary>
    /// Net new conditions-based source (target_type products or variants) to create — must belong to one collection.
    /// </summary>
    [JsonPropertyName("source")]
    public CollectionCreateConditionsSourceInput? source { get; set; } = null;

    /// <summary>
    /// Net new sub-collection source (target_type collections) whose membership comes from one or more referenced collections.
    /// </summary>
    [JsonPropertyName("subCollections")]
    public CollectionCreateSubCollectionsSourceInput? subCollections { get; set; } = null;
}