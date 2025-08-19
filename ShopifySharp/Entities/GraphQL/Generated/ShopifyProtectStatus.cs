#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The status of an order's protection with Shopify Protect.
/// </summary>
public enum ShopifyProtectStatus
{
    PENDING,
    ACTIVE,
    INACTIVE,
    PROTECTED,
    NOT_PROTECTED,
}