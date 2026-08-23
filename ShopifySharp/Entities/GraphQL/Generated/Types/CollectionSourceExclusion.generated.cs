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
/// Defines the rules and selections for excluding products from a collection.
/// </summary>
public record CollectionSourceExclusion : IGraphQLObject
{
    /// <summary>
    /// The conditions that determine which products are excluded from the collection.
    /// </summary>
    [JsonPropertyName("conditions")]
    public ICollection<ICollectionSourceExclusionCondition>? conditions { get; set; } = null;

    /// <summary>
    /// Specifies whether products must match any or all non-collection exclusion conditions. Collection exclusion
    /// conditions are always applied independently with ANY semantics, so this field returns ANY for
    /// collection-only exclusions and null when collection and non-collection exclusion conditions are mixed.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The products that have been manually selected for exclusion from the collection.
    /// </summary>
    [JsonPropertyName("selections")]
    public CollectionExclusionProductSelectionConnection? selections { get; set; } = null;
}