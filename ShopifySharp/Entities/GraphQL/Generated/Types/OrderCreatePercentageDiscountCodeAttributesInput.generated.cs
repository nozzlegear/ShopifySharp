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
/// The input fields for a percentage discount code to apply to an order.
/// </summary>
public record OrderCreatePercentageDiscountCodeAttributesInput : GraphQLInputObject<OrderCreatePercentageDiscountCodeAttributesInput>
{
    /// <summary>
    /// The discount code that was entered at checkout.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The amount that's deducted from the order total. When you create an order, this value is the percentage to deduct.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}