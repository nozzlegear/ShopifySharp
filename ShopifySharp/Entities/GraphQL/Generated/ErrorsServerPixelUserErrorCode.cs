#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `ErrorsServerPixelUserError`.
/// </summary>
public enum ErrorsServerPixelUserErrorCode
{
    NOT_FOUND,
    ALREADY_EXISTS,
    PUB_SUB_ERROR,
    NEEDS_CONFIGURATION_TO_CONNECT,
}