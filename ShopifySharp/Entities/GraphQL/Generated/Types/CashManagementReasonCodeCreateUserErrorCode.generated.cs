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
/// Possible error codes that can be returned by `CashManagementReasonCodeCreateUserError`.
/// </summary>
public enum CashManagementReasonCodeCreateUserErrorCode
{
    CODE_ALREADY_EXISTS,
    NOT_SAVED,
    BLANK,
}