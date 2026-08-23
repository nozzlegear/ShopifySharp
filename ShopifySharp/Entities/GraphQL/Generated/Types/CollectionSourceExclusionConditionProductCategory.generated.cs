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
/// A condition based on product category IDs for excluding products from a collection.
/// </summary>
public record CollectionSourceExclusionConditionProductCategory : IGraphQLObject, ICollectionSourceExclusionCondition
{
    /// <summary>
    /// The unique identifier for this exclusion condition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Specifies whether products must match any or all values.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The relationship between the product category ID and the condition values.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceExclusionConditionProductCategoryRelation? relation { get; set; } = null;

    /// <summary>
    /// The product category values to match against.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<CollectionSourceExclusionConditionProductCategoryValue>? values { get; set; } = null;
}