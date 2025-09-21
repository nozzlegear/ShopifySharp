#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Actions that can be taken at the location when a client requests the deletion of the fulfillment service.
/// </summary>
public enum FulfillmentServiceDeleteInventoryAction
{
    DELETE,
    KEEP,
    TRANSFER,
}