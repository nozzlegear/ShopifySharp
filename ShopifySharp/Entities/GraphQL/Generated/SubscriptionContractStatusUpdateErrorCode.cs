#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `SubscriptionContractStatusUpdateUserError`.
/// </summary>
public enum SubscriptionContractStatusUpdateErrorCode
{
    INVALID,
    CONTRACT_TERMINATED,
}