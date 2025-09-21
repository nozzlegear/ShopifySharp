#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The transfer status of the payout.
/// </summary>
public enum ShopifyPaymentsPayoutStatus
{
    SCHEDULED,
    [Obsolete("Use `SCHEDULED` instead.")]
    IN_TRANSIT,
    PAID,
    FAILED,
    CANCELED,
}