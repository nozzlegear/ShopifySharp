#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `MetafieldDefinitionPinUserError`.
/// </summary>
public enum MetafieldDefinitionPinUserErrorCode
{
    NOT_FOUND,
    PINNED_LIMIT_REACHED,
    ALREADY_PINNED,
    INTERNAL_ERROR,
    UNSUPPORTED_PINNING,
    DISALLOWED_OWNER_TYPE,
}