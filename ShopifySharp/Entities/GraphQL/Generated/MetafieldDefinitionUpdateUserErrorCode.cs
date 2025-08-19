#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `MetafieldDefinitionUpdateUserError`.
/// </summary>
public enum MetafieldDefinitionUpdateUserErrorCode
{
    PRESENT,
    TOO_LONG,
    BLANK,
    NOT_FOUND,
    INVALID_INPUT,
    CAPABILITY_REQUIRED_BUT_DISABLED,
    PINNED_LIMIT_REACHED,
    INTERNAL_ERROR,
    UNSUPPORTED_PINNING,
    INVALID_OPTION,
    DUPLICATE_OPTION,
    TYPE_NOT_ALLOWED_FOR_CONDITIONS,
    METAFIELD_DEFINITION_IN_USE,
    OWNER_TYPE_LIMIT_EXCEEDED_FOR_AUTOMATED_COLLECTIONS,
    METAOBJECT_DEFINITION_CHANGED,
    DISALLOWED_OWNER_TYPE,
    INVALID_INPUT_COMBINATION,
    INVALID_CONSTRAINTS,
    INVALID_CAPABILITY,
    CAPABILITY_CANNOT_BE_DISABLED,
    ADMIN_ACCESS_INPUT_NOT_ALLOWED,
    APP_CONFIG_MANAGED,
}