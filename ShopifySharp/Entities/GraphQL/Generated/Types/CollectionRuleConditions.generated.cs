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
/// Defines the available columns and relationships that can be used when creating
/// rules for smart collections. This provides the schema for building automated
/// collection logic based on product attributes.
/// For example, merchants can create rules like "product type equals 'Shirts'" or
/// "vendor contains 'Nike'" using the conditions defined in this object to
/// automatically populate collections.
/// Use `CollectionRuleConditions` to:
/// - Discovering valid field options for smart collection rule interfaces
/// - Understanding which conditions are available for automated collections
/// - Exploring available product attributes for collection automation
/// - Learning about proper field relationships for rule implementation
/// The conditions define which product fields can be used in smart collection rules
/// and what types of comparisons are allowed for each field.
/// Learn more about [smart collections](https://shopify.dev/docs/api/admin-graphql/latest/objects/Collection).
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