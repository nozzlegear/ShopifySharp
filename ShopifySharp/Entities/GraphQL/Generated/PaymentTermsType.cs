#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of a payment terms or a payment terms template.
/// </summary>
public enum PaymentTermsType
{
    RECEIPT,
    NET,
    FIXED,
    FULFILLMENT,
    UNKNOWN,
}