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
/// The input fields for creating inclusion rules for a collection source.
/// </summary>
public record CollectionCreateSourceInclusionInput : GraphQLInputObject<CollectionCreateSourceInclusionInput>
{
    /// <summary>
    /// The conditions that products must match to be included in the collection.
    /// </summary>
    [JsonPropertyName("conditions")]
    public ICollection<CollectionSourceInclusionConditionInput>? conditions { get; set; } = null;

    /// <summary>
    /// Whether products must match all or any of the conditions.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The products to explicitly include in the collection.
    /// </summary>
    [JsonPropertyName("selections")]
    public ICollection<CollectionInclusionProductSelectionInput>? selections { get; set; } = null;
}