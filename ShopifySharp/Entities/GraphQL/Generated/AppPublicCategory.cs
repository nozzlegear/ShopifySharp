#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The public-facing category for an app.
/// </summary>
public enum AppPublicCategory
{
    PRIVATE,
    PUBLIC,
    CUSTOM,
    OTHER,
}