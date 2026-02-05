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
/// The input fields for a monetary value with currency.
/// </summary>
public record MoneyInput : GraphQLInputObject<MoneyInput>
{
    /// <summary>
    /// Decimal money amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// Currency of the money.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public CurrencyCode? currencyCode { get; set; } = null;
}