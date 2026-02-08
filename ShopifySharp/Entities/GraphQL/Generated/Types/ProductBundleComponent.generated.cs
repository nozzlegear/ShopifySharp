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
/// The product's component information.
/// </summary>
public record ProductBundleComponent : IGraphQLObject
{
    /// <summary>
    /// The product that's related as a component.
    /// </summary>
    [JsonPropertyName("componentProduct")]
    public Product? componentProduct { get; set; } = null;

    /// <summary>
    /// The list of products' variants that are components.
    /// </summary>
    [JsonPropertyName("componentVariants")]
    public ProductVariantConnection? componentVariants { get; set; } = null;

    /// <summary>
    /// The number of component variants for the product component.
    /// </summary>
    [JsonPropertyName("componentVariantsCount")]
    public Count? componentVariantsCount { get; set; } = null;

    /// <summary>
    /// The options in the parent and the component options they're connected to, along with the chosen option values
    /// that appear in the bundle.
    /// </summary>
    [JsonPropertyName("optionSelections")]
    public ICollection<ProductBundleComponentOptionSelection>? optionSelections { get; set; } = null;

    /// <summary>
    /// The quantity of the component product set for this bundle line.
    /// It will be null if there's a quantityOption present.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The quantity as option of the component product. It will be null if there's a quantity set.
    /// </summary>
    [JsonPropertyName("quantityOption")]
    public ProductBundleComponentQuantityOption? quantityOption { get; set; } = null;
}