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
/// An exclusion condition introduced in a newer API version that is not modeled by
/// this version of the API. Clients should treat the relation and values as opaque strings.
/// </summary>
public record CollectionSourceExclusionConditionUnknown : IGraphQLObject, ICollectionSourceExclusionCondition
{
    /// <summary>
    /// The unique identifier for this exclusion condition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether products must match any or all values. Null when the condition has no concept of a match type.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The relation, as a raw string. Nullable and not coerced into an enum because
    /// the set of possible relations is open-ended for unknown condition types, and
    /// some future conditions may not have a relation at all.
    /// </summary>
    [JsonPropertyName("relation")]
    public string? relation { get; set; } = null;

    /// <summary>
    /// The condition values, as raw strings. Nullable because some future condition types may have no values at all.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<string>? values { get; set; } = null;
}