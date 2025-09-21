#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// This object defines all columns and allowed relations that can be used in rules
/// for smart collections to automatically include the matching products.
/// </summary>
public record CollectionRuleConditions : IGraphQLObject
{
    /// <summary>
    /// Allowed relations of the rule.
    /// </summary>
    [JsonPropertyName("allowedRelations")]
    public ICollection<CollectionRuleRelation>? allowedRelations { get; set; } = null;

    /// <summary>
    /// Most commonly used relation for this rule.
    /// </summary>
    [JsonPropertyName("defaultRelation")]
    public CollectionRuleRelation? defaultRelation { get; set; } = null;

    /// <summary>
    /// Additional attributes defining the rule.
    /// </summary>
    [JsonPropertyName("ruleObject")]
    public CollectionRuleConditionsRuleObject? ruleObject { get; set; } = null;

    /// <summary>
    /// Type of the rule.
    /// </summary>
    [JsonPropertyName("ruleType")]
    public CollectionRuleColumn? ruleType { get; set; } = null;
}