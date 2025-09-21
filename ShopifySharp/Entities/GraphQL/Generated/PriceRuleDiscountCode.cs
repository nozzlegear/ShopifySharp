#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A discount code of a price rule.
/// </summary>
public record PriceRuleDiscountCode : IGraphQLObject, INode
{
    /// <summary>
    /// The application that created the discount code.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The code to apply the discount.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The number of times that the price rule has been used. This value is updated
    /// asynchronously and can be different than the actual usage count.
    /// </summary>
    [JsonPropertyName("usageCount")]
    public int? usageCount { get; set; } = null;
}