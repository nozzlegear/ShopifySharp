#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// New items associated to the exchange.
/// </summary>
public record ExchangeV2Additions : IGraphQLObject
{
    /// <summary>
    /// The list of new items for the exchange.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<ExchangeV2LineItem>? lineItems { get; set; } = null;

    /// <summary>
    /// The subtotal of the items being added, including discounts.
    /// </summary>
    [JsonPropertyName("subtotalPriceSet")]
    public MoneyBag? subtotalPriceSet { get; set; } = null;

    /// <summary>
    /// The summary of all taxes of the items being added.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;

    /// <summary>
    /// The total price of the items being added, including discounts and taxes.
    /// </summary>
    [JsonPropertyName("totalPriceSet")]
    public MoneyBag? totalPriceSet { get; set; } = null;
}