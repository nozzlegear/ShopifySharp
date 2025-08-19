#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the fixed amount value of the discount and distribution on the lines.
/// </summary>
public record SubscriptionManualDiscountFixedAmountInput : GraphQLInputObject<SubscriptionManualDiscountFixedAmountInput>
{
    /// <summary>
    /// Fixed amount value.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// Whether the amount is intended per line item or once per subscription.
    /// </summary>
    [JsonPropertyName("appliesOnEachItem")]
    public bool? appliesOnEachItem { get; set; } = null;
}