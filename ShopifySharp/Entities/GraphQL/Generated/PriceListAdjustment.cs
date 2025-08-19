#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type and value of a price list adjustment.
/// For more information on price lists, refer to
/// [Support different pricing models](https://shopify.dev/apps/internationalization/product-price-lists).
/// </summary>
public record PriceListAdjustment : IGraphQLObject
{
    /// <summary>
    /// The type of price adjustment, such as percentage increase or decrease.
    /// </summary>
    [JsonPropertyName("type")]
    public PriceListAdjustmentType? type { get; set; } = null;

    /// <summary>
    /// The value of price adjustment, where positive numbers reduce the prices and negative numbers
    /// increase them.
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? @value { get; set; } = null;
}