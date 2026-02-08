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
/// Possible error codes that can be returned by `PaymentCustomizationError`.
/// </summary>
public enum PaymentCustomizationErrorCode
{
    CUSTOM_APP_FUNCTION_NOT_ELIGIBLE,
    FUNCTION_DOES_NOT_IMPLEMENT,
    FUNCTION_NOT_FOUND,
    FUNCTION_PENDING_DELETION,
    INVALID,
    PAYMENT_CUSTOMIZATION_NOT_FOUND,
    PAYMENT_CUSTOMIZATION_FUNCTION_NOT_ELIGIBLE,
    MAXIMUM_ACTIVE_PAYMENT_CUSTOMIZATIONS,
    REQUIRED_INPUT_FIELD,
    INVALID_METAFIELDS,
    FUNCTION_ID_CANNOT_BE_CHANGED,
    MISSING_FUNCTION_IDENTIFIER,
    MULTIPLE_FUNCTION_IDENTIFIERS,
}