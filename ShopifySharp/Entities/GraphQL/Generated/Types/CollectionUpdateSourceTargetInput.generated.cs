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
/// The input fields for updating a collection source - provide the one field that represents the type of source to update.
/// </summary>
public record CollectionUpdateSourceTargetInput : GraphQLInputObject<CollectionUpdateSourceTargetInput>
{
    /// <summary>
    /// An update to a shareable conditions-based source.
    /// </summary>
    [JsonPropertyName("condition")]
    public CollectionUpdateConditionsSourceInput? condition { get; set; } = null;

    /// <summary>
    /// An update to a sub-collection source whose membership comes from one or more referenced collections.
    /// </summary>
    [JsonPropertyName("subCollections")]
    public CollectionUpdateSubCollectionsSourceInput? subCollections { get; set; } = null;
}