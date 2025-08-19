#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Reasons the shop is blocked from converting to full multi-location delivery profiles mode.
/// </summary>
public enum DeliveryLegacyModeBlockedReason
{
    [Obsolete("All shops are now using multi-location mode.")]
    MULTI_LOCATION_DISABLED,
    NO_LOCATIONS_FULFILLING_ONLINE_ORDERS,
}