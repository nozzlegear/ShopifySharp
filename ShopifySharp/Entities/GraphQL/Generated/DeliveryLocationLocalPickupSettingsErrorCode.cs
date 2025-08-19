#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `DeliveryLocationLocalPickupSettingsError`.
/// </summary>
public enum DeliveryLocationLocalPickupSettingsErrorCode
{
    ACTIVE_LOCATION_NOT_FOUND,
    CUSTOM_PICKUP_TIME_NOT_ALLOWED,
    GENERIC_ERROR,
}