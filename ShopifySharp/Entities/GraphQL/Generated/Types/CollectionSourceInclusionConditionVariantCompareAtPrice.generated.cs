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
/// A condition based on variant compare at prices for including products in a collection.
/// </summary>
public record CollectionSourceInclusionConditionVariantCompareAtPrice : IGraphQLObject, ICollectionSourceInclusionCondition
{
    /// <summary>
    /// The unique identifier for this condition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The relationship between the variant compare at price and the condition values.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionVariantCompareAtPriceRelation? relation { get; set; } = null;

    /// <summary>
    /// The variant compare at price to match against. Null when the relation is IS_SET or IS_NOT_SET.
    /// </summary>
    [JsonPropertyName("value")]
    public MoneyV2? @value { get; set; } = null;
}