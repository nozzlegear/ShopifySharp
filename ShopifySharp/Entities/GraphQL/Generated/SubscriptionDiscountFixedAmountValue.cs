#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The value of the discount and how it will be applied.
/// </summary>
public record SubscriptionDiscountFixedAmountValue : SubscriptionDiscountValue, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The fixed amount value of the discount.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// Whether the amount is applied per item.
    /// </summary>
    [JsonPropertyName("appliesOnEachItem")]
    public bool? appliesOnEachItem { get; set; } = null;
}