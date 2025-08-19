#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `LocationDeleteUserError`.
/// </summary>
public enum LocationDeleteUserErrorCode
{
    LOCATION_NOT_FOUND,
    LOCATION_IS_ACTIVE,
    GENERIC_ERROR,
    LOCATION_HAS_INVENTORY,
    LOCATION_HAS_PENDING_ORDERS,
    LOCATION_HAS_ACTIVE_RETAIL_SUBSCRIPTION,
}