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
/// A pickup option to deliver a subscription contract.
/// </summary>
public record SubscriptionPickupOption : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The code of the pickup option.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The description of the pickup option.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The pickup location.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// Whether a phone number is required for the pickup option.
    /// </summary>
    [JsonPropertyName("phoneRequired")]
    public bool? phoneRequired { get; set; } = null;

    /// <summary>
    /// The estimated amount of time it takes for the pickup to be ready. For example, "Usually ready in 24 hours".).
    /// </summary>
    [JsonPropertyName("pickupTime")]
    public string? pickupTime { get; set; } = null;

    /// <summary>
    /// The presentment title of the pickup option.
    /// </summary>
    [JsonPropertyName("presentmentTitle")]
    public string? presentmentTitle { get; set; } = null;

    /// <summary>
    /// The price of the pickup option.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// The title of the pickup option.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}