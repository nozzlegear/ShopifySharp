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
/// Possible error codes that can be returned by `BulkOperationUserError`.
/// </summary>
public enum BulkOperationUserErrorCode
{
    OPERATION_IN_PROGRESS,
    INVALID,
    LIMIT_REACHED,
}