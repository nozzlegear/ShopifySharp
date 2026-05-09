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
/// Possible error codes that can be returned by `CashManagementReasonCodeDeleteUserError`.
/// </summary>
public enum CashManagementReasonCodeDeleteUserErrorCode
{
    NOT_FOUND,
    DATABASE_ERROR,
    NOT_DELETABLE,
}