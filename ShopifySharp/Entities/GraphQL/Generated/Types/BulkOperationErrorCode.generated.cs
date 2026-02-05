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
/// Error codes for failed bulk operations.
/// </summary>
public enum BulkOperationErrorCode
{
    ACCESS_DENIED,
    INTERNAL_SERVER_ERROR,
    TIMEOUT,
}