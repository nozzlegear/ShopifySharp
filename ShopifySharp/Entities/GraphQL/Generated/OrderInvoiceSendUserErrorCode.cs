#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `OrderInvoiceSendUserError`.
/// </summary>
public enum OrderInvoiceSendUserErrorCode
{
    ORDER_INVOICE_SEND_UNSUCCESSFUL,
}