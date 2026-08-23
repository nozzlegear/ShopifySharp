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
/// A condition based on boolean metafield values for including products in a collection.
/// </summary>
public record CollectionSourceInclusionConditionMetafieldBoolean : IGraphQLObject, ICollectionSourceInclusionCondition, ICollectionSourceInclusionConditionMetafield
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
    /// The relationship between the metafield value and the condition.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionMetafieldBooleanRelation? relation { get; set; } = null;

    /// <summary>
    /// The boolean value to match against.
    /// </summary>
    [JsonPropertyName("value")]
    public bool? @value { get; set; } = null;
}