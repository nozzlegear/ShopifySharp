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
/// The input fields for a condition based on variant compare at prices.
/// </summary>
public record CollectionSourceInclusionConditionVariantCompareAtPriceInput : GraphQLInputObject<CollectionSourceInclusionConditionVariantCompareAtPriceInput>
{
    /// <summary>
    /// The relationship between the variant compare at price and the condition value.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionSourceInclusionConditionVariantCompareAtPriceRelation? relation { get; set; } = null;

    /// <summary>
    /// The variant compare at price to match against. Required for numeric relations and must be absent for IS_SET or IS_NOT_SET.
    /// </summary>
    [JsonPropertyName("value")]
    public MoneyInput? @value { get; set; } = null;
}