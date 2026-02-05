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
/// The `DeliverySetting` object enables you to manage shop-wide shipping settings.
/// </summary>
public record DeliverySetting : IGraphQLObject
{
    /// <summary>
    /// Whether the shop is blocked from converting to full multi-location delivery
    /// profiles mode. If the shop is blocked, then the blocking reasons are also
    /// returned. Note: this field is effectively deprecated and will be removed in a
    /// future version of the API.
    /// </summary>
    [JsonPropertyName("legacyModeBlocked")]
    public DeliveryLegacyModeBlocked? legacyModeBlocked { get; set; } = null;

    /// <summary>
    /// Enables legacy compatability mode for the multi-location delivery profiles
    /// feature. Note: this field is effectively deprecated and will be removed in a
    /// future version of the API.
    /// </summary>
    [JsonPropertyName("legacyModeProfiles")]
    public bool? legacyModeProfiles { get; set; } = null;
}