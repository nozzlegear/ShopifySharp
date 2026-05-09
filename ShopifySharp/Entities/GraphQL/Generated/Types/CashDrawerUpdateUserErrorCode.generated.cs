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
/// Possible error codes that can be returned by `CashDrawerUpdateUserError`.
/// </summary>
public enum CashDrawerUpdateUserErrorCode
{
    INTERNAL_ERROR,
    NOT_SAVED,
    CASH_DRAWER_NOT_FOUND,
    CASH_DRAWER_ALREADY_EXISTS,
    INVALID_NAME,
}