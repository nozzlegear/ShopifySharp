#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies the kind of the suggested order transaction.
/// </summary>
public enum SuggestedOrderTransactionKind
{
    SUGGESTED_REFUND,
}