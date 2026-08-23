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
/// The input fields for updating inclusion rules for a collection source.
/// </summary>
public record CollectionUpdateSourceInclusionInput : GraphQLInputObject<CollectionUpdateSourceInclusionInput>
{
    /// <summary>
    /// The conditions to create for the source.
    /// </summary>
    [JsonPropertyName("conditionsToCreate")]
    public ICollection<CollectionSourceInclusionConditionInput>? conditionsToCreate { get; set; } = null;

    /// <summary>
    /// The IDs of the conditions to delete from the source.
    /// </summary>
    [JsonPropertyName("conditionsToDelete")]
    public ICollection<string>? conditionsToDelete { get; set; } = null;

    /// <summary>
    /// The conditions to update for the source.
    /// </summary>
    [JsonPropertyName("conditionsToUpdate")]
    public ICollection<CollectionUpdateSourceInclusionConditionInput>? conditionsToUpdate { get; set; } = null;

    /// <summary>
    /// Whether products must match all or any of the conditions.
    /// </summary>
    [JsonPropertyName("matchType")]
    public CollectionConditionMatchType? matchType { get; set; } = null;

    /// <summary>
    /// The product selections to add to the source.
    /// </summary>
    [JsonPropertyName("selectionsToAdd")]
    public ICollection<CollectionInclusionProductSelectionInput>? selectionsToAdd { get; set; } = null;

    /// <summary>
    /// The product selections to remove from the source. For sources that target
    /// variants, omitting variant IDs will remove all for the product.
    /// </summary>
    [JsonPropertyName("selectionsToRemove")]
    public ICollection<CollectionInclusionProductSelectionInput>? selectionsToRemove { get; set; } = null;
}