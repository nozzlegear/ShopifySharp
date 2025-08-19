#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a single component related to a componentized product.
/// </summary>
public record ProductBundleComponentInput : GraphQLInputObject<ProductBundleComponentInput>
{
    /// <summary>
    /// The options to use in the component product, and the values for the option.
    /// </summary>
    [JsonPropertyName("optionSelections")]
    public ICollection<ProductBundleComponentOptionSelectionInput>? optionSelections { get; set; } = null;

    /// <summary>
    /// The ID of the component product to add to the bundle product.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;

    /// <summary>
    /// The quantity of the component product to add to the bundle product. This field can't exceed 2000.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// New option to be created on the bundle parent that enables the buyer to select different quantities for
    /// this component (e.g. two-pack, three-pack). Can only be used if quantity isn't set.
    /// </summary>
    [JsonPropertyName("quantityOption")]
    public ProductBundleComponentQuantityOptionInput? quantityOption { get; set; } = null;
}