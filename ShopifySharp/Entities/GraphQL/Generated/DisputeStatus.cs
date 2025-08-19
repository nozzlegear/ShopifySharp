#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible statuses of a dispute.
/// </summary>
public enum DisputeStatus
{
    ACCEPTED,
    LOST,
    NEEDS_RESPONSE,
    UNDER_REVIEW,
    WON,
    [Obsolete("CHARGE_REFUNDED is no longer supported.")]
    CHARGE_REFUNDED,
}