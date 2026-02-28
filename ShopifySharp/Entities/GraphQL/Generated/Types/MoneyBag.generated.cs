#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A collection of monetary values in their respective currencies. Used throughout
/// the API for multi-currency pricing and transactions, when an amount in the
/// shop's currency is converted to the customer's currency of choice. The
/// `presentmentMoney` field contains the amount in the customer's selected
/// currency. The `shopMoney` field contains the equivalent in the shop's base currency.
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