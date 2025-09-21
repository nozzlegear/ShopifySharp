#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `UrlRedirectUserError`.
/// </summary>
public enum UrlRedirectErrorCode
{
    DOES_NOT_EXIST,
    CREATE_FAILED,
    UPDATE_FAILED,
    DELETE_FAILED,
}