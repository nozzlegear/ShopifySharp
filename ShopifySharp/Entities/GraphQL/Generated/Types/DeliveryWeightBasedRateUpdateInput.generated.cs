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
/// The input fields for updating a weight-based rate.
/// </summary>
public record DeliveryWeightBasedRateUpdateInput : GraphQLInputObject<DeliveryWeightBasedRateUpdateInput>
{
    /// <summary>
    /// The globally unique ID of the weight-based rate to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The maximum package weight for this rate tier. Null means no upper weight limit.
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