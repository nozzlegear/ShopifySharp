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
/// A condition based on integer metafield values for including products in a
/// collection. This object is deprecated as of API version 2026-10 in favor of
/// `CollectionSourceInclusionConditionMetafieldInt`, which supports the full
/// integer metafield value range. On those versions this legacy type is only
/// returned to queries that reference it without also referencing
/// `CollectionSourceInclusionConditionMetafieldInt`. As of API version 2027-01,
/// this legacy type is removed entirely.
/// </summary>
public record CollectionSourceInclusionConditionMetafieldInteger : IGraphQLObject, ICollectionSourceInclusionCondition, ICollectionSourceInclusionConditionMetafield
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
    public CollectionSourceInclusionConditionMetafieldIntegerRelation? relation { get; set; } = null;

    /// <summary>
    /// The integer value to match against.
    /// </summary>
    [JsonPropertyName("value")]
    public int? @value { get; set; } = null;
}