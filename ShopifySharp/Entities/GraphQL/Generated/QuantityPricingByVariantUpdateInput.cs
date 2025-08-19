#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update quantity pricing.
/// </summary>
public record QuantityPricingByVariantUpdateInput : GraphQLInputObject<QuantityPricingByVariantUpdateInput>
{
    /// <summary>
    /// A list of fixed prices to add.
    /// </summary>
    [JsonPropertyName("pricesToAdd")]
    public ICollection<PriceListPriceInput>? pricesToAdd { get; set; } = null;

    /// <summary>
    /// A list of variant IDs that identify which fixed prices to remove.
    /// </summary>
    [JsonPropertyName("pricesToDeleteByVariantId")]
    public ICollection<string>? pricesToDeleteByVariantId { get; set; } = null;

    /// <summary>
    /// A list of quantity price breaks to add.
    /// </summary>
    [JsonPropertyName("quantityPriceBreaksToAdd")]
    public ICollection<QuantityPriceBreakInput>? quantityPriceBreaksToAdd { get; set; } = null;

    /// <summary>
    /// A list of quantity price break IDs that identify which quantity breaks to remove.
    /// </summary>
    [JsonPropertyName("quantityPriceBreaksToDelete")]
    public ICollection<string>? quantityPriceBreaksToDelete { get; set; } = null;

    /// <summary>
    /// A list of product variant IDs that identify which quantity breaks to remove.
    /// </summary>
    [JsonPropertyName("quantityPriceBreaksToDeleteByVariantId")]
    public ICollection<string>? quantityPriceBreaksToDeleteByVariantId { get; set; } = null;

    /// <summary>
    /// A list of quantity rules to add.
    /// </summary>
    [JsonPropertyName("quantityRulesToAdd")]
    public ICollection<QuantityRuleInput>? quantityRulesToAdd { get; set; } = null;

    /// <summary>
    /// A list of variant IDs that identify which quantity rules to remove.
    /// </summary>
    [JsonPropertyName("quantityRulesToDeleteByVariantId")]
    public ICollection<string>? quantityRulesToDeleteByVariantId { get; set; } = null;
}