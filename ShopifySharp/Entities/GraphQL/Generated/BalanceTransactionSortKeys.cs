#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the BalanceTransaction query.
/// </summary>
public enum BalanceTransactionSortKeys
{
    AMOUNT,
    FEE,
    ID,
    NET,
    ORDER_NAME,
    PAYMENT_METHOD_NAME,
    PAYOUT_DATE,
    PAYOUT_STATUS,
    PROCESSED_AT,
    TRANSACTION_TYPE,
}