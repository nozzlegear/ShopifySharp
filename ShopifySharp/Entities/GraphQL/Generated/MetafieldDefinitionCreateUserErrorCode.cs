#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `MetafieldDefinitionCreateUserError`.
/// </summary>
public enum MetafieldDefinitionCreateUserErrorCode
{
    INVALID,
    INCLUSION,
    PRESENT,
    TAKEN,
    TOO_LONG,
    TOO_SHORT,
    BLANK,
    CAPABILITY_REQUIRED_BUT_DISABLED,
    RESOURCE_TYPE_LIMIT_EXCEEDED,
    LIMIT_EXCEEDED,
    INVALID_OPTION,
    DUPLICATE_OPTION,
    RESERVED_NAMESPACE_KEY,
    PINNED_LIMIT_REACHED,
    UNSTRUCTURED_ALREADY_EXISTS,
    UNSUPPORTED_PINNING,
    INVALID_CHARACTER,
    TYPE_NOT_ALLOWED_FOR_CONDITIONS,
    OWNER_TYPE_LIMIT_EXCEEDED_FOR_AUTOMATED_COLLECTIONS,
    INVALID_CONSTRAINTS,
    INVALID_INPUT_COMBINATION,
    INVALID_CAPABILITY,
    ADMIN_ACCESS_INPUT_NOT_ALLOWED,
}