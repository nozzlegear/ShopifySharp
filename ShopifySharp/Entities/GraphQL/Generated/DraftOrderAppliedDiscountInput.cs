#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for applying an order-level discount to a draft order.
/// </summary>
public record DraftOrderAppliedDiscountInput : GraphQLInputObject<DraftOrderAppliedDiscountInput>
{
    /// <summary>
    /// The applied amount of the discount in the specified currency.
    /// </summary>
    [JsonPropertyName("amountWithCurrency")]
    public MoneyInput? amountWithCurrency { get; set; } = null;

    /// <summary>
    /// Reason for the discount.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// Title of the discount.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The value of the discount.
    /// If the type of the discount is fixed amount, then this is a fixed amount in your shop currency.
    /// If the type is percentage, then this is the percentage.
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? @value { get; set; } = null;

    /// <summary>
    /// The type of discount.
    /// </summary>
    [JsonPropertyName("valueType")]
    public DraftOrderAppliedDiscountType? valueType { get; set; } = null;
}