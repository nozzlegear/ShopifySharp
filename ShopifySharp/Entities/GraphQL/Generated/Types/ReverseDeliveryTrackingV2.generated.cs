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
/// Represents the information used to track a reverse delivery.
/// </summary>
public record ReverseDeliveryTrackingV2 : IGraphQLObject
{
    /// <summary>
    /// The provider of the tracking information, in a human-readable format for display purposes.
    /// </summary>
    [JsonPropertyName("carrierName")]
    public string? carrierName { get; set; } = null;

    /// <summary>
    /// The identifier used by the courier to identify the shipment.
    /// </summary>
    [JsonPropertyName("number")]
    public string? number { get; set; } = null;

    /// <summary>
    /// The URL to track a shipment.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}