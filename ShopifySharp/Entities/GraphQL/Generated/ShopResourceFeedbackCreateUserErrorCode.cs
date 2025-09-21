#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `ShopResourceFeedbackCreateUserError`.
/// </summary>
public enum ShopResourceFeedbackCreateUserErrorCode
{
    OUTDATED_FEEDBACK,
    FEEDBACK_DATE_IN_FUTURE,
    INVALID,
    BLANK,
    PRESENT,
}