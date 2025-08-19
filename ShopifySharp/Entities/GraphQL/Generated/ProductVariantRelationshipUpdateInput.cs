#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for updating a composite product variant.
/// </summary>
public record ProductVariantRelationshipUpdateInput : GraphQLInputObject<ProductVariantRelationshipUpdateInput>
{
    /// <summary>
    /// A product ID which contains product variants that have relationships with other variants.
    /// </summary>
    [JsonPropertyName("parentProductId")]
    public string? parentProductId { get; set; } = null;

    /// <summary>
    /// The product variant ID representing that which contains the relationships with other variants.
    /// </summary>
    [JsonPropertyName("parentProductVariantId")]
    public string? parentProductVariantId { get; set; } = null;

    /// <summary>
    /// Method in which to update the price of the parent product variant.
    /// </summary>
    [JsonPropertyName("priceInput")]
    public PriceInput? priceInput { get; set; } = null;

    /// <summary>
    /// The product variants and associated quantitites to add to the product variant.
    /// </summary>
    [JsonPropertyName("productVariantRelationshipsToCreate")]
    public ICollection<ProductVariantGroupRelationshipInput>? productVariantRelationshipsToCreate { get; set; } = null;

    /// <summary>
    /// The bundle component product variants to be removed from the product variant.
    /// </summary>
    [JsonPropertyName("productVariantRelationshipsToRemove")]
    public ICollection<string>? productVariantRelationshipsToRemove { get; set; } = null;

    /// <summary>
    /// The product variants and associated quantitites to update in specified product variant.
    /// </summary>
    [JsonPropertyName("productVariantRelationshipsToUpdate")]
    public ICollection<ProductVariantGroupRelationshipInput>? productVariantRelationshipsToUpdate { get; set; } = null;

    /// <summary>
    /// Whether to remove all components from the product variant. The default value is `false`.
    /// </summary>
    [JsonPropertyName("removeAllProductVariantRelationships")]
    public bool? removeAllProductVariantRelationships { get; set; } = null;
}