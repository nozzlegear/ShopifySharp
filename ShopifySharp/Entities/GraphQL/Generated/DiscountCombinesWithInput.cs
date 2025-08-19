#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to determine which discount classes the discount can combine with.
/// </summary>
public record DiscountCombinesWithInput : GraphQLInputObject<DiscountCombinesWithInput>
{
    /// <summary>
    /// Whether the discount combines with the
    /// [order discount](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// class.
    /// </summary>
    [JsonPropertyName("orderDiscounts")]
    public bool? orderDiscounts { get; set; } = null;

    /// <summary>
    /// Whether the discount combines with the
    /// [product discount](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// class.
    /// </summary>
    [JsonPropertyName("productDiscounts")]
    public bool? productDiscounts { get; set; } = null;

    /// <summary>
    /// Whether the discount combines
    /// with the
    /// [shipping discount](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// class.
    /// </summary>
    [JsonPropertyName("shippingDiscounts")]
    public bool? shippingDiscounts { get; set; } = null;
}