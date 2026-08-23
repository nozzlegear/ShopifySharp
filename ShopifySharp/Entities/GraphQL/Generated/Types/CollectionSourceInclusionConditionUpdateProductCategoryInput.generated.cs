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
/// The input fields for updating a condition based on product categories.
/// </summary>
public record CollectionSourceInclusionConditionUpdateProductCategoryInput : GraphQLInputObject<CollectionSourceInclusionConditionUpdateProductCategoryInput>
{
    /// <summary>
    /// Whether to match any or all of the values.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The relationship between the product category and the condition values.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionProductCategoryRelation? relation { get; set; } = null;

    /// <summary>
    /// The product category values to match against.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<CollectionSourceInclusionConditionProductCategoryValueInput>? values { get; set; } = null;
}