#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for pickup option.
/// </summary>
public record SubscriptionDeliveryMethodPickupOptionInput : GraphQLInputObject<SubscriptionDeliveryMethodPickupOptionInput>
{
    /// <summary>
    /// A custom reference to the delivery method for use with automations.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The details displayed to the customer to describe the pickup option.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The ID of the pickup location.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// The presentment title of the pickup option.
    /// </summary>
    [JsonPropertyName("presentmentTitle")]
    public string? presentmentTitle { get; set; } = null;

    /// <summary>
    /// The title of the pickup option.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}