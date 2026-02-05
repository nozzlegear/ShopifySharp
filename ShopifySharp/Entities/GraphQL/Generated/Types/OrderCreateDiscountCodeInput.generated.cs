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
/// The input fields for a discount code to apply to an order. Only one type of discount can be applied to an order.
/// </summary>
public record OrderCreateDiscountCodeInput : GraphQLInputObject<OrderCreateDiscountCodeInput>
{
    /// <summary>
    /// A free shipping discount code applied to the shipping on an order.
    /// </summary>
    [JsonPropertyName("freeShippingDiscountCode")]
    public OrderCreateFreeShippingDiscountCodeAttributesInput? freeShippingDiscountCode { get; set; } = null;

    /// <summary>
    /// A fixed amount discount code applied to the line items on the order.
    /// </summary>
    [JsonPropertyName("itemFixedDiscountCode")]
    public OrderCreateFixedDiscountCodeAttributesInput? itemFixedDiscountCode { get; set; } = null;

    /// <summary>
    /// A percentage discount code applied to the line items on the order.
    /// </summary>
    [JsonPropertyName("itemPercentageDiscountCode")]
    public OrderCreatePercentageDiscountCodeAttributesInput? itemPercentageDiscountCode { get; set; } = null;
}