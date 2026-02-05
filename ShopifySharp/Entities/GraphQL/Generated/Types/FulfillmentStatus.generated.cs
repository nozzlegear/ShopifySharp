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