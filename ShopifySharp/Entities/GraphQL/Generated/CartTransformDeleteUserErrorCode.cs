#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `CartTransformDeleteUserError`.
/// </summary>
public enum CartTransformDeleteUserErrorCode
{
    NOT_FOUND,
    UNAUTHORIZED_APP_SCOPE,
}