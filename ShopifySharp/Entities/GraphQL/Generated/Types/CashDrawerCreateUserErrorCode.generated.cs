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
/// Possible error codes that can be returned by `CashDrawerCreateUserError`.
/// </summary>
public enum CashDrawerCreateUserErrorCode
{
    INTERNAL_ERROR,
    NOT_SAVED,
    CASH_DRAWER_ALREADY_EXISTS,
    LOCATION_NOT_FOUND,
    INVALID_NAME,
}