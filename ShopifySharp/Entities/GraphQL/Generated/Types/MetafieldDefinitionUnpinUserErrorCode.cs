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