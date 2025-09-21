#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields and values to use when creating quantity price breaks.
/// </summary>
public record QuantityPriceBreakInput : GraphQLInputObject<QuantityPriceBreakInput>
{
    /// <summary>
    /// The minimum required quantity for a variant to qualify for this price.
    /// </summary>
    [JsonPropertyName("minimumQuantity")]
    public int? minimumQuantity { get; set; } = null;

    /// <summary>
    /// The price of the product variant when its quantity meets the break's minimum quantity.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyInput? price { get; set; } = null;

    /// <summary>
    /// The product variant ID associated with the quantity break.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;
}