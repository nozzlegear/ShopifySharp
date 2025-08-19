#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of a fulfillment service.
/// </summary>
public enum FulfillmentServiceType
{
    GIFT_CARD,
    MANUAL,
    THIRD_PARTY,
}