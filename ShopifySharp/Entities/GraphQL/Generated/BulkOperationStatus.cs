#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The valid values for the status of a bulk operation.
/// </summary>
public enum BulkOperationStatus
{
    CANCELED,
    CANCELING,
    COMPLETED,
    CREATED,
    EXPIRED,
    FAILED,
    RUNNING,
}