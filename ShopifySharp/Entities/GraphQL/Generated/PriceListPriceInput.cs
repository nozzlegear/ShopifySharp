#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for providing the fields and values to use when creating or updating a fixed price list price.
/// </summary>
public record PriceListPriceInput : GraphQLInputObject<PriceListPriceInput>
{
    /// <summary>
    /// The compare-at price of the product variant on this price list.
    /// </summary>
    [JsonPropertyName("compareAtPrice")]
    public MoneyInput? compareAtPrice { get; set; } = null;

    /// <summary>
    /// The price of the product variant on this price list.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyInput? price { get; set; } = null;

    /// <summary>
    /// The product variant ID associated with the price list price.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;
}