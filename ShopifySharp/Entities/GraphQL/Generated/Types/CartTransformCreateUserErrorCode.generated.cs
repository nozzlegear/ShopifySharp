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
/// Possible error codes that can be returned by `CartTransformCreateUserError`.
/// </summary>
public enum CartTransformCreateUserErrorCode
{
    INPUT_INVALID,
    FUNCTION_NOT_FOUND,
    FUNCTION_ALREADY_REGISTERED,
    FUNCTION_DOES_NOT_IMPLEMENT,
    CUSTOM_APP_FUNCTION_NOT_ELIGIBLE,
    INVALID_METAFIELDS,
    MAXIMUM_CART_TRANSFORMS,
    MULTIPLE_FUNCTION_IDENTIFIERS,
    MISSING_FUNCTION_IDENTIFIER,
}