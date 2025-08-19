#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update a price list.
/// </summary>
public record PriceListUpdateInput : GraphQLInputObject<PriceListUpdateInput>
{
    /// <summary>
    /// The ID of the catalog to associate with this price list.
    /// </summary>
    [JsonPropertyName("catalogId")]
    public string? catalogId { get; set; } = null;

    /// <summary>
    /// The three-letter currency code for fixed prices associated with this price list.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? currency { get; set; } = null;

    /// <summary>
    /// The unique name of the price list, used as a human-readable identifier.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Relative adjustments to other prices.
    /// </summary>
    [JsonPropertyName("parent")]
    public PriceListParentUpdateInput? parent { get; set; } = null;
}