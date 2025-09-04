#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A shipping option to deliver a subscription contract.
/// </summary>
public record SubscriptionShippingOption : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The carrier service that's providing this shipping option.
    /// This field isn't currently supported and returns null.
    /// </summary>
    [JsonPropertyName("carrierService")]
    [Obsolete("This field has never been implemented.")]
    public DeliveryCarrierService? carrierService { get; set; } = null;

    /// <summary>
    /// The code of the shipping option.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The description of the shipping option.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// If a phone number is required for the shipping option.
    /// </summary>
    [JsonPropertyName("phoneRequired")]
    public bool? phoneRequired { get; set; } = null;

    /// <summary>
    /// The presentment title of the shipping option.
    /// </summary>
    [JsonPropertyName("presentmentTitle")]
    public string? presentmentTitle { get; set; } = null;

    /// <summary>
    /// The price of the shipping option.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// The title of the shipping option.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}