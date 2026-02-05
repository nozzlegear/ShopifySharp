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
/// The final arrangement of an item from a reverse fulfillment order.
/// </summary>
public enum ReverseFulfillmentOrderDispositionType
{
    RESTOCKED,
    PROCESSING_REQUIRED,
    NOT_RESTOCKED,
    MISSING,
}