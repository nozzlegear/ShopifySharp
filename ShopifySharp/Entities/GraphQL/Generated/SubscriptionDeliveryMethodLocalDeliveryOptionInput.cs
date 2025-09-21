#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for local delivery option.
/// </summary>
public record SubscriptionDeliveryMethodLocalDeliveryOptionInput : GraphQLInputObject<SubscriptionDeliveryMethodLocalDeliveryOptionInput>
{
    /// <summary>
    /// A custom reference to the delivery method for use with automations.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The details displayed to the customer to describe the local delivery option.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The delivery instructions that the customer can provide to the merchant.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? instructions { get; set; } = null;

    /// <summary>
    /// The phone number that the customer must provide to the merchant.
    /// Formatted using E.164 standard. For example, `+16135551111`.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The presentment title of the local delivery option.
    /// </summary>
    [JsonPropertyName("presentmentTitle")]
    public string? presentmentTitle { get; set; } = null;

    /// <summary>
    /// The title of the local delivery option.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}