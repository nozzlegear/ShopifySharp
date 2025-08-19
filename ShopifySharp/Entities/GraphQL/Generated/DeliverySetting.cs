#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DeliveryRateProviderDeliveryParticipant(DeliveryParticipant Value): DeliveryRateProvider;
internal record DeliveryRateProviderDeliveryRateDefinition(DeliveryRateDefinition Value): DeliveryRateProvider;
#endif /// <summary>

/// The `DeliverySetting` object enables you to manage shop-wide shipping settings.
/// You can enable legacy compatibility mode for the multi-location delivery profiles feature
/// if the legacy mode isn't blocked.
/// </summary>
public record DeliverySetting : IGraphQLObject
{
    /// <summary>
    /// Whether the shop is blocked from converting to full multi-location delivery
    /// profiles mode. If the shop is blocked, then the blocking reasons are also returned.
    /// </summary>
    [JsonPropertyName("legacyModeBlocked")]
    public DeliveryLegacyModeBlocked? legacyModeBlocked { get; set; } = null;

    /// <summary>
    /// Enables legacy compatability mode for the multi-location delivery profiles feature.
    /// </summary>
    [JsonPropertyName("legacyModeProfiles")]
    public bool? legacyModeProfiles { get; set; } = null;
}