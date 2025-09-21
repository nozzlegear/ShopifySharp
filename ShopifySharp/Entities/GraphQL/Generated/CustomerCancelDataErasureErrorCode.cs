#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `CustomerCancelDataErasureUserError`.
/// </summary>
public enum CustomerCancelDataErasureErrorCode
{
    DOES_NOT_EXIST,
    FAILED_TO_CANCEL,
    NOT_BEING_ERASED,
    UNAUTHORIZED_CANCELLATION,
}