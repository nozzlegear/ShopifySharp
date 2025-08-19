#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The delivery promise settings.
/// </summary>
public record DeliveryPromiseSetting : IGraphQLObject
{
    /// <summary>
    /// Whether delivery dates is enabled.
    /// </summary>
    [JsonPropertyName("deliveryDatesEnabled")]
    public bool? deliveryDatesEnabled { get; set; } = null;

    /// <summary>
    /// The number of business days required for processing the order before the
    /// package is handed off to the carrier. Expressed as an ISO8601 duration.
    /// </summary>
    [JsonPropertyName("processingTime")]
    public string? processingTime { get; set; } = null;
}