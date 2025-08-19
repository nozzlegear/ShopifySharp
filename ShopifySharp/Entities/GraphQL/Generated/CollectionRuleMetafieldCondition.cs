#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Identifies a metafield definition used as a rule for the smart collection.
/// </summary>
public record CollectionRuleMetafieldCondition : CollectionRuleConditionObject, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The metafield definition associated with the condition.
    /// </summary>
    [JsonPropertyName("metafieldDefinition")]
    public MetafieldDefinition? metafieldDefinition { get; set; } = null;
}