#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `OrderRiskAssessmentCreateUserError`.
/// </summary>
public enum OrderRiskAssessmentCreateUserErrorCode
{
    TOO_MANY_FACTS,
    ORDER_ALREADY_FULFILLED,
    INVALID,
    NOT_FOUND,
}