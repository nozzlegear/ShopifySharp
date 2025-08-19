#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DiscountDiscountAutomaticApp(DiscountAutomaticApp Value): Discount;
internal record DiscountDiscountAutomaticBasic(DiscountAutomaticBasic Value): Discount;
internal record DiscountDiscountAutomaticBxgy(DiscountAutomaticBxgy Value): Discount;
internal record DiscountDiscountAutomaticFreeShipping(DiscountAutomaticFreeShipping Value): Discount;
internal record DiscountDiscountCodeApp(DiscountCodeApp Value): Discount;
internal record DiscountDiscountCodeBasic(DiscountCodeBasic Value): Discount;
internal record DiscountDiscountCodeBxgy(DiscountCodeBxgy Value): Discount;
internal record DiscountDiscountCodeFreeShipping(DiscountCodeFreeShipping Value): Discount;
#endif /// <summary>

/// An amount that's allocated to a line based on an associated discount application.
/// </summary>
public record DiscountAllocation : IGraphQLObject
{
    /// <summary>
    /// The money amount that's allocated to a line based on the associated discount application.
    /// </summary>
    [JsonPropertyName("allocatedAmount")]
    [Obsolete("Use `allocatedAmountSet` instead.")]
    public MoneyV2? allocatedAmount { get; set; } = null;

    /// <summary>
    /// The money amount that's allocated to a line based on the associated discount
    /// application in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("allocatedAmountSet")]
    public MoneyBag? allocatedAmountSet { get; set; } = null;

    /// <summary>
    /// The discount application that the allocated amount originated from.
    /// </summary>
    [JsonPropertyName("discountApplication")]
    public IDiscountApplication? discountApplication { get; set; } = null;
}