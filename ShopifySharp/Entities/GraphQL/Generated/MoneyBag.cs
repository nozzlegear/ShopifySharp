#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A collection of monetary values in their respective currencies. Typically used
/// in the context of multi-currency pricing and transactions,
/// when an amount in the shop's currency is converted to the customer's currency of choice (the presentment currency).
/// </summary>
public record MoneyBag : IGraphQLObject
{
    /// <summary>
    /// Amount in presentment currency.
    /// </summary>
    [JsonPropertyName("presentmentMoney")]
    public MoneyV2? presentmentMoney { get; set; } = null;

    /// <summary>
    /// Amount in shop currency.
    /// </summary>
    [JsonPropertyName("shopMoney")]
    public MoneyV2? shopMoney { get; set; } = null;
}