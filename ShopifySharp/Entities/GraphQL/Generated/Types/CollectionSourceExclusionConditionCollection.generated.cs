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
/// A condition based on collections for excluding products from a collection.
/// </summary>
public record CollectionSourceExclusionConditionCollection : IGraphQLObject, ICollectionSourceExclusionCondition
{
    /// <summary>
    /// The unique identifier for this exclusion condition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Collection exclusion conditions always match any referenced collection.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The collection values whose products are excluded.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<Collection>? values { get; set; } = null;
}