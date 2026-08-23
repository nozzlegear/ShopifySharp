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
/// The input fields for updating a condition based on variant prices.
/// </summary>
public record CollectionSourceInclusionConditionUpdateVariantPriceInput : GraphQLInputObject<CollectionSourceInclusionConditionUpdateVariantPriceInput>
{
    /// <summary>
    /// The relationship between the variant price and the condition value.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionVariantPriceRelation? relation { get; set; } = null;

    /// <summary>
    /// The variant price to match against.
    /// </summary>
    [JsonPropertyName("value")]
    public MoneyInput? @value { get; set; } = null;
}