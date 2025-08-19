#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `MetafieldDefinitionUnpinUserError`.
/// </summary>
public enum MetafieldDefinitionUnpinUserErrorCode
{
    NOT_FOUND,
    NOT_PINNED,
    INTERNAL_ERROR,
    APP_CONFIG_MANAGED,
    DISALLOWED_OWNER_TYPE,
}