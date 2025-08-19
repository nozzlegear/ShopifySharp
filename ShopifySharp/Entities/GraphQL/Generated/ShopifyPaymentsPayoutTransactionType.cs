#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible transaction types for a payout.
/// </summary>
public enum ShopifyPaymentsPayoutTransactionType
{
    DEPOSIT,
    WITHDRAWAL,
}