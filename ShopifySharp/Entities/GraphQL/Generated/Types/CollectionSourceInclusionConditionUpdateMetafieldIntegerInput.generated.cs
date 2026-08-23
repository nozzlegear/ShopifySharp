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
/// The input fields for updating a condition based on integer metafield values.
/// </summary>
public record CollectionSourceInclusionConditionUpdateMetafieldIntegerInput : GraphQLInputObject<CollectionSourceInclusionConditionUpdateMetafieldIntegerInput>
{
    /// <summary>
    /// The ID of the metafield definition.
    /// </summary>
    [JsonPropertyName("definitionId")]
    public string? definitionId { get; set; } = null;

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