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
/// Pricing for a [`ProductVariant`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant) on a [`PriceList`](https://shopify.dev/docs/api/admin-graphql/latest/objects/PriceList). Represents the variant's price, compare-at price, and whether the price is fixed
/// or calculated using percentage-based adjustments. The [`PriceListPriceOriginType`](https://shopify.dev/docs/api/admin-graphql/latest/enums/PriceListPriceOriginType)
/// distinguishes between prices set directly on the price list (fixed) and prices
/// calculated using the price list's adjustment configuration (relative).
/// Learn more about [building catalogs with different pricing
/// models](https://shopify.dev/docs/apps/build/markets/build-catalog).
/// </summary>
public record PriceListPrice : IGraphQLObject
{
    /// <summary>
    /// The compare-at price of the product variant on this price list.
    /// </summary>
    [JsonPropertyName("compareAtPrice")]
    public MoneyV2? compareAtPrice { get; set; } = null;

    /// <summary>
    /// The origin of a price, either fixed (defined on the price list) or relative
    /// (calculated using a price list adjustment configuration).
    /// </summary>
    [JsonPropertyName("originType")]
    public PriceListPriceOriginType? originType { get; set; } = null;

    /// <summary>
    /// The price of the product variant on this price list.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// A list of quantity breaks for the product variant.
    /// </summary>
    [JsonPropertyName("quantityPriceBreaks")]
    public QuantityPriceBreakConnection? quantityPriceBreaks { get; set; } = null;

    /// <summary>
    /// The product variant associated with this price.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;
}