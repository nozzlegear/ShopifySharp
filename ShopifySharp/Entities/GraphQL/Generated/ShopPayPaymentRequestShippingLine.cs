#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a shipping line for a Shop Pay payment request.
/// </summary>
public record ShopPayPaymentRequestShippingLine : IGraphQLObject
{
    /// <summary>
    /// The amount for the shipping line.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// The code of the shipping line.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The label of the shipping line.
    /// </summary>
    [JsonPropertyName("label")]
    public string? label { get; set; } = null;
}