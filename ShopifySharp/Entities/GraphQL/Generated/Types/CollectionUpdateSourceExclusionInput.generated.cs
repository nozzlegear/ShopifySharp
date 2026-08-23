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
/// The input fields for updating exclusion rules for a collection source.
/// </summary>
public record CollectionUpdateSourceExclusionInput : GraphQLInputObject<CollectionUpdateSourceExclusionInput>
{
    /// <summary>
    /// The exclusion conditions to create for the source.
    /// </summary>
    [JsonPropertyName("conditionsToCreate")]
    public ICollection<CollectionSourceExclusionConditionInput>? conditionsToCreate { get; set; } = null;

    /// <summary>
    /// The IDs of the exclusion conditions to delete from the source.
    /// </summary>
    [JsonPropertyName("conditionsToDelete")]
    public ICollection<string>? conditionsToDelete { get; set; } = null;

    /// <summary>
    /// The exclusion conditions to update for the source.
    /// </summary>
    [JsonPropertyName("conditionsToUpdate")]
    public ICollection<CollectionUpdateSourceExclusionConditionInput>? conditionsToUpdate { get; set; } = null;

    /// <summary>
    /// Whether products must match all or any of the conditions to be excluded.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The product selections to add to the source.
    /// </summary>
    [JsonPropertyName("selectionsToAdd")]
    public ICollection<CollectionExclusionProductSelectionInput>? selectionsToAdd { get; set; } = null;

    /// <summary>
    /// The product selections to remove from the source.
    /// </summary>
    [JsonPropertyName("selectionsToRemove")]
    public ICollection<CollectionExclusionProductSelectionInput>? selectionsToRemove { get; set; } = null;
}