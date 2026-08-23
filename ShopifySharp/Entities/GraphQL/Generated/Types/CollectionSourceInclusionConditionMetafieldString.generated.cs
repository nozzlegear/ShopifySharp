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
/// A condition based on string metafield values for including products in a collection.
/// </summary>
public record CollectionSourceInclusionConditionMetafieldString : IGraphQLObject, ICollectionSourceInclusionCondition, ICollectionSourceInclusionConditionMetafield
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
    /// Determines how many values a metafield must match against in order to satisfy
    /// this condition. Will be either at least one given value, or all of the given values.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The relationship between the metafield value and the condition values.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionMetafieldStringRelation? relation { get; set; } = null;

    /// <summary>
    /// The string values to match against.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<string>? values { get; set; } = null;
}