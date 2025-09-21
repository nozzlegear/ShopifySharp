#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A [discount application](https://shopify.dev/api/admin-graphql/latest/interfaces/discountapplication) involved in order editing that might be newly added or have new changes applied.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CalculatedAutomaticDiscountApplication), typeDiscriminator: "CalculatedAutomaticDiscountApplication")]
[JsonDerivedType(typeof(CalculatedDiscountCodeApplication), typeDiscriminator: "CalculatedDiscountCodeApplication")]
[JsonDerivedType(typeof(CalculatedManualDiscountApplication), typeDiscriminator: "CalculatedManualDiscountApplication")]
[JsonDerivedType(typeof(CalculatedScriptDiscountApplication), typeDiscriminator: "CalculatedScriptDiscountApplication")]
public interface ICalculatedDiscountApplication : IGraphQLObject
{
    /// <summary>
    /// The method by which the discount's value is allocated to its entitled items.
    /// </summary>
    [JsonPropertyName("allocationMethod")]
    public DiscountApplicationAllocationMethod? allocationMethod { get; set; }

    /// <summary>
    /// The level at which the discount was applied.
    /// </summary>
    [JsonPropertyName("appliedTo")]
    public DiscountApplicationLevel? appliedTo { get; set; }

    /// <summary>
    /// The description of discount application. Indicates the reason why the discount was applied.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; }

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// How the discount amount is distributed on the discounted lines.
    /// </summary>
    [JsonPropertyName("targetSelection")]
    public DiscountApplicationTargetSelection? targetSelection { get; set; }

    /// <summary>
    /// Whether the discount is applied on line items or shipping lines.
    /// </summary>
    [JsonPropertyName("targetType")]
    public DiscountApplicationTargetType? targetType { get; set; }

    /// <summary>
    /// The value of the discount application.
    /// </summary>
    [JsonPropertyName("value")]
    public PricingValue? @value { get; set; }
}