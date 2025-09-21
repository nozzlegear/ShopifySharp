#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A sale associated with a tip.
/// </summary>
public record TipSale : IGraphQLObject, ISale
{
    /// <summary>
    /// The type of order action that the sale represents.
    /// </summary>
    [JsonPropertyName("actionType")]
    public SaleActionType? actionType { get; set; } = null;

    /// <summary>
    /// The unique ID for the sale.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The line item for the associated sale.
    /// </summary>
    [JsonPropertyName("lineItem")]
    public LineItem? lineItem { get; set; } = null;

    /// <summary>
    /// The line type assocated with the sale.
    /// </summary>
    [JsonPropertyName("lineType")]
    public SaleLineType? lineType { get; set; } = null;

    /// <summary>
    /// The number of units either ordered or intended to be returned.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// All individual taxes associated with the sale.
    /// </summary>
    [JsonPropertyName("taxes")]
    public ICollection<SaleTax>? taxes { get; set; } = null;

    /// <summary>
    /// The total sale amount after taxes and discounts.
    /// </summary>
    [JsonPropertyName("totalAmount")]
    public MoneyBag? totalAmount { get; set; } = null;

    /// <summary>
    /// The total discounts allocated to the sale after taxes.
    /// </summary>
    [JsonPropertyName("totalDiscountAmountAfterTaxes")]
    public MoneyBag? totalDiscountAmountAfterTaxes { get; set; } = null;

    /// <summary>
    /// The total discounts allocated to the sale before taxes.
    /// </summary>
    [JsonPropertyName("totalDiscountAmountBeforeTaxes")]
    public MoneyBag? totalDiscountAmountBeforeTaxes { get; set; } = null;

    /// <summary>
    /// The total amount of taxes for the sale.
    /// </summary>
    [JsonPropertyName("totalTaxAmount")]
    public MoneyBag? totalTaxAmount { get; set; } = null;
}