#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible method types that a delivery method can have.
/// </summary>
public enum DeliveryMethodType
{
    SHIPPING,
    PICK_UP,
    NONE,
    RETAIL,
    LOCAL,
    PICKUP_POINT,
}