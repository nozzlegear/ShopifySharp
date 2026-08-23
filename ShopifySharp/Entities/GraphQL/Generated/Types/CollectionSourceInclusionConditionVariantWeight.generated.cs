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
/// A condition based on variant weights for including products in a collection.
/// </summary>
public record CollectionSourceInclusionConditionVariantWeight : IGraphQLObject, ICollectionSourceInclusionCondition
{
    /// <summary>
    /// The unique identifier for this condition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The relationship between the variant weight and the condition values.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionVariantWeightRelation? relation { get; set; } = null;

    /// <summary>
    /// The variant weight to match against.
    /// </summary>
    [JsonPropertyName("value")]
    public Weight? @value { get; set; } = null;
}