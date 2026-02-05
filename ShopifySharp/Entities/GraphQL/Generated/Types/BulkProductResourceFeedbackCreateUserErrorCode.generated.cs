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
/// Possible error codes that can be returned by `BulkProductResourceFeedbackCreateUserError`.
/// </summary>
public enum BulkProductResourceFeedbackCreateUserErrorCode
{
    MAXIMUM_FEEDBACK_LIMIT_EXCEEDED,
    OUTDATED_FEEDBACK,
    PRODUCT_NOT_FOUND,
    INVALID,
    BLANK,
    PRESENT,
    LESS_THAN_OR_EQUAL_TO,
}