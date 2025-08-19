#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The price of a product in a specific country.
/// Prices vary between countries.
/// Refer to [Product](https://shopify.dev/docs/api/admin-graphql/latest/queries/product?example=Get+the+price+range+for+a+product+for+buyers+from+Canada)
/// for more information on how to use this object.
/// </summary>
public record ProductContextualPricing : IGraphQLObject
{
    /// <summary>
    /// The number of fixed quantity rules for the product's variants on the price list.
    /// </summary>
    [JsonPropertyName("fixedQuantityRulesCount")]
    public int? fixedQuantityRulesCount { get; set; } = null;

    /// <summary>
    /// The pricing of the variant with the highest price in the given context.
    /// </summary>
    [JsonPropertyName("maxVariantPricing")]
    public ProductVariantContextualPricing? maxVariantPricing { get; set; } = null;

    /// <summary>
    /// The pricing of the variant with the lowest price in the given context.
    /// </summary>
    [JsonPropertyName("minVariantPricing")]
    public ProductVariantContextualPricing? minVariantPricing { get; set; } = null;

    /// <summary>
    /// The minimum and maximum prices of a product, expressed in decimal numbers.
    /// For example, if the product is priced between $10.00 and $50.00,
    /// then the price range is $10.00 - $50.00.
    /// </summary>
    [JsonPropertyName("priceRange")]
    public ProductPriceRangeV2? priceRange { get; set; } = null;
}