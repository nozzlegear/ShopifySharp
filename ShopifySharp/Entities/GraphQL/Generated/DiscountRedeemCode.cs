#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A code that a customer can use at checkout to receive a discount. For example, a
/// customer can use the redeem code 'SUMMER20' at checkout to receive a 20%
/// discount on their entire order.
/// </summary>
public record DiscountRedeemCode : IGraphQLObject
{
    /// <summary>
    /// The number of times that the discount redeem code has been used. This value is
    /// updated asynchronously and can be different than the actual usage count.
    /// </summary>
    [JsonPropertyName("asyncUsageCount")]
    public int? asyncUsageCount { get; set; } = null;

    /// <summary>
    /// The code that a customer can use at checkout to receive a discount.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The application that created the discount redeem code.
    /// </summary>
    [JsonPropertyName("createdBy")]
    public App? createdBy { get; set; } = null;

    /// <summary>
    /// A globally-unique ID of the discount redeem code.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}