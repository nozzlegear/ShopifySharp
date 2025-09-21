#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a refunded duty.
/// </summary>
public record RefundDuty : IGraphQLObject
{
    /// <summary>
    /// The amount of a refunded duty in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBag? amountSet { get; set; } = null;

    /// <summary>
    /// The duty associated with this refunded duty.
    /// </summary>
    [JsonPropertyName("originalDuty")]
    public Duty? originalDuty { get; set; } = null;
}