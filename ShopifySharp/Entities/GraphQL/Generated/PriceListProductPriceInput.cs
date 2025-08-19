#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields representing the price for all variants of a product.
/// </summary>
public record PriceListProductPriceInput : GraphQLInputObject<PriceListProductPriceInput>
{
    /// <summary>
    /// The price of the product to use for all variants with its currency.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyInput? price { get; set; } = null;

    /// <summary>
    /// Specifies the ID of the product to update its variants for.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;
}