#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `LocationActivateUserError`.
/// </summary>
public enum LocationActivateUserErrorCode
{
    GENERIC_ERROR,
    LOCATION_LIMIT,
    HAS_ONGOING_RELOCATION,
    LOCATION_NOT_FOUND,
    HAS_NON_UNIQUE_NAME,
}