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
/// A condition based on single metaobject reference metafield values for including products in a collection.
/// </summary>
public record CollectionSourceInclusionConditionMetafieldMetaobject : IGraphQLObject, ICollectionSourceInclusionCondition, ICollectionSourceInclusionConditionMetafield
{
    /// <summary>
    /// The metafield definition to use for the condition.
    /// </summary>
    [JsonPropertyName("definition")]
    public MetafieldDefinition? definition { get; set; } = null;

    /// <summary>
    /// The unique identifier for this condition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The relationship between the metafield value and the condition value.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionMetafieldMetaobjectRelation? relation { get; set; } = null;

    /// <summary>
    /// The metaobject to match against.
    /// </summary>
    [JsonPropertyName("value")]
    public Metaobject? @value { get; set; } = null;
}