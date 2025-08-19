#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `FulfillmentConstraintRuleCreateUserError`.
/// </summary>
public enum FulfillmentConstraintRuleCreateUserErrorCode
{
    INPUT_INVALID,
    FUNCTION_NOT_FOUND,
    FUNCTION_ALREADY_REGISTERED,
    FUNCTION_DOES_NOT_IMPLEMENT,
    CUSTOM_APP_FUNCTION_NOT_ELIGIBLE,
    FUNCTION_PENDING_DELETION,
    MAXIMUM_FULFILLMENT_CONSTRAINT_RULES_REACHED,
}