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
/// The [discount classes](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
/// that you can use in combination with
/// [Shopify discount types](https://help.shopify.com/manual/discounts/discount-types).
/// </summary>
public record DiscountCombinesWith : IGraphQLObject
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
    /// Whether the discount combines with the
    /// [shipping discount](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// class.
    /// </summary>
    [JsonPropertyName("shippingDiscounts")]
    public bool? shippingDiscounts { get; set; } = null;
}