#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A local delivery option for a subscription contract.
/// </summary>
public record SubscriptionLocalDeliveryOption : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The code of the local delivery option.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The description of the local delivery option.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// Whether a phone number is required for the local delivery option.
    /// </summary>
    [JsonPropertyName("phoneRequired")]
    public bool? phoneRequired { get; set; } = null;

    /// <summary>
    /// The presentment title of the local delivery option.
    /// </summary>
    [JsonPropertyName("presentmentTitle")]
    public string? presentmentTitle { get; set; } = null;

    /// <summary>
    /// The price of the local delivery option.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// The title of the local delivery option.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}