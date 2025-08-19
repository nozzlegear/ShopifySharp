#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `OrderCustomerSetUserError`.
/// </summary>
public enum OrderCustomerSetUserErrorCode
{
    NOT_FOUND,
    INVALID,
    NOT_SAVED,
    NOT_PERMITTED,
}