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
/// The input fields for updating a condition based on product tags.
/// </summary>
public record CollectionSourceInclusionConditionUpdateProductTagInput : GraphQLInputObject<CollectionSourceInclusionConditionUpdateProductTagInput>
{
    /// <summary>
    /// Whether to match any or all of the values.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The relationship between the product tag and the condition values.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionProductTagRelation? relation { get; set; } = null;

    /// <summary>
    /// The tag values to match against.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<string>? values { get; set; } = null;
}