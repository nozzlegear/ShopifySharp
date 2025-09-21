#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a price list, including information about related prices and eligibility rules.
/// You can use price lists to specify either fixed prices or adjusted relative prices that
/// override initial product variant prices. Price lists are applied to customers
/// using context rules, which determine price list eligibility.
///   For more information on price lists, refer to
///   [Support different pricing models](https://shopify.dev/apps/internationalization/product-price-lists).
/// </summary>
public record PriceList : IGraphQLObject, INode
{
    /// <summary>
    /// The catalog that the price list is associated with.
    /// </summary>
    [JsonPropertyName("catalog")]
    public ICatalog? catalog { get; set; } = null;

    /// <summary>
    /// The currency for fixed prices associated with this price list.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? currency { get; set; } = null;

    /// <summary>
    /// The number of fixed prices on the price list.
    /// </summary>
    [JsonPropertyName("fixedPricesCount")]
    public int? fixedPricesCount { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The unique name of the price list, used as a human-readable identifier.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Relative adjustments to other prices.
    /// </summary>
    [JsonPropertyName("parent")]
    public PriceListParent? parent { get; set; } = null;

    /// <summary>
    /// A list of prices associated with the price list.
    /// </summary>
    [JsonPropertyName("prices")]
    public PriceListPriceConnection? prices { get; set; } = null;

    /// <summary>
    /// A list of quantity rules associated with the price list, ordered by product variants.
    /// </summary>
    [JsonPropertyName("quantityRules")]
    public QuantityRuleConnection? quantityRules { get; set; } = null;
}