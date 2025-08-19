#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for shipping option.
/// </summary>
public record SubscriptionDeliveryMethodShippingOptionInput : GraphQLInputObject<SubscriptionDeliveryMethodShippingOptionInput>
{
    /// <summary>
    /// The carrier service ID of the shipping option.
    /// </summary>
    [JsonPropertyName("carrierServiceId")]
    public string? carrierServiceId { get; set; } = null;

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
    /// The presentment title of the shipping option.
    /// </summary>
    [JsonPropertyName("presentmentTitle")]
    public string? presentmentTitle { get; set; } = null;

    /// <summary>
    /// The title of the shipping option.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}