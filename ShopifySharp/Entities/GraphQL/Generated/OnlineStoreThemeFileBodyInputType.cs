#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input type for a theme file body.
/// </summary>
public enum OnlineStoreThemeFileBodyInputType
{
    TEXT,
    BASE64,
    URL,
}