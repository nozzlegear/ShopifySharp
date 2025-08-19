#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The status of a return.
/// </summary>
public enum ReturnStatus
{
    CANCELED,
    CLOSED,
    OPEN,
    REQUESTED,
    DECLINED,
}