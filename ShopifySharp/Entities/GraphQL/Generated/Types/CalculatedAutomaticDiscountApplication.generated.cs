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
/// A discount that is automatically applied to an order that is being edited.
/// </summary>
public record CalculatedAutomaticDiscountApplication : IGraphQLObject, ICalculatedDiscountApplication
{
    /// <summary>
    /// The method by which the discount's value is allocated to its entitled items.
    /// </summary>
    [JsonPropertyName("allocationMethod")]
    public DiscountApplicationAllocationMethod? allocationMethod { get; set; } = null;

    /// <summary>
    /// The level at which the discount was applied.
    /// </summary>
    [JsonPropertyName("appliedTo")]
    public DiscountApplicationLevel? appliedTo { get; set; } = null;

    /// <summary>
    /// The description of discount application. Indicates the reason why the discount was applied.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

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
    /// The value of the discount application.
    /// </summary>
    [JsonPropertyName("value")]
    public PricingValue? @value { get; set; } = null;
}