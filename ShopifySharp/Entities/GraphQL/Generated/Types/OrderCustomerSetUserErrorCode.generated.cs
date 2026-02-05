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
/// Possible error codes that can be returned by `OrderCustomerSetUserError`.
/// </summary>
public enum OrderCustomerSetUserErrorCode
{
    NOT_FOUND,
    INVALID,
    NOT_SAVED,
    NOT_PERMITTED,
}