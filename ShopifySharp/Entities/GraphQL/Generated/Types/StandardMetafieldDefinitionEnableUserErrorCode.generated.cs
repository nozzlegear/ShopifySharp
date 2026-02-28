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
/// Possible error codes that can be returned by `StandardMetafieldDefinitionEnableUserError`.
/// </summary>
public enum StandardMetafieldDefinitionEnableUserErrorCode
{
    INVALID,
    TAKEN,
    TEMPLATE_NOT_FOUND,
    LIMIT_EXCEEDED,
    UNSTRUCTURED_ALREADY_EXISTS,
    TYPE_NOT_ALLOWED_FOR_CONDITIONS,
    INVALID_CAPABILITY,
    CAPABILITY_CANNOT_BE_DISABLED,
    OWNER_TYPE_LIMIT_EXCEEDED_FOR_USE_AS_ADMIN_FILTERS,
    UNSUPPORTED_PINNING,
    ADMIN_ACCESS_INPUT_NOT_ALLOWED,
    INVALID_INPUT_COMBINATION,
}