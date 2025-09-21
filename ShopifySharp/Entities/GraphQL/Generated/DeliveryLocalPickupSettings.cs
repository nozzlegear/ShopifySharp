#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Local pickup settings associated with a location.
/// </summary>
public record DeliveryLocalPickupSettings : IGraphQLObject
{
    /// <summary>
    /// Additional instructions or information related to the local pickup.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? instructions { get; set; } = null;

    /// <summary>
    /// The estimated pickup time to show customers at checkout.
    /// </summary>
    [JsonPropertyName("pickupTime")]
    public DeliveryLocalPickupTime? pickupTime { get; set; } = null;
}