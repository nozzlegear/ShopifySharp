#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Error codes for failed bulk operations.
/// </summary>
public enum BulkOperationErrorCode
{
    ACCESS_DENIED,
    INTERNAL_SERVER_ERROR,
    TIMEOUT,
}