#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `CustomerEmailMarketingConsentUpdateUserError`.
/// </summary>
public enum CustomerEmailMarketingConsentUpdateUserErrorCode
{
    INVALID,
    INCLUSION,
    INTERNAL_ERROR,
    MISSING_ARGUMENT,
}