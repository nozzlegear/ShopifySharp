#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `DeliveryCustomizationError`.
/// </summary>
public enum DeliveryCustomizationErrorCode
{
    INVALID,
    FUNCTION_NOT_FOUND,
    DELIVERY_CUSTOMIZATION_NOT_FOUND,
    DELIVERY_CUSTOMIZATION_FUNCTION_NOT_ELIGIBLE,
    UNAUTHORIZED_APP_SCOPE,
    MAXIMUM_ACTIVE_DELIVERY_CUSTOMIZATIONS,
    CUSTOM_APP_FUNCTION_NOT_ELIGIBLE,
    FUNCTION_DOES_NOT_IMPLEMENT,
    FUNCTION_PENDING_DELETION,
    FUNCTION_ID_CANNOT_BE_CHANGED,
    REQUIRED_INPUT_FIELD,
    INVALID_METAFIELDS,
}