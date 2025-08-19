#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a shop's privacy settings.
/// </summary>
public enum PrivacyFeaturesEnum
{
    COOKIE_BANNER,
    DATA_SALE_OPT_OUT_PAGE,
    PRIVACY_POLICY,
}