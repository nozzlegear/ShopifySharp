#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `AppUninstallAppUninstallError`.
/// </summary>
public enum AppUninstallAppUninstallErrorCode
{
    APP_NOT_FOUND,
    APP_NOT_INSTALLED,
    USER_PERMISSIONS_INSUFFICIENT,
    APP_UNINSTALL_ERROR,
}