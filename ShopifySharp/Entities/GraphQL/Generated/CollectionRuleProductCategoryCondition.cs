#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies the condition for a Product Category field.
/// </summary>
public record CollectionRuleProductCategoryCondition : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The value of the condition.
    /// </summary>
    [JsonPropertyName("value")]
    public ProductTaxonomyNode? @value { get; set; } = null;
}