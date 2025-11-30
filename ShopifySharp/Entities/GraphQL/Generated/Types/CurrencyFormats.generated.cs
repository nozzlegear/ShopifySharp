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
/// Currency formats configured for the merchant. These formats are available to use within Liquid.
/// </summary>
public record CurrencyFormats : IGraphQLObject
{
    /// <summary>
    /// Money without currency in HTML.
    /// </summary>
    [JsonPropertyName("moneyFormat")]
    public string? moneyFormat { get; set; } = null;

    /// <summary>
    /// Money without currency in emails.
    /// </summary>
    [JsonPropertyName("moneyInEmailsFormat")]
    public string? moneyInEmailsFormat { get; set; } = null;

    /// <summary>
    /// Money with currency in HTML.
    /// </summary>
    [JsonPropertyName("moneyWithCurrencyFormat")]
    public string? moneyWithCurrencyFormat { get; set; } = null;

    /// <summary>
    /// Money with currency in emails.
    /// </summary>
    [JsonPropertyName("moneyWithCurrencyInEmailsFormat")]
    public string? moneyWithCurrencyInEmailsFormat { get; set; } = null;
}