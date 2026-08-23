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
/// The input fields for creating exclusion rules for a collection source.
/// </summary>
public record CollectionCreateSourceExclusionInput : GraphQLInputObject<CollectionCreateSourceExclusionInput>
{
    /// <summary>
    /// The conditions that products must match to be excluded from the collection.
    /// </summary>
    [JsonPropertyName("conditions")]
    public ICollection<CollectionSourceExclusionConditionInput>? conditions { get; set; } = null;

    /// <summary>
    /// Whether products must match all or any of the conditions to be excluded.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The products to explicitly exclude from the collection.
    /// </summary>
    [JsonPropertyName("selections")]
    public ICollection<CollectionExclusionProductSelectionInput>? selections { get; set; } = null;
}