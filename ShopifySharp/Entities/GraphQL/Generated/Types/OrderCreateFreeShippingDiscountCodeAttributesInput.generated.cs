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
/// The input fields for a free shipping discount code to apply to an order.
/// </summary>
public record OrderCreateFreeShippingDiscountCodeAttributesInput : GraphQLInputObject<OrderCreateFreeShippingDiscountCodeAttributesInput>
{
    /// <summary>
    /// The discount code that was entered at checkout.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;
}