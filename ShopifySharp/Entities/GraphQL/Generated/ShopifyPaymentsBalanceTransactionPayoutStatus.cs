#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The payout status of the balance transaction.
/// </summary>
public enum ShopifyPaymentsBalanceTransactionPayoutStatus
{
    SCHEDULED,
    [Obsolete("Use `SCHEDULED` instead.")]
    IN_TRANSIT,
    PAID,
    FAILED,
    CANCELED,
    PENDING,
    ACTION_REQUIRED,
}