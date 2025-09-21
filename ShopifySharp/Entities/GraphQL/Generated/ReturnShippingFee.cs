#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A return shipping fee is a fee captured as part of a return to cover the costs of shipping the return.
/// </summary>
public record ReturnShippingFee : IGraphQLObject, IFee
{
    /// <summary>
    /// The amount of the return shipping fee, in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBag? amountSet { get; set; } = null;

    /// <summary>
    /// The unique ID for the Fee.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}