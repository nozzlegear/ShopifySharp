#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The kinds of request merchants can make to a fulfillment service.
/// </summary>
public enum FulfillmentOrderMerchantRequestKind
{
    FULFILLMENT_REQUEST,
    CANCELLATION_REQUEST,
}