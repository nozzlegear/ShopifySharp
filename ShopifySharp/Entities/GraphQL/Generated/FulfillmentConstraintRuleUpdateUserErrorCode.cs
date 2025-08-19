#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `FulfillmentConstraintRuleUpdateUserError`.
/// </summary>
public enum FulfillmentConstraintRuleUpdateUserErrorCode
{
    NOT_FOUND,
    UNAUTHORIZED_APP_SCOPE,
}