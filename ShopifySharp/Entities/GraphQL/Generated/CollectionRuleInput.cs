#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a rule to associate with a collection.
/// </summary>
public record CollectionRuleInput : GraphQLInputObject<CollectionRuleInput>
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
    /// The object ID that points to additional attributes for the collection rule.
    /// This is only required when using metafield definition rules.
    /// </summary>
    [JsonPropertyName("conditionObjectId")]
    public string? conditionObjectId { get; set; } = null;

    /// <summary>
    /// The type of operator that the rule is based on. For example, `equals`, `contains`, or `not_equals`.
    /// </summary>
    [JsonPropertyName("relation")]
    public CollectionRuleRelation? relation { get; set; } = null;
}