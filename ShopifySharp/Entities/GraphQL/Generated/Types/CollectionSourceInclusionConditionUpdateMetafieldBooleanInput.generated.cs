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
/// The input fields for updating a condition based on boolean metafield values.
/// </summary>
public record CollectionSourceInclusionConditionUpdateMetafieldBooleanInput : GraphQLInputObject<CollectionSourceInclusionConditionUpdateMetafieldBooleanInput>
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
    public CollectionSourceInclusionConditionMetafieldBooleanRelation? relation { get; set; } = null;

    /// <summary>
    /// The boolean value to match against.
    /// </summary>
    [JsonPropertyName("value")]
    public bool? @value { get; set; } = null;
}