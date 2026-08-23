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
/// The input fields for creating a value-based rate.
/// </summary>
public record DeliveryValueBasedRateCreateInput : GraphQLInputObject<DeliveryValueBasedRateCreateInput>
{
    /// <summary>
    /// The maximum cart value (inclusive) for this rate. Omit for no upper limit.
    /// </summary>
    [JsonPropertyName("maxValue")]
    public MoneyInput? maxValue { get; set; } = null;

    /// <summary>
    /// The minimum cart value (inclusive) for this rate.
    /// </summary>
    [JsonPropertyName("minValue")]
    public MoneyInput? minValue { get; set; } = null;

    /// <summary>
    /// The price charged for this rate.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyInput? price { get; set; } = null;

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