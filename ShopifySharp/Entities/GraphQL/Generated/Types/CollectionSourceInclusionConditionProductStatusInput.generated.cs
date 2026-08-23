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
/// The input fields for a condition based on product status.
/// </summary>
public record CollectionSourceInclusionConditionProductStatusInput : GraphQLInputObject<CollectionSourceInclusionConditionProductStatusInput>
{
    /// <summary>
    /// Whether to match any or all of the values.
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