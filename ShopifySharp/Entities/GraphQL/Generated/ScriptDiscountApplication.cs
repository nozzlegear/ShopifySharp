#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Script discount applications capture the intentions of a discount that
/// was created by a Shopify Script for an order's line item or shipping line.
/// Discount applications don't represent the actual final amount discounted on a
/// line (line item or shipping line). The actual amount discounted on a line is
/// represented by the [DiscountAllocation](https://shopify.dev/api/admin-graphql/latest/objects/discountallocation) object.
/// </summary>
public record ScriptDiscountApplication : IGraphQLObject, IDiscountApplication
{
    /// <summary>
    /// The method by which the discount's value is applied to its entitled items.
    /// </summary>
    [JsonPropertyName("allocationMethod")]
    public DiscountApplicationAllocationMethod? allocationMethod { get; set; } = null;

    /// <summary>
    /// The description of the application as defined by the Script.
    /// </summary>
    [JsonPropertyName("description")]
    [Obsolete("Use `title` instead.")]
    public string? description { get; set; } = null;

    /// <summary>
    /// An ordered index that can be used to identify the discount application and indicate the precedence
    /// of the discount application for calculations.
    /// </summary>
    [JsonPropertyName("index")]
    public int? index { get; set; } = null;

    /// <summary>
    /// How the discount amount is distributed on the discounted lines.
    /// </summary>
    [JsonPropertyName("targetSelection")]
    public DiscountApplicationTargetSelection? targetSelection { get; set; } = null;

    /// <summary>
    /// Whether the discount is applied on line items or shipping lines.
    /// </summary>
    [JsonPropertyName("targetType")]
    public DiscountApplicationTargetType? targetType { get; set; } = null;

    /// <summary>
    /// The title of the application as defined by the Script.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The value of the discount application.
    /// </summary>
    [JsonPropertyName("value")]
    public PricingValue? @value { get; set; } = null;
}