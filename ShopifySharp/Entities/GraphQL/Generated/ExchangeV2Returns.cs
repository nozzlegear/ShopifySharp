#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return items associated to the exchange.
/// </summary>
public record ExchangeV2Returns : IGraphQLObject
{
    /// <summary>
    /// The list of return items for the exchange.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<ExchangeV2LineItem>? lineItems { get; set; } = null;

    /// <summary>
    /// The amount of the order-level discount for the items and shipping being
    /// returned, which doesn't contain any line item discounts.
    /// </summary>
    [JsonPropertyName("orderDiscountAmountSet")]
    public MoneyBag? orderDiscountAmountSet { get; set; } = null;

    /// <summary>
    /// The amount of money to be refunded for shipping.
    /// </summary>
    [JsonPropertyName("shippingRefundAmountSet")]
    public MoneyBag? shippingRefundAmountSet { get; set; } = null;

    /// <summary>
    /// The subtotal of the items being returned.
    /// </summary>
    [JsonPropertyName("subtotalPriceSet")]
    public MoneyBag? subtotalPriceSet { get; set; } = null;

    /// <summary>
    /// The summary of all taxes of the items being returned.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;

    /// <summary>
    /// The amount of money to be refunded for tip.
    /// </summary>
    [JsonPropertyName("tipRefundAmountSet")]
    public MoneyBag? tipRefundAmountSet { get; set; } = null;

    /// <summary>
    /// The total value of the items being returned.
    /// </summary>
    [JsonPropertyName("totalPriceSet")]
    public MoneyBag? totalPriceSet { get; set; } = null;
}