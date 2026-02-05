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
/// Possible error codes that can be returned by `DelegateAccessTokenDestroyUserError`.
/// </summary>
public enum DelegateAccessTokenDestroyUserErrorCode
{
    PERSISTENCE_FAILED,
    ACCESS_TOKEN_NOT_FOUND,
    CAN_ONLY_DELETE_DELEGATE_TOKENS,
    ACCESS_DENIED,
}