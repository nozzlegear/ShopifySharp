#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a discount for a Shop Pay payment request.
/// </summary>
public record ShopPayPaymentRequestDiscount : IGraphQLObject
{
    /// <summary>
    /// The amount of the discount.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// The label of the discount.
    /// </summary>
    [JsonPropertyName("label")]
    public string? label { get; set; } = null;
}