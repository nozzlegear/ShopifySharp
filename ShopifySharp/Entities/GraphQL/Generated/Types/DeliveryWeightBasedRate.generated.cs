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
/// A weight-based shipping rate.
/// Weight-based rates charge different prices depending on package weight, which can
/// include packaging weight in addition to item weight, and may include optional
/// transit time estimates.
/// </summary>
public record DeliveryWeightBasedRate : IGraphQLObject, IDeliveryRate
{
    /// <summary>
    /// A globally unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The maximum package weight for this rate tier.
    /// </summary>
    [JsonPropertyName("maxWeight")]
    public Weight? maxWeight { get; set; } = null;

    /// <summary>
    /// The minimum package weight for this rate tier.
    /// </summary>
    [JsonPropertyName("minWeight")]
    public Weight? minWeight { get; set; } = null;

    /// <summary>
    /// The price charged for this rate.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// The maximum transit time estimate in seconds.
    /// </summary>
    [JsonPropertyName("transitTimeMaxSeconds")]
    public int? transitTimeMaxSeconds { get; set; } = null;

    /// <summary>
    /// The minimum transit time estimate in seconds.
    /// </summary>
    [JsonPropertyName("transitTimeMinSeconds")]
    public int? transitTimeMinSeconds { get; set; } = null;
}