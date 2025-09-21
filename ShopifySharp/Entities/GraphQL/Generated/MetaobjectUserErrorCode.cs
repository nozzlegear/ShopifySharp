#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `MetaobjectUserError`.
/// </summary>
public enum MetaobjectUserErrorCode
{
    INVALID,
    INCLUSION,
    TAKEN,
    TOO_LONG,
    TOO_SHORT,
    PRESENT,
    BLANK,
    INVALID_TYPE,
    INVALID_VALUE,
    INVALID_OPTION,
    DUPLICATE_FIELD_INPUT,
    UNDEFINED_OBJECT_TYPE,
    UNDEFINED_OBJECT_FIELD,
    OBJECT_FIELD_TAKEN,
    OBJECT_FIELD_REQUIRED,
    RECORD_NOT_FOUND,
    INTERNAL_ERROR,
    MAX_DEFINITIONS_EXCEEDED,
    MAX_OBJECTS_EXCEEDED,
    INPUT_LIMIT_EXCEEDED,
    IMMUTABLE,
    NOT_AUTHORIZED,
    RESERVED_NAME,
    DISPLAY_NAME_CONFLICT,
    ADMIN_ACCESS_INPUT_NOT_ALLOWED,
    APP_CONFIG_MANAGED,
    CAPABILITY_NOT_ENABLED,
    URL_HANDLE_TAKEN,
    URL_HANDLE_INVALID,
    URL_HANDLE_BLANK,
    FIELD_TYPE_INVALID,
    MISSING_REQUIRED_KEYS,
    REFERENCE_EXISTS_ERROR,
}