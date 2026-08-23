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
/// A value-based shipping rate.
/// Defines price, optional transit time estimates, and the cart-value range for this rate.
/// </summary>
public record DeliveryValueBasedRate : IGraphQLObject, IDeliveryRate
{
    /// <summary>
    /// A globally unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The maximum cart value (inclusive) for this rate. Null means no upper limit.
    /// </summary>
    [JsonPropertyName("maxValue")]
    public MoneyV2? maxValue { get; set; } = null;

    /// <summary>
    /// The minimum cart value (inclusive) for this rate.
    /// </summary>
    [JsonPropertyName("minValue")]
    public MoneyV2? minValue { get; set; } = null;

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