#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Discount applications capture the intentions of a discount source at
/// the time of application on an order's line items or shipping lines.
/// Discount applications don't represent the actual final amount discounted on a
/// line (line item or shipping line). The actual amount discounted on a line is
/// represented by the [DiscountAllocation](https://shopify.dev/api/admin-graphql/latest/objects/discountallocation) object.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(AutomaticDiscountApplication), typeDiscriminator: "AutomaticDiscountApplication")]
[JsonDerivedType(typeof(DiscountCodeApplication), typeDiscriminator: "DiscountCodeApplication")]
[JsonDerivedType(typeof(ManualDiscountApplication), typeDiscriminator: "ManualDiscountApplication")]
[JsonDerivedType(typeof(ScriptDiscountApplication), typeDiscriminator: "ScriptDiscountApplication")]
public interface IDiscountApplication : IGraphQLObject
{
    /// <summary>
    /// The method by which the discount's value is applied to its entitled items.
    /// </summary>
    [JsonPropertyName("allocationMethod")]
    public DiscountApplicationAllocationMethod? allocationMethod { get; set; }

    /// <summary>
    /// An ordered index that can be used to identify the discount application and indicate the precedence
    /// of the discount application for calculations.
    /// </summary>
    [JsonPropertyName("index")]
    public int? index { get; set; }

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