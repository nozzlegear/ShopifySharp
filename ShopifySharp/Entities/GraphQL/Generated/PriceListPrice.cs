#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents information about pricing for a product variant
///         as defined on a price list, such as the price, compare at price, and
/// origin type. You can use a `PriceListPrice` to specify a fixed price for a
/// specific product variant. For examples, refer to [PriceListFixedPricesAdd](https://shopify.dev/api/admin-graphql/latest/mutations/priceListFixedPricesAdd) and [PriceList](https://shopify.dev/api/admin-graphql/latest/queries/priceList#section-examples).
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