#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `BusinessCustomerUserError`.
/// </summary>
public enum BusinessCustomerErrorCode
{
    INTERNAL_ERROR,
    RESOURCE_NOT_FOUND,
    FAILED_TO_DELETE,
    REQUIRED,
    NO_INPUT,
    INVALID_INPUT,
    UNEXPECTED_TYPE,
    TOO_LONG,
    LIMIT_REACHED,
    INVALID,
    BLANK,
    TAKEN,
}