#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible types of app developer.
/// </summary>
public enum AppDeveloperType
{
    SHOPIFY,
    PARTNER,
    MERCHANT,
    UNKNOWN,
}