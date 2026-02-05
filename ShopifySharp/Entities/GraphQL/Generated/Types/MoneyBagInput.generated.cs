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
/// An input collection of monetary values in their respective currencies.
/// Represents an amount in the shop's currency and the amount as converted to the
/// customer's currency of choice (the presentment currency).
/// </summary>
public record MoneyBagInput : GraphQLInputObject<MoneyBagInput>
{
    /// <summary>
    /// Amount in presentment currency. If this isn't given then we assume that the
    /// presentment currency is the same as the shop's currency.
    /// </summary>
    [JsonPropertyName("presentmentMoney")]
    public MoneyInput? presentmentMoney { get; set; } = null;

    /// <summary>
    /// Amount in shop currency.
    /// </summary>
    [JsonPropertyName("shopMoney")]
    public MoneyInput? shopMoney { get; set; } = null;
}