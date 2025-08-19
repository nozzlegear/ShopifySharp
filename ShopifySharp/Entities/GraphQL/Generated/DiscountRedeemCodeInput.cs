#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the redeem code to attach to a discount.
/// </summary>
public record DiscountRedeemCodeInput : GraphQLInputObject<DiscountRedeemCodeInput>
{
    /// <summary>
    /// The code that a customer can use at checkout to receive the associated discount.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;
}