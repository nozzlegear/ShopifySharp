#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents at rule that's used to assign products to a collection.
/// </summary>
public record CollectionRule : IGraphQLObject
{
    /// <summary>
    /// The attribute that the rule focuses on. For example, `title` or `product_type`.
    /// </summary>
    [JsonPropertyName("column")]
    public CollectionRuleColumn? column { get; set; } = null;

    /// <summary>
    /// The value that the operator is applied to. For example, `Hats`.
    /// </summary>
    [JsonPropertyName("condition")]
    public string? condition { get; set; } = null;

    /// <summary>
    /// The value that the operator is applied to.
    /// </summary>
    [JsonPropertyName("conditionObject")]
    public CollectionRuleConditionObject? conditionObject { get; set; } = null;

    /// <summary>
    /// The type of operator that the rule is based on. For example, `equals`, `contains`, or `not_equals`.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionRuleRelation? relation { get; set; } = null;
}