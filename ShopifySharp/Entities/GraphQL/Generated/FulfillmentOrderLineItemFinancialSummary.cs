#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The financial details of a fulfillment order line item.
/// </summary>
public record FulfillmentOrderLineItemFinancialSummary : IGraphQLObject
{
    /// <summary>
    /// The approximate split price of a line item unit, in shop and presentment
    /// currencies. This value doesn't include discounts applied to the entire
    /// order.For the full picture of applied discounts, see discountAllocations.
    /// </summary>
    [JsonPropertyName("approximateDiscountedUnitPriceSet")]
    public MoneyBag? approximateDiscountedUnitPriceSet { get; set; } = null;

    /// <summary>
    /// The discounts that have been allocated onto the line item by discount applications, not including order edits and refunds.
    /// </summary>
    [JsonPropertyName("discountAllocations")]
    public ICollection<FinancialSummaryDiscountAllocation>? discountAllocations { get; set; } = null;

    /// <summary>
    /// The variant unit price without discounts applied, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("originalUnitPriceSet")]
    public MoneyBag? originalUnitPriceSet { get; set; } = null;

    /// <summary>
    /// Number of line items that this financial summary applies to.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}