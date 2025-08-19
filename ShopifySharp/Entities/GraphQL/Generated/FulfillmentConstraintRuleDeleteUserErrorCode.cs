#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `FulfillmentConstraintRuleDeleteUserError`.
/// </summary>
public enum FulfillmentConstraintRuleDeleteUserErrorCode
{
    NOT_FOUND,
    UNAUTHORIZED_APP_SCOPE,
}