#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DraftOrderPlatformDiscountAllocationTargetCalculatedDraftOrderLineItem(CalculatedDraftOrderLineItem Value): DraftOrderPlatformDiscountAllocationTarget;
internal record DraftOrderPlatformDiscountAllocationTargetDraftOrderLineItem(DraftOrderLineItem Value): DraftOrderPlatformDiscountAllocationTarget;
internal record DraftOrderPlatformDiscountAllocationTargetShippingLine(ShippingLine Value): DraftOrderPlatformDiscountAllocationTarget;
#endif /// <summary>

/// A shipping rate is an additional cost added to the cost of the products that were ordered.
/// </summary>
public record DraftOrderShippingRate : IGraphQLObject
{
    /// <summary>
    /// The code of the shipping rate.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// Unique identifier for this shipping rate.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The cost associated with the shipping rate.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// The source of the shipping rate.
    /// </summary>
    [JsonPropertyName("source")]
    public string? source { get; set; } = null;

    /// <summary>
    /// The name of the shipping rate.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}