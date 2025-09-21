#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The different states that an `OrderTransaction` can have.
/// </summary>
public enum OrderTransactionStatus
{
    SUCCESS,
    FAILURE,
    PENDING,
    ERROR,
    AWAITING_RESPONSE,
    UNKNOWN,
}