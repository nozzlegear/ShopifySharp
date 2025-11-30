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
/// The input fields for tracking information about a return delivery.
/// </summary>
public record ReverseDeliveryTrackingInput : GraphQLInputObject<ReverseDeliveryTrackingInput>
{
    /// <summary>
    /// The tracking number for the label.
    /// </summary>
    [JsonPropertyName("number")]
    public string? number { get; set; } = null;

    /// <summary>
    /// The tracking URL for the carrier. If the carrier isn't supported by Shopify,
    /// then provide the tracking URL of the delivery.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}