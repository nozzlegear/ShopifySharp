#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Whether the shop is blocked from converting to full multi-location delivery
/// profiles mode. If the shop is blocked, then the blocking reasons are also returned.
/// </summary>
public record DeliveryLegacyModeBlocked : IGraphQLObject
{
    /// <summary>
    /// Whether the shop can convert to full multi-location delivery profiles mode.
    /// </summary>
    [JsonPropertyName("blocked")]
    public bool? blocked { get; set; } = null;

    /// <summary>
    /// The reasons why the shop is blocked from converting to full multi-location delivery profiles mode.
    /// </summary>
    [JsonPropertyName("reasons")]
    public ICollection<DeliveryLegacyModeBlockedReason>? reasons { get; set; } = null;
}