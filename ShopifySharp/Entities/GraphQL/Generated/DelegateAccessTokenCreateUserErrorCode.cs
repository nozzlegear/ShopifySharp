#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `DelegateAccessTokenCreateUserError`.
/// </summary>
public enum DelegateAccessTokenCreateUserErrorCode
{
    EMPTY_ACCESS_SCOPE,
    DELEGATE_ACCESS_TOKEN,
    NEGATIVE_EXPIRES_IN,
    EXPIRES_AFTER_PARENT,
    REFRESH_TOKEN,
    PERSISTENCE_FAILED,
    UNKNOWN_SCOPES,
}