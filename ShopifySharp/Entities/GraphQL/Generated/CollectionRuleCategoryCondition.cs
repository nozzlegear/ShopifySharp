#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies the taxonomy category to used for the condition.
/// </summary>
public record CollectionRuleCategoryCondition : CollectionRuleConditionObject, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The taxonomy category used as condition.
    /// </summary>
    [JsonPropertyName("value")]
    public TaxonomyCategory? @value { get; set; } = null;
}