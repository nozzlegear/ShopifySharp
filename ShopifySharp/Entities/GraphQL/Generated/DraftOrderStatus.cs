#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The valid statuses for a draft order.
/// </summary>
public enum DraftOrderStatus
{
    COMPLETED,
    INVOICE_SENT,
    OPEN,
}