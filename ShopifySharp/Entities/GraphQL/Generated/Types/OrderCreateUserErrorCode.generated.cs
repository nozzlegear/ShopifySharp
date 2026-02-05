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
/// Possible error codes that can be returned by `OrderCreateUserError`.
/// </summary>
public enum OrderCreateUserErrorCode
{
    INVALID,
    FULFILLMENT_SERVICE_INVALID,
    INVENTORY_CLAIM_FAILED,
    PROCESSED_AT_INVALID,
    TAX_LINE_RATE_MISSING,
    REDUNDANT_CUSTOMER_FIELDS,
    SHOP_DORMANT,
}