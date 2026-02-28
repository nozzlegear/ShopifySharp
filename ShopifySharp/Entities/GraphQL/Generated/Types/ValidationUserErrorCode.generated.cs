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
/// Possible error codes that can be returned by `ValidationUserError`.
/// </summary>
public enum ValidationUserErrorCode
{
    NOT_FOUND,
    FUNCTION_NOT_FOUND,
    CUSTOM_APP_FUNCTION_NOT_ELIGIBLE,
    FUNCTION_DOES_NOT_IMPLEMENT,
    PUBLIC_APP_NOT_ALLOWED,
    FUNCTION_PENDING_DELETION,
    MAX_VALIDATIONS_ACTIVATED,
    MISSING_FUNCTION_IDENTIFIER,
    MULTIPLE_FUNCTION_IDENTIFIERS,
    INVALID_TYPE,
    INVALID_VALUE,
    APP_NOT_AUTHORIZED,
    UNSTRUCTURED_RESERVED_NAMESPACE,
    DISALLOWED_OWNER_TYPE,
    INCLUSION,
    TAKEN,
    PRESENT,
    BLANK,
    TOO_LONG,
    TOO_SHORT,
    INVALID,
    CAPABILITY_VIOLATION,
    INTERNAL_ERROR,
}