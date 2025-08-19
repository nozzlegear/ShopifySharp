#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies the condition for a text field.
/// </summary>
public record CollectionRuleTextCondition : CollectionRuleConditionObject, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The value of the condition.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}