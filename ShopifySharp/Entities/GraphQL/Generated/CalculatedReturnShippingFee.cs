#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The calculated cost of the return shipping.
/// </summary>
public record CalculatedReturnShippingFee : IGraphQLObject, ICalculatedReturnFee
{
    /// <summary>
    /// The calculated amount of the return fee, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBag? amountSet { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}