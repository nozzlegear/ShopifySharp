#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The different kinds of order transactions.
/// </summary>
public enum OrderTransactionKind
{
    SALE,
    CAPTURE,
    AUTHORIZATION,
    VOID,
    REFUND,
    CHANGE,
    EMV_AUTHORIZATION,
    SUGGESTED_REFUND,
}