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
/// The input fields for updating a condition based on variant weights.
/// </summary>
public record CollectionSourceInclusionConditionUpdateVariantWeightInput : GraphQLInputObject<CollectionSourceInclusionConditionUpdateVariantWeightInput>
{
    /// <summary>
    /// The relationship between the variant weight and the condition value.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionVariantWeightRelation? relation { get; set; } = null;

    /// <summary>
    /// The variant weight to match against.
    /// </summary>
    [JsonPropertyName("value")]
    public WeightInput? @value { get; set; } = null;
}