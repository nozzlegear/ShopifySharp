#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

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