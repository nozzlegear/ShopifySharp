#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A precise monetary value and its associated currency. For example, 12.99 USD.
/// </summary>
public record MoneyV2 : DeliveryConditionCriteria, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// A monetary value in decimal format, allowing for precise representation of cents or fractional
    /// currency. For example, 12.99.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// The three-letter currency code that represents a world currency used in a store. Currency codes
    /// include standard [standard ISO 4217 codes](https://en.wikipedia.org/wiki/ISO_4217), legacy codes,
    /// and non-standard codes. For example, USD.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public CurrencyCode? currencyCode { get; set; } = null;
}