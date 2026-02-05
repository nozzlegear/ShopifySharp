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
/// Possible error codes that can be returned by `TransactionVoidUserError`.
/// </summary>
public enum TransactionVoidUserErrorCode
{
    TRANSACTION_NOT_FOUND,
    AUTH_NOT_SUCCESSFUL,
    AUTH_NOT_VOIDABLE,
    GENERIC_ERROR,
}