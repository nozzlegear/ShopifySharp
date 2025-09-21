#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The status of a fulfillment.
/// </summary>
public enum FulfillmentStatus
{
    [Obsolete("This is a legacy status and is due to be deprecated.")]
    PENDING,
    [Obsolete("This is a legacy status and is due to be deprecated.")]
    OPEN,
    SUCCESS,
    CANCELLED,
    ERROR,
    FAILURE,
}