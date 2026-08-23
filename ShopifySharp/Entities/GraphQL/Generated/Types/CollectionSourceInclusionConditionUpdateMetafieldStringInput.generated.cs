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
/// The input fields for updating a condition based on string metafield values.
/// </summary>
public record CollectionSourceInclusionConditionUpdateMetafieldStringInput : GraphQLInputObject<CollectionSourceInclusionConditionUpdateMetafieldStringInput>
{
    /// <summary>
    /// The ID of the metafield definition.
    /// </summary>
    [JsonPropertyName("definitionId")]
    public string? definitionId { get; set; } = null;

    /// <summary>
    /// Whether to match any or all of the values.
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