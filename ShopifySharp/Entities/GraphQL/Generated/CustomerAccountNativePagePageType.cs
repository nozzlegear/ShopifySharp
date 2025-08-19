#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of customer account native page.
/// </summary>
public enum CustomerAccountNativePagePageType
{
    NATIVE_ORDERS,
    NATIVE_SETTINGS,
    NATIVE_PROFILE,
    UNKNOWN,
}