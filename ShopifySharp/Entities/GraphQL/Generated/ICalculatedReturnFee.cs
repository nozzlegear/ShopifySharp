#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A calculated return fee.
/// </summary>
public interface ICalculatedReturnFee : IGraphQLObject
{
    /// <summary>
    /// The calculated amount of the return fee, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBag? amountSet { get; set; }

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }
}