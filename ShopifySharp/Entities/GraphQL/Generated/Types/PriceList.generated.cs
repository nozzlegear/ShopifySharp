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
/// A list that defines pricing for [product variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant).
/// Price lists override default product prices with either fixed prices or
/// percentage-based adjustments.
/// Each price list associates with a [`Catalog`](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/Catalog)
/// to determine which customers see the pricing. The catalog's context rules
/// control when the price list applies, such as for specific markets, company
/// locations, or apps.
/// Learn how to [support different pricing models](https://shopify.dev/docs/apps/build/markets/build-catalog).
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