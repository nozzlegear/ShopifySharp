#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible pickup time values that a location enabled for local pickup can have.
/// </summary>
public enum DeliveryLocalPickupTime
{
    ONE_HOUR,
    TWO_HOURS,
    FOUR_HOURS,
    TWENTY_FOUR_HOURS,
    TWO_TO_FOUR_DAYS,
    FIVE_OR_MORE_DAYS,
    [Obsolete("Custom pickup time is no longer supported.")]
    CUSTOM,
}