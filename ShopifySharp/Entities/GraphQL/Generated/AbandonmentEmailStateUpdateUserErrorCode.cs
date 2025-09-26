#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `AbandonmentEmailStateUpdateUserError`.
/// </summary>
public enum AbandonmentEmailStateUpdateUserErrorCode
{
    ABANDONMENT_NOT_FOUND,
}