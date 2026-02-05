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
/// Possible error codes that can be returned by `DeliveryLocationLocalPickupSettingsError`.
/// </summary>
public enum DeliveryLocationLocalPickupSettingsErrorCode
{
    ACTIVE_LOCATION_NOT_FOUND,
    CUSTOM_PICKUP_TIME_NOT_ALLOWED,
    GENERIC_ERROR,
}