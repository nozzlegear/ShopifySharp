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
/// The type of a fulfillment service.
/// </summary>
public enum FulfillmentServiceType
{
    GIFT_CARD,
    MANUAL,
    THIRD_PARTY,
}