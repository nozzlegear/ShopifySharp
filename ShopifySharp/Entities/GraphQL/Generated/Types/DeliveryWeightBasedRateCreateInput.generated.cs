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
/// The input fields for creating a weight-based rate.
/// </summary>
public record DeliveryWeightBasedRateCreateInput : GraphQLInputObject<DeliveryWeightBasedRateCreateInput>
{
    /// <summary>
    /// The maximum package weight for this rate tier. If omitted, the tier has no upper weight limit.
    /// </summary>
    [JsonPropertyName("maxWeight")]
    public WeightInput? maxWeight { get; set; } = null;

    /// <summary>
    /// The minimum package weight for this rate tier.
    /// </summary>
    [JsonPropertyName("minWeight")]
    public WeightInput? minWeight { get; set; } = null;

    /// <summary>
    /// The price charged for this rate tier.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyInput? price { get; set; } = null;

    /// <summary>
    /// The maximum estimated transit time in seconds.
    /// </summary>
    [JsonPropertyName("transitTimeMaxSeconds")]
    public int? transitTimeMaxSeconds { get; set; } = null;

    /// <summary>
    /// The minimum estimated transit time in seconds.
    /// </summary>
    [JsonPropertyName("transitTimeMinSeconds")]
    public int? transitTimeMinSeconds { get; set; } = null;
}