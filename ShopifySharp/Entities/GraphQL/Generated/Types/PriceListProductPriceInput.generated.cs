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
/// The input fields representing the price for all variants of a product.
/// </summary>
public record PriceListProductPriceInput : GraphQLInputObject<PriceListProductPriceInput>
{
    /// <summary>
    /// Specifies the compare-at price and currency to apply to the product's variants on the price list.
    /// </summary>
    [JsonPropertyName("compareAtPrice")]
    public MoneyInput? compareAtPrice { get; set; } = null;

    /// <summary>
    /// Specifies the price and currency to apply to the product's variants on the price list.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyInput? price { get; set; } = null;

    /// <summary>
    /// Specifies the ID of the product to update its variants for.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;
}