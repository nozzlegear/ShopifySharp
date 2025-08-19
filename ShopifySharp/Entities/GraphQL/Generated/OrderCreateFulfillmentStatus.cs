#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The order's status in terms of fulfilled line items.
/// </summary>
public enum OrderCreateFulfillmentStatus
{
    FULFILLED,
    PARTIAL,
    RESTOCKED,
}