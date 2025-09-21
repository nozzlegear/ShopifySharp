#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `CustomerRequestDataErasureUserError`.
/// </summary>
public enum CustomerRequestDataErasureErrorCode
{
    DOES_NOT_EXIST,
    FAILED_TO_REQUEST,
}