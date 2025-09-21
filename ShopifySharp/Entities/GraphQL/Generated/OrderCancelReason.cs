#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the reason for the order's cancellation.
/// </summary>
public enum OrderCancelReason
{
    CUSTOMER,
    DECLINED,
    FRAUD,
    INVENTORY,
    STAFF,
    OTHER,
}