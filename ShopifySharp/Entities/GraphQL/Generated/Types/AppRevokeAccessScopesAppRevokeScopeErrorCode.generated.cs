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
/// Possible error codes that can be returned by `AppRevokeAccessScopesAppRevokeScopeError`.
/// </summary>
public enum AppRevokeAccessScopesAppRevokeScopeErrorCode
{
    MISSING_SOURCE_APP,
    APPLICATION_CANNOT_BE_FOUND,
    UNKNOWN_SCOPES,
    CANNOT_REVOKE_REQUIRED_SCOPES,
    CANNOT_REVOKE_IMPLIED_SCOPES,
    CANNOT_REVOKE_UNDECLARED_SCOPES,
    APP_NOT_INSTALLED,
}