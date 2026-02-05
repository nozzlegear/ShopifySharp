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
/// The input fields for a shop's privacy settings.
/// </summary>
public enum PrivacyFeaturesEnum
{
    COOKIE_BANNER,
    DATA_SALE_OPT_OUT_PAGE,
    PRIVACY_POLICY,
}