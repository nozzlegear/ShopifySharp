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
/// Defines the rules and selections for including products in a collection.
/// </summary>
public record CollectionSourceInclusion : IGraphQLObject
{
    /// <summary>
    /// The conditions that determine which products are included in the collection.
    /// </summary>
    [JsonPropertyName("conditions")]
    public ICollection<ICollectionSourceInclusionCondition>? conditions { get; set; } = null;

    /// <summary>
    /// Specifies whether products must match any or all conditions. Only relevant when conditions are present.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The products that have been manually selected for inclusion in the collection.
    /// </summary>
    [JsonPropertyName("selections")]
    public CollectionInclusionProductSelectionConnection? selections { get; set; } = null;
}