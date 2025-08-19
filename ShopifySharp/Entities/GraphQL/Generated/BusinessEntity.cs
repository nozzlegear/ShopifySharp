#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a merchant's Business Entity.
/// </summary>
public record BusinessEntity : IGraphQLObject, INode
{
    /// <summary>
    /// The address of the merchant's Business Entity.
    /// </summary>
    [JsonPropertyName("address")]
    public BusinessEntityAddress? address { get; set; } = null;

    /// <summary>
    /// Whether the Business Entity is archived from the shop.
    /// </summary>
    [JsonPropertyName("archived")]
    public bool? archived { get; set; } = null;

    /// <summary>
    /// The name of the company associated with the merchant's Business Entity.
    /// </summary>
    [JsonPropertyName("companyName")]
    public string? companyName { get; set; } = null;

    /// <summary>
    /// The display name of the merchant's Business Entity.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether it's the merchant's primary Business Entity.
    /// </summary>
    [JsonPropertyName("primary")]
    public bool? primary { get; set; } = null;

    /// <summary>
    /// Shopify Payments account information, including balances and payouts.
    /// </summary>
    [JsonPropertyName("shopifyPaymentsAccount")]
    public ShopifyPaymentsAccount? shopifyPaymentsAccount { get; set; } = null;
}