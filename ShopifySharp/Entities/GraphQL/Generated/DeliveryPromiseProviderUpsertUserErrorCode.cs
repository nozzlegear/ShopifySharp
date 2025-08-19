#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `DeliveryPromiseProviderUpsertUserError`.
/// </summary>
public enum DeliveryPromiseProviderUpsertUserErrorCode
{
    NOT_FOUND,
    TOO_LONG,
    MUST_BELONG_TO_APP,
    INVALID_TIME_ZONE,
}