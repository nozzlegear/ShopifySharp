#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `ConsentPolicyError`.
/// </summary>
public enum ConsentPolicyErrorCode
{
    COUNTRY_CODE_REQUIRED,
    REGION_CODE_REQUIRED,
    REGION_CODE_MUST_MATCH_COUNTRY_CODE,
    SHOPIFY_COOKIE_BANNER_NOT_DISABLED,
    UNSUPORTED_CONSENT_POLICY,
}