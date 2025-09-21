#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a fixed amount discount code to apply to an order.
/// </summary>
public record OrderCreateFixedDiscountCodeAttributesInput : GraphQLInputObject<OrderCreateFixedDiscountCodeAttributesInput>
{
    /// <summary>
    /// The amount that's deducted from the order total. When you create an order, this value is the monetary amount to deduct.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBagInput? amountSet { get; set; } = null;

    /// <summary>
    /// The discount code that was entered at checkout.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;
}