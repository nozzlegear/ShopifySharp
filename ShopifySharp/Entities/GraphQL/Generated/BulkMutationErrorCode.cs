#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `BulkMutationUserError`.
/// </summary>
public enum BulkMutationErrorCode
{
    OPERATION_IN_PROGRESS,
    INVALID_MUTATION,
    INVALID_STAGED_UPLOAD_FILE,
    NO_SUCH_FILE,
    INTERNAL_FILE_SERVER_ERROR,
}