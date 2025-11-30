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
/// The order's status in terms of fulfilled line items.
/// </summary>
public enum OrderCreateFulfillmentStatus
{
    FULFILLED,
    PARTIAL,
    RESTOCKED,
}