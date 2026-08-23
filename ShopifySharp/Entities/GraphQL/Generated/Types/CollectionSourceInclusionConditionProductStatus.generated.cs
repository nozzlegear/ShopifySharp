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
/// A condition based on product status for including products in a collection.
/// </summary>
public record CollectionSourceInclusionConditionProductStatus : IGraphQLObject, ICollectionSourceInclusionCondition
{
    /// <summary>
    /// The unique identifier for this condition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Specifies whether products must match any or all values.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The relationship between the product status and the condition values.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionProductStatusRelation? relation { get; set; } = null;

    /// <summary>
    /// The product status values to match against.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<ProductStatus>? values { get; set; } = null;
}