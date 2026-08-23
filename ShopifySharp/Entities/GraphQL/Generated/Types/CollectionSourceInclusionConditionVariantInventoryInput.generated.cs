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
/// The input fields for a condition based on variant inventory quantities.
/// </summary>
public record CollectionSourceInclusionConditionVariantInventoryInput : GraphQLInputObject<CollectionSourceInclusionConditionVariantInventoryInput>
{
    /// <summary>
    /// The relationship between the variant inventory and the condition value.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionVariantInventoryRelation? relation { get; set; } = null;

    /// <summary>
    /// The variant inventory quantity to match against.
    /// </summary>
    [JsonPropertyName("value")]
    public int? @value { get; set; } = null;
}